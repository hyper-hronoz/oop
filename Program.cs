// See https://aka.ms/new-console-template for more information
using System;

public class Facade
{
    private IDoTask taskRunner(IDoTask task) {
        task.doTask(); 
        return task;
    }

    public void doFirstTask() {
        double a = 1;
        double b = 2;
        double c = 3;

        IDoTask task = this.taskRunner(new FirstTask(a, b, c));
        Console.WriteLine(task.getResult());
    }

    public void doSecondTask() {
        int m = 1;
        IDoTask task = this.taskRunner(new SecondTask(m));
        Console.WriteLine(task.getResult());
    }

    public void doThirdTask() {
        IDoTask task = this.taskRunner(new ThirdTask());
        Console.WriteLine(task.getResult());
    }

    public void doFourthTask() {
        double a = 1;
        double b = 2;
        double c = 7;
        double d = 8;

        IDoTask task = this.taskRunner(new FourthTask(a, b, c, d));
        Console.WriteLine(task.getResult());
    }

    public void runAll() {
        this.doFirstTask(); 
        this.doSecondTask();
        this.doThirdTask();
        this.doFourthTask();
    }
}

public class Lab1
{
    public static void Main()
    {
        Facade facade = new Facade();
        facade.runAll();
    }
}
