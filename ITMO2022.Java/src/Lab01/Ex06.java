package Lab01;

import java.util.Scanner;

public class Ex06 {
    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);
        System.out.println("Введите целое число");
        int b = scanner.nextInt();

        if (b % 2 != 0) {
            System.out.println("Нечетное");
        } else if ((b % 2 == 0) && (b > 100)) {
            System.out.println("Выход за пределы диапазона");
        } else if (b % 2 == 0) {
            System.out.println("Четное");
        }
    }
}
