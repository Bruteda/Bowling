class Frame {

    int?[] pins = new int?[2]; //(){null, null};
    bool completed = false;

    public bool Add(int pins) {

        Console.WriteLine(pins);
        if (pins != null) pins = pins;
        if (Current() >= 10) completed = true;

        return completed;
    }

    public int Current() {
        return pins[0] ?? 0 + pins[1] ?? 0;
    }
}