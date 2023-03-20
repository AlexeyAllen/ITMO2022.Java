package Lab09.Ex02;

import java.util.ArrayList;
import java.util.List;

public class Main {
    public static void main(String[] args) {

        List<String> myList = new ArrayList<>();
        myList.add("Volga");
        myList.add("BMW");
        myList.add("Renault");
        myList.add("Volga");
        myList.add("Mercedes");
        myList.add("Volga");
        myList.add("Tesla");


        NoDuplicate noDuplicate = new NoDuplicate();
        noDuplicate.noDuplicate(myList);
    }
}
