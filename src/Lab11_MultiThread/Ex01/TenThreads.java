package Lab11_MultiThread.Ex01;

public class TenThreads {
    void tenThreads() {
        for (int i = 1; i < 11; i++) {
            System.out.printf("Thread #%d started \n", i);
            int finalI = i;
            new Thread(() -> {
                for (int j = 0; j < 101; j++) {
                    System.out.printf("Thread #%d output number %d %n", finalI, j);
                }
            }).start();
        }
    }
}
