public class ThirdTask
{
    private int days = 31;
    private double[] array;
    private double maximalDay;
    private double averangeTemp;

    public ThirdTask()
    {
        this.array = new double[days];
        for (int i = 0; i < this.days; i++)
        {
            Random random = new Random();
            this.array[i] = random.Next(10);
        }
    }

    public void doTask() { 
        double localMaximal = Double.MinValue;
        for (int i = 0; i < this.days; i++) {
            this.averangeTemp += array[i];
            if (array[i] > localMaximal) {
                localMaximal = array[i];
            }
        }
        this.averangeTemp *= 1 / days;
        this.maximalDay = localMaximal;
    }

    public void print() {
        Console.WriteLine(this.averangeTemp); 
        Console.WriteLine(this.maximalDay); 
    }
}
