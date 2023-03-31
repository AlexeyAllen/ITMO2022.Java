package Lab11_MultiThread.Ex04;

public class TwoThreadsNameSeq extends Thread {
    Object pauseObj;

    TwoThreadsNameSeq(Object object) {
        this.pauseObj = object;
    }

    @Override
    public void run() {
        while (true) {
            synchronized (pauseObj) {
                try {
                    System.out.println(Thread.currentThread().getName());
                    pauseObj.notify();
                    pauseObj.wait();
                } catch (InterruptedException e) {
                    e.printStackTrace();
                }
            }
        }
    }
}
