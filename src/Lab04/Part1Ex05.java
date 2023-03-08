package Lab04;

import java.lang.reflect.Array;
import java.util.Arrays;

public class Part1Ex05 {
    public static void main(String[] args) {
        int[] array = new int[]{3, 5, 7, 9, 2, 3};
        int firstNumber = array[0];
        int lastNumber = array[array.length - 1];
        if (firstNumber == 3 && lastNumber == 3) {
            System.out.println("array = " + Arrays.toString(array));
            System.out.println("true");
        } else {
            System.out.println("false");
        }
    }
}
