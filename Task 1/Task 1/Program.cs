using System;
using System.IO;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Client c1 = new Client(001, "AZE56781234", 22.30);
            Client c2 = new Client(025, "RU87654321", 50.00);
            Client c3 = new Client(034, "ENG56781234", 12.35);
            string direct = @"C:\Elxan_monstr9";
            DirectoryInfo dir = new DirectoryInfo(direct);
            if (!dir.Exists)
            {
                dir.Create();
            }
            string filename1 = $@"{direct}\Elxan_Main.txt";
            FileInfo fileinf = new FileInfo(filename1);
            if (!fileinf.Exists)
            {
                fileinf.CreateText().Close();
            }
            
            string filename2 = $@"{direct}\Elxan_Changed.txt";
            FileInfo fileing = new FileInfo(filename2);
            if (!fileinf.Exists)
            {
                fileing.CreateText().Close();
            }
            using (StreamWriter smwr = new StreamWriter(filename1, false, System.Text.Encoding.Default))
            {
                smwr.WriteLine(c1.GetInfoAbout());
                smwr.WriteLine(c2.GetInfoAbout());
                smwr.WriteLine(c3.GetInfoAbout());
            }
            for (; ; )
            {
                Console.WriteLine($"Информацию о каком человеке вы хотите поменять? {c1.ID} (1), {c2.ID} (2), {c3.ID} (3), если хотите выйти нажмите 4.");
                int selection1 = Input.SelectionInput();
                if (selection1 == 1)
                {
                    for (; ; )
                    {
                        Console.WriteLine("Для изменения ID нажмите 1, номер паспорта - 2,\nколичество денег - 3, если хотите выйти нажмите 4.");
                        int selection2 = Input.SelectionInput();
                        if (selection2 == 1)
                        {
                            c1.ChangeID();
                            using (StreamWriter smwr = new StreamWriter(filename2, false, System.Text.Encoding.Default))
                            {
                                smwr.WriteLine(c1.GetInfoAbout());
                                smwr.WriteLine(c2.GetInfoAbout());
                                smwr.WriteLine(c3.GetInfoAbout());
                            }
                            Console.WriteLine("Для продолжения нажмите любую клавишу!");
                            Console.ReadKey();
                        }
                        else if (selection2 == 2)
                        {
                            c1.ChangePasNum();
                            using (StreamWriter smwr = new StreamWriter(filename2, false, System.Text.Encoding.Default))
                            {
                                smwr.WriteLine(c1.GetInfoAbout());
                                smwr.WriteLine(c2.GetInfoAbout());
                                smwr.WriteLine(c3.GetInfoAbout());
                            }
                            Console.WriteLine("Для продолжения нажмите любую клавишу!");
                            Console.ReadKey();
                        }
                        else if (selection2 == 3)
                        {
                            c1.ChangePaymet();
                            using (StreamWriter smwr = new StreamWriter(filename2, false, System.Text.Encoding.Default))
                            {
                                smwr.WriteLine(c1.GetInfoAbout());
                                smwr.WriteLine(c2.GetInfoAbout());
                                smwr.WriteLine(c3.GetInfoAbout());
                            }
                            Console.WriteLine("Для продолжения нажмите любую клавишу!");
                            Console.ReadKey();
                        }
                        else
                            break;
                    }
                }
                else if (selection1 == 2)
                {
                    for (; ; )
                    {
                        Console.WriteLine("Для изменения ID нажмите 1, номер паспорта - 2,\nколичество денег - 3, если хотите выйти нажмите 4.");
                        int selection2 = Input.SelectionInput();
                        if (selection2 == 1)
                        {
                            c2.ChangeID();
                            using (StreamWriter smwr = new StreamWriter(filename2, false, System.Text.Encoding.Default))
                            {
                                smwr.WriteLine(c1.GetInfoAbout());
                                smwr.WriteLine(c2.GetInfoAbout());
                                smwr.WriteLine(c3.GetInfoAbout());
                            }
                            Console.WriteLine("Для продолжения нажмите любую клавишу!");
                            Console.ReadKey();
                        }
                        else if (selection2 == 2)
                        {
                            c2.ChangePasNum();
                            using (StreamWriter smwr = new StreamWriter(filename2, false, System.Text.Encoding.Default))
                            {
                                smwr.WriteLine(c1.GetInfoAbout());
                                smwr.WriteLine(c2.GetInfoAbout());
                                smwr.WriteLine(c3.GetInfoAbout());
                            }
                            Console.WriteLine("Для продолжения нажмите любую клавишу!");
                            Console.ReadKey();
                        }
                        else if (selection2 == 3)
                        {
                            c2.ChangePaymet();
                            using (StreamWriter smwr = new StreamWriter(filename2, false, System.Text.Encoding.Default))
                            {
                                smwr.WriteLine(c1.GetInfoAbout());
                                smwr.WriteLine(c2.GetInfoAbout());
                                smwr.WriteLine(c3.GetInfoAbout());
                            }
                            Console.WriteLine("Для продолжения нажмите любую клавишу!");
                            Console.ReadKey();
                        }
                        else
                            break;
                    }
                }
                else if (selection1 == 3)
                {
                    for (; ; )
                    {
                        Console.WriteLine("Для изменения ID нажмите 1, номер паспорта - 2,\nколичество денег - 3, если хотите выйти нажмите 4.");
                        int selection2 = Input.SelectionInput();
                        if (selection2 == 1)
                        {
                            c3.ChangeID();
                            using (StreamWriter smwr = new StreamWriter(filename2, false, System.Text.Encoding.Default))
                            {
                                smwr.WriteLine(c1.GetInfoAbout());
                                smwr.WriteLine(c2.GetInfoAbout());
                                smwr.WriteLine(c3.GetInfoAbout());
                            }
                            Console.WriteLine("Для продолжения нажмите любую клавишу!");
                            Console.ReadKey();
                        }
                        else if (selection2 == 2)
                        {
                            c3.ChangePasNum();
                            using (StreamWriter smwr = new StreamWriter(filename2, false, System.Text.Encoding.Default))
                            {
                                smwr.WriteLine(c1.GetInfoAbout());
                                smwr.WriteLine(c2.GetInfoAbout());
                                smwr.WriteLine(c3.GetInfoAbout());
                            }
                            Console.WriteLine("Для продолжения нажмите любую клавишу!");
                            Console.ReadKey();
                        }
                        else if (selection2 == 3)
                        {
                            c3.ChangePaymet();
                            using (StreamWriter smwr = new StreamWriter(filename2, false, System.Text.Encoding.Default))
                            {
                                smwr.WriteLine(c1.GetInfoAbout());
                                smwr.WriteLine(c2.GetInfoAbout());
                                smwr.WriteLine(c3.GetInfoAbout());
                            }
                            Console.WriteLine("Для продолжения нажмите любую клавишу!");
                            Console.ReadKey();
                        }
                        else
                            break;
                    }
                }
                else
                    break;
            }
        }
    }
    class Client
    {
        public int ID { get; set; }
        public string PassportNum { get; set; }
        public double Payment { get; set; }
        public Client(int id, string passportnum, double payment)
        {
            ID = id;
            PassportNum = passportnum;
            Payment = payment;
        }
        public string GetInfoAbout()
        {
            string print = $"ID: {ID}; Номер паспорта: {PassportNum}; Денег на счету: {Payment}";
            Console.WriteLine(print);
            return print;
        }
        public string ChangePaymet()
        {
            Console.Write("Введите сумму денег: ");
            Payment = Input.PaymentInput();
            return $"ID: {ID}; Номер паспорта: {PassportNum}; Денег на счету: {Payment}";
        }
        public string ChangeID()
        {
            Console.Write("Введите ID: ");
            ID = Input.NumsInput();
            return $"ID: {ID}; Номер паспорта: {PassportNum}; Денег на счету: {Payment}";
        }
        public string ChangePasNum()
        {
            Console.Write("Введите номер паспорта: ");
            PassportNum = Input.WordInput();
            return $"ID: {ID}; Номер паспорта: {PassportNum}; Денег на счету: {Payment}";
        }
    }
    class Input
    {
        public static string WordInput()
        {
            string word = Console.ReadLine();
            return word;
        }
        public static int SelectionInput()
        {
            int nums = 0;
            string input = Console.ReadLine();
            if (Int32.TryParse(input, out nums))
            {
                if (nums > 0 && nums < 5)
                    return nums;
                else
                {
                    Console.WriteLine("Введите число от 1 до 4");
                    return SelectionInput();
                }
            }
            else
            {
                Console.WriteLine("Введите число!");
                return SelectionInput();
            }
        }
        public static int NumsInput()
        {
            int nums = 0;

            string input = Console.ReadLine();
            if (Int32.TryParse(input, out nums))
            {
                if (nums > 0)
                    return nums;
                else
                {
                    Console.WriteLine("Введите положительное число!");
                    return NumsInput();
                }
            }
            else
            {
                Console.WriteLine("Введите число!");
                return NumsInput();
            }
        }
        public static double PaymentInput()
        {
            double nums = 0;

            string input = Console.ReadLine();
            if (Double.TryParse(input, out nums))
            {
                if (nums >= 0)
                    return nums;
                else
                {
                    Console.WriteLine("Введите положительное число!");
                    return PaymentInput();
                }
            }
            else
            {
                Console.WriteLine("Введите число! (Не забудьте про запятую!)");
                return PaymentInput();
            }
        }
    }
}
