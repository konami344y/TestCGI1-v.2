namespace TestCGI1_v._2
{
    namespace testies1_cgi
    {
        class Program
        {
            static List<Order> ordrar = new List<Order>();

            //instruktioner för moi:
            //1. Skapa alla relevanta klasser (Artikel, OrderRad, Order)
            //2. Skapa en lista av Orderklassen
            //3. Skapa tre olika orderobjekt och lägger till dem i listan
            //4. Skapa en sökning efter valfri artikel mellan 1-3
            //5. Skapa en lista för att spara alla träffar
            //6. Loopa igenom alla orderrader och lägger till dem i listan om de innehåller sökordet
            //7. Loopa igenom listan och skriver ut alla träffar
            //8. Loopa igenom listan och summerar alla ordervärden
            //allt annat är strössel (validering, felhantering, etc)
            static void Main(string[] args)
            {
                Order order1 = new Order("Kund1");
                order1.LäggTillOrderRad(new OrderRad(1, 2, new Artikel(1, 100, "Artikelnummer 1")));
                order1.LäggTillOrderRad(new OrderRad(2, 3, new Artikel(3, 200, "Artikelnummer 2")));
                ordrar.Add(order1);

                Order order2 = new Order("Kund2");
                order2.LäggTillOrderRad(new OrderRad(1, 2, new Artikel(1, 25, "Artikelnummer 3")));
                order2.LäggTillOrderRad(new OrderRad(2, 3, new Artikel(2, 299, "Artikelnummer 2")));
                ordrar.Add(order2);

                Order order3 = new Order("Kund3");
                order3.LäggTillOrderRad(new OrderRad(1, 2, new Artikel(3, 87, "Artikelnummer 1")));
                order3.LäggTillOrderRad(new OrderRad(2, 3, new Artikel(2, 200, "Artikenummer 3")));
                ordrar.Add(order3);

                Console.WriteLine("Välkommen!");
                Console.WriteLine("");
                Console.WriteLine("Skriv in en siffra mellan 1-3");
                int number;
                string input = Console.ReadLine();
                if (!int.TryParse(input, out number) || number < 1 || number > 3)
                {
                    Console.WriteLine("Felaktig inmatning. Skriv in en siffra mellan 1-3.");
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("Du skrev: " + number);
                }
                Console.WriteLine("");

                List<OrderRad> resultat = new List<OrderRad>();
                foreach (Order order in ordrar)
                {
                    foreach (OrderRad orderRad in order.OrderRad)
                    {
                        if (orderRad.Artikel.Namn.Contains(input))
                        {
                            resultat.Add(orderRad);
                        }


                    }
                }
                Console.WriteLine($"Totalt antal träffar för sökresultatet: {resultat.Count}");
                Console.WriteLine("");
                decimal totalSum = 0;
                Console.WriteLine("Övrig information:");
                foreach (OrderRad orderRad in resultat)
                {
                    if (orderRad.Artikel != null && orderRad.Order != null)
                    {
                        Console.WriteLine($"Utvald Artikel: {orderRad.Artikel.Namn}, Order: {orderRad.Order.OrderNummer}, Kund: {orderRad.Order.KundNamn}, Orderrad: {orderRad.RadNummer}, Styckpris: {orderRad.Artikel.StyckPris}, Antal: {orderRad.Antal}, Summa pris: {orderRad.TotalPris}");
                        totalSum += orderRad.TotalPris;
                    }
                    else
                    {
                        Console.WriteLine("Saknar ref till artikel eller order.");
                    }
                }
                Console.WriteLine("");
                Console.WriteLine($"Totalsumman/sammanlagda priset för tillgänlig artikel: {totalSum}");




            }
        }
    }
}