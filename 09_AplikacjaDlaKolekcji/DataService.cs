namespace _09_AplikacjaDlaKolekcji
{
    internal class DataService
    {
        public List<Car> GetCarsFromFile()
        {
            var fileName = "cars.txt";
            var cars = new List<Car>();
            var lines = File.ReadAllLines(fileName);
            int i=0;
            foreach (var line in lines)
            {
                if (string.IsNullOrWhiteSpace(line))
                    continue;
                var data = line.Split(';');
                if (data.Length != 3)
                    continue;
                var successfulConversion = int.TryParse(data[2], out int year);
                if (!successfulConversion)
                    continue;
                var name = data[0];
                var model = data[1];
                var car = new Car(name, model, year);

                cars.Add(car);

            }
            return cars;
        }
        public void SaveCarsToFile(List<Car> cars)
        {
            var fileName = "cars.txt";
            var convertedCars = new List<string>();
            foreach (var car in cars)
            {
                convertedCars.Add(car.ToString());                
            }
            File.WriteAllLines(fileName,convertedCars);
        }
    }
}