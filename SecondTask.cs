// See https://aka.ms/new-console-template for more information
public class SecondTask : DoTask<double>
{
    private int m;

    public SecondTask(int m) {
        this.m = m; 
    }

    public override void doTask()
    {
        switch (m)
        {
            case 1:
            case 2:
                this.result = Math.Log(m + Math.Pow(m, 2)) + Math.Sqrt(14);
                break;
            case 3:
                this.result = (m + 3) / Math.Log(m);
                break;
            case 4:
            case 7:
                this.result = Math.Pow(m, 3) + 2 * (m * m + 1);
                break;
            case 5:
                this.result = 744 - Math.Pow(m, 2) * Math.Pow(Math.Sin(m), 2);
                break;
            case 6:
                this.result = Math.Log(1 + Math.Sqrt(m));
                break;
            default:
                Console.Write("OMG there is no [m] in range(1, 7)");
                break;
        } 
    }
}

