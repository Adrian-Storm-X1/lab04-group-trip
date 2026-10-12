/*
 *Name: Adrian Aguero
 *Course: CSCI 1250, Section 001
 *Asssignment: Lab 04, Group Trip Calculator
 *Date: October 11, 2026
 *Description: Calculates the fuel, food, and work hours behind one group road trip.
*/

//constants
using System.ComponentModel;
using System.Diagnostics;

const double pizzaslices = 8.00;
const double taxRate = .18; 


// This Calculates the fuel and food cost
Console.WriteLine("=== Part 1: The Trip ===");
Console.WriteLine("");
Console.Write("How many miles is the trip? ");
int Miles = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("");

Console.Write("How many miles do you get per gallon? ");
double milesPerGallon = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("");

Console.Write("What is the price per gallon? ");
double pricePerGallon = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("");

double fuel = FuelCost(Miles, milesPerGallon, pricePerGallon);
fuel = Math.Round(fuel, 2);
Console.WriteLine("Fuel cost: " + fuel);
Console.WriteLine("");
//Code written above specifically deals in calculating fuel
//Code written below specifically deals in calculating pizza cost

Console.Write("How many pizzas will you need? ");
int pizza = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("");

Console.Write("What is the cost per pizza? ");
double pricePerPizza = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("");

double totalPizzaCost = pizza * pricePerPizza;

Console.WriteLine("Pizza Cost: " + totalPizzaCost);
Console.WriteLine("");
//Code written below calculates the trip total

double tripTotal = fuel + totalPizzaCost;
Console.WriteLine("Trip Total: " + tripTotal);

//This calculates the cost per person 
Console.WriteLine("=== Part 2: The Group ===");
Console.WriteLine("");

string[] names = {"Ada", "Grace", "Alan", "Katherine"};
double[] hoursWorked = {22, 15, 30, 18};
double[] hourlyRates = {13.50, 16.00, 11.20, 14.80};

//this determines the number of people going
int people = names.Length;

Console.WriteLine("People going: " + people);
Console.WriteLine("");

//This determines how many slices each person gets

double slicesEach = pizzaslices * pizzaslices / names.Length;

Console.WriteLine("Slices each: " + slicesEach);
Console.WriteLine("");

//This determines the total cost per person

double costPerPerson = tripTotal / names.Length;
costPerPerson = Math.Round(costPerPerson, 2);

Console.WriteLine("Cost per person: " + costPerPerson);
Console.WriteLine("");

//This calculates who works how long and what they owe
Console.WriteLine("=== Part 3: Who Works How Long ===");
Console.WriteLine("");

double totalHours= 0;
double totalPay = 0;
for (int i = 0; i < names.Length; i++)
{
    double pay = TakeHomePay(hoursWorked[i], hourlyRates[i], taxRate);
    double takeHomePerHour = pay / hoursWorked[i];
    totalHours += hoursWorked[i];
    double mustWork = HoursToCover(costPerPerson, takeHomePerHour);
    totalPay+= takeHomePerHour;
    Console.WriteLine(names[i] + ": takes home " + pay.ToString("C") + " for " + hoursWorked[i] + " hours, " + takeHomePerHour.ToString("C") + " per hour, must work " + mustWork + " hours ");
    Console.WriteLine("");
}



static double FuelCost(double miles, double milesPerGallon, double pricePerGallon)
{
    double gallons = miles / milesPerGallon;
    return gallons * pricePerGallon;
}

static double TakeHomePay(double hours, double hourlyRate, double taxRate)
{
    double wages = hours * hourlyRate; 
    double taxed = wages * taxRate;
    double pay = wages - taxed;
    return pay;

}

static double HoursToCover(double costPerPerson, double takeHomePerHour)
{
    double mustWork = costPerPerson / takeHomePerHour;
    return mustWork = Math.Round(mustWork, 2);
}


