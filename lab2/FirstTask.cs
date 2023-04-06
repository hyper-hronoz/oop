
// See https://aka.ms/new-console-template for more information
//
public class FirstTask {
    private double a = 0;
    private double b = 0;
    private double c = 0;
    private double d = 0;

    private double result = 0;

    public FirstTask(double a, double b, double c, double d) {
        this.a = a;
        this.b = b;
        this.c = c;
        this.d = d;
    }

    public void doTask()
    {
        double[,] areas = { { a, b, c }, { b, c, d }, { a, c, d } };
        for (int i = 0; i < areas.GetLength(0); i++) {
            double s = 0;

            double x = areas[i, 0];
            double y = areas[i, 1];
            double z = areas[i, 2];

            double p = (x + y+ z) / 2;

            s = Math.Sqrt(p * (Math.Sqrt(p - x) * (Math.Sqrt(p - y) * (Math.Sqrt(p - z)))));
            if (s > this.result) {
                this.result = s;
            }
        }
    }

    public double getResult() {
        return this.result;
    }
}

