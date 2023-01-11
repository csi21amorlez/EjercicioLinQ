using System;


List<int> listEnteros = new List<int>();

for (int i = 0; i < 100; i++)
    listEnteros.Add(i);

var divisibleEntre7 =
    from entre in listEnteros
    where (entre % 7) == 0
    select entre;

foreach (int i in divisibleEntre7)
    Console.WriteLine(i);

var esPar = 
    from par in divisibleEntre7
    where (par % 2) == 0
    select par;

foreach(int i in esPar)
    Console.WriteLine(i);

var esInPar =
    from inpar in divisibleEntre7
    where (inpar % 2) != 0
    select inpar;

foreach(int i in esInPar)
    Console.WriteLine(i);