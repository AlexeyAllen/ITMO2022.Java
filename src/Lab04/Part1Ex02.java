package Lab04;

public class Part1Ex02 {
    public static void main(String[] args) {
        divByNUms();
    }

    public static void divByNUms(){
        for (int i = 1; i < 101; i++)
            if (i % 3 == 0 && i % 5 == 0) {
                System.out.println("Делится на 3 и на 5: " + i);
            } else if (i % 3 == 0) {
                System.out.println("Делится на 3: " + i);
            } else if (i % 5 == 0) {
                System.out.println("Делится на 5: " + i);
            } else continue;
    }
}
