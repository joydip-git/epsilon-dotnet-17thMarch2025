namespace GenericCollectionsApp
{
    class Person
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public override string ToString()
        {
            return $"Name={Name}, Id= {Id}";
        }
        public override bool Equals(object? obj)
        {
            if (obj == null)
                return false;
            else
            {
                if (!(obj is Person))
                    return false;
                else
                {
                    Person other = (Person)obj;
                    if (this == other)
                        return true;
                    else
                    {
                        if (!this.Id.Equals(other.Id))
                            return false;

                        if (!this.Name.Equals(other.Name))
                            return false;

                        return true;
                    }
                }
            }
        }
        public override int GetHashCode()
        {
            const int salt = 32;
            int hash = this.Id.GetHashCode() * salt;
            hash = this.Name.GetHashCode() * hash;
            return hash;
        }
    }
}
