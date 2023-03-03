package Lab02.Ex01;

public class Ex01_Calculator {
    public static void main(String[] args) {
        sum(5,8);
        sum(1000L,5000L);
        sum(4.8, 4.9);

        multiply(5,8);
        multiply(1000L,5000L);
        multiply(4.8, 4.9);

        divide(5,8);
        divide(1000L,5000L);
        divide(4.8, 4.9);

        subtract(5,8);
        subtract(1000L,5000L);
        subtract(4.8, 4.9);
    }

    //sum
    public static void sum(int a, int b) {
        int c = a + b;
        System.out.println(c);
    }

    public static void sum(long a, long b) {
        long c = a + b;
        System.out.println(c);
    }

    public static void sum(double a, double b) {
        double c = a + b;
        System.out.println(c);
    }

    //multiply
    public static void multiply(int a, int b) {
        int c = a * b;
        System.out.println(c);
    }

    public static void multiply(long a, long b) {
        long c = a * b;
        System.out.println(c);
    }

    public static void multiply(double a, double b) {
        double c = a * b;
        System.out.println(c);
    }

    //divide
    public static void divide(int a, int b) {
        int c = a / b;
        System.out.println(c);
    }

    public static void divide(long a, long b) {
        long c = a / b;
        System.out.println(c);
    }

    public static void divide(double a, double b) {
        double c = a / b;
        System.out.println(c);
    }

    //subtract
    public static void subtract(int a, int b) {
        int c = a - b;
        System.out.println(c);
    }

    public static void subtract(long a, long b) {
        long c = a - b;
        System.out.println(c);
    }

    public static void subtract(double a, double b) {
        double c = a - b;
        System.out.println(c);
    }
}
