using System;


List<int> listEnteros = new List<int>();

for (int i = 0; i < 100; i++)
    listEnteros.Add(i);

var divisibleEntre7 =
    from entre in listEnteros
    where (entre % 7) == 0
    select entre;

foreach(int i in divisibleEntre7)
    Console.WriteLine(i);