public class DoTask {
  private double x;
  private double y;
  private double z;
  private double alpha;

  private double betta;

  public DoTask(double x, double y, double z, double alpha) {
    this.x = x; 
    this.y = y; 
    this.z = z;
    this.alpha = alpha;
  }

  public void Calcualte() {
    this.betta = Math.Sqrt(10*(Math.Pow(x, 1/3) + Math.Pow(x, y + 2))) * (Math.Pow(Math.Asin(z), 2) - Math.Abs(x - y));
  }

  public double GetBetta() {
    return this.betta;
  }

  public void Print() {
    Console.WriteLine();
  }
};

public class Program {
  public static void Main() {
    DoTask task = new DoTask(16.55, -2.75, 0.15, -182.036);
    task.Calcualte();
    Console.WriteLine(task.GetBetta());
  } 
}

