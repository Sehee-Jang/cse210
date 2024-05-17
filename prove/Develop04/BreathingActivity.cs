public class BreathingActivity : Activity
{
    // Constructor
    public BreathingActivity() : base("Breathing", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {

    }

    // Method
    public void Run()
    {
        DisplayStartingMessage();

        int remainingTime = _duration;
        while (remainingTime > 0)
        {
            Console.Write("Breathe in...");
            ShowCountDown(remainingTime >= 4 ? 4 : remainingTime); // Count down for 4 seconds or remaining time if less
            remainingTime -= 4;

            if (remainingTime > 0)
            {
                Console.Write("Now breathe out...");
                ShowCountDown(remainingTime >= 6 ? 6 : remainingTime); // Count down for 6 seconds or remaining time if less
                remainingTime -= 6;
                Console.WriteLine();
            }
        }
        DisplayEndingMessage();
    }
}