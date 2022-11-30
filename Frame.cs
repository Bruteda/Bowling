class Frame
{

    public int? firstRoll;
    public int? secondRoll;

    public bool completed = false;

    public bool Add(int pins)
    {

        if (this.firstRoll == null)
        {
            this.firstRoll = pins;
            //Console.WriteLine("Add, set first: " + this.firstRoll);
        }
        else
        {
            if (this.firstRoll + pins >= 10){
                this.secondRoll = (10 - this.firstRoll);
                this.completed = true;
                //Console.WriteLine("Add, second sparre: " + this.secondRoll);
                }
            else {
                this.secondRoll = pins;
                this.completed = true;
                
                //Console.WriteLine("Add, second: " + this.secondRoll);
                }
        }

        if (Current() == 10 && secondRoll == null)
        {
            //Console.WriteLine("Add, Strike: ");
                
            this.completed = true;
            
                
        }
  
        return this.completed;
    }

    public int Current()
    {
        return (this.firstRoll ?? 0) + (this.secondRoll ?? 0);
    }



    public int[] PinsAsArray()
    {
        int[] result = new int[2];

        result[0] = this.firstRoll ?? 0;
        result[1] = this.secondRoll ?? 0;

        return result;
    }

    public BonusType GetBonusType()
    {   

        if (Current() == 10 && this.secondRoll == null)
            return BonusType.STRIKE;
        else if (Current() == 10)
            return BonusType.SPARE;
        else
            return BonusType.NONE;
    }
}

public enum BonusType
{
    NONE,
    STRIKE,
    SPARE
}
