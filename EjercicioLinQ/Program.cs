using System;


List<int> listEnteros = new List<int>();

for (int i = 0; i < 100; i++)
    listEnteros.Add(i);

Console.WriteLine("Mostrando con Query syntax");
#region Primera forma 
var divisibleEntre7 =
    from entre in listEnteros
    where (entre % 7) == 0
    select entre;

foreach (int i in divisibleEntre7)
    Console.WriteLine(i);
Console.WriteLine();
var esPar =
    from par in divisibleEntre7
    where (par % 2) == 0
    select par;
Console.WriteLine();
foreach (int i in esPar)
    Console.WriteLine(i);
Console.WriteLine();
var esInPar =
    from inpar in divisibleEntre7
    where (inpar % 2) != 0
    select inpar;

foreach (int i in esInPar)
    Console.WriteLine(i);

#endregion

#region Segunda forma 
Console.WriteLine("Mostrando con Method syntax");
var divisibleEntreSiete = listEnteros.Where(x => x % 7 == 0);

var esParSiete = divisibleEntre7.Where(x => x % 2 == 0);

var esImparSiete = divisibleEntre7.Where(x => x % 2 != 0);

foreach (int i in divisibleEntreSiete) Console.WriteLine(i);
Console.WriteLine();
foreach (int i in esParSiete) Console.WriteLine(i);
Console.WriteLine();
foreach (int i in esImparSiete) Console.WriteLine(i);
#endregion