using System;

namespace JumpingOnTheClouds
{

    /*  There is a new mobile game that starts with consecutively numbered clouds.Some of the clouds are thunderheads and others are cumulus.The player can jump on
        any cumulus cloud having a number that is equal to the number of the current cloud plus 1 or 2
    .   The player must avoid the thunderheads. Determine the minimum number of jumps it will take to jump from the starting postion to the last cloud.It is always 
        possible to win the game.
        For each game, you will get an array of clouds numbered 0
        if they are safe or 1 if they must be avoided. */
    class Solution
    {

        // Complete the jumpingOnClouds function below.
        static int jumpingOnClouds(int[] c)
        {
            int result = 0;
            int current = 0;
            int end = c.Length - 1;
            while(current < end)
            {
                int twoStep = current + 2;
                int oneStep = current + 1;

                if(twoStep <= end && c[twoStep] == 1) {
                    current = oneStep;
                }
                else
                {
                    current = twoStep;
                }
                result++;
            }

            return result;
        }

        static void Main(string[] args)
        {

            int n = 6;

            int[] c = { 0, 0, 0, 1, 0, 0 };
            int result = jumpingOnClouds(c);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
