// See https://aka.ms/new-console-template for more information
public class ThirdTask : DoTask<(double sum1, double sum2, double sum3)> {
    private const double accurancy = 0.05;

    private double findSum1() {
        double sum = 0; 
        double current = 0;
        double prev = 0;

        for (int i = 0; i < int.MaxValue; i++) {
            current = Math.Pow(Math.E, -Math.Sqrt(i));
            sum += current;
            if (Math.Abs(prev - current) <= accurancy) {
                break;
            }
            prev = current;
        }

        return sum;
    }

    private double findSum2() {
        double sum = 1;

        for (double i = 1, j = 2; i <= 31 && j <= 32; i++,j++) {
            sum *= i / j;
        }

        return sum;
    }

    private double findSum3() {
        double sum = 0;

        for (int k = 1; k < 10; k++) {
            double temp = 0;
            for (int i = 1; i < 15; i++) {
                temp += Math.Pow(k - i, 2);
            }
            sum += Math.Pow(k, 3) * temp;
        }

        return sum;
    }

    public override void doTask() {
        this.result = (findSum1(), findSum2(), findSum3());
    }
}

