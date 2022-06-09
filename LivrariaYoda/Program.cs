using LivrariaYoda.Enum;
using LivrariaYoda.Model;
using LivrariaYoda.Service;
using System.Globalization;

List<Item> listOfPurchase = new List<Item>();
ProcessDiscount discount = new ProcessDiscount();
ProcessPayament payament = new ProcessPayament(discount);

listOfPurchase.Add(new Item
(
    "God Of War",
    2,
    100.0,
    "Jogo de ação",
    Category.VIDEOGAME,
    MediaType.FISICO
));

listOfPurchase.Add(new Item
(
    "Fofoca",
    1,
    100.0,
    "Revista de fofoca",
    Category.REVISTA,
    MediaType.IMPRESSO //30%
));

listOfPurchase.Add(new Item
(
    "PGR",
    1,
    100.0,
    "Jogo de ação",
    Category.VIDEOGAME,
    MediaType.DIGITAL
));

listOfPurchase.Add(new Item
(
    "Cod",
    4,
    100.0,
    "Jogo de ação",
    Category.VIDEOGAME,
    MediaType.DIGITAL
));

listOfPurchase.Add(new Item
(
    "Codigo Limpo",
    1,
    100.0,
    "Livro de ti",
    Category.LIVRO,
    MediaType.DIGITAL  //15%
));

double totalPayament = payament.CalculatePayament(listOfPurchase);

Console.WriteLine("Total a pagar: " + totalPayament.ToString(CultureInfo.InvariantCulture));