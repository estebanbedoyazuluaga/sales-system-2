namespace sales_system
{
    internal class Seller
    {
        private string Name;
        private byte Age;

        public Seller(string Name, byte Age)
        {
            this.Name = Name;
            this.Age = Age;
        }

        public string GetName()
        {
            return this.Name;
        }
        public void SetName(string Name)
        {
            this.Name = Name;
        }
        public byte GetAge()
        {
            return this.Age;
        }
        public void SetAge(byte Age)
        {
            this.Age = Age;
        }
    }
}