/*
* Name: La'Shaye Etheridge
* Course: CSCI 1250, Section 201
* Assignment: Lab 02, Trip Calculator
* Date: September 22, 2026
* Description: Calculates the fuel, food, and work hours behind one road trip.
*/

using System.Data;

Console.WriteLine("=== Part 1: Road Trip ===");

Console.Write("How many miles will this trip take?");
int tripMiles = Convert.ToInt32(Console.ReadLine());

Console.Write("How many miles per gallon?");
Double milesGallon = Convert.ToDouble(Console.ReadLine());

Console.Write("What's the price per gallon?");
Decimal priceGallon = Convert.ToDecimal(Console.ReadLine());

Double gallonsNeeded = 0;
gallonsNeeded = tripMiles / milesGallon;
Decimal fuelCost = 0;
fuelCost = (decimal)gallonsNeeded * priceGallon;

Console.WriteLine("Round Trip Miles: " + tripMiles);
Console.WriteLine("Miles per gallon: " + milesGallon);
Console.WriteLine("Price per gallon: " + priceGallon);
Console.WriteLine("");
Console.WriteLine("Gallons needed: " + gallonsNeeded.ToString("F2"));
Console.WriteLine("Fuel cost: " + fuelCost.ToString("C"));
Console.WriteLine(""); // \n was breaking fuelCost, so I started writing this instead.

Console.WriteLine("=== Part 2: Pizza Party ===");

Console.WriteLine("How many people are attending?");
int attending = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("How many pizzas?");
int pizza = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Price per pizza?");
Decimal pizzaPrice = Convert.ToDecimal(Console.ReadLine());


const int pizzaSlices = 8;
int totalSlices = 0;
totalSlices = pizza * pizzaSlices;
Double slicesPerPerson = 0;
slicesPerPerson = totalSlices / attending;
Decimal pizzaCost = 0;
pizzaCost = pizza * pizzaPrice;

Console.WriteLine("How many people are going: " + attending);
Console.WriteLine("How many pizzas: " + pizza);
Console.WriteLine("Price per pizza:" + pizzaPrice);
Console.WriteLine("");
Console.WriteLine("Total slices: " + totalSlices);
Console.WriteLine("Slices per person: " + slicesPerPerson.ToString("F1"));
Console.WriteLine("Pizza cost: " + pizzaCost.ToString("C"));
Console.WriteLine("");

Console.WriteLine("=== Part 3: Paycheck ===");

Console.WriteLine("How many hours have you worked this week?");
int hoursWorked = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Hourly Rate?");
decimal hourlyRate = Convert.ToDecimal(Console.ReadLine());
const Decimal taxRate = 0.18m;

decimal grossPay = 0;
grossPay = hoursWorked * hourlyRate;
decimal taxWithhlend = grossPay * taxRate;
decimal homePay = grossPay - taxWithhlend;

Console.WriteLine("Hours worked this week: " + hoursWorked);
Console.WriteLine("Hourly rate: " + hourlyRate);
Console.WriteLine("");
Console.WriteLine("Gross pay: " + grossPay);
Console.WriteLine("Tax withhlend: " + taxWithhlend.ToString("C"));
Console.WriteLine("Take home pay: " + homePay.ToString("C"));
Console.WriteLine("");

Console.WriteLine("=== Part 4: The Whole Trip ===");

Decimal tripTotal = fuelCost + pizzaCost;
Decimal costPerPerson = tripTotal / attending;
Decimal homePayHourly = homePay / hoursWorked;
Decimal hoursRequired = costPerPerson / homePayHourly;

Console.WriteLine("Trip Total: " + tripTotal.ToString("C"));
Console.WriteLine("Cost per person: " + costPerPerson.ToString("C"));
Console.WriteLine("Take home pay per hour: " + homePayHourly.ToString("C"));
Console.WriteLine("Hoursyou much work to cover your share: " + hoursRequired.ToString("F2"));