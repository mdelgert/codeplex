
-- =============================================
-- Author:		Matthew David Elgert
-- Create date: 11/16/2012
-- Description:	
/*

sample usage

EXEC dbo.LookupWordOne "like"

*/
-- =============================================
CREATE PROCEDURE [dbo].[LookupWordOne] @Word VARCHAR(80)
AS
  BEGIN
      -- SET NOCOUNT ON added to prevent extra result sets from
      -- interfering with SELECT statements.
      SET NOCOUNT ON;

      -- Insert statements for procedure here
      SELECT se1.rank,
             sy1.pos,
             wa.lemma + ' -- ' + sy1.definition,
             wb.lemma + ' -- ' + sy2.definition
      FROM   word w1
             LEFT JOIN sense se1
                    ON w1.wordid = se1.wordid
             LEFT JOIN synset sy1
                    ON se1.synsetid = sy1.synsetid
             LEFT JOIN semlinkref
                    ON sy1.synsetid = semlinkref.synset1id
             LEFT JOIN synset sy2
                    ON semlinkref.synset2id = sy2.synsetid
             LEFT JOIN sense se2
                    ON sy2.synsetid = se2.synsetid
             LEFT JOIN word wb
                    ON se2.wordid = wb.wordid
             LEFT JOIN sense se3
                    ON sy1.synsetid = se3.synsetid
             LEFT JOIN word wa
                    ON se3.wordid = wa.wordid
      WHERE  w1.lemma = @Word
             AND sy1.pos = 'n'
             AND semlinkref.linkid = 1
      ORDER  BY se1.rank,
                wa.wordid,
                wb.wordid ASC
  END