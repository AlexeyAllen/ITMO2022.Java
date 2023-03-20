package Lab09.Ex04;

import java.util.HashMap;
import java.util.Map;

public class User {
    private String name;

    public User() {
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    Map<String, Integer> players = new HashMap<String, Integer>();

    public void showPlayers() {
        players.put("Андрей", 34);
        players.put("Михаил", 37);
        players.put("Василий", 23);
        players.put("Роман", 4);
        players.put("Анна", 67);
        players.put("Мария", 65);

        System.out.println("В игре участвуют следующие игроки:");

        for (Map.Entry<String, Integer> item : players.entrySet()) {
            System.out.println(item.getKey());
        }
    }

    public Integer showScore(String userName) {

        Integer scoreValue = players.get(userName);
        return scoreValue;
    }
}
