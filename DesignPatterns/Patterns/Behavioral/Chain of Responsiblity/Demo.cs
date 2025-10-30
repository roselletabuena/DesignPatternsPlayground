using DesignPatterns.Patterns.Behavioral.Chain_of_Responsiblity.Handlers;
using DesignPatterns.Patterns.Behavioral.Chain_of_Responsiblity.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.Behavioral.Chain_of_Responsiblity
{
    internal class Demo
    {

        public static void Run()
        {
            Console.WriteLine("=== Chain of Responsibility Pattern Demo ===\n");

            var level1 = new LevelOneSupportHandler();
            var level2 = new LevelTwoSupportHandler();
            var manager = new ManagerHandler();

            level1.SetNext(level2).SetNext(manager);


            var request1 = new SupportRequest("Alice", "Password reset needed", 1);
            var request2 = new SupportRequest("Bob", "System crashes occasionally", 2);
            var request3 = new SupportRequest("Charlie", "Database corruption detected", 3);


            level1.Handle(request1);
            Console.WriteLine();

            level1.Handle(request2);
            Console.WriteLine();    

            level1.Handle(request3);
            Console.WriteLine();


        }

    }
}
