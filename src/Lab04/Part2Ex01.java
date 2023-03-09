package Lab04;

public class Part2Ex01 {
    static boolean isTrue;

    public static void main(String[] args) {
        sortAscend();
    }

    public static void sortAscend(){
        int[] intArray = new int[]{2, 4, 6, 7, 8, 23, 56, 67};
        for (int i = 0; i < intArray.length - 1; i++) {
            if (intArray[i] < intArray[i + 1]) {
                isTrue = true;
            } else {
                isTrue = false;
                break;
            }
        }
        if (isTrue) {
            System.out.println("OK");
        } else {
            System.out.println("Please, try again");
        }
    }
}
