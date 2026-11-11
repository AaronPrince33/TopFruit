string[] fruitName = new string[5];
int[] salesAmount =  new int[5];

int highestSales, highestSalesPosition;

for (int i = 0; i < fruitName.Length; i++)
{
    Console.Write("Input fruit name: ");
    fruitName[i] = Console.ReadLine();

    Console.WriteLine("Input sales amount: ");
    salesAmount[i] = int.Parse(Console.ReadLine());
}