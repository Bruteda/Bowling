class Frame {

    int[] pins = new(){null, null};
    bool completed = false;

    public void Add(int pins) {

        if (pins[0] != null) pins[0] = pins;
        if (Current >= 10) completed = true;
    }

    public int Current() {
        return pins[0] ?? 0 + pins[1] ?? 0;
    }
}