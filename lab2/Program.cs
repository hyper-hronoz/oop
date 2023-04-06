
// See https://aka.ms/new-console-template for more information
//
public class Facade {
    public void doFirstTask() {
        FirstTask firstTask = new FirstTask(1, 2, 3, 4);
        firstTask.doTask();
    }

    public void doSecondTask() {
        SecondTask secondTask = new SecondTask();
        secondTask.doTask();
    }

    public void doThirdTask() {
        ThirdTask thirdTask = new ThirdTask();
        thirdTask.doTask();
    }
};


public class Program {
    public static void Main() {
        Facade facade = new Facade(); 
        facade.doFirstTask();
        facade.doSecondTask();
    }
}
