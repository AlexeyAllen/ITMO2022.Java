package Lab04;

public class Part1Ex01 {
    public static void main(String[] args) {
        oddsCalc();
    }

    public static void oddsCalc(){
        for (int i = 1; i < 100; i++) {
            if (i == 1 | i % 2 != 0) {
                System.out.println(i);
            }
        }
    }
}
