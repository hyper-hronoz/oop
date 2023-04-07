public class SecondTask
{
    private const int MATRIX_SIZE = 25;
    private double[,] areas;
    private int maxRowIndex = 0;
    private int minRowIndex = 0;

    public SecondTask() {
        this.areas = new double[MATRIX_SIZE, MATRIX_SIZE];

        for (int i = 0; i < SecondTask.MATRIX_SIZE; i++)
        {
            for (int j = 0; j < SecondTask.MATRIX_SIZE; j++)
            {
                Random random = new Random();
                areas[i, j] = random.Next(10);
            }
        }
    }

    public void doTask()
    {
        double maxAverangeSum = Double.MinValue;
        double minAverangeSum = Double.MaxValue;

        for (int i = 0; i < SecondTask.MATRIX_SIZE; i++)
        {
            double averange = 0;
            for (int j = 0; j < SecondTask.MATRIX_SIZE; j++)
            {
                averange += areas[i, j];
            }
            if (averange > maxAverangeSum)
            {
                maxAverangeSum = averange; maxRowIndex = i;
            }
            if (averange < minAverangeSum)
            {
                minAverangeSum = averange;
                minRowIndex = i;
            }
        }

        for (int i = 0; i < areas.GetLength(1); i++) {
            double temp = 0;
            temp = areas[maxRowIndex, i];
            areas[maxRowIndex, i] = areas[minRowIndex, i];
            areas[minRowIndex, i] = temp;
        }
    }

    public void print() {
        Console.WriteLine();
        for (int i = 0; i < areas.GetLength(0); i++) {
            for (int j = 0; j < areas.GetLength(1); j++) {
                Console.Write(areas[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    public int getMaxRowIndex() {
        return this.maxRowIndex;
    }

    public int getMinRowIndex() {
        return this.minRowIndex;
    }
}
