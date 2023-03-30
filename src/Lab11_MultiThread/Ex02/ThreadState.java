package Lab11_MultiThread.Ex02;

public class ThreadState {
    void threadState() {
        Thread thread = new Thread() {
            @Override
            public void run() {
                System.out.println("Thread state: "  + getState());
            }
        };
        System.out.println("Thread state: " + thread.getState());
        thread.start();
        try {
            thread.join();
        } catch (InterruptedException e) {
            e.printStackTrace();
        }
        System.out.println("Thread state: " + thread.getState());
    }
}
