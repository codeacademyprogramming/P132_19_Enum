using CourseAppLibrary;
using CourseAppLibrary.Enums;
using System;
using System.Collections.Generic;

namespace CourseApp
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Course course = new Course();

            string opt;
            do
            {
                ShowMenu();

                Console.WriteLine("Emeliyyati secin:");
                opt = Console.ReadLine();

                switch (opt)
                {
                    case "1":
                        AddGroup(course);
                        break;
                    case "2":
                        ShowAllGroups(course);
                        break;
                    case "3":
                        ShowGroupsByCategory(course);
                        break;
                    case "0":
                        Console.WriteLine("Bitdi!");
                        break;
                    default:
                        Console.WriteLine("Secim yanlisdir!");
                        break;
                }


            } while (opt!="0");


        }

        static void ShowMenu()
        {
            Console.WriteLine("1. Qrup elave et");
            Console.WriteLine("2. Putun qruplara bax");
            Console.WriteLine("3. Kateqoriyaya esasen qruplara bax");
            Console.WriteLine("0. Cix");
        }

        static void AddGroup(Course course)
        {
            string no;
            bool hasNo = false;
            bool checkNo = true;
            do
            {
                if(hasNo == true)
                    Console.WriteLine("Bu nomreli qrup var!");

                if(checkNo == false)
                    Console.WriteLine("Qrup no deyeri ardicil 1 boyuk herf ve 3 reqemden ibaret olmalidir");

                Console.WriteLine("No:");
                no = Console.ReadLine();

                hasNo = course.HasGroupByNo(no);
                checkNo = Group.CheckGroupNo(no);
            } while (hasNo || !checkNo);
           



            string limtiStr;
            byte limit;
            do
            {
                Console.WriteLine("Limit:");
                limtiStr = Console.ReadLine();

            } while (!byte.TryParse(limtiStr, out limit));


           

            string typeStr;
            GroupType type;

            do
            {
                Console.WriteLine("Asagidaki qruplardan novlerinden birini secin:");
                foreach (var item in Enum.GetNames(typeof(GroupType)))
                {
                    Console.WriteLine(item);
                }
                typeStr = Console.ReadLine();

            } while (!Enum.IsDefined(typeof(GroupType),typeStr));

            type = Enum.Parse<GroupType>(typeStr);

            Group group = new Group()
            {
                No = no,
                Limit = limit,
                Category = type
            };

            course.AddGroup(group);
        }

        static void ShowAllGroups(Course course)
        {
            foreach (var item in course.Groups)
            {
                Console.WriteLine(item.GetInfo());
            }
        }


        static void ShowGroupsByCategory(Course course)
        {

            string typeStr;
            do
            {

                Console.WriteLine("Asagidaki kateqoriyalardan birini secin:");

                foreach (var item in Enum.GetNames(typeof(GroupType)))
                {
                    Console.WriteLine(item);
                }
                typeStr = Console.ReadLine();

            } while (!Enum.IsDefined(typeof(GroupType),typeStr));

            GroupType type = Enum.Parse<GroupType>(typeStr);

            foreach (var item in course.GetGroupsByCategory(type))
            {
                Console.WriteLine(item.GetInfo());
            }
        }
    }
}
