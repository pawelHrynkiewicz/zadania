using _15_BazaDanychWlasne;

var dbService = new DbService();
while (true)
{
    var shutDown = false;
    Console.WriteLine("Podaj komendę");
    Console.WriteLine("[S] -> wyswietl studnetow");
    Console.WriteLine("[A] -> dodaj nowego stundeta");
    Console.WriteLine("[U] -> edytuj studenta");
    Console.WriteLine("[D] -> Wywal studneta ze studiow");
    Console.WriteLine("[E] -> zakoncz");
    var input = Console.ReadLine();
    try
    {
        input = input.ToUpper();
    }
    catch (Exception ex)
    { 
        Console.WriteLine(ex.Message);
        continue;
    }
    switch (input)
    {
        case "S":
            ShowAll();
            break;
        case "A":
            AddNewStudent();
            break;
        case "U":
            EditSelected();
            break;
        case "D":
            WywalStudenciaka();
            break;
        case "E":
            shutDown = true;
            break;

    };
    if (shutDown)
        break;

}

void ShowAll()
{
    var students = dbService.GetStudentsFromDb();

    foreach (Student student in students)
    {
        Console.WriteLine(student.ToString());
    }
}
void EditSelected()
{
    var id = 0;
    while (true)
    {
        Console.WriteLine("Podaj Id");
        var givenIdStr = Console.ReadLine();
        try
        {
            id = int.Parse(givenIdStr);
            break;
        }
        catch (Exception ex) { Console.WriteLine(ex.Message); }
    }
    Console.WriteLine("Podaj Nazwisko");
    var lastname = Console.ReadLine();

    Console.WriteLine("Podaj imie");
    var firstname = Console.ReadLine();

    Console.WriteLine("Podaj kierunek studiow");
    var major = Console.ReadLine();
    var year = 0;
    while (true)
    {
        Console.WriteLine("Podaj rok studiow");
        var yearStr = Console.ReadLine();
        try
        {
            year = int.Parse(yearStr);
            if (year > 0 && year < 7)
                break;
            else { throw new Exception("zly przedzial"); }
        }
        catch (Exception ex) { Console.WriteLine(ex.Message) ; }
    }
    var gpa = 0.0;
    while (true)
    {
        Console.WriteLine("Podaj srednia ze studiow");
        var gpaStr = Console.ReadLine();
        try
        {
            gpa = double.Parse(gpaStr);
            if (gpa >= 2 && gpa <= 5)
                break;
            else throw new Exception("zly przedzial");
        }
        catch (Exception ex) { Console.WriteLine(ex.Message); }
    }
    var student = new Student(id, lastname, firstname, major, year, gpa);
    dbService.EditStudent(student);
}
void WywalStudenciaka()
{
    var id = 0;
    Console.WriteLine("Podaj id studenciaka do wywalenia");
    while (true)
    {
        var idStr= Console.ReadLine();
        try
        {
            id = int.Parse(idStr);
            break;
        }
        catch (Exception ex) { Console.WriteLine(); }
    }
    dbService.DeleteStudent(id);
     
}
void AddNewStudent()
{
    Console.WriteLine("Podaj Nazwisko");
    var lastname = Console.ReadLine();

    Console.WriteLine("Podaj imie");
    var firstname = Console.ReadLine();

    Console.WriteLine("Podaj kierunek studiow");
    var major = Console.ReadLine();

    var year = 0;
    while (true)
    {
        Console.WriteLine("Podaj rok studiow");
        var yearStr = Console.ReadLine();
        try
        {
            year = int.Parse(yearStr);
            if (year >0 && year<7)
                break;
            else { throw new Exception("zly przedzial"); }
        }
        catch (Exception ex) { Console.WriteLine(ex.Message); }
    }
    var gpa = 0.0;
    while (true)
    {
        Console.WriteLine("Podaj srednia ze studiow");
        var gpaStr = Console.ReadLine();
        try
        {
            gpa = double.Parse(gpaStr);
            if (gpa >= 2 && gpa <= 5)
                break;
            else throw new Exception("zly przedzial");
        }
        catch (Exception ex) { Console.WriteLine(ex.Message); }
        
    }
    var student = new Student(lastname, firstname, major, year, gpa);
    Console.WriteLine(student.ToString());
    dbService.AddStudent(student);
}
