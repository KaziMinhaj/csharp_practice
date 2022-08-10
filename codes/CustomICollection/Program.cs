/*
 * Author : Kazi M Minhajul H.
 * IEnumerable interface practic 
 */

using CustomICollection;


Cat[] cats = new Cat[3];
Cat cat1 = new Cat { Name = "Bell", Color = "Black" };
Cat cat2 = new Cat { Name = "Sen", Color = "White" };

cats[0] = cat1;
cats[1] = cat2;

Animal animal = new Animal(cats);

Cat cat3 = new Cat { Name = "Ben", Color = "Green" };
animal.Add(cat3);

foreach (Cat item in animal)
{
    Console.WriteLine(item.Name);
}