using System;
using System.Xml.Serialization;
using System.IO;
using System.Transactions;

class Program
{
    static void Main(string[] args)
    {
        string choice;
        do {
            //version 2
            Console.WriteLine("Please select one of the following choices.");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.WriteLine("What would you like to do?");
            choice = Console.ReadLine();
            Journal newJ = new Journal();
            if (choice == "1")
            {
                PromptGenerator newP = new PromptGenerator();
                string prompt = newP.GetRandomPrompt();

                Entry newE = new Entry();
                newE._promptText = prompt;
                newE.Display();
                newJ.AddEntry(newE);
            }
            else if (choice == "2")
            {
                newJ.DisplayAll();
            }
            else if (choice == "3")
            {
                newJ._entries.Clear();
                string fileName = Console.ReadLine();
                newJ.LoadFromFiles(fileName);
            

            }
            else if (choice == "4")
            {
                Console.WriteLine("What is the file name?");
                string fileName = Console.ReadLine();
                newJ.SaveToFiles(fileName);
            }
            else if (choice == "5")
            {
                break;
            }
        } while (choice != "5");

        /*
        version 1
        string choice;
        string current_entry = "";
        string current_response = "";
        List<string> stored =  new List<string>();

        do
        {
            Console.WriteLine("Please select one of the following choices.");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.WriteLine("What would you like to do?");
            choice = Console.ReadLine();
            
            if (choice == "1")
            {
                //random message question
                //use WriteFiles method, the strings are response
                //prompt-and-date(entry)
                WriteFiles new1 = new WriteFiles();
                new1._entry = new1.ReturnMessage();
                new1._response = Console.ReadLine();

                current_entry = new1._entry;
                current_response = new1._response;
            }
            else if (choice == "2")
            {
                //Display the past message stored
                for (int i = 0; i > stored.Count; i++)
                {
                    string fileName = stored[i];
                    string[] lines = System.IO.File.ReadAllLines(fileName);

                    foreach (string line in lines)
                    {
                        Console.WriteLine(line);
                    }
                    Console.WriteLine("");
                }

            }
            else if (choice == "3")
            {
                //Load the chosen past message
                string fileName = Console.ReadLine();
                string[] lines = System.IO.File.ReadAllLines(fileName);

                current_entry = lines[0];
                current_response = lines[1];
            }
            else if (choice == "4")
            {
                //entry + response = file
                //Save the current message
                Console.WriteLine("What is the file name?");
                string fileName = Console.ReadLine();

                using (StreamWriter output1 = new StreamWriter(fileName))
                {
                    output1.WriteLine(current_entry);
                    output1.WriteLine(current_response);
                }
                stored.Add(fileName);
            }
            else if (choice == "5")
            {
                //Quit
                break;
            }
        } while (choice != "5");
        */
    }
}