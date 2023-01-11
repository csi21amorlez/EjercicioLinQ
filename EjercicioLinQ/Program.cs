using System;

List<int> listEnteros = new List<int>();

for (int i = 0; i < 100; i++)
    if (i % 7 == 0)
        listEnteros.Add(i);


#region Query syntax
Console.WriteLine("\n Mostrando con Query syntax");

Console.WriteLine();
var esPar =
    from par in listEnteros
    where (par % 2) == 0
    select par;

var esInPar =
    from inpar in listEnteros
    where (inpar % 2) != 0
    select inpar;

foreach (int i in listEnteros) Console.WriteLine(i);
Console.WriteLine();
foreach (int i in esPar) Console.WriteLine(i);
Console.WriteLine();
foreach (int i in esInPar) Console.WriteLine(i);

#endregion

#region Method syntax
Console.WriteLine("\n Mostrando con Method syntax");


var esParSiete = listEnteros.Where(x => x % 2 == 0);

var esImparSiete = listEnteros.Where(x => x % 2 != 0);


foreach (int i in listEnteros) Console.WriteLine(i);
Console.WriteLine();
foreach (int i in esParSiete) Console.WriteLine(i);
Console.WriteLine();
foreach (int i in esImparSiete) Console.WriteLine(i);
#endregion