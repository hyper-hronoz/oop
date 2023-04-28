class Point
{
    private double x;
    private double y;

    public Point(double x, double y)
    {
        this.x = x;
        this.y = y;
    }

    public void setCoord(double x, double y)
    {
        this.x = x;
        this.y = y;
    }

    public (double, double) getCoords()
    {
        return (x, y);
    }

    public double getX()
    {
        return this.x;
    }

    public double getY()
    {
        return this.y;
    }
}

abstract class Shape
{
    private int poinsRequired;
    private List<Point> points = new List<Point>();

    public abstract void display();
    public abstract double getArea();
    public abstract double getPerimeter();

    public Shape(int amountOfPoints)
    {
        this.poinsRequired = amountOfPoints;
    }

    public void appendPoint(Point point)
    {
        if (this.points.Count < this.poinsRequired)
        {
            this.points.Add(point);
            return;
        }
        Console.WriteLine("Maximal limit of points for current shape");
    }

    public void printPoints()
    {
        foreach (Point point in this.points)
        {
            (double x, double y) = point.getCoords();
            Console.WriteLine("x: " + x + " y: " + y);
        }
    }

    public List<Point> getPoints()
    {
        return this.points;
    }
}

class Triangle : Shape
{
    public Triangle()
        : base(3) { }

    public override void display()
    {
        Console.WriteLine("That is triangle");
    }

    public override double getArea()
    {
        if (this.getPoints().Count() < 3)
        {
            Console.WriteLine("There are not enought points 3 required");
            return Double.NaN;
        }

        Point startPoint = this.getPoints()[0];
        Point middlePoint = this.getPoints()[1];
        Point finishPoint = this.getPoints()[2];

        double side1 = Math.Sqrt(
            Math.Pow(startPoint.getX() - middlePoint.getX(), 2)
                + Math.Pow(startPoint.getY() - middlePoint.getY(), 2)
        );
        double side2 = Math.Sqrt(
            Math.Pow(middlePoint.getX() - finishPoint.getX(), 2)
                + Math.Pow(middlePoint.getY() - finishPoint.getY(), 2)
        );

        return side1 * side2 * 0.5;
    }

    public override double getPerimeter()
    {
        if (this.getPoints().Count() < 3)
        {
            Console.WriteLine("There are not enought points 3 required");
            return Double.NaN;
        }

        Point startPoint = this.getPoints()[0];
        Point middlePoint = this.getPoints()[1];
        Point finishPoint = this.getPoints()[2];

        double side1 = Math.Sqrt(
            Math.Pow(startPoint.getX() - middlePoint.getX(), 2)
                + Math.Pow(startPoint.getY() - middlePoint.getY(), 2)
        );
        double side2 = Math.Sqrt(
            Math.Pow(middlePoint.getX() - finishPoint.getX(), 2)
                + Math.Pow(middlePoint.getY() - finishPoint.getY(), 2)
        );
        double side3 = Math.Sqrt(
            Math.Pow(finishPoint.getX() - startPoint.getX(), 2)
                + Math.Pow(finishPoint.getY() - startPoint.getY(), 2)
        );

        return side1 + side2 + side3;
    }
}

class Rectangle : Shape
{
    public Rectangle()
        : base(4) { }

    public override void display()
    {
        Console.WriteLine("This is Rect");
    }

    public override double getArea()
    {
        if (this.getPoints().Count() < 4)
        {
            Console.WriteLine("There are not enought points 4 required");
            return Double.NaN;
        }

        Point startPoint = this.getPoints()[0];
        Point middlePoint = this.getPoints()[1];
        Point fuckingPoint = this.getPoints()[2];
        Point finishPoint = this.getPoints()[3];

        double side1 = Math.Sqrt(
            Math.Pow(startPoint.getX() - middlePoint.getX(), 2)
                + Math.Pow(startPoint.getY() - middlePoint.getY(), 2)
        );
        double side2 = Math.Sqrt(
            Math.Pow(middlePoint.getX() - fuckingPoint.getX(), 2)
                + Math.Pow(middlePoint.getY() - fuckingPoint.getY(), 2)
        );

        return side1 * side2;
    }

    public override double getPerimeter()
    {
        if (this.getPoints().Count() < 4)
        {
            Console.WriteLine("There are not enought points 4 required");
            return Double.NaN;
        }

        Point startPoint = this.getPoints()[0];
        Point middlePoint = this.getPoints()[1];
        Point fuckingPoint = this.getPoints()[2];
        Point finishPoint = this.getPoints()[3];

        double side1 = Math.Sqrt(
            Math.Pow(startPoint.getX() - middlePoint.getX(), 2)
                + Math.Pow(startPoint.getY() - middlePoint.getY(), 2)
        );
        double side2 = Math.Sqrt(
            Math.Pow(middlePoint.getX() - fuckingPoint.getX(), 2)
                + Math.Pow(middlePoint.getY() - fuckingPoint.getY(), 2)
        );
        double side3 = Math.Sqrt(
            Math.Pow(fuckingPoint.getX() - finishPoint.getX(), 2)
                + Math.Pow(fuckingPoint.getY() - finishPoint.getY(), 2)
        );
        double side4 = Math.Sqrt(
            Math.Pow(startPoint.getX() - finishPoint.getX(), 2)
                + Math.Pow(finishPoint.getY() - startPoint.getY(), 2)
        );

        return side1 + side2 + side3 + side4;
    }
}

class Circle : Shape
{
    public Circle()
        : base(2) { }

    public override void display()
    {
        Console.WriteLine("This is circle");
    }

    public override double getArea()
    {
        if (this.getPoints().Count() < 2)
        {
            Console.WriteLine("There are not enought points 4 required");
            return Double.NaN;
        }

        Point startPoint = this.getPoints()[0];
        Point middlePoint = this.getPoints()[1];

        double radis = Math.Sqrt(
            Math.Pow(startPoint.getX() - middlePoint.getX(), 2)
                + Math.Pow(startPoint.getY() - middlePoint.getY(), 2)
        );

        return Math.PI * Math.Pow(radis, 2);
    }

    public override double getPerimeter()
    {
        if (this.getPoints().Count() < 2)
        {
            Console.WriteLine("There are not enought points 4 required");
            return Double.NaN;
        }

        Point startPoint = this.getPoints()[0];
        Point middlePoint = this.getPoints()[1];

        double radis = Math.Sqrt(
            Math.Pow(startPoint.getX() - middlePoint.getX(), 2)
                + Math.Pow(startPoint.getY() - middlePoint.getY(), 2)
        );

        return 2 * Math.PI * radis;
    }
}

abstract class Function
{
    public abstract double getResult(double x);
}

class Line : Function
{
    public double a = Double.NaN;
    public double b = Double.NaN;

    public Line(double a, double b) { 
      this.a = a;
      this.b = b;
    }

    public override double getResult(double x)
    {
        return a * x + b;
    }
}

class Kub : Function {
    public double a;
    public double b;
    public double c;

    public Kub(double a, double b, double c) {
        this.a = a;
        this.b = b;
        this.c = c;
    }

    public override double getResult(double x) {
        return a*Math.Pow(x, 2) + b * x + c;
    }
}

class Hyperbola : Function {
    public override double getResult(double x) {
        return 1 / x;
    }
}

abstract class Software {
    private string name = "";
    private string producer = "";

    public Software(string name, string producer) {
        this.name = name;
        this.producer = producer;
    }

    public abstract void doTask();
    public abstract void print();

    public string getName() {
        return this.name;
    }

    public string getProducer() {
        return this.producer;
    }
}

class FreeSoftware : Software
{
    public FreeSoftware(string name, string producer) : base(name, producer) {

    }

    public override void doTask()
    {
        Console.WriteLine("That is always free");
    }

    public override void print()
    {
        Console.WriteLine();
        Console.WriteLine("Free software name: " + this.getName());
        Console.WriteLine("Free software producer: " + this.getProducer());
        Console.WriteLine();
    }
}

class TempSoftware : Software {
    private long startUnixTime;
    private long finishUnixTime;

    public TempSoftware(string name, string producer, long startUnixTime, long finishUnixTime) : base(name, producer) {
        this.startUnixTime = startUnixTime;
        this.finishUnixTime = finishUnixTime;
    }

    public override void doTask()
    {
        DateTime currentTime = DateTime.UtcNow;
        long unixTime = ((DateTimeOffset)currentTime).ToUnixTimeSeconds();
        Console.WriteLine(unixTime);
        if (this.startUnixTime <= unixTime && unixTime <= this.finishUnixTime) {
            Console.WriteLine("U can use it for now by hurry up with payment"); 
            return;
        } 
        Console.WriteLine("U are out of date for some reason");
    }

    public override void print()
    {
        Console.WriteLine("Temporary free software name: " + this.getName());
        Console.WriteLine("Temporary free software producer: " + this.getProducer());
        Console.WriteLine("Temporary free software start trial time: " + this.getStartUnixTime());
        Console.WriteLine("Temporary free software finish trial time: " + this.getFinishUnixTime());
    }

    public long getStartUnixTime() {
        return this.startUnixTime;
    }

    public long getFinishUnixTime() {
        return this.finishUnixTime;
    }
}

class CommertialSoftware : TempSoftware {
    private long price;
    public CommertialSoftware(string name, string producer, long startUnixTime, long finishUnixTime, long price) : base(name, producer, startUnixTime, finishUnixTime) {
        this.price = price; 
    }

    public override void print() {
        Console.WriteLine("Temporary free software name: " + this.getName());
        Console.WriteLine("Temporary free software producer: " + this.getProducer());
        Console.WriteLine("Temporary free software start trial time: " + this.getStartUnixTime());
        Console.WriteLine("Temporary free software finish trial time: " + this.getFinishUnixTime());
        Console.WriteLine("Temporary free software price: " + this.getPrice());
    }

    public long getPrice() {
        return this.price;
    }
}

static class Facade {
    public static void doFirstTask() {
        Rectangle rect = new Rectangle();
        rect.appendPoint(new Point(1, 1));
        rect.appendPoint(new Point(1, 3));
        rect.appendPoint(new Point(3, 3));
        rect.appendPoint(new Point(3, 1));

        Triangle triangle = new Triangle();
        triangle.appendPoint(new Point(1, 1));
        triangle.appendPoint(new Point(1, 4));
        triangle.appendPoint(new Point(5, 1));

        Circle circle = new Circle();
        circle.appendPoint(new Point(1, 1));
        circle.appendPoint(new Point(3, 1));
        List<Shape> shapes = new List<Shape>();
        shapes.Add(rect);
        shapes.Add(triangle);
        shapes.Add(circle);
        foreach (Shape shape in shapes)
        {
            Console.WriteLine(shape.getPerimeter() + " " + shape.getArea());
        }
    }

    public static void doSecondTask() {
        Line line = new Line(2, 2);
        Console.WriteLine(line.getResult(4));

        Kub kub = new Kub(2, 2, 2);
        Console.WriteLine(kub.getResult(4));

        Hyperbola hyperbola = new Hyperbola();
        Console.WriteLine(line.getResult(4));
    }

    public static void doThirdTask() {
        FreeSoftware free = new FreeSoftware("git", "linux torwalds");
        free.print();
        free.doTask();

        DateTime currentTime = DateTime.UtcNow;
        long unixTime = ((DateTimeOffset)currentTime).ToUnixTimeSeconds();
        TempSoftware temp = new TempSoftware("photoshop", "adobe", unixTime - 1000, unixTime + 100000); 
        temp.print();
        temp.doTask();

        CommertialSoftware commertial = new CommertialSoftware("photoshop", "adobe", unixTime - 1000, unixTime + 100000, 10000); 
        temp.print();
        temp.doTask();

        List<Software> list = new List<Software>();
        list.Add(free);
        list.Add(temp);
        list.Add(commertial);

        foreach (Software soft in list) {
            soft.print();
            soft.doTask();
        }
    }
}



class Program
{
    public static void Main()
    {
        // Console.WriteLine("---First task---");
        // Facade.doFirstTask();
        // Console.WriteLine("---Second task---");
        // Facade.doSecondTask();
        Facade.doThirdTask();
    }
};
