package Lab02.Ex01;

public class Ex01_Calculator {
    public static void main(String[] args) {
        calc(1.0, 24324L, 3, 4);
        calc(1.0, 24324L, 3);
        calc(1.4, 24324L, 3, 4L);
        calc(1.3, 24324L, 3, 4.5);
        calc(-24324L, 3);

    }

    public static void calc(double a, long b, int c, int d) {
        double e = a + b + c + d;
        System.out.println(e);
    }

    public static void calc(double a, long b, int c) {
        double d = a / b / c;
        System.out.println(d);
    }

    public static void calc(double a, long b, int c, long d) {
        double e = a * b * c * d;
        System.out.println(e);
    }

    public static void calc(double a, long b, int c, double d) {
        double e = a - b - c - d;
        System.out.println(e);
    }

    public static void calc(long b, int c) {
        long e = b - c;
        System.out.println(e);
    }
}
