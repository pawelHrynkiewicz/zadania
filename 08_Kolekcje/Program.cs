using System.Linq;
var cats = new List<Cat>(){
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
    var inputLine = "";
    while (true)
    {
        inputLine = Console.ReadLine();
        try
        {
            validateString(inputLine);
            break;
        }
        catch (Exception ex)
        {

            Console.WriteLine(ex.Message);
        }
    }
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
void AddCat()
{
    string? catsName = null;
    string? ownersName = null;
    while (true)
    {
        while (true)
        {
            Console.WriteLine("Type name of new cat");
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
        while (true)
        {
            Console.WriteLine("Type name of the owner");
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
            break;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

    }
    var catToAdd = new Cat()
    {
        Name = capitalizeFirstLetter(catsName),
        Owner = capitalizeFirstLetter(ownersName),
    };
    cats.Add(catToAdd);
    Console.WriteLine(cats.Count);
}

void validateString(string? dataToValidate)
{
    if (string.IsNullOrWhiteSpace(dataToValidate))
        throw new Exception("this can not be empty");

}
void checkCatAndOwnerExistance(string catsName, string ownersName)
{
    catsName.ToUpper();
    var newCat = new Cat()
    {
        Name = capitalizeFirstLetter(catsName),
        Owner = capitalizeFirstLetter(ownersName),
    };
    if (cats.Contains(newCat))
    {
        throw new Exception($"cat {catsName} with its owner {ownersName} already exists");
    }
}
void checkCatExistance(string catsName)
{
    bool catExists = cats.Any(cat => String.Equals(cat.Name, catsName, StringComparison.OrdinalIgnoreCase));
    if (!catExists)
    {
        throw new Exception($"there is no cat named {catsName}");
    }
}
void checkOwnerExistance(string catsName, string dataToValidate)
{
    Cat newCat = new Cat()
    {
        Name = capitalizeFirstLetter(catsName),
        Owner = capitalizeFirstLetter(dataToValidate),
    };
    bool ownerExists = cats.Contains(newCat);
    if (!ownerExists)
    {
        throw new Exception($"{dataToValidate} isn't owner of {catsName}");
    }
}
void ShowCats()
{
    Console.WriteLine();
    Console.WriteLine();
    foreach (var cat in cats)
    {
        Console.WriteLine($"cat: {cat.Name}, owner: {cat.Owner}");
    }
    Console.WriteLine();
    Console.WriteLine();
}
void DeleteCat()
{
    try
    {
        checkListExistance();
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
        return;
    }
    var catToDelete = provideCheckedData();
    Console.WriteLine(catToDelete.Name);
    Console.WriteLine(catToDelete.Owner);
    cats.Remove(catToDelete);

}
void checkListExistance()
{
    if (cats.Count == 0)
    {
        throw new Exception("list is empty");
    }

}
Cat provideCheckedData()
{
    string? catsName = "";
    string? ownersName = "";
    while (true)
    {
        Console.WriteLine("type name of the cat");
        catsName = Console.ReadLine();
        try
        {
            validateString(catsName);
            try
            {
                checkCatExistance(catsName);
                break;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

    }

    if (isUnique(catsName))
    {
        var result = cats.FirstOrDefault(cat => String.Equals(cat.Name, catsName, StringComparison.OrdinalIgnoreCase));
        Console.WriteLine(result.Owner);
        return result;
    }
    else
    {
        while (true)
        {
            Console.WriteLine("there are more than 1 cat with this name");
            Console.WriteLine("to select cat provide its owner's name ");
            ownersName = Console.ReadLine();
            try
            {
                validateString(ownersName);
                try
                {
                    checkOwnerExistance(catsName, ownersName);
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        var result = new Cat()
        {
            Name = capitalizeFirstLetter(catsName),
            Owner = capitalizeFirstLetter(ownersName),
        };
        return result;
    }


}
bool isUnique(string catsName)
{
    int existingCats = cats.Count(cat => String.Equals(cat.Name, catsName, StringComparison.OrdinalIgnoreCase));
    if (existingCats > 1)
        return false;
    else
        return true;


}
void EditCat()
{
    try
    {
        checkListExistance();
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
        return;
    }
    var catToEdit = provideCheckedData();
    Console.WriteLine("What do you want to do?");
    Console.WriteLine("Type [N] for editing the name of the Cat.\nType [O] for editing the Owner.\nType [B] for editing the both values.");
    var inputLine = Console.ReadLine();
    while (true)
    {
        try
        {
            validateString(inputLine);
            break;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    switch (inputLine.ToUpper())
    {
        case "N":
            changeCat(catToEdit);
            break;
        case "O":
            changeOwner(catToEdit);
            break;
        case "B":
            changeBoth(catToEdit);
            break;
        default:
            Console.WriteLine("provide correct input");
            break;
    }

}


string capitalizeFirstLetter(string text)
{
    string firstChar = text.Substring(0, 1);
    firstChar = firstChar.ToUpper();
    string rest = text.Substring(1);
    rest.ToLower();
    string result = firstChar + rest;
    return result;
}

void changeCat(Cat catToEdit)
{
    string? catsName = "";
    string? ownersName = catToEdit.Owner;
    Console.WriteLine("Provide new name of the cat");
    while (true)
    {
        catsName = Console.ReadLine();
        try
        {
            validateString(catsName);
            checkCatAndOwnerExistance(catsName, ownersName);
            break;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
    int index = cats.IndexOf(catToEdit);
    var editedCat = new Cat()
    {
        Name = capitalizeFirstLetter(catsName),
        Owner = capitalizeFirstLetter(ownersName),
    };
    cats.Insert(index, editedCat);
    cats.RemoveAt(index + 1);
}
void changeOwner(Cat catToEdit)
{
    string? catsName = catToEdit.Name;
    string? ownersName = "";
    Console.WriteLine("Provide new name of the owner");
    while (true)
    {
        ownersName = Console.ReadLine();
        try
        {
            validateString(ownersName);
            checkCatAndOwnerExistance(catsName, ownersName);
            break;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
    int index = cats.IndexOf(catToEdit);
    var editedCat = new Cat()
    {
        Name = capitalizeFirstLetter(catsName),
        Owner = capitalizeFirstLetter(ownersName),
    };
    cats.Insert(index, editedCat);
    cats.RemoveAt(index + 1);
}
void changeBoth(Cat catToEdit)
{
    string? catsName = "";
    string? ownersName = "";
    Console.WriteLine("Provide new name of the cat,");
    Console.WriteLine("then provide new name of the owner");
    while (true)
    {
        catsName = Console.ReadLine();
        ownersName = Console.ReadLine();
        try
        {
            validateString(catsName);
            validateString(ownersName);
            checkCatAndOwnerExistance(catsName, ownersName);
            break;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
    int index = cats.IndexOf(catToEdit);
    var editedCat = new Cat()
    {
        Name = capitalizeFirstLetter(catsName),
        Owner = capitalizeFirstLetter(ownersName),
    };
    cats.Insert(index, editedCat);
    cats.RemoveAt(index + 1);
}