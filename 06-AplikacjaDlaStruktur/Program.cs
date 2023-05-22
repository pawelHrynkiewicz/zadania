var cats = new Cat[]{
    new(){
        Name="Endrju",
        Owner="Andrzej"
    },
    new(){
        Name="Pablo",
        Owner="Paweł"
    },
    new(){
        Name="Olka",
        Owner="Aleksandra"
    }
};

var endSession = false;

while (!endSession)
{
    Console.WriteLine("What do you want to do?");
    Console.WriteLine("[a]dd new cat");
    Console.WriteLine("[d]elete existing cat");
    Console.WriteLine("[e]dit existing cat");
    Console.WriteLine("[s]how cats on the list");
    Console.WriteLine("[ex]it");
    var inputLine = Console.ReadLine();
    switch (inputLine.ToUpper())
    {
        case "A":
            AddCat();
            break;
        case "D":
            DeleteCat();
            break;
        case "E":
            EditCat();
            break;
        case "S":
            ShowCats();
            break;
        case "EX":
            endSession = true;
            break;
        default:
            Console.WriteLine("provide correct input");
            break;
    }

}
Console.WriteLine("closing the app");



void AddCat()
{

    var newList = new Cat[cats.Length + 1];
    for (int index = 0; index < cats.Length; index++)
    {
        newList[index] = cats[index];
    }
    newList[cats.Length] = takeNewCatAdd();
    cats = newList;

}
void validateString(string dataToValidate)
{
    if (string.IsNullOrWhiteSpace(dataToValidate))
    {
        throw new Exception("name can't be empty");
    }
}
void checkCatAndOwnerExistance(string catsName, string ownersName)
{
    foreach (var cat in cats)
    {
        bool catsNameCollision = string.Equals(cat.Name, catsName, System.StringComparison.OrdinalIgnoreCase);
        bool ownersNameCollision = string.Equals(cat.Owner, ownersName, System.StringComparison.OrdinalIgnoreCase);
        if (catsNameCollision && ownersNameCollision)
        {
            throw new Exception($"cat {catsName} with its owner {ownersName} already exists");
        }
    }
}
Cat takeNewCatAdd()
{
    var success1 = false;
    var success2 = false;
    string? catsName = "";
    string? ownersName = "";
    while (!success1)
    {
        success2 = false;
        while (true)
        {
            Console.WriteLine("what is cat's name?");
            catsName = Console.ReadLine();
            try
            {
                validateString(catsName);
                break;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        success2 = false;
        while (true)
        {
            Console.WriteLine("what is owners's name?");
            ownersName = Console.ReadLine();
            try
            {
                validateString(ownersName);
                break;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        try
        {
            checkCatAndOwnerExistance(catsName, ownersName);
            success1 = true;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
    var cat = new Cat()
    {
        Name = catsName,
        Owner = ownersName,
    };
    return cat;
}
void validateListExistance()
{
    if (cats.Length == 0)
    {
        throw new Exception("list can't be empty");
    }
}
void DeleteCat()
{
    var catToDelete = provideCheckedData();
    if (catToDelete.Length == 0)
    {
        return;
    }
    deleteCatAfterChecking(catToDelete[0], catToDelete[1]);


}

void deleteCatAfterChecking(string catsName, string ownersName)
{
    var newList = new Cat[cats.Length - 1];
    int index = 0;
    foreach (var cat in cats)
    {
        if (!(string.Equals(cat.Name, catsName, System.StringComparison.OrdinalIgnoreCase) && string.Equals(cat.Owner, ownersName, System.StringComparison.OrdinalIgnoreCase)))
        {
            newList[index] = cat;
            index++;
        }
    }
    cats = newList;
}
void checkCatExistance(string? dataToValidate)
{
    var exists = false;
    foreach (var cat in cats)
    {
        if (string.Equals(cat.Name, dataToValidate, StringComparison.OrdinalIgnoreCase))
        {
            exists = true;
            break;
        }
    }
    if (!exists)
    {
        throw new Exception($"there is no cat named {dataToValidate}");
    }
}
void checkOwnerExistance(string? catsName, string? dataToValidate)
{
    var exists = false;
    foreach (var cat in cats)
    {
        var catsNameExists = string.Equals(cat.Name, catsName, StringComparison.OrdinalIgnoreCase);
        var ownersNameExists = string.Equals(cat.Owner, dataToValidate, StringComparison.OrdinalIgnoreCase);
        if (catsNameExists && ownersNameExists)
        {
            exists = true;
            break;
        }
    }
    if (!exists)
    {
        throw new Exception($"{dataToValidate} isn't owner of {catsName}");
    }
}
void EditCat()
{
    var catToEdit = provideCheckedData();
    if (catToEdit.Length == 0)
    {
        return;
    }
    int index = provideIndex(catToEdit[0], catToEdit[1]);
    Console.WriteLine(index);
    Console.WriteLine($"{catToEdit[0]}, {catToEdit[1]}");

    Console.WriteLine("What do you want to do?");
    Console.WriteLine("Type [N] for editing the name of the Cat.\nType [O] for editing the Owner.\nType [B] for editing the both values.");
    var inputLine = Console.ReadLine();

    switch (inputLine.ToUpper())
    {
        case "N":
            changeCat(index);
            break;
        case "O":
            changeOwner(index);
            break;
        case "B":
            changeBoth(index);
            break;
        default:
            Console.WriteLine("provide correct input");
            break;
    }

}
string[] provideCheckedData()
{
    try
    {
        validateListExistance();
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
        return new string[0];
    }
    Console.WriteLine("Provide name of the cat");
    string? catsName = "";
    var success1 = false;
    var success2 = false;
    while (!success1 || !success2)
    {
        success1 = false;
        success2 = false;
        catsName = Console.ReadLine();
        try
        {
            validateString(catsName);
            success1 = true;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            continue;
        }
        try
        {
            checkCatExistance(catsName);
            success2 = true;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
    int count = 0;
    int index = -1;
    foreach (Cat cat in cats)
    {
        if (string.Equals(cat.Name, catsName, System.StringComparison.OrdinalIgnoreCase))
        {
            count++;
            index = Array.IndexOf(cats, cat);
        }
    }
    if (count == 1)
    {
        var result = new string[2];
        result[0] = catsName;
        result[1] = cats[index].Owner;
        return result;
    }
    else
    {
        Console.WriteLine("there are more than 1 cat with this name");
        Console.WriteLine("to select cat provide its owner's name ");
        string ownersName = "";
        success1 = false;
        success2 = false;
        while (!success1 || !success2)
        {
            success1 = false;
            success2 = false;
            ownersName = Console.ReadLine();
            try
            {
                validateString(ownersName);
                success1 = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                continue;
            }
            try
            {
                checkOwnerExistance(catsName, ownersName);
                success2 = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        var output = new string[2];
        output[0] = catsName;
        output[1] = ownersName;
        return output;
    }

}
int provideIndex(string catsName, string ownersName)
{
    int output = -1;
    foreach (var cat in cats)
    {

        var correctCatsName = string.Equals(cat.Name, catsName, StringComparison.OrdinalIgnoreCase);
        var correctOwnersName = string.Equals(cat.Owner, ownersName, StringComparison.OrdinalIgnoreCase);
        if (correctCatsName && correctOwnersName)
        {
            output = Array.IndexOf(cats, cat);
            return output;
        }

    }
    return output;
}
void ShowCats()

{
    Console.WriteLine();
    Console.WriteLine();
    foreach (var cat in cats)
    {
        Console.WriteLine($"Name:{cat.Name}, owner: {cat.Owner}");
    }
    Console.WriteLine();
    Console.WriteLine();
}

void changeCat(int index)
{

    Console.WriteLine("Provide new name of the cat");
    var catsName = "";
    while (true)
    {
        while (true)
        {
            catsName = Console.ReadLine();
            try
            {
                validateString(catsName);
                break;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        try
        {
            checkCatAndOwnerExistance(catsName, cats[index].Owner);
            break;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
    cats[index].Name = catsName;

}
void changeOwner(int index)
{
    Console.WriteLine("Provide new name of the owner");
    string? ownersName = "";
    while (true)
    {
        while (true)
        {
            ownersName = Console.ReadLine();
            try
            {
                validateString(ownersName);
                break;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        try
        {
            checkCatAndOwnerExistance(cats[index].Name, ownersName);
            break;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
    cats[index].Owner = ownersName;

}
void changeBoth(int index)
{
    Console.WriteLine("Provide new name of the cat then provide name of the owner");
    string? catsName = "";
    string? ownersName = "";
    while (true)
    {
        while (true)
        {
            catsName = Console.ReadLine();
            ownersName = Console.ReadLine();
            try
            {
                validateString(catsName);
                validateString(ownersName);
                break;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        try
        {
            checkCatAndOwnerExistance(catsName, ownersName);
            break;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
    cats[index].Name = catsName;
    cats[index].Owner = ownersName;

}