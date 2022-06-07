namespace DesignPatterns.Builder
{
    public interface IBuilder
    {
        void BuildPartA();
        void BuildPartB();
        void BuildPartC();
    }

    public class ConcreteBuilder : IBuilder
    {
        private Product _product = new Product();

        public ConcreteBuilder()
        {
            this.Reset();
        }

        public void Reset()
        {
            _product = new Product();
        }

        public void BuildPartA()
        {
            this._product.Add("PartA");
        }

        public void BuildPartB()
        {
            this._product.Add("PartB");
        }

        public void BuildPartC()
        {
            this._product.Add("PartC");
        }

        public Product GetProduct()
        {
            Product result = this._product;

            this.Reset();

            return result;
        }
    }

    public class ConcreteChainedBuilder
    {
        private Product _product;

        public ConcreteChainedBuilder()
        {
            _product = new Product();
        }

        public ConcreteChainedBuilder BuildPartA()
        {
            this._product.Add("PartA");
            return this;
        }

        public ConcreteChainedBuilder BuildPartB()
        {
            this._product.Add("PartB");
            return this;
        }

        public ConcreteChainedBuilder BuildPartC()
        {
            this._product.Add("PartC");
            return this;
        }

        public Product GetProduct()
        {
            Reset();
            return _product;
        }

        public void Reset()
        {
            _product = new Product();
        }
    }
}
