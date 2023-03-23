// See https://aka.ms/new-console-template for more information
using System;

public delegate void CallBack();

public class Facade
{
    private IDoTask taskRunner(IDoTask task) {
        task.doTask(); 
        return task;
    }

    private void printTaskResult(string taskId, IDoTask task, CallBack inputDataCallback) {
        Console.WriteLine($"---{taskId} is running---");
        
        inputDataCallback();

        Console.WriteLine($"{taskId} result: {task.getResult()}");

        Console.WriteLine($"---END {taskId}---\n");
    }

    public void doFirstTask() {
        double a = 1;
        double b = 2;
        double c = 3;

        this.printTaskResult("First task", this.taskRunner(new FirstTask(a, b, c)), () => {
            Console.WriteLine($"a: {a}");
            Console.WriteLine($"b: {b}");
            Console.WriteLine($"c: {c}");
        });
    }

    public void doSecondTask() {
        int m = 1;
            
        this.printTaskResult("Second task", this.taskRunner(new SecondTask(m)), () => {
            Console.WriteLine($"M: {m}");
        });
    }

    public void doThirdTask() {
        this.printTaskResult("ThirdTask task", this.taskRunner(new ThirdTask()), () => {});
    }

    public void doFourthTask() {
        double a = 1;
        double b = 2;
        double c = 7;
        double d = 8;

        this.printTaskResult("Fourth task", this.taskRunner(new FourthTask(a, b, c, d)), () => {
            Console.WriteLine($"a: {a}");
            Console.WriteLine($"b: {b}");
            Console.WriteLine($"c: {c}");
            Console.WriteLine($"d: {d}");
        });
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
