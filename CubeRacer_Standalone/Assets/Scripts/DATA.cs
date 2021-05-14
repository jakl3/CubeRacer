public static class DATA
{
    private static bool INFINITE;
    private static int LIVES;

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
}
