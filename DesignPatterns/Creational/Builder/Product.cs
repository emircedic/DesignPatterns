namespace DesignPatterns.Builder
{
    public class Product
    {
        private List<object> _parts = new List<object>();

        public void Add(string part)
        {
            this._parts.Add(part);
        }

        public string ListParts()
        {
            return $"Product parts: {string.Join(", ", _parts)}\n";
        }
    }
}
