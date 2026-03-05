using System;
InventoryItem[] Item = new InventoryItem[5];
Item[0].Name = "검";
Item[0].Weight = 3.5;
Item[0].Price = 1500;
Item[1].Name = "방패";
Item[1].Weight = 5.0;
Item[1].Price = 1200;
Item[2].Name = "포션";
Item[2].Weight = 0.3;
Item[2].Price = 50;
Item[3].Name = "활";
Item[3].Weight = 1.8;
Item[3].Price = 1300;
Item[4].Name = "투구";
Item[4].Weight = 2.0;
Item[4].Price = 800;
Console.WriteLine("=== 인벤토리 목록 ===");
foreach (var item in Item)
{
    Console.WriteLine($"{item.Name}- 무게: {item.Weight}kg, 가격: {item.Price}골드");
}
Console.WriteLine();
Console.WriteLine("=== 인벤토리 통계 ===");
void Result(InventoryItem[] item)
{
    double tempWeight = 0;
    int tempPrice = 0;
    int Priceaverage = 0;
    int RPrice = 0;
    double sWeight = item[0].Price;
    int Rcount = 0;
    int Scount = 0;
    for (int i = 0; i < item.Length; i++)
    {
        tempWeight += item[i].Weight;
        tempPrice += item[i].Price;
        Priceaverage = tempPrice / item.Length;
        if (RPrice < item[i].Price)
        {
            RPrice = item[i].Price;
            Rcount = i;
        }
        else if (sWeight > item[i].Weight)
        {
            sWeight = item[i].Weight;
            Scount = i;
        }
    }
    Console.WriteLine($"전체 무게: {tempWeight:F1}Kg");
    Console.WriteLine($"전체 가격: {tempPrice}골드");
    Console.WriteLine($"평균 가격: {Priceaverage}골드");
    Console.WriteLine($"가장 비싼 아이템: {item[Rcount]}");
    Console.WriteLine($"가장 가벼운 아이템: {item[Scount]}");
}
Result(Item);


