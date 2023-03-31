package Lab11_MultiThread.Ex03;

class Counter {
    static int count = 0;

    public static int getCount() {
        return count;
    }

    public static void increment() {
        count += 1;
    }
}
