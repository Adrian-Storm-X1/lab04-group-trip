/*
 *Name: Adrian Aguero
 *Course: CSCI 1250, Section 001
 *Asssignment: Lab 04, Group Trip Calculator
 *Date: October 11, 2026
 *Description: Rebuilds the trip calculator with methods and array so it reports on a whole group instead of one person.
*/

//constants
using System.ComponentModel;
using System.Diagnostics;

const double pizzaslices = 8.00;
const double taxRate = .18; 


// This Calculates the fuel and food cost
//these take user input and stores as variables
Console.WriteLine("");
Console.Write("Round trip miles: ");
int Miles = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("");

Console.Write("Miles per gallon: ");
double milesPerGallon = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("");

Console.Write("Price per gallon: ");
double pricePerGallon = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("");

double fuel = FuelCost(Miles, milesPerGallon, pricePerGallon);
fuel = Math.Round(fuel, 2);
Console.Write("How many pizzas: ");
int pizza = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("");

Console.Write("Price per pizza: ");
double pricePerPizza = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("");

Console.WriteLine("=== Part 1: The Trip ===");
Console.WriteLine("");
Console.WriteLine("Fuel cost: " + fuel);
Console.WriteLine("");
//Code written above specifically deals in calculating fuel
//Code written below specifically deals in calculating pizza cost



double totalPizzaCost = pizza * pricePerPizza;

Console.WriteLine("Pizza Cost: " + totalPizzaCost);
Console.WriteLine("");
//Code written below calculates the trip total

double tripTotal = fuel + totalPizzaCost;
Console.WriteLine("Trip Total: " + tripTotal);
Console.WriteLine("");

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

double slicesEach = pizza * pizzaslices / names.Length;

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
double longest = 0;
//this for loop prints how many hours people work how much they make and for how many hours and what they need to work to cover their portion
for (int i = 0; i < names.Length; i++)
{
    double pay = TakeHomePay(hoursWorked[i], hourlyRates[i], taxRate);
    double takeHomePerHour = pay / hoursWorked[i];
    totalHours += hoursWorked[i];
    double mustWork = HoursToCover(costPerPerson, takeHomePerHour);
    totalPay+= pay;
    Console.WriteLine(names[i] + ": takes home " + pay.ToString("C") + " for " + hoursWorked[i] + " hours, " + takeHomePerHour.ToString("C") + " per hour, must work " + mustWork + " hours ");
    Console.WriteLine("");
    longest = Math.Max(longest, mustWork);
}




Console.WriteLine("Total hours worked: " + totalHours);
Console.WriteLine("");
Console.WriteLine("Total take home pay: " + totalPay.ToString("C"));
Console.WriteLine("");
Console.WriteLine("Longest anyone must work: " + longest); 



//method to determine fuel cost
static double FuelCost(double miles, double milesPerGallon, double pricePerGallon)
{
    double gallons = miles / milesPerGallon;
    return gallons * pricePerGallon;
}
//method to determine takehome pay
static double TakeHomePay(double hours, double hourlyRate, double taxRate)
{
    double wages = hours * hourlyRate; 
    double taxed = wages * taxRate;
    double pay = wages - taxed;
    return pay;

}
//method to determine hours to cover 
static double HoursToCover(double costPerPerson, double takeHomePerHour)
{
    double mustWork = costPerPerson / takeHomePerHour;
    return mustWork = Math.Round(mustWork, 2);
}


