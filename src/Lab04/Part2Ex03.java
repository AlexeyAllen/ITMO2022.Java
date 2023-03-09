package Lab04;

import java.util.Arrays;

public class Part2Ex03 {
    public static void main(String[] args) {
        firstAndLastSubst();
    }

    public static void firstAndLastSubst(){
        int[] intArray = new int[]{2, 6, 2, 56, 4};
        System.out.println("Array 1: " + Arrays.toString(intArray));
        int temp = intArray[0];
        intArray[0] = intArray[intArray.length - 1];
        intArray[intArray.length - 1] = temp;
        System.out.println("Array 2: " + Arrays.toString(intArray));
    }
}
