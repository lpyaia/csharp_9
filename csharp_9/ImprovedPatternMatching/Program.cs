using ImprovedPatternMatching;
using System;

var deliveryTruck = new DeliveryTruck { GrossWeightClass = 5500 };
var deliveryTruck2 = new DeliveryTruck { GrossWeightClass = 1000 };
var car = new Car();
var motorcycle = new Motorcycle();
var bus = new Bus { MaxPeopleCapacity = 50 };
var bus2 = new Bus { MaxPeopleCapacity = 20 };
var bus3 = new Bus { MaxPeopleCapacity = 31 };

Console.WriteLine(CalculateToll(deliveryTruck));
Console.WriteLine(CalculateToll(deliveryTruck2));
Console.WriteLine(CalculateToll(car));
Console.WriteLine(CalculateToll(motorcycle));
Console.WriteLine(CalculateToll(bus));
Console.WriteLine(CalculateToll(bus2));
Console.WriteLine(CalculateToll(bus3));

static decimal CalculateToll(object vehicle)
{
    return vehicle switch
    {
        DeliveryTruck t when t.GrossWeightClass > 5000 => 15m,
        DeliveryTruck t when t.GrossWeightClass < 5000 => 8m,
        Car => 5m,
        Motorcycle => 2,
        Bus b when b.MaxPeopleCapacity >= 45 => 12m,
        Bus b when b.MaxPeopleCapacity < 30 => 7m,
        Bus b when b.MaxPeopleCapacity < 45 && b.MaxPeopleCapacity > 30 => 9m,
        _ => throw new ArgumentException("Not a known vehicle type", nameof(vehicle))
    };
}