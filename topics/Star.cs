using System;


public class Star
{
    private double shineFactor;
    private bool isFadedOut = false;

    public Star(double shineFactor)
    {
        this.shineFactor = shineFactor;
    }

    public double Shine()
    {
        if (isFadedOut)
        {
            throw new InvalidOperationException("The star has faded out and cannot shine.");
        }
        return shineFactor;
    }

    public void FadeOut()
    {
        isFadedOut = true;
    }

    public string Name { get; set; }

    public static void Main3(string[] args)
    {
        // Code for debugging the test case NewStarsCanShine
        double shineFactor = 1.6d;
        Star star = new(shineFactor);
        Console.WriteLine($"Are equal: {object.Equals(shineFactor, star.Shine())}, expected: {shineFactor}, actual: {star.Shine()}");
    }
}
