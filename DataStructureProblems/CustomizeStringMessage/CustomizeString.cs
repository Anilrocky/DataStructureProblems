using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DataStructureProblems.CustomizeStringMessage
{
    public class CustomizeString
    {
        public void Customize()
        {
            string msg = "Hello <<name>>, We have your full name as <<full name>> in our system. your contact number is 91-xxxxxxxxxx. Please,let us know in case of any clarification Thank you BridgeLabz 01/01/2016.";
            msg = msg.Replace("<<name>>", "Anil");
            msg = msg.Replace("<<full name>>", "Anil Kumar");
            msg = msg.Replace("91-xxxxxxxxxx", "91-9856745643");
            msg = msg.Replace("01/01/2016", DateTime.Today.ToShortDateString());
            Console.WriteLine(msg);
        }
    }
}
