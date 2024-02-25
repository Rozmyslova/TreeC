using System.Reflection.Metadata.Ecma335;

internal class People
{
    public People()
    {
    }

    public static Dictionary<int, Person> MembersOfFamily()
    {
        Dictionary<int, Person> allMembers = new Dictionary<int, Person>()
        {
            [1] = new Person {FullName = "Романов Николай Аександрович", 
                        Gender = "Мужской", DateOfBirth = "18.5.1868", 
                        DateOfDeath = "17.07.1918", Mother = "Романова Мария Федоровна", 
                        Father = "Романов Александр Александрович", 
                        FamilyStatus = "Женат", PartnerName = "Романова Александра Федоровна"},
            [2] = new Person{FullName = "Романова Александра Федоровна",
                        Gender = "Женский", DateOfBirth = "6.6.1872", 
                        DateOfDeath = "17.07.1918", Mother = "Гессенская Алиса", 
                        Father = "Гессенский Людвиг",  
                        FamilyStatus = "Замужем", PartnerName = "Романов Николай Аександрович"},
            [3] = new Person{FullName = "Романова Ольга Николаевна", 
                        Gender = "Женский", DateOfBirth = "3.11.1895", 
                        DateOfDeath = "17.07.1918", Mother = "Романова Александра Федоровна", 
                        Father = "Романов Николай Аександрович", 
                        FamilyStatus = "Не замужем",  PartnerName = "нет"},
            [4] = new Person{FullName = "Романова Татьяна Николаевна", 
                        Gender = "Женский", DateOfBirth = "10.6.1897", 
                        DateOfDeath = "17.07.1918", Mother = "Романова Александра Федоровна", 
                        Father = "Романов Николай Аександрович", 
                        FamilyStatus = "Не замужем", PartnerName = "нет"},
            [5] = new Person{FullName = "Романова Мария Николаевна", 
                        Gender = "Женский", DateOfBirth = "26.6.1899", 
                        DateOfDeath = "17.07.1918", Mother = "Романова Александра Федоровна", 
                        Father = "Романов Николай Аександрович", 
                        FamilyStatus = "Не замужем", PartnerName = "нет"},
            [6] = new Person{FullName = "Романова Анастасия Николаевна", 
                        Gender = "Женский", DateOfBirth = "18.6.1901", 
                        DateOfDeath = "17.07.1918", Mother = "Романова Александра Федоровна", 
                        Father = "Романов Николай Аександрович", 
                        FamilyStatus = "Не замужем", PartnerName = "нет"},
            [7] = new Person{FullName = "Романов Алексей Николаевич", 
                        Gender = "Мужской", DateOfBirth = "12.8.1904", 
                        DateOfDeath = "17.07.1918", Mother = "Романова Александра Федоровна", 
                        Father = "Романов Николай Аександрович", 
                        FamilyStatus = "Не женат", PartnerName = "нет"},
            [8] = new Person{FullName = "Романов Александр Александрович", 
                        Gender = "Мужской", DateOfBirth = "10.3.1845", 
                        DateOfDeath = "20.10.1984", Mother = "Романова Мария Александровна", 
                        Father = "Романов Александр Николаевич", 
                        FamilyStatus = "Женат", PartnerName = "Романова Мария Федоровна"},
            [9] = new Person{FullName = "Романова Мария Федоровна", 
                        Gender = "Женский", DateOfBirth = "26.11.1847", 
                        DateOfDeath = "13.10.1928", Mother = "Глюксборг Луиза", 
                        Father = "Глюксборг Кристиан", 
                        FamilyStatus = "Замужем", PartnerName = "Романов Александр Александрович"},
            [10] = new Person{FullName = "Гессенский Людвиг",
                        Gender = "Мужской", DateOfBirth = "12.9.1837", 
                        DateOfDeath = "13.3.1892", Mother = "Прусская Елизавета", 
                        Father = "Гессенский Карл", 
                        FamilyStatus = "Женат", PartnerName = "Гессенская Алиса"},
            [11] = new Person{FullName = "Гессенская Алиса", 
                        Gender = "Женский", DateOfBirth = "25.4.1843", 
                        DateOfDeath = "14.12.1878", Mother = "Александрина Виктория", 
                        Father = "Альберт Саксен-Кобург-Готского", 
                        FamilyStatus = "Замужем", PartnerName = "Гессенский Людвиг"}
        };
        return allMembers;
    }
    
}

internal class Person
{
    public string Gender { get; internal set; }
    public string Mother { get; internal set; }
    public string Father { get; internal set; }
    public string FullName { get; internal set; }
    public string DateOfBirth { get; internal set; }
    public string DateOfDeath { get; internal set; }
    public string PartnerName { get; internal set; }
    public string FamilyStatus { get; internal set; }

    public override string ToString()
    {
        string buf = FullName + "\nПол: "+ Gender + "\nДата рождения: "+ DateOfBirth + "\nДата смерти: "+ DateOfDeath + "\nМать: "+  Mother + "\nОтец: "+ Father + "\nСемейное положение: "+ FamilyStatus + "\nИмя партнера: "+ PartnerName;
        return buf;
    }
}
