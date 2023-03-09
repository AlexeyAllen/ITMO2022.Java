package Lab04;

import java.util.Arrays;

public class Part2Ex04 {

    public static void main(String[] args) {
        firstUnique();
    }

    public static void firstUnique(){
        boolean isNotUnique = true;
        int[] intArray = new int[]{2, 6, 2, 6, 6, 4, 9};

        for (int i = 0; i < intArray.length; i++) {
            boolean isUnique = true;
            for (int j = 0; j < intArray.length; j++) {
                if (intArray[i] == intArray[j] && i != j) {
                    isUnique = false;
                    break;
                }
            }
            if (isUnique) {
                System.out.println("First unique number: " + intArray[i]);
                isNotUnique = false;
                break;
            }
        }
        if (isNotUnique) {
            System.out.println("There are no unique numbers");
        }
    }
}

