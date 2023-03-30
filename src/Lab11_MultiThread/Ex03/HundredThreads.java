package Lab11_MultiThread.Ex03;

public class HundredThreads {
    void hundThreads(){
        try {
            for (int i = 0; i < 100; i++) {
                Thread thread = new Thread(() -> {
                    for (int j = 0; j < 1000; j++) {
                        Counter.Increment();
                    }
                });
                thread.start();
                thread.join();
            }
            System.out.printf("Result: %d %n", Counter.getCount());
        }
        catch (InterruptedException e) {
            e.printStackTrace();
        }
    }
}
