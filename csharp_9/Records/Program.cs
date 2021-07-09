using Records;
using System;

Person p = new("Lucas", "França");
Console.WriteLine(p);

// doesn't works
// p.LastName = "Pyaia";

Person p2 = p with { LastName = "Pyaia" };
Console.WriteLine(p2);

Person p3 = new("Lucas", "Pyaia");
Console.WriteLine(p2 == p3);

p = p2;
Console.WriteLine(p);
Console.WriteLine(p == p2);
Console.WriteLine(p.FullName);

var (f, l) = p;
Console.WriteLine($"{f} {l}");

PersonExplicitDescontructor p5 = new("Lucas", "Pyaia");
var (f2, l2, full) = p5;
Console.WriteLine($"{f} {l} - {full}");