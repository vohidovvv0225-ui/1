class Car
{
    public string Make;
    public string Model;
    public int Year;
    public double Mileage;
    public double Fuel;

    public Car(string make, string model, int year)
    {
        Make = make;
        Model = model;
        Year = year;
        Mileage = 0;
        Fuel = 0;
    }

    public void Drive(double miles)
    {
        double fuelNeeded = miles / 20;

        if (Fuel < fuelNeeded)
        {
            Console.WriteLine("Not enough fuel. Please refuel!");
        }
        else
        {
            Mileage += miles;
            Fuel -= fuelNeeded;

            Console.WriteLine($"You have driven {miles} miles. Current mileage: {Mileage} miles. Remaining fuel: {Fuel} gallons.");
        }
    }

    public void AddFuel(double gallons)
    {
        Fuel += gallons;

        Console.WriteLine($"Added {gallons} gallons of fuel. Current fuel level: {Fuel} gallons.");
    }
}