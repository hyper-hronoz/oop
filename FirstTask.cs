// See https://aka.ms/new-console-template for more information
public class FirstTask : DoTask<(double a, double b, double c)>
{
    private double a = 0;
    private double b = 0;
    private double c = 0;

    public FirstTask(double a, double b, double c) {
        this.a = a;    
        this.b = b;
        this.c = c;
    }

    public override void doTask()
    {
        if (b < a && a < c)
        {
            a *= 2;
            b *= 2;
            c *= 2;
        }
        else if (a < b && b < c)
        {
            c *= c;
        }
        else
        {
            double[] array = { a, b, c };
            double min = Double.MinValue;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
            }
            a = min;
            b = min;
            c = min;
        }
        this.result = (a, b, c);
    }
}

