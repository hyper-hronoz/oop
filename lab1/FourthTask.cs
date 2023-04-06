public class FourthTask : DoTask <double>{
    private double a = 0;
    private double b = 0;
    private double c = 0;
    private double d = 0;

    public FourthTask(double a, double b, double c, double d) {
        this.a = a;
        this.b = b;
        this.c = c;
        this.d = d;
    }

    public override void doTask()
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
}
