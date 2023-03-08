package Lab04;

public class Part1Ex06 {
    static boolean isTrue;
    public static void main(String[] args) {
        int[] array = new int[]{4, 5, 7, 9, 2, 3};
        for (int i = 0; i < array.length; i++) {
            if (array[i] == 1 | array[i] == 3) {
                isTrue = true;
            }
        }
        if (isTrue) {
            System.out.println("Contains 1 or 3");
        } else {
            System.out.println("Doesn't contain 1 or 3");
        }
    }
}
