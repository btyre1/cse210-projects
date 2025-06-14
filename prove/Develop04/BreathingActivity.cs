class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        SetName("Breathing");
        SetDescription("This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");
    }

    private void BreatheIn(int seconds)
    {
        Console.Write("\nBreathe in...");
        AnimateBreath(seconds, true);
    }

    private void BreatheOut(int seconds)
    {
        Console.Write("\nNow breath out...");
        AnimateBreath(seconds, false);
    }

    private void AnimateBreath(int seconds, bool isBreathingIn)
    {
        int blocks = 20;
        int delay = (seconds * 1000) / blocks;
        Console.WriteLine();

        if (isBreathingIn)
        {
            for (int i = 1; i <= blocks; i++)
            {
                Console.Write("\r" + new string('■', i) + new string(' ', blocks - i));
                Thread.Sleep(delay);
            }
        }
        else
        {
            for (int i = blocks; i >= 0; i--)
            {
                Console.Write("\r" + new string('■', i) + new string(' ', blocks - i));
                Thread.Sleep(delay);
            }
        }
    }

    public void PerformActivity()
    {
        int elapsedTime = 0;
        bool isFirstCycle = true;

        while (elapsedTime + (isFirstCycle ? 5 : 10) <= GetDuration())
        {
            if (isFirstCycle)
            {
                BreatheIn(2);
                BreatheOut(3);
                elapsedTime += 5;
                isFirstCycle = false;
            }
            else
            {
                Console.WriteLine("");
                BreatheIn(4);
                BreatheOut(6);
                elapsedTime += 10;
            }
        }

        int remainingTime = GetDuration() - elapsedTime;

        if (remainingTime > 0)
        {
            Console.Write("\nJust relax...");
            DisplaySpinner((int)remainingTime);
        }
    }
}