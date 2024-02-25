using System;
using System.Collections.Generic;


public class FamilyTree
{
    public static void Main(string[] args)
    {    
        Console.WriteLine("Добро пожаловать в программу генеологического древа семьи Романовых!");
        Console.WriteLine("Что выхотите посмотреть?");
        bool flag = true;
        while (flag){
            Console.WriteLine("1 - узнать информацию о конкретном человеке;");
            Console.WriteLine("2 - узнать информацию о всей семье;");
            Console.WriteLine("3 - выход из программы.");
            Console.WriteLine("Укажите порядковый номер: ");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num == 1)
            {
                GetValue.GetPersonInfo();
                Console.WriteLine("Вы хотите продолжить работу с приложением? Что выхотите посмотреть?");
            }
            else if (num == 2)
            {
                GetValue.GetListofMembers();
                Console.WriteLine("Вы хотите продолжить работу с приложением? Что выхотите посмотреть?");
            }
            else if (num == 3)
            {
                Console.WriteLine("Спасибо за визит!");
                flag = false;
            }
            else
            {
                Console.WriteLine("Нет такого пункта!");
                Console.WriteLine("Скорректируйте данные пункта: ");
            }
        }
    }
}

