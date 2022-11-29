class Frame
{
    public int? firstRoll;

    public int? secondRoll;

    public bool completed = false;

    public bool Add(int pins)
    {
        if (this.firstRoll == null)
            this.firstRoll = pins;
        else
        {
            if (firstRoll + pins >= 10) this.secondRoll = 10;
            else this.secondRoll = pins;
            this.completed = true;
        }

        if (Current() >= 10 || this.secondRoll != null)
        {
            this.completed = true;
        }
        return this.completed;
    }

    public int Current()
    {
        return (this.firstRoll ?? 0) + (this.secondRoll ?? 0);
    }

    public int BonusRolls() {
        
        if (Current() == 10 && secondRoll == null) return 2;
        else if (Current() == 10) return 1;
        else return 0;
    }
}
