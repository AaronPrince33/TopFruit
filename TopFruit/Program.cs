string[] fruitName = new string[5];
int[] salesAmount =  new int[5];

int highestSales = 0, highestSalesPosition = 0;

for (int i = 0; i < fruitName.Length; i++)
{
    Console.Write("Input fruit name: ");
    fruitName[i] = Console.ReadLine();

    Console.Write("Input sales amount: ");
    salesAmount[i] = int.Parse(Console.ReadLine());
}

//finding highest fruit sales amount
for (int i = 0; i < fruitName.Length; i++)
{
    if (salesAmount[i] > highestSales)
    {
        highestSales = salesAmount[i];
        highestSalesPosition = i;
    }
}

Console.WriteLine("-----------------------");
Console.WriteLine($"Highest Sales Amount: {highestSales}");
Console.WriteLine($"Fruit with highest sales amount: {fruitName[highestSalesPosition]}");