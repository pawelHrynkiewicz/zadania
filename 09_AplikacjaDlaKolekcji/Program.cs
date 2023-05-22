using _09_AplikacjaDlaKolekcji;

var carService = new CarService();
var endSession = false;
while (!endSession)
{
    Console.WriteLine("What do you want to do?");
    Console.WriteLine("[a]dd new car");
    Console.WriteLine("[d]elete existing car");
    Console.WriteLine("[e]dit existing car");
    Console.WriteLine("[s]how cars on the list");
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
            carService.Add();
            break;
        case "D":
            carService.Delete();
            break;
        case "E":
            carService.Edit();
            break;
        case "S":
            carService.Show();
            break;
        case "EX":
            endSession = true;
            break;
        default:
            Console.WriteLine("provide correct input");
            break;
    }
    
}
carService.SaveData();
void validateString(string? dataToValidate)
{
    if (string.IsNullOrWhiteSpace(dataToValidate))
        throw new Exception("this can not be empty");

}