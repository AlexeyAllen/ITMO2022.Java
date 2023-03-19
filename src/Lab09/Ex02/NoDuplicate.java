package Lab09.Ex02;

import java.util.HashSet;

public class NoDuplicate {
    public void noDuplicate(String item1, String item2, String item3,String item4){
        HashSet<String> itemList = new HashSet<>();
        itemList.add(item1);
        itemList.add(item2);
        itemList.add(item3);
        itemList.add(item4);

        for (String item : itemList){
            System.out.println(item);
        }
    }
}
