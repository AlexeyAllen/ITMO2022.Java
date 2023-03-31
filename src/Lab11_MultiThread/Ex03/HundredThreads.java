package Lab11_MultiThread.Ex03;

public class HundredThreads extends Thread {

    Counter counter;
    int threadsNum = 100;
    int incremNum = 1000;

    public HundredThreads(Counter counter) {
        this.counter = counter;
    }

    public void threadCounter() throws InterruptedException {
        Thread[] threads = new Thread[threadsNum];
        for (int i = 0; i < threadsNum; ++i) {
            threads[i] = new Thread(new HundredThreads(counter));
            threads[i].start();
        }
    }

    public void run() {
        synchronized (counter) {
            for (int i = 0; i < incremNum; ++i) {
                counter.increment();
                System.out.println("Current threadsNum: " + Thread.currentThread().getName() + "Current incremNum: " + counter.getCount());
            }
        }
        System.out.println("Final count value is: " + counter.getCount());

    }
}


