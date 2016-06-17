﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NewTeach_Service;
using Server_Properties;

namespace NewTeach_Server
{
    class ConsoleServer
    {
        static string command = "";
        static void Main(string[] args)
        {
            Console.WriteLine("NewTeach_Server V1.0\n\n\t>>> [Service Activing]");
            Service.ActiveService();
            Console.WriteLine("\t>>> [Service Actived]\n\n");
            do
            {
                Console.Write("NewTeach Server -->");
                command = Console.ReadLine();
                
                switch(command)
                {
                    case "exit":
                        Environment.Exit(0);
                        break;
                    case "SQLKEY_EDIT":
                        try
                        {
                            Console.Write("Input NewKey -->");
                            string newkey = Console.ReadLine();
                            INI.FileCheck.ChangeSQLKey(newkey);
                            Property.SqlKey = newkey;
                            Console.WriteLine("[Succeeded]");
                        }
                        catch
                        {
                            Console.WriteLine("[Failed]");
                        }
                        break;
                }
            } while (true);
        }
    }
}
