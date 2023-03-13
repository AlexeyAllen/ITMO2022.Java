package Lab06.Ex05;

import java.util.Scanner;

public class ParentClass {
    Scanner scanner = new Scanner(System.in);

    public void getUserAge() {
        System.out.println("Введите возраст");
        int age = scanner.nextInt();
        System.out.println(age);
        scanner.nextLine();
    }
}
