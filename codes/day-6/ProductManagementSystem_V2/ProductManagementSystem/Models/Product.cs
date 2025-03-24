namespace ProductManagementSystem.Models
{
    public class Product : IComparable<Product>
    {
        public string Id { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal Price { get; set; }

        public int CompareTo(Product? other)
        {
            if (other == null) return 1;
            if (other == this) return 0;
            return this.Id.CompareTo(other.Id);
        }
        public override int GetHashCode()
        {
            const int prime = 31;
            int hash = this.Id.GetHashCode() * prime;
            return hash;
        }
        public override bool Equals(object? obj)
        {
            if (obj == null) return false;
            if (obj is not Product) return false;
            else
            {
                Product other = (Product)obj;
                if (!this.Id.Equals(other.Id)) return false;
                if (!this.Name.Equals(other.Name)) return false;

                return true;
            }
        }
        public override string ToString()
        {
            return $"Id={Id}, Name={Name}, Price={Price}, Description={Description}";
        }
    }
}
