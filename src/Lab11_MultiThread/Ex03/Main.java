package Lab11_MultiThread.Ex03;

public class Main {
    public static void main(String[] args) throws InterruptedException {
        Counter counter = new Counter();
        HundredThreads hundredThreads = new HundredThreads(counter);
        hundredThreads.threadCounter();
    }
}
