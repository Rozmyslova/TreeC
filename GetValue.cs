using System.Data.Common;
using System.Runtime.CompilerServices;

public class GetValue
{  
    public static void GetListofMembers()
    {
        Dictionary<int, Person> people = People.MembersOfFamily();
        Console.WriteLine("Ниже приведен список членов семьи Романовых: ");
        foreach(var person in people)
        {
            Console.WriteLine($"{person.Key} - {person.Value.FullName}");
        }
    }

    public static void GetPersonInfo()
    {
        bool flag = true;
        while (flag)
        {
            Console.WriteLine("Вы хотите узнать информацию по конкрутному человеку?");
            Console.WriteLine("1 - да;");
            Console.WriteLine("2 - нет, хочу выйти в предыдущее меню");
            Console.WriteLine("Укажите номер пункта: ");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num < 1 || num > 2)
            {
                Console.WriteLine("Нет такого пункта!");
                Console.WriteLine("Скорректируйте данные пункта: ");
            }
            else if (num == 1)
            {
                GetListofMembers();
                Console.WriteLine("Укажите id интересующего человека (1-11): ");
                int id = Convert.ToInt32(Console.ReadLine());
                if (id < 1 || id > 11)
                {
                    Console.WriteLine("Нет такого id!");
                    Console.WriteLine("Скорректируйте данные id: ");
                }
                else 
                {
                    bool flag2 = true;
                    while (flag2)
                    {
                        Console.WriteLine("Какую информацию по этому человеку вы хотите получить?");
                        Console.WriteLine("1 - общая информация (ФИО, дата рождения, дата смерти;)");
                        Console.WriteLine("2 - информация по родителям (мать, отец)");
                        Console.WriteLine("3 - информация по семейному положению (статус, имя партнера, если женат/замужем)");
                        Console.WriteLine("4 - выход в предыдущее меню");
                        Console.WriteLine("Укажите номер пункта (1-4): ");
                        int num2 = Convert.ToInt32(Console.ReadLine());
                        if (num2 == 1)
                        {
                            Dictionary<int, Person> people = People.MembersOfFamily();
                            Console.WriteLine("\nФИО           | " + people[id].FullName); 
                            Console.WriteLine("Дата рождения | " + people[id].DateOfBirth); 
                            Console.WriteLine("Дата смерти   | " + people[id].DateOfDeath); 
                            Console.WriteLine("__________________________________________________\n"); 
                        }
                        else if (num2 == 2)
                        {
                            Dictionary<int, Person> people = People.MembersOfFamily();
                            Console.WriteLine("\nФИО  | " + people[id].FullName); 
                            Console.WriteLine("Мать | " + people[id].Mother); 
                            Console.WriteLine("Отец | " + people[id].Father); 
                            Console.WriteLine("____________________________________________\n");
                        }
                        else if (num2 == 3)
                        {
                            Dictionary<int, Person> people = People.MembersOfFamily();
                            Console.WriteLine("\nФИО                | " + people[id].FullName); 
                            Console.WriteLine("Семейное положение | " + people[id].FamilyStatus);
                            if (people[id].FamilyStatus == "Женат")
                            {
                                Console.WriteLine("Супруга            | " + people[id].PartnerName);
                            }
                            else if (people[id].FamilyStatus == "Замужем")
                            {
                                Console.WriteLine("Супруг             | " + people[id].PartnerName);
                            }
                                Console.WriteLine("____________________________________________________\n");
                        }
                        
                        else if (num2 == 4)
                        {
                            Console.WriteLine("Выходим из этого меню.");
                            flag2 = false;
                        }
                        else
                        {
                            Console.WriteLine("Нет такого пункта!");
                            Console.WriteLine("Скорректируйте данные пункта: ");
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("Выходим из этого меню.");
                flag = false;
            }

                
        }
    }      
}