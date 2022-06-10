namespace DesignPatterns.Prototype
{
    public class Person
    {
        public int Age { get; set; }
        public DateTime BirthDate { get; set; }
        public string Name { get; set; }
        public IdInfo IdInfo { get; set; }
        
        public Person ShallowCopy()
        {
            return (Person)this.MemberwiseClone();
        }

        public Person DeepCopy()
        {
            Person clone = (Person)this.MemberwiseClone();
            clone.Name = String.Copy(Name);
            clone.IdInfo = new IdInfo(IdInfo.IdNumber);

            return clone;
        }
    }

    public class IdInfo
    {
        public int IdNumber { get; set; }

        public IdInfo(int idNumber)
        {
            IdNumber = idNumber;
        }
    }
}
