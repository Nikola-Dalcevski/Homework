namespace homeworkClass07
{
    internal class Dog
    {

        public string Name { get; set; }
        public string Race { get; set; }
        public string Color { get; set; }
        public bool isHungry { get; private set; }

        public Dog(string name, string race, string color)
        {
            Name = name;
            Race = race;
            Color = color;
        }

        public string isEating()
        {
            if (isHungry)
            {
                return "The dog is not a hungry";
            }
            else
            {
                isHungry = !isHungry;
                return "The dog has eated";
            }        
        }
  
        public string isPlaying(string toy)
        {
            if (isHungry)
            {
                isHungry = !isHungry;
             
                return $"The dog is playing whit the {toy}";
            }
            else
            {
                return "The dog wont play its hungry";
            }  
        }


        public string isChaseTail()
        {
            if (isHungry)
            {
                isHungry = !isHungry;

                return $"The dog is chasing his tail";
            }
            else
            {
                return "The dog is hungry cant chase";
            }
        }
    }
}