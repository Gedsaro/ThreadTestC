using System;

public class WritingThread
{
    public int x;

    public WritingThread()
    {
        this.x = 0;
    }

    public void displayX()
    {
        do
        {

            Console.WriteLine(x);
        } while (this.x <= 9);

        Console.WriteLine("Done writing threads");
    }

}

