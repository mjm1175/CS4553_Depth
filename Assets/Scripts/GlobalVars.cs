public static class GlobalVars
{
    // these two MUST be the same size
    // which lane the next enemy/bonus will spawn in
    public static int[] nextLane = {1, 2, 3, 2, 3, 1, 3, 2}; // size 8; maybe this could be random
    // the next enemy/bonus to be spawned (t = trig, c = circle, x = cross, ...)
    public static char[] nextSpawn = {'t', 'c', 's', 'c', 't', 'x', 't', 'c'};

    public static int lives = 3;

    public static bool shieldOn = false; 
}
