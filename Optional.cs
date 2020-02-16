namespace Roux
{
    public class Optional<T>
    {
        public static Optional<T> Empty
        {
            get
            {
                return new Optional<T>();
            }
        }

        public T value { get; private set; }
        public bool hasValue { get; private set; }

        public Optional()
        {
            hasValue = false;
        }

        public Optional(T value)
        {
            this.value = value;
            hasValue = true;
        }
    }
}