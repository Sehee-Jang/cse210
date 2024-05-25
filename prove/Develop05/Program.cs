using System;

/* Report on additional features
 * Gamification Element : Leveling Up
 * - A simple leveling system based on the total score accumalate by the player.
 */
class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();
        goalManager.Start();
    }
}