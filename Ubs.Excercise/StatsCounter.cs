namespace Ubs.Excercise
{
    class StatsCounter
    {
        public string Word { get; set; }
        public int Count { get; private set; }

        public StatsCounter(string word)
        {
            Word = word;
            Count = 1;
        }
        public void IncrementCount()
        {
            Count = Count+1;
        }

        public override string ToString()
        {
            return string.Format("{0} - {1}", Word, Count);
        }
    }
}