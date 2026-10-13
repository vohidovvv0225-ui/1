// Person person= new Person();
// person.LastName="Shahrom";
// person.FirstName="Sharipov";
// person.Age=2000;
// person.Addrress="n.sino";
// person.GetFullname();
// person.Getbirthday();


// taski 2
// Rectangle rectangle=new Rectangle();
// rectangle.Width=7;
// rectangle.Height=5;
// rectangle.Area();



// taski 3
//  Student student = new Student();
//         student.Name = "Vohidov Muhammad";
//         student.Gradelevel = 1;
//         student.Testscore = new int[] { 75, 80, 85 };

//         Student student1 = new Student()
//         {
//             Name = "Hamzaali",
//             Gradelevel = 2,
//             Testscore = new int[] { 70, 75, 80 }
//         };

//         Student student2 = new Student()
//         {
//             Name = "Ali",
//             Gradelevel = 3,
//             Testscore = new int[] { 90, 95, 100 }
//         };

//         Student student3 = new Student()
//         {
//             Name = "Vali",
//             Gradelevel = 4,
//             Testscore = new int[] { 85, 90, 95 }
//         };

//         Student[] students={student,student1,student2,student3};
//      foreach (Student student4 in students)
//         {
//             double average = student4.Getaverage();

//             if (average > 85)
//             {
//                 Console.WriteLine($"Congratulations {student4.Name} on achieving above average scores ({average:F1}) in grade {student4.Gradelevel}!");
//                 Console.WriteLine("Keep up the good work!");
//             }
//             else if (average < 70)
//             {
//                 Console.WriteLine($"{student4.Name}, if you're having difficulties with your studies, don't hesitate to seek help. Your current average score is {average:F1} in grade {student4.Gradelevel}.");
//             }
//             else
//             {
//                 Console.WriteLine($"Good job, {student4.Name}! Your average score is {average:F1} in grade {student4.Gradelevel}. Keep working to improve!");
//             }

//             Console.WriteLine("----------------------------------------");
//         }
    


    Car myCar = new Car("Toyota", "Camry", 2022);

        Console.WriteLine($"Make: {myCar.Make}");
        Console.WriteLine($"Model: {myCar.Model}");
        Console.WriteLine($"Year: {myCar.Year}");
        Console.WriteLine($"Mileage: {myCar.Mileage} miles");
        Console.WriteLine($"Fuel level: {myCar.Fuel} gallons");

        myCar.Drive(100);

        myCar.AddFuel(10);

        Console.WriteLine("\nAfter the trip and refueling:");
        Console.WriteLine($"Mileage: {myCar.Mileage} miles");
        Console.WriteLine($"Fuel level: {myCar.Fuel} gallons");