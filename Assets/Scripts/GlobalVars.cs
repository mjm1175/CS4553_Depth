public static class GlobalVars
{
    // these two MUST be the same size
    // which lane the next enemy/bonus will spawn in
    public static int[] nextLane = {1, 2, 3, 2, 3, 1, 3, 2}; // size 8; maybe this could be random
    // the next enemy/bonus to be spawned (t = trig, c = circle, x = cross, ...)
    public static char[] nextSpawn = {'s', 'c', 'l', 'c', 't', 'x', 't', 'c'};

    public static int lives = 3;

    public static bool shieldOn = false;
    public static bool turningOff = false; // for shield stuffs
    public static float shieldTime = 5f; 
}
