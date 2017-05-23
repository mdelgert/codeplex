using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Begin:");

            //Test using a console
            //string firstName = "Matthew"; 
            //string middleName = "David"; 
            //string lastName = "Elgert"; 
            //string emailAddress = "mdelgert@yahoo.com"; 
            //string phone = "480-777-7777";
            //string addressLine = "101 Main Street";
            //string city = "Phoenix"; 
            //string stateProvince = "Arizona"; 
            //string postalCode = "85345";
            //BLL.Contacts.Create(firstName, middleName, lastName, emailAddress, phone, addressLine, city, stateProvince, postalCode);

            BLL.Contacts.AddRadomContact();

            Console.WriteLine("End:");
            
            Console.ReadKey();
            
            //ElmahExtension.LogToElmah(new ApplicationException("Test exception"));


        }

    }

}
