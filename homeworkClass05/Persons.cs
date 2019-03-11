namespace homeworkClass05
{
    internal class Persons
    {
        public string[] names = new string[0];
        public int[] ages = new int[0];
        string Oldestname;
         
        public string Oldest()
        {
            int start = 0;
            foreach (var item in ages)
            {
                if(item > start)
                {
                    start = item;
                }
            }

          for(int i = 0; i< ages.Length;i++)
            {
                if(start == ages[i])
                {
                  Oldestname=$"The oldest person is {names[i]} who is {ages[i]} years old";   
                }
            }
            return Oldestname;
        }
    }
}