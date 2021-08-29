namespace Анализ_ежедневной_рыночной_цены_криптовалюты
{
    class SpecificData
    {
        public object X { get; private set; }
        public object Y { get; private set; }

        public SpecificData(object x, object y)
        {
            this.X = x;
            this.Y = y;
        }
    }
}
