namespace TestCGI1_v._2
{


    public class Order
    {
        public int OrderRäknare = 1;
        public string KundNamn { get; set; }

        public int OrderNummer { get; set; }
        public List<OrderRad> OrderRad { get; set; }
       



        public Order(string kundNamn)
        {
            OrderNummer = OrderRäknare++;
            KundNamn = kundNamn;
            OrderRad = new List<OrderRad>();

        }

        //Skapar metoden LäggTillOrderRad, tar orderRad som parameter,
        //sätter orderRad.Order till "this" (Varje orderRad objekt blir kopplad till en Order)
        //och sedan lägger till orderRad i listan OrderRad.
        public void LäggTillOrderRad(OrderRad orderRad)
        {
            orderRad.Order = this;
            OrderRad.Add(orderRad);
        }
    }

}
