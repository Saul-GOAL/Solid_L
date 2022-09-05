namespace Solid_L
{
    class Program
    { 
        public void Main()
        {

            LocalSale sale = new LocalSale(100, "Sauru", 0.16m);
            sale.CalculateTaxes();
            sale.Generate();

            AbstractSale sale2 = new ForeignSale(100, "Sauru");
            sale.Generate();

            //T t = new S1();
            //Console.WriteLine(t.GetName());
            //t = new S2();
            //Console.WriteLine(t.GetName());

        }

        public abstract class AbstractSale
        {
            protected decimal amount;
            protected string customer;
            /*protected decimal taxes;  */     // <- Can generate a problem, for example, in a sale without taxes
            public abstract void Generate();
            //public abstract void CalculateTaxes();
        }

        public abstract class SaleWithTaxes : AbstractSale
        {
            protected decimal taxes;
            public abstract void CalculateTaxes();
        }

        public class ForeignSale : SaleWithTaxes
        {
            public ForeignSale(decimal amount, string customer)
            {
                this.amount = amount;
                this.customer = customer;
            }
            public override void Generate()
            {
                Console.WriteLine("The sale is generated");
            }
        }

        public class LocalSale : SaleWithTaxes 
        {
            public LocalSale(decimal amount, string customer, decimal taxes)
            {
                this.amount = amount;
                this.customer = customer;
                this.taxes = taxes;
            }
            public override void Generate()
            {
                Console.WriteLine("The sale is generated");
            }
            public override void CalculateTaxes()
            {
                Console.WriteLine("Taxes are calculated");
            }

        }


        //public abstract class T
        //{
        //    public abstract string GetName();
        //}

        //public class S1 : T
        //{
        //    public override string GetName()
        //    {
        //        return "S1";
        //    }
        //}

        //public class S2 : T
        //{
        //    public override string GetName()
        //    {
        //        return "S2";
        //    }
        //}
    }
}