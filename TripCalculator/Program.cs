/*
 *Name: Adrian Aguero
 *Course: CSCI 1250, Section 001
 *Asssignment: Lab 04, Group Trip Calculator
 *Date: October 11, 2026
 *Description: Calculates the fuel, food, and work hours behind one group road trip.
*/

// This Calculates the fuel cost
Console.WriteLine("=== Part 1: Road Trip ===");
Console.WriteLine("");
Console.Write("How many miles is the trip? ");
int totalMiles = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("");

Console.Write("How many miles do you get per gallon? ");
double milesPerGallon = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("");

Console.Write("What is the price per gallon? ");
double pricePerGallon = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("");

double gallonsNeeded = totalMiles / milesPerGallon;

double fuelCost = gallonsNeeded * pricePerGallon;

Console.WriteLine("Gallons needed; " + gallonsNeeded.ToString("F2"));
Console.WriteLine("");
Console.WriteLine("Fuel cost: " + fuelCost.ToString("C"));
Console.WriteLine("");


// This calculates the pizza cost
Console.WriteLine("=== Part 2: Pizza Party ===");
Console.WriteLine("");


const double pizzaslices = 8.00;

Console.Write("How many people are coming? ");
int people = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("");

Console.Write("How many pizzas will you need? ");
int pizza = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("");

Console.Write("What is the cost per pizza? ");
double pricePerPizza = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("");

double totalSlices = pizzaslices * pizza;

double slicesperPerson = totalSlices / people;

double TotalPizzaCost = pizza * pricePerPizza;

Console.WriteLine("Total slices: " + totalSlices.ToString());
Console.WriteLine("");

Console.WriteLine("Slices per person: " + slicesperPerson.ToString("F1"));
Console.WriteLine("");

Console.WriteLine("Pizza cost: " + TotalPizzaCost.ToString("C"));Console.WriteLine("");


//This calculates the money you have
Console.WriteLine("=== Part 3: Paycheck ===");
Console.WriteLine("");


const double taxrate = .18; 


Console.Write("How many hours did you work this week? ");
double hoursWorked = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("");

Console.Write("How much do you get paid per hour? ");
double wages = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("");

double grosspay = hoursWorked * wages;
double taxed = grosspay * taxrate;
double takehome = grosspay - taxed;

Console.WriteLine("Gross pay: " + grosspay.ToString("C"));
Console.WriteLine("");

Console.WriteLine("Tax withheld: " + taxed.ToString("C"));
Console.WriteLine("");

Console.WriteLine("Take home pay: " + takehome.ToString("C"));
Console.WriteLine("");

//This gives the totals for all previous parts
Console.WriteLine("=== Part 4: The Whole Trip ===");
Console.WriteLine("");

double triptotal = fuelCost + TotalPizzaCost;
double costperperson = triptotal / people;
double takeHperH = takehome / hoursWorked;
double hoursMwork = costperperson / takeHperH;

Console.WriteLine("TripTotal " + triptotal.ToString("C"));
Console.WriteLine("");

Console.WriteLine("Cost per person: " + costperperson.ToString("C"));
Console.WriteLine("");

Console.WriteLine("Take home pay per hour: " + takeHperH.ToString("C"));
Console.WriteLine("");

Console.WriteLine("Hours you must work to cover your share: " + hoursMwork.ToString("F2"));