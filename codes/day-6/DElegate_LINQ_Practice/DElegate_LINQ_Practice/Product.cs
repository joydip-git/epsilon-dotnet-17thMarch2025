namespace DElegate_LINQ_Practice
{
    class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public decimal Price { get; set; }

        public override string ToString()
        {
            return $"Name={Name}, Id={Id}, Price={Price}";
        }
    }
}
