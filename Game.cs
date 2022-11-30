class Game
{
    List<Frame> frames = new List<Frame>();

    int currentIndex = 0;

    Frame currentFrame;

    public Game()
    {
        for (int i = 0; i < 10; i++)
        {
            this.frames.Add(new Frame());
        }
        this.currentFrame = this.frames[0];
    }

    public int NextFrame()
    {
        if (this.currentIndex < this.frames.Count) this.currentIndex++;

        if (
            this.currentIndex == 9 &&
            this.currentFrame.GetBonusType() != BonusType.NONE
        )
        {
            this.frames.Add(new Frame());
        }

        if (this.currentIndex < this.frames.Count)
            this.currentFrame = this.frames[this.currentIndex];

        return currentIndex;
    }

    public bool Roll(int pins)
    {


        if (this.currentIndex < this.frames.Count)
        {   
            Console.WriteLine("Roll() frame: " + (this.currentIndex + 1) + ", pins: " + pins);
        
            if (this.currentFrame.Add(pins))
                NextFrame();
            return true;
        }
        else
        {
            Console.WriteLine("Game Over");
            return false;
        }
    }

    public int Score()
    {
        int total = 0;

        for (int i = 0; i < this.frames.Count; i++)
        {
            Frame frame = this.frames[i];
            total += frame.Current();

            BonusType bonusType = frame.GetBonusType();

            switch (bonusType)
            {
                case BonusType.SPARE:
                    total += GetBonusPoints(i, 1);
                    break;
                case BonusType.STRIKE:
                    total += GetBonusPoints(i, 2);

                    break;
                default:
                    break;
            }
        }

        return total;
    }

    public int GetBonusPoints(int index, int bonusRolls)
    {
        int i = index;
        int found = 0;
        int total = 0;

        while (found < bonusRolls)
        {
            try
            {
                Frame current = this.frames[i + 1];

                if (current.firstRoll != null)
                {
                    total += (int) current.firstRoll;
                    found++;
                }

                if (found == bonusRolls) break;

                if (current.secondRoll != null)
                {
                    total += (int) current.secondRoll;
                    found++;
                }

                i++;
            }
            catch (System.Exception)
            {
                found = bonusRolls;
            }
        }

        return total;
    }
}
