using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace DiceRoller
{
    internal class Class1
    {
        public string fileInput = "";

        // Läser in data från fil

        public void Inlägg(string input)
        {
            // TITLE###Mitt blogginlägg###BODY###nfjdiuosahbhjuvec hduanbfdjihsa


            List<string> strings = new List<string>();

            string[] splitInput = input.Split(new string[] { "###" }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < splitInput.Length; i++)
            {
                switch (splitInput[i])
                {
                    case "TITLE":
                        Console.WriteLine(splitInput[i + 1]);
                        break;

                    case "BODY":
                        Console.WriteLine(splitInput[i + 1]);
                        break;

                    case "FOOTER":
                        Console.WriteLine(splitInput[i + 1]);
                        break;
                }
            }
        }


        public void Main2(File sender, EventArgs e)
        {
            Inlägg(fileInput);
        }
    }
}
