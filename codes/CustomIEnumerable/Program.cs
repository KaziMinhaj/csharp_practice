/*
 * Author : Kazi M Minhajul H.
 * IEnumerable interface practic 
 */

using CustomIEnumerable;

Animal animal = new Animal(new Cat[] { new Cat { Name = "Jord", Color = "White" }, new Cat { Name = "Bell", Color = "Black" } });

foreach (Cat item in animal)
{
    Console.WriteLine(item.Name);
}