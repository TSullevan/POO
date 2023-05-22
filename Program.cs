// See https://aka.ms/new-console-template for more information
using POO.Models;

Console.WriteLine("Welcome!");

Stock marketStock = new();

Product soap = new Product("2Kg Soap");
Product rice = new Product("5Kg Rice");
Product bean = new Product("1Kg Bean");

marketStock.AddNewProduct(soap, 5, 40);
marketStock.AddNewProduct(rice, 15, 30);
marketStock.AddNewProduct(bean, 7, 50);

Shop market = new(marketStock);

Console.WriteLine("Shop is Open!");
marketStock.PrintStock();


int zezinAge = 18;
DateTime zezinBirthday = DateTime.Today.AddYears(zezinAge);
Customer zezinCustomer = new("Zézin", zezinBirthday);

List<ShopItem> zezinShoppingList = new()
{
    new ShopItem(soap, 2),
    new ShopItem(rice, 1),
    new ShopItem(bean, 3),
};


zezinCustomer.ShoppingList = zezinShoppingList;

Console.WriteLine("Zezin está comprando!");
market.DoShopping(zezinCustomer);
Console.WriteLine("Zezin fez suas compras!");

Console.WriteLine("Shop is Closed!");
marketStock.PrintStock();

/// Realização de compra (verificar disponibilidade no stock), pagamento e baixa
/// (Ideia para futuro teste de contratação de estagiário, com esse tendo boa noção de POO, faria)
/// 