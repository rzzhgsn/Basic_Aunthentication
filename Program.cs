using BasicAuthentication;
using System;
using System.Collections.Generic;
using System.Data;
using System.Security.AccessControl;

namespace BasicAunthentication;

public class Program 
{
    public static void Main()
    {
        List<Data> datas = new List<Data>();
        //List<string> first = new List<string>();
        //List<string> last = new List<string>();
        //List<string> pass = new List<string>();
        //List<string> name = new List<string>();
        //List<string> username = new List<string>();
        //List<int> id = new List<int>();

        TampilanMenu(datas);
    }

    public static void TampilanMenu(List<Data> datas)
    {
        bool user = true;
        bool login = true;

        do
        {
            Console.WriteLine("== BASIC AUTHENTICATION ==");
            Console.WriteLine("1. Create User");
            Console.WriteLine("2. Show User");
            //Console.WriteLine("Search User");
            Console.WriteLine("3. Login User");
            Console.WriteLine("4. Exit");
            //pilih menu
            Console.Write("Input : ");
            int key = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            switch (key)
            {
                case 1:
                    Menu.Create(datas);
                    break;

                case 2:
                    Menu.Show(datas);
                    break;

                case 3:
                    Menu.Login(datas);
                    break;

                case 4:
                    Menu.Exit(datas);
                    break;
            }
        } while (user);
    }
}   



