package Lab05;

public class Ex02 {
    public static void main(String[] args) {
        String str = "saippuakivikauppias";
        System.out.println(isPalindrome(str));
    }
    public static boolean isPalindrome(String str) {
        return str.equals(new StringBuilder(str).reverse().toString());
    }
}
