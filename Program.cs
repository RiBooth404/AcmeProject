﻿using System.Collections;
using System.Runtime.InteropServices;
using System;
using AcmeProject.Services;
using AcmeProject.Model;
using System.Collections.Generic;

namespace AcmeProject
{
    class Program
    {
        static void Main(string[] args)
        {
            String input = args[0];
            List<Employee> eList=new List<Employee>();
            bool incomplete = true;
            while (incomplete)
            {
                try
                {
                    eList = Wrapper.TextFileToEmployee(input);
                    incomplete=false;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Problem found while trying to read employees file, please enter the path manually.\nOtherwise if you want to close this program press CTRL+C");
                    Console.Write("Path:");
                    input = Console.ReadLine();
                }

            }
            foreach (string message in Employee.CompareEmployeesSchedule(eList))
            {
                Console.WriteLine(message);
            }

            Console.WriteLine();
        }
    }
}
