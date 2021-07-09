using InitOnlyProperties;
using System;

Person p = new() { FirstName = "Lucas", LastName = "França" };

// cannot change property value after initialization
//p.LastName = "Pyaia França";

Console.WriteLine($"{p.FirstName} {p.LastName}");