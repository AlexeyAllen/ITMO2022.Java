package Lab09.Ex04;

import java.util.Scanner;

public class Main {
    public static void main(String[] args) {

        User user = new User();
        user.showPlayers();

        Scanner scanner = new Scanner(System.in);
        System.out.print("Введите имя игрока для показа соотвествующего ему количества очков: ");
        String name = scanner.nextLine();

        System.out.println("Количество очков, соответствующих игроку " + name + " = " + user.showScore(name));
    }
}
