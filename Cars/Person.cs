using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicle;

namespace Cars
{
    internal class Person
    {
        public DateOnly today = new DateOnly();
        public int keyCode { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public int age { get; set; }
        public string gender { get; set; }
        List<License> licenseSet = new List<License>();
        List<Car> carSet = new List<Car>();
        public bool supiciousOfFraud = false;

        
        public bool firstLicense = true;

        public DateOnly lastLicense { get; set; }

        private int counter = 0;
        private int counterCar = 0;

        public void receiveLicense(License licenseMethod)
        {
            licenseSet.Add(licenseMethod);
        }
        public void receiveCar(Car carMethod)
        {
            carSet.Add(carMethod);
        }
        public bool quitCar(Car cars)
        {
            foreach (Car vehicle in carSet)
            {
                if (cars == vehicle)
                {
                    carSet.Remove(cars);
                    return true;
                }

            }
            return false;
        }
        public int carCounter()
        {
            counterCar = carSet.Count;
            return counterCar;
        }

        public bool validLicense()
        {
            for (int i = 0; i < licenseSet.Count; i++)
            {
                if (today < licenseSet[i].expirationDate)
                {
                    return true;
                }
            }

            return false;
        }

        public bool licenseGet(string type)
        {
            for (int i = 0; i < licenseSet.Count; i++)
            {
                if (licenseSet[i].type == type)
                {

                    if (true == validLicense())
                    {
                        return true;
                    }
                }
            }
            Console.WriteLine("That license is not the good one");
            return false;
        }

        public Person createPerson(int keyCodeParameter, string NameParameter, string surNameParameter, int ageParameter, string genderParameter)
        {
            Person personTuned = new Person();
            personTuned.keyCode = keyCodeParameter;
            personTuned.name = NameParameter;
            personTuned.surname = surNameParameter;
            personTuned.age = ageParameter;
            personTuned.gender = genderParameter;
            return personTuned;
        }

        
        public void printUserData(Person people)
        {
            Console.WriteLine("\n" + "User especifications:" + "\n");
            Console.WriteLine("Key Code: " + people.keyCode + "\n" +
                "Name: " + people.name + "\n" +
                "SurName: " + people.surname + "\n" +
                "Age: " + people.age + "\n" +
                "Gender: " + people.gender + "\n");
        }
        public void printLicenses()
        {
            Console.WriteLine("The follow LICENSES are of " + name + "\n");
            counter = 0;
            if (licenseSet.Count == 0)
            {
                Console.Write("Empty, there aren't any license" + "\n" + "\n");
            }
            foreach (License license in licenseSet)
            {
                counter++;
                Console.WriteLine("License Number: " + counter + "\n" + "Type: " + license.type + "\n" + "Initial Date: " + license.initialDate + "\n" + "Expiration date: " + license.expirationDate + "\n" + "Key code: " + license.keyCode + "\n");
            }
        }

        public void printCars()
        {
            Console.WriteLine("The follow CARS are of " + name + "\n");
            counter = 0;
            if (carSet.Count == 0)
            {
                Console.Write("Empty, there aren't any car" + "\n" + "\n");
            }
            foreach (Car car in carSet)
            {
                counter++;
                Console.WriteLine("Car Number " + counter + "\n" + "Brand: " + car.brand + "\n" + "Year :" + car.model + "\n" + "Wheels: " + car.wheels + "\n" + "Color: " + car.color + "\n" + "Car type: " + car.type + "\n" + "A brief description: " + car.description + "\n");
            }
        }



        License date = new License();

        public void giveLicense(License license)
        {
            if (age >= 90) 
            {
                Console.WriteLine("\n" + "Old people are a danger to themselfs and others, so we're sorry about t 2" + "\n");
            }
            else
            {
                if (firstLicense == true)
                {
                    receiveLicense(license);
                    license.keyCode = keyCode; 
                    firstLicense = false;
                    lastLicense = license.expirationDate;
                }
                else
                {
                    if (lastLicense > date.today) 
                    {
                        Console.WriteLine("\n" + "The other licese is still working, you don't need a new one" + "\n");
                    }
                    else
                    {
                        receiveLicense(license);
                        lastLicense = license.expirationDate;
                    }
                }

            }
        }

        public void giveCar(Car car)
        {
            if (gender == "Girl")
            {
                if (car.color == "Red")
                {
                    receiveCar(car);
                }
                else
                {
                    Console.WriteLine("\n" + "Girls doen't want red cars " + "\n");
                }
            }
            else
            {
                if (car.brand == "Ford" || car.brand == "Toyota")
                {
                    receiveCar(car);
                }
                else
                {
                    Console.WriteLine("\n" + "The boys prefer just Ford and Toyota cars" + "\n");
                }
            }
            if (carCounter() >= 5)
            {
                supiciousOfFraud = true;
            }
        }
        public void cancelCar(Car car)
        {
            if (car.type == "A")
            {
                if (licenseGet("A") == true)
                {
                    if (quitCar(car) == true)
                    {
                        Console.WriteLine("Car " + car.brand + " quitted to " + name + " succesfully!");
                    }
                    else
                    {
                        Console.WriteLine("\n" + "------- Function error: Car " + car.brand + " didn't found on " + name + " to quit :( -----------" + "\n");
                    }
                }
                else
                {
                    Console.WriteLine("\n" + "-------- Function error: You cannot cancel " + car.brand + " without a valid license :( ------" + "\n");
                }
            }
            else if (car.type == "B")
            {
                if (licenseGet("B") == true)
                {
                    if (quitCar(car) == true)
                    {
                        Console.WriteLine("\n" + "Car " + car.brand + " quitted to " + name + " succesfully!" + "\n");
                    }
                    else
                    {
                        Console.WriteLine("\n" + "------ Function error: Car" + car.brand + "didn't found on " + name + " to quit :( -------" + "\n");
                    }
                }
                else
                {
                    Console.WriteLine("\n" + "-------- Function error: You cannot cancel car " + car.brand + " without a valid license :( ----------" + "\n");
                }
            }

            else if (car.type == "C")
            {
                if (licenseGet("C") == true)
                {
                    if (quitCar(car) == true)
                    {
                        Console.WriteLine("\n" + "Car " + car.brand + " quitted to " + name + " success!" + "\n");
                    }
                    else
                    {
                        Console.WriteLine("\n" + "------ Car" + car.brand + "didn't found on " + name + " to quit " + "\n");
                    }
                }
                else
                {
                    Console.WriteLine("\n" + " You can't cancel car " + car.brand + " without a valid license " + "\n");
                }
            }
            else
            {
                Console.WriteLine("\n" + " You don't even have that car " + "\n");
            }



        }

    }
}