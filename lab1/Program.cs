// See https://aka.ms/new-console-template for more information
using System;

public delegate void CallBack();


public class Facade
{
    private IDoTask taskRunner(IDoTask task) {
        CallBack hello = () => {};
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
        Console.Write("a: "); double a = Convert.ToDouble(Console.ReadLine());
        Console.Write("b: "); double b = Convert.ToDouble(Console.ReadLine());
        Console.Write("c: "); double c = Convert.ToDouble(Console.ReadLine());

        this.printTaskResult("First task", this.taskRunner(new FirstTask(a, b, c)), () => {
            Console.WriteLine($"a: {a}");
            Console.WriteLine($"b: {b}");
            Console.WriteLine($"c: {c}");
        });
    }

    public void doSecondTask() {
        Console.Write("m: "); int m = Convert.ToInt32(Console.ReadLine());
            
        this.printTaskResult("Second task", this.taskRunner(new SecondTask(m)), () => {
            Console.WriteLine($"m: {m}");
        });
    }

    public void doThirdTask() {
        this.printTaskResult("ThirdTask task", this.taskRunner(new ThirdTask()), () => {});
    }

    public void doFourthTask() {
        Console.Write("a: "); double a = Convert.ToDouble(Console.ReadLine());
        Console.Write("b: "); double b = Convert.ToDouble(Console.ReadLine());
        Console.Write("c: "); double c = Convert.ToDouble(Console.ReadLine());
        Console.Write("d: "); double d = Convert.ToDouble(Console.ReadLine());

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
