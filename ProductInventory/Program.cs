using System;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

// README.md를 읽고 아래에 코드를 작성하세요.


Console.WriteLine("코드를 작성하세요.");
Product[] product = new Product[3]
{
    new() { Name = "노트북", Price = 1500000, Stock = 5 },
    new() { Name = "마우스", Price = 35000, Stock = 20 },
    new() { Name = "키보드", Price = 89000, Stock = 15 }
};

for (int i = 0; i <= product.Length-1; i++)
{
    product[i].ShowInfo();
}
Console.WriteLine();
Console.WriteLine("====거래====");
product[0].Sell(2);
product[1].Sell(5);
product[2].Sell(20);
product[2].AddStock(10);

Console.WriteLine();
Console.WriteLine("====최종 상품 목록====");
for (int i = 0; i <= product.Length - 1; i++)
{
    product[i].ShowInfo();
}

Console.WriteLine();
Console.WriteLine("====총 재고 가치====");

Console.WriteLine(product[0].ToString());
Console.WriteLine(product[1].ToString());
Console.WriteLine(product[2].ToString());

Console.WriteLine();
Console.WriteLine("========");
int totalsum = 0;
for (int i = 0; i < product.Length; i++)
{
    totalsum += product[i].GetTotalValue();
}
Console.WriteLine($"전체 재고 총 가치:{totalsum} ");





class Product
{
    public string Name;
    public int Price;
    public int Stock;
    public int sum = 0;
    

    public void AddStock(int quantity)
    {
        Stock += quantity;
        Console.WriteLine($"{Name} {quantity}재고 추가. 현재재고: {Stock}개");
    }

    public void Sell(int quantity)
    {
        Stock -= quantity;
        if (Stock < 0)
        {
            Console.WriteLine($"{Name} {quantity}판매 실패. 재고가 부족합니다");
            Stock += quantity;
        }
        else
        {
            Console.WriteLine($"{Name} {quantity}판매 완료. 남은재고: {Stock}개");
        }
    }

    public  int GetTotalValue()
      { 
        return sum = Price * Stock;
      }

    public void ShowInfo()
    {
        Console.WriteLine($"[{Name}] {Price}원 (재고: {Stock})");
    }

    public override string ToString()
    {
        return $"[{Name}] {Price}원 (재고:{Stock})";
    }

 

}
