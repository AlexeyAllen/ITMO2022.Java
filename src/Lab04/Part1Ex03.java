package Lab04;

import java.util.Scanner;

public class Part1Ex03 {
    public static void main(String[] args) {
        sumDivByThirdNum();
    }
    public static void sumDivByThirdNum(){
        Scanner in = new Scanner(System.in);
        System.out.print("Введите первое число: ");
        int numberOne = in.nextInt();
        System.out.print("Введите второе число: ");
        int numberTwo = in.nextInt();
        System.out.print("Введите третье число: ");
        int numberThree = in.nextInt();
        if (numberOne + numberTwo == numberThree) {
            System.out.print("Результат: true");
        } else {
            System.out.print("Результат: false");
        }
    }
}
