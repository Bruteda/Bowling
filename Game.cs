

class Game {

    Frame[] frames;

    int currentIndex = 0;
    Frame currentFrame;

    public Game()
    {


        this.frames = new Frame[10];
        
        for (int i = 0; i < frames.Count(); i++)
        {
            this.frames[i] = new Frame();
        }


        this.currentFrame = this.frames[0];

    }

    public int NextFrame() {

        this.currentIndex ++;
        this.currentFrame = this.frames[this.currentIndex];

        return this.currentIndex;
    }

    public void Roll(int pins) {

        if (this.currentFrame.Add(pins)) NextFrame();


    }

    public int Score() {
        int total = 0;
        
        foreach (Frame frame in this.frames)
        {
            total += frame.Current();
            
        }

        return total;
    }
}