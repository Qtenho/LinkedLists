using LinkedList.Logic;
using System;

Console.WriteLine("*** Linked Lists ***");
Console.WriteLine("*** CARS ***");
var car1 = new Car { brand = "Chevrolet", model = "Onix Turbo", year = "2023", color = "Azul", price = 76820000 };
var car2 = new Car { brand = "Ford", model = "Fiesta Rs", year = "2017", color = "Blanco", price = 72500000 };
var car3 = new Car { brand = "Toyota", model = "Corola", year = "2010", color = "Plateado", price = 58900000 };
var car4 = new Car { brand = "Mazda", model = "CX5", year = "2017", color = "Gris", price = 88900000 };
var car5 = new Car { brand = "Chevrolet", model = "Spark", year = "2010", color = "Blanco", price = 31500000 };
var car6 = new Car { brand = "Ford", model = "Escape", year = "2023", color = "Azul", price = 220000000 };
var car7 = new Car { brand = "Toyota", model = "Hilux", year = "2023", color = "Plateado", price = 238000000 };
var car8 = new Car { brand = "Mazda", model = "3", year = "2010", color = "Azul", price = 36900000 };
var car9 = new Car { brand = "Chevrolet", model = "Colorado", year = "2023", color = "Gris", price = 180000000 };
var car10 = new Car { brand = "Ford", model = "Ranger", year = "2017", color = "Gris", price = 107990000 };
var car11 = new Car { brand = "Toyota", model = "Land Cruiser TXL", year = "2017", color = "Blanco", price = 235000000 };
var car12 = new Car { brand = "Mazda", model = "BT50", year = "2010", color = "Plateado", price = 56000000 };


var cars = new DoubleList<Car>();
cars.Add(car1);
cars.Add(car2);
cars.Add(car3);
cars.Add(car4);
cars.Add(car5);
cars.Add(car6);
cars.Add(car7);
cars.Add(car8);
cars.Add(car9);
cars.Add(car10);
cars.Add(car11);
cars.Add(car12);

Console.WriteLine("Cars List =>");
Console.WriteLine(cars);

Console.WriteLine("Mostrando modelos por Marca =>");
var carsArray = cars.GetBrand("Chevrolet");
foreach (var car in carsArray)
{
    Console.WriteLine(car);
}
