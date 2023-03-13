package Lab06.Ex05;

import java.util.Scanner;

public class ChildClass extends ParentClass {
    @Override
    public void getUserAge() {
        super.getUserAge();
        System.out.println("Введите имя");
        String name = scanner.nextLine();
        System.out.println(name);
    }
}
