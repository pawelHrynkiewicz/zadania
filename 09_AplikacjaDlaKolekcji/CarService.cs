namespace _09_AplikacjaDlaKolekcji
{
    internal class CarService
    {
        private readonly DataService _dataService;
        private List<Car> _cars { get; set; } = new List<Car>();
        public CarService()
        {
            _dataService = new DataService();
            _cars = _dataService.GetCarsFromFile();
        }
        public void SaveData()
        {
            _dataService.SaveCarsToFile(_cars);
        }
        public void Add()
        {
            string? carName = "";
            Console.WriteLine("Provide name of the car");
            while (true)
            {
                carName = Console.ReadLine();
                try
                {
                    validateString(carName);
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);

                }
            }
            string? carModel = "";
            Console.WriteLine("Provide Model of the car");
            while (true)
            {
                carModel = Console.ReadLine();
                try
                {
                    validateString(carModel);
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);

                }
            }
            string? carYearString = "";
            int carYear = 0;
            Console.WriteLine("Provide year of production");
            while (true)
            {
                carYearString = Console.ReadLine();
                try
                {
                    carYear = int.Parse(carYearString);
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);

                }
            }
            var carToAdd = new Car(carName, carModel, carYear);
            _cars.Add(carToAdd);

        }
        public void Show()
        {
            Console.WriteLine(_cars.Count());
            foreach (var car in _cars)
            {
                car.Show();
            }
        }
        public void Delete()
        {
            Console.WriteLine("Provide an ID of the new car that you want to remove:");
            string? providedInput = "";
            int idToDelete = 0;
            while (true)
            {
                providedInput = Console.ReadLine();
                try
                {
                    idToDelete = int.Parse(providedInput);
                    var carToDelete = _cars.Find(x => x.Id == idToDelete);
                    if (carToDelete == null)
                    {
                        throw new Exception($"There is no car with id: {idToDelete}");
                    }
                    _cars.Remove(carToDelete);
                    Console.WriteLine("You've removed car successfully!");
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }


            }
        }
        public void Edit()
        {
            Console.WriteLine("Provide car ID to edit:");
            string? providedValue = "";
            int id = 0;
            var carToEdit = new Car();
            while (true)
            {
                providedValue = Console.ReadLine();
                try
                {
                    validateString(providedValue);
                    id = int.Parse(providedValue);
                    carToEdit = _cars.Find(x => x.Id == id);
                    if (carToEdit == null)
                    {
                        throw new Exception($"There is no car with id: {id}");
                    }
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }
            //-------------------

            while (true)
            {
                Console.WriteLine("Type [N] for editing the name of the car.\nType [M] for editing the Model.\nType [Y] for editing the year \nType [E] for editing everything");
                providedValue = Console.ReadLine();
                try
                {
                    validateString(providedValue);
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            //-------------
            var success = false;
            while (!success)
            {
                switch (providedValue.ToUpper())
                {
                    case "N":
                        ChangeName(carToEdit);
                        success = true;
                        break;
                    case "M":
                        ChangeModel(carToEdit);
                        success = true;
                        break;
                    case "Y":
                        ChangeYear(carToEdit);
                        success = true;
                        break;
                    case "E":
                        ChangeEvr(carToEdit);
                        success = true;
                        break;
                    default:
                        continue;
                }
            }
        }
        public void validateString(string? dataToValidate)
        {
            if (string.IsNullOrWhiteSpace(dataToValidate))
                throw new Exception("this can not be empty");

        }
        public void ChangeName(Car car)
        {
            Console.WriteLine("Provide new name of the car");
            string? input = "";
            while (true)
            {
                input = Console.ReadLine();
                try
                {
                    validateString(input);
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            car.ChangeName(input);
        }
        public void ChangeModel(Car car)
        {
            Console.WriteLine("Provide new model of the car");
            string? input = "";
            while (true)
            {
                input = Console.ReadLine();
                try
                {
                    validateString(input);
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            car.ChangeModel(input);
        }
        public void ChangeYear(Car car)
        {
            Console.WriteLine("Provide new year of prodcution of the car");
            string? input = "";
            int year = 0;
            while (true)
            {
                input = Console.ReadLine();
                try
                {

                    year = int.Parse(input);
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            car.ChangeYear(year);
        }
        public void ChangeEvr(Car car)
        {
            ChangeName(car);
            ChangeModel(car);
            ChangeYear(car);
        }
    }
}