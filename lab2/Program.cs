
// See https://aka.ms/new-console-template for more information
//
public class Facade {
    public void doFirstTask() {
        FirstTask firstTask = new FirstTask(1, 2, 3, 4);
        firstTask.print();
        firstTask.doTask();
        firstTask.print();
    }

    public void doSecondTask() {
        SecondTask secondTask = new SecondTask();
        secondTask.print();
        secondTask.doTask();
        secondTask.print();
    }

    public void doThirdTask() {
        ThirdTask thirdTask = new ThirdTask();
        thirdTask.print();
        thirdTask.doTask();
        thirdTask.print();
    }

    public void doFourthTask() {
        FourthTask task = new FourthTask();
        task.print();
        task.doTask();
        task.print();
    }

    public void doFifthTask() {
        FifthTask fifthTask = new FifthTask();
        fifthTask.print();
        // fifthTask.remove(1, 2);
        // fifthTask.remove(1, 3);
        fifthTask.appendStrings();
        fifthTask.print();
    }
};


public class Program {
    public static void Main() {
        Facade facade = new Facade(); 
        facade.doFirstTask();
        facade.doSecondTask();
        facade.doThirdTask();
        facade.doFourthTask();
        facade.doFifthTask();
    }
}
