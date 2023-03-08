package Lab04;

import java.util.Arrays;
import java.util.Scanner;

public class Part2Ex02 {
    public static void main(String[] args) {
        Scanner in = new Scanner(System.in);
        System.out.print("Array length: ");
        int arrayLength = in.nextInt();
        int[] array = new int[arrayLength];
        System.out.println("Numbers of array:");
        for (int i = 0; i < arrayLength; i++) {
            array[i] = in.nextInt();
        }
        System.out.println("Result: " + Arrays.toString(array));
    }
}
