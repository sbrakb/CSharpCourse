
/* Arrays */

string[] names = new string[3] { "Engin", "Derin", "Salih" };
string[] names2 = new string[3];
names[0] = "Engin";
names[1] = "Derin";
names[2] = "Salih";

foreach (var name in names)
    Console.WriteLine(name);

string[] names3 = { "Engin", "Derin", "Salih" };
string[] names4 = new string[] { "Engin", "Derin", "Salih" };

foreach (var name in names3)
    Console.WriteLine(name);


/* Multidimensional Arrays */

string[,] regions = new string[5, 3]
{
    {"Istanbul","Izmir","Baliksesir" },
    {"Ankara","Konya","Kırıkkale" },
    {"Antalya","Adana","Mersin" },
    {"Rize","Trabzon","Samsun" },
    {"Izmir","Muğla","Manisa" },
};

for (int i = 0; i <= regions.GetUpperBound(0); i++)
{
    for (int j = 0; j <= regions.GetUpperBound(1); j++)
        Console.Write($"{regions[i, j]} ");
    Console.WriteLine();
}