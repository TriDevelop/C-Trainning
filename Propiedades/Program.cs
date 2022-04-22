namespace Objetos
{

    class Program
    {
        static void Main(string[] args)
        {
            Sale Mysale = new Sale(100, DateTime.Now);
            Mysale.Total = 10;
           // Mysale.Date = DateTime.Now; //no modifica la propiedad porque es Get y no tiene Set
            Console.WriteLine(Mysale.Total);
        }
    }

    class Sale
    {
        private int total;
        private DateTime date;

        public string Date
        {
            get
            {
                return date.ToLongDateString();
            }
        }

        public int Total
        {
            get
            { 
               return total; 
            }
            set
            {
                if (value < 0)
                    value = 0;
                total = value;  
            }
        }

        public Sale(int total, DateTime date)
        {
            this.total = total;
            this.date = date;
        }
    }
}
