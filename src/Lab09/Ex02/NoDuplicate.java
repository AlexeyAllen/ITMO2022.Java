package Lab09.Ex02;

import java.util.HashSet;
import java.util.List;

public class NoDuplicate {

    public void noDuplicate(List<String> stringList) {

        HashSet<String> itemList = new HashSet<>(stringList);

        for (String item : itemList) {
            System.out.println(item);
        }
    }
}
