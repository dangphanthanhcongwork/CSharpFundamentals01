namespace CSharpFundamentals01;

class Program
{
    public static void FindMale(List<Member> members)
    {
        List<Member> males = [];
        foreach (var member in members)
        {
            if (member.Gender == "Male")
            {
                males.Add(member);
            }
        }
        Console.WriteLine("List of members who is male:");
        foreach (var member in males)
        {
            Console.WriteLine(member);
        }
    }
    public static void FindOldest(List<Member> members)
    {
        Member oldestMember = members[0];
        foreach (var member in members)
        {
            if (oldestMember.Age < member.Age)
            {
                oldestMember = member;
            }
        }
        Console.WriteLine("The oldest one:");
        Console.WriteLine(oldestMember);
    }
    public static void GetFullNameOnly(List<Member> members)
    {
        List<string> fullNames = [];
        foreach (var member in members)
        {
            fullNames.Add(member.LastName + " " + member.FirstName);
        }
        Console.WriteLine("List of fullname only:");
        foreach (var fullName in fullNames)
        {
            Console.WriteLine(fullName);
        }
    }
    public static void FilterByYearOfBirth(List<Member> members)
    {
        List<Member> equal2000 = [];
        List<Member> greaterThan2000 = [];
        List<Member> lessThan2000 = [];
        foreach (var member in members)
        {
            switch (member.DateOfBirth.Year)
            {
                case > 2000:
                    greaterThan2000.Add(member);
                    break;
                case < 2000:
                    lessThan2000.Add(member);
                    break;
                default:
                    equal2000.Add(member);
                    break;
            }
        }
        Console.WriteLine("List of members who has birth year is 2000:");
        foreach (var member in equal2000)
        {
            Console.WriteLine(member);
        }
        Console.WriteLine();
        Console.WriteLine("List of members who has birth year is greater than 2000:");
        foreach (var member in greaterThan2000)
        {
            Console.WriteLine(member);
        }
        Console.WriteLine();
        Console.WriteLine("List of members who has birth year is less than 2000:");
        foreach (var member in lessThan2000)
        {
            Console.WriteLine(member);
        }
    }
    public static void FindFirstBornInHanoi(List<Member> members)
    {

        Console.WriteLine("The first person who was born in Ha Noi:");
        foreach (var member in members)
        {
            if (member.Birthplace == "Ha Noi")
            {
                Console.WriteLine(member);
                break;
            }
        }
    }
    static void Main(string[] args)
    {
        List<Member> members =
        [
            new Member("Cong", "Dang Phan Thanh", "Male", "15/06/2000", "Lam Dong", "0375284637", true),
            new Member("Linh", "Nguyen My", "Female", "04/07/1995", "Ha Noi", "0375284636", true),
            new Member("Phuong", "Nguyen Thi Ha", "Female", "07/04/2002", "Hai Phong", "0375284635", false),
            new Member("Thu", "Phan Thi Ha", "Female", "27/02/2003", "Nghe An", "0375284634", false),
            new Member("Quang", "Tran Huy", "Male", "20/04/1994", "Ha Noi", "0375284633", false),
        ];

        // print list
        // foreach (Member member in members)
        // {
        //     Console.WriteLine(member);
        // }
        // Console.WriteLine();

        Console.WriteLine("Menu");
        Console.WriteLine("1. Return a list of members who is male");
        Console.WriteLine("2. Return the oldest one based on age");
        Console.WriteLine("3. Return a list that contains full name only");
        Console.WriteLine("4. Return 3 lists:");
        Console.WriteLine(" - List of members who has birth year is 2000");
        Console.WriteLine(" - List of members who has birth year greater than 2000");
        Console.WriteLine(" - List of members who has birth year less than 2000");
        Console.WriteLine("5. Return the first person who was born in Ha Noi");
        Console.WriteLine("0. Exit");
        Console.WriteLine("-------");

        Console.Write("Selection: ");
        int selection = Convert.ToInt32(Console.ReadLine());

        while (selection != 0)
        {
            switch (selection)
            {
                case 1:
                    FindMale(members);
                    Console.WriteLine("-------");
                    break;
                case 2:
                    FindOldest(members);
                    Console.WriteLine("-------");
                    break;
                case 3:
                    GetFullNameOnly(members);
                    Console.WriteLine("-------");
                    break;
                case 4:
                    FilterByYearOfBirth(members);
                    Console.WriteLine("-------");
                    break;
                case 5:
                    FindFirstBornInHanoi(members);
                    Console.WriteLine("-------");
                    break;
                default:
                    Console.WriteLine("INVALID SELECTION!!! PLEASE SELECT AGAIN !!!");
                    Console.WriteLine("-------");
                    break;
            }
            Console.Write("Selection: ");
            selection = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine("GOOD BYE !!! =))");
    }
}
