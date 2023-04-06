public abstract class DoTask<T> : IDoTask {
    protected T? result;

    public abstract void doTask();

    object IDoTask.getResult() {
        return (T)result;
    }
}

