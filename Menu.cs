using BasicAunthentication;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BasicAuthentication;

public class Menu : Data
{
    public static void Create(List<Data> datas)
    {
        Console.Write("Fisrt Name   : ");
        string First_Name = Console.ReadLine();
        Console.Write("Last Name    : ");
        string Last_Name = Console.ReadLine();

        //first.Add(First_Name);
        //last.Add(Last_Name);
        Menu datas1 = new Menu();
        datas1.First = First_Name;
        datas1.Last = Last_Name;
        datas1.Username = (First_Name[0..2] + Last_Name[0..2]);

        datas.Add(datas1);

        bool checkpass = true;
        do
        {
            Console.Write("Password     : ");
            string Password = Console.ReadLine();
            if (Password.Length >= 8)
            {
                if (Password.Any(char.IsUpper))
                {
                    if (Password.Any(char.IsLower))
                    {
                        if (Password.Any(char.IsNumber))
                        {
                            datas1.Pass = Password;
                            checkpass = false;
                            break;
                        }

                    }
                }
            }
            Console.WriteLine("\nPassword must have at least 8 characters\r\n with at least one Capital letter, at least one lower case letter and at least one number.\n");
            //checkpass = true;
            //break;


        } while (checkpass);

        Console.WriteLine();
        Console.WriteLine("Data Berhasil di Buat");
        Console.ReadKey();
        Console.Clear();
        //user = true;
    }
    public static void Show(List<Data> datas)
    {
        int i = 0;
        bool check = true;
        do
        {
            i = 0;
            foreach (Data n in datas)
            {
                i++;
                Console.WriteLine("        SHOW USER         ");
                Console.WriteLine("==========================");
                if (datas == null)
                {
                    continue;
                }
                Console.WriteLine($"ID       : {i}");
                Console.WriteLine($"Name     : {n.First} {n.Last}");
                Console.WriteLine($"Username : {n.Username}");
                Console.WriteLine($"Password : {n.Pass}");
                Console.WriteLine("==========================");
                Console.WriteLine();
            }

            Console.WriteLine("Menu");
            Console.WriteLine("1. Edit User ");
            Console.WriteLine("2. Delete User");
            Console.WriteLine("3. Back ");
            Console.Write("Pilih : ");
            int edit = Convert.ToInt32(Console.ReadLine());
            switch (edit)
            {
                case 1:
                    Console.Write("ID Yang Ingin Diubah : ");
                    int editid = Convert.ToInt32(Console.ReadLine());
                    foreach (Data n in datas)
                    {
                        if (editid == n.id)
                        {
                            Console.Write("Fisrt Name   : ");
                            string editFirst_Name = Console.ReadLine();
                            n.First = editFirst_Name;

                            Console.Write("Last Name    : ");
                            string editLast_Name = Console.ReadLine();
                            n.Last = editLast_Name;

                            Console.Write("Password     : ");
                            string editPass = Console.ReadLine();
                            n.Pass = editPass;

                            n.Name = n.First[..2] + n.Last[..2];
                            n.Username = n.First[..2] + n.First[..2];

                            bool checkpass = true;
                            do
                            {
                                Console.Write("Password     : ");
                                string Password = Console.ReadLine();
                                if (Password.Length >= 8)
                                {
                                    if (Password.Any(char.IsUpper))
                                    {
                                        if (Password.Any(char.IsLower))
                                        {
                                            if (Password.Any(char.IsNumber))
                                            {
                                                n.Pass = Password;
                                                checkpass = false;
                                                break;
                                            }

                                        }
                                    }
                                }
                                Console.WriteLine("\nPassword must have at least 8 characters\r\n with at least one Capital letter, at least one lower case letter and at least one number.\n");
                                //checkpass = true;
                                //break;
                            } while (checkpass);
                            break;
                        }
                    }
                    Console.Write("User Sudah Berhasil Diedit");
                    Console.ReadKey();
                    check = true;
                    Console.Clear();
                    break;

                case 2:
                    i = 0;
                    Console.Write("ID Yang Ingin Dihapus : ");
                    int hapusid = Convert.ToInt32(Console.ReadLine());
                    Console.Write("User Sudah Berhasil Dihapus");
                    Console.ReadKey();
                    Console.Clear();
                    //int id = (i + 1);
                    if (hapusid != null)
                    {
                        datas.RemoveAt(hapusid - 1);
                        break;
                    }
                    check = true;
                    break;

                case 3:
                    //user = true;
                    check = false;
                    Console.Clear();
                    break;

                default:
                    Console.Write("Tidak Ada Pilihan");
                    Console.ReadKey();
                    break;
            }
        } while (check);
    }
    public static void Login(List<Data> datas)
    {
        bool login = true;
        do
        {
            Console.WriteLine("== LOGIN ==");
            Console.Write("USERNAME : ");
            string masukuser = Console.ReadLine();

            Console.Write("PASSWORD : ");
            string masukpass = Console.ReadLine();

            foreach (var item in datas)
            {
                if (item.Username == masukuser && item.Pass == masukpass)
                {
                    Console.WriteLine("Login Berhasil");
                    Console.ReadKey();
                    //login = true;
                    break;

                }
                else
                {
                    Console.WriteLine("Login Gagal");
                    Console.ReadKey();
                    login = false;
                }
            }
            
            Console.Clear();
            login = false;
        } while (login);
    }

    public static void Exit(List<Data> datas)
    {
        System.Environment.Exit(0);
    }
}