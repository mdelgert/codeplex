using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ARSoft.Tools.Net.Spf;
using ARSoft.Tools.Net;
using ARSoft.Tools.Net.Dns;



namespace Base.ConsoleApplicationDNS
{
    class Program
    {
        static void Main(string[] args)
        {
            using (DnsServer server = new DnsServer(IPAddress.Any, 10, 10, ProcessQuery))
            {
                server.Start();

                Console.WriteLine("Press any key to stop server");
                Console.ReadLine();
            }
        }

        static DnsMessageBase ProcessQuery(DnsMessageBase message, IPAddress clientAddress, ProtocolType protocol)
        {
            message.IsQuery = false;

            DnsMessage query = message as DnsMessage;

            if ((query != null) && (query.Questions.Count == 1))
            {
                // send query to upstream server
                DnsQuestion question = query.Questions[0];
                DnsMessage answer = DnsClient.Default.Resolve(question.Name, question.RecordType, question.RecordClass);

                // if got an answer, copy it to the message sent to the client
                if (answer != null)
                {
                    foreach (DnsRecordBase record in (answer.AnswerRecords))
                    {
                        query.AnswerRecords.Add(record);
                    }
                    foreach (DnsRecordBase record in (answer.AdditionalRecords))
                    {
                        query.AnswerRecords.Add(record);
                    }

                    query.ReturnCode = ReturnCode.NoError;
                    return query;
                }
            }

            // Not a valid query or upstream server did not answer correct
            message.ReturnCode = ReturnCode.ServerFailure;
            return message;
        }
    }

}
