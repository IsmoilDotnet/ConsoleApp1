using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Paginaton
    {
        public static void Page1()
        {
            Console.WriteLine("PAGE 1\n");
            Console.WriteLine("1) create table");
            Console.WriteLine("2) GetAll");
            Console.WriteLine("3) InsertOne");
            Console.WriteLine("4) Truncate table");
            Console.WriteLine("5) UpdateAll");
            Console.WriteLine("6) Clear console...");
            Console.WriteLine("7) Exit...");
            Console.WriteLine("8) Next page");
            Console.WriteLine("Choose one of this functions (1, 2, or 3)... ");

            var result = Console.ReadLine();

            int res = Int32.Parse(result);

            switch (res)
            {
                case 1:
                    Console.WriteLine("Enter table name and column.");

                    Methods.CreateTable(Console.ReadLine(), Console.ReadLine());
                    break;

                case 2:
                    Console.WriteLine("Enter the table name.");

                    Methods.GetAll(Console.ReadLine());
                    break;

                case 3:
                    Console.WriteLine("Enter the table name, columnName and value.");

                    Methods.InsertOne(Console.ReadLine(), Console.ReadLine(), Console.ReadLine());
                    break;

                case 4:
                    Console.WriteLine("Enter the table name.");

                    Methods.TruncateTable(Console.ReadLine());
                    break;

                case 5:
                    Console.WriteLine("Enter the table, columnName and value.");

                    Methods.UpdateAll(Console.ReadLine(), Console.ReadLine(), Console.ReadLine());
                    break;

                case 6:
                    Console.Clear();
                    break;

                case 7:
                    Console.WriteLine("OK");
                    break;

                case 8:
                    Console.Clear();
                    Page2();
                    break;

                default:
                    Console.WriteLine("Please, enter only existed numbers in the page!\n");
                    break;

            }
            if (res != 7)
            {
                Page1();
            }
            else
            {
                Console.WriteLine("See you later :)");
            }
        }
        public static void Page2()
        {
            Console.WriteLine("Page 2\n");
            Console.WriteLine("1) DeleteFrom");
            Console.WriteLine("2) GetById");
            Console.WriteLine("3) UpdateOne");
            Console.WriteLine("4) UpdateColumnName");
            Console.WriteLine("5) Clear console...");
            Console.WriteLine("6) Exit...");
            Console.WriteLine("7) Previous page || 8) Next Page ");
            Console.WriteLine("Choose one of this functions (1, 2, or 3)... ");
            var result = Console.ReadLine();

            int res = Int32.Parse(result);

            switch (res)
            {
                case 1:
                    Console.WriteLine("Enter the table, column and value");

                    Methods.DeleteFrom(Console.ReadLine(),Console.ReadLine(),Console.ReadLine());
                    break;

                case 2:
                    Console.WriteLine("Enter the table, column and id");

                    Methods.DeleteFrom(Console.ReadLine(),Console.ReadLine(),Console.ReadLine());
                    break;

                case 3: 
                    Console.WriteLine("Enter the table, column, value, (WHERE) column, and value");

                    Methods.UpdateOne(Console.ReadLine(),Console.ReadLine(),Console.ReadLine(),Console.ReadLine(),Console.ReadLine());
                    break;

                case 4:
                    Console.WriteLine("Enter the table, oldColumnName and NewColumnName");

                    Methods.UpdateColumn(Console.ReadLine(),Console.ReadLine(),Console.ReadLine());
                    break;

                case 5:
                    Console.Clear();
                    break;

                case 6:
                    Console.WriteLine("OK");
                    break;

                case 7:
                    Console.Clear();
                    Page1();
                    break;

                case 8:
                    Console.Clear();
                    Page3();
                    break;

                default:
                    Console.WriteLine("Please, enter only Existed numbers in the page!");
                    break;

            }
            if (res != 6)
            {
                Page2();
            }
            else
            {
                Console.WriteLine("See you later :)");
            }
        }
        public static void Page3()
        {
            Console.WriteLine("Page 3\n");
            Console.WriteLine("1) AddColumn");
            Console.WriteLine("2) AddColumnDefault");
            Console.WriteLine("3) UpdateTableName");
            Console.WriteLine("4) Join");
            Console.WriteLine("5) AddIndex");
            Console.WriteLine("6) Clear console...");
            Console.WriteLine("7) Exit...");
            Console.WriteLine("8) Previous page");
            Console.WriteLine("Choose one of this functions (1, 2, or 3)... ");
            var result = Console.ReadLine();

            int res = Int32.Parse(result);

            switch (res)
            {
                case 1:
                    Console.WriteLine("Enter the table, column and value");

                    Methods.AddColumn(Console.ReadLine(),Console.ReadLine(),Console.ReadLine());
                    break;

                case 2:
                    Console.WriteLine("Enter  old table name and new table name.");

                    Methods.UpdateTable(Console.ReadLine(), Console.ReadLine());
                    break;

                case 3:
                    Console.WriteLine("Enter the table, column and value");

                    Methods.AddColumn(Console.ReadLine(), Console.ReadLine(), Console.ReadLine());
                    break;

                case 4:
                    Console.WriteLine("Enter the first table, second table, join1 and join2");

                    Methods.Join(Console.ReadLine(), Console.ReadLine(), Console.ReadLine(),Console.ReadLine());
                    break;

                case 5:
                    Console.WriteLine("Enter the Index, table and value");

                    Methods.AddIndex(Console.ReadLine(), Console.ReadLine(), Console.ReadLine());
                    break;

                case 6:
                    Console.Clear();
                    Page3();
                    break;

                case 7:
                    Console.WriteLine("OK");
                    break;

                case 8:
                    Console.Clear();
                    Page2();
                    break;

                default:
                    Console.WriteLine("Please, Enter only existed numbers in the page !");
                    break;
            }
            if (res != 7)
            {
                Page3();
            }
            else
            {
                Console.WriteLine("See you later :)");
            }

        }
    }
}
