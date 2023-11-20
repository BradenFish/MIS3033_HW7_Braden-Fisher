namespace MIS3033_HW7_Braden_Fisher.Models
{
    public class Order
    {
        public string ID { get; set; }
        public int nCogs { get; set; }
        public int nGears { get; set; }
        public double subtotal { get; set; }
        public int level { get; set; }

        public double CalSubtotal()
        {
            this.subtotal = 100 * nCogs + 200 * nGears;
            return this.subtotal;
        }

        public int CalSubtotallevel()
        {
            if (this.subtotal > 1000)
            {
                level = 1;
            }
            else if (this.subtotal >= 5000)
            {
                level = 2;
            }
            else
            {
                level = 3;
            }
            return level;
        }
    }
}
