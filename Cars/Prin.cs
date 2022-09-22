using Cars;
using Vehicle;
internal class Program
{
    internal class Functions
    {

    }
    private static void Main(string[] args)
    {
        Functions function = new Functions();
        Car Prius = new Car();
        Prius.model = new DateOnly(1997, 02, 11);
        Prius.brand = "Toyota";
        Prius.wheels = "Michelin";
        Prius.color = "White";
        Prius.description = "Ugliest hybrid car";
        Prius.type = "A";

        Car Actros = new Car();
        Actros.model = new DateOnly(2022, 07, 05);
        Actros.brand = "Mercedez Benz";
        Actros.wheels = "ToyoTires";
        Actros.color = "Gray";
        Actros.description = "A work bus";
        Actros.type = "C";

        Car Explorer = new Car();
        Explorer.model = new DateOnly(2007, 02, 15);
        Explorer.brand = "Ford";
        Explorer.wheels = "Tornel";
        Explorer.color = "Blue";
        Explorer.description = "Familiar SUV";
        Explorer.type = "A";

        Car Taycan = new Car();
        Taycan.model = new DateOnly(2018, 05, 12);
        Taycan.brand = "Tesla";
        Taycan.wheels = "Michelin";
        Taycan.color = "Gray";
        Taycan.description = "The electric Prosrche";
        Taycan.type = "A";

        Car Sentra = new Car();
        Sentra.model = new DateOnly(2012, 03, 01);
        Sentra.brand = "Nissan";
        Sentra.wheels = "Michelin";
        Sentra.color = "Red";
        Sentra.description = "Simple, usable, just a car";
        Sentra.type = "A";

        Car Ft125 = new Car();
        Ft125.model = new DateOnly(2016, 07, 29);
        Ft125.brand = "Italika";
        Ft125.wheels = "Ft125 wheels";
        Ft125.color = "Red";
        Ft125.description = "Excelence bike motorized in México";
        Ft125.type = "B";

        Car Fusion = new Car();
        Fusion.model = new DateOnly(2002, 07, 29);
        Fusion.brand = "Ford";
        Fusion.wheels = "Chidas";
        Fusion.color = "Yellow";
        Fusion.description = "It reaches 250 km in 3 secs!";
        Fusion.type = "A";



        //People instances

        Person person = new Person();
        Person user1 = person.createPerson(001, "Rodrigo", "Santacruz", 21, "Boy");

        Person user2 = person.createPerson(002, "Uriel", "Durán", 19, "Boy");

        Person user3 = person.createPerson(003, "Danna", "Ramos", 19, "Girl");

        Person user4 = person.createPerson(004, "Gustavo", "Fernandez", 92, "Boy");

        Person user5 = person.createPerson(005, "Jesús", "Nolasco", 19, "Boy");

        Person user6 = person.createPerson(006, "Alondra", "GArcía", 30, "Girl");




        //Lincenses instances

        License license = new License();
        License A09 = license.createLicense("A", new DateOnly(2021, 05, 06), new DateOnly(2022, 05, 06));

        License A14 = license.createLicense("A", new DateOnly(2021, 12, 02), new DateOnly(2022, 12, 02));

        License B17 = license.createLicense("B", new DateOnly(2018, 12, 25), new DateOnly(2019, 12, 25));

        License C10 = license.createLicense("B", new DateOnly(2022, 08, 30), new DateOnly(2023, 12, 25));

        //Entering data
        user2.giveCar(Prius);
        user6.giveCar(Actros);
        user6.giveCar(Ft125);
        user6.giveCar(Sentra);
        user6.giveCar(Taycan);
        user1.giveCar(Fusion);

        user1.giveLicense(C10);
        user4.giveLicense(A09);
        user3.giveLicense(A14);
        user2.giveLicense(A09);
        user2.giveLicense(A14);
        user6.giveLicense(C10);


        //Properties
        //User 1
        Console.WriteLine("----------User 1------------");
        person.printUserData(user1);
        user1.printLicenses();
        user1.printCars();
        Console.WriteLine("----------User 2------------");
        person.printUserData(user2);
        user2.printLicenses();
        user2.printCars();
        Console.WriteLine("----------User 3------------");
        person.printUserData(user3);
        user3.printLicenses();
        user4.printCars();
        Console.WriteLine("----------User 4------------");
        person.printUserData(user4);
        user4.printLicenses();
        user4.printCars();
        Console.WriteLine("----------User 5------------");
        person.printUserData(user5);
        user5.printLicenses();
        user5.printCars();
        Console.WriteLine("----------User 6------------");
        person.printUserData(user6);
        user6.printLicenses();
        user6.printCars();

        user6.cancelCar(Ft125);
        user1.cancelCar(Fusion);
        user1.printCars();

    }
}