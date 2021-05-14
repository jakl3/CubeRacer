public static class DATA
{
    private static bool INFINITE;
    private static int LIVES;
    private static int DIFFICULTY = 1;

    public static bool Infinite 
    {
        get 
        {
            return INFINITE;
        }
        set 
        {
            INFINITE = value;
        }
    }

    public static int Lives
    {
        get
        {
            return LIVES;
        }
        set
        {
            LIVES = value;
        }
    }
    // 0 is easy, 1 is normal, 2 is hard
    public static int Difficulty
    {
        get
        {
            return DIFFICULTY;
        }
        set
        {
            DIFFICULTY = value;
        }
    }
}
