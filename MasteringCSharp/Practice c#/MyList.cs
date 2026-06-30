namespace MasteringCSharp
{
    internal class MyList
    {
        List<int> myNumbers = [1,22,34,21,56,45];
        public void SortedList()
        {
            myNumbers.Sort();
            foreach(int number in myNumbers)
            {
                Console.WriteLine(number);
            }
        }

        public void HasLargeNumber()
        {
            bool hasLargeNumber = myNumbers.Any(x => x > 10);
            if (hasLargeNumber)
            {
                Console.WriteLine("There are large numbers inside this list");
            } else
            {
                Console.WriteLine("No lage numbers found on this list");
            }
        }
    }
}