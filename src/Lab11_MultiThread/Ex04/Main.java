package Lab11_MultiThread.Ex04;

public class Main {
    public static void main(String[] args) {
        Object pauseObj = new Object();
        new TwoThreadsNameSeq(pauseObj).start();
        new TwoThreadsNameSeq(pauseObj).start();
    }
}
