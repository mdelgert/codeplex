
-- =============================================
-- Author:		Matthew David Elgert
-- Create date: 11/16/2012
-- Description:	
/*

EXEC [dbo].[LookupWordTwo] 'wordnet'


*/
-- =============================================
CREATE PROCEDURE [dbo].[LookupWordTwo] @Word VARCHAR(80)
AS
  BEGIN
      -- SET NOCOUNT ON added to prevent extra result sets from
      SET NOCOUNT ON;

      SELECT w.[wordid]
             ,w.[lemma]
             ,ss.[pos]
             ,ss.[synsetid]
             ,ss.[definition]
             ,sp.[sampleid]
             ,sp.[sample]
      FROM   dbo.[word] w
             LEFT JOIN dbo.[sense]
                    ON w.[wordid] = sense.[wordid]
             LEFT JOIN dbo.[synset] ss
                    ON sense.[synsetid] = ss.[synsetid]
             LEFT JOIN dbo.[sample] sp
                    ON sp.[synsetid] = sense.[synsetid]
      WHERE  w.lemma = @Word
      ORDER  BY ss.[pos]
                ,[sense].rank, sp.[sampleid]
  END