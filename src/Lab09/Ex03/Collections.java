package Lab09.Ex03;

import java.util.ArrayList;
import java.util.LinkedList;
import java.util.List;

public class Collections {
    List<Integer> arrayList = new ArrayList<>();
    List<Integer> linkedList = new LinkedList<>();

    public void addToList() {

        long startTimeArrList = System.currentTimeMillis();
        for (int i = 0; i < 1000000; i++) {
            arrayList.add(i);
        }
        long endTimeArrList = System.currentTimeMillis();

        System.out.println("The time spent to add 1000.000 elements to ArrayList is: " + (endTimeArrList - startTimeArrList) + " ms");

        long startTimeLinkedList = System.currentTimeMillis();
        for (int i = 0; i < 1000000; i++) {
            linkedList.add(i);
        }
        long endTimeLinkedList = System.currentTimeMillis();
        System.out.println("The time spent to add 1000.000 elements to LinkedList is: " + (endTimeLinkedList - startTimeLinkedList) + " ms");

        if ((endTimeArrList - startTimeArrList) > (endTimeLinkedList - startTimeLinkedList)) {
            System.out.println("LinkedList is faster then ArrayList");
        } else if ((endTimeArrList - startTimeArrList) < (endTimeLinkedList - startTimeLinkedList)) {
            System.out.println("ArrayList is faster then LinkedList as ArraylList has got a direct reference to elements from the list, " +
                    "while LinkedList has to look up for an element through entire list");
        } else {
            System.out.println("ArrayList's speed is the same as LinkedList's speed");
        }
    }

    public void removeFromList() {
        long startTimeArrList = System.currentTimeMillis();
        for (int i = 0; i < 100000; i++) {
            int random = (int)(Math.random()*(arrayList.size()));
            arrayList.remove(random);
        }
        long endTimeArrList = System.currentTimeMillis();
        System.out.println("The time spent to remove 100.000 elements from ArrayList is: " + (endTimeArrList - startTimeArrList) + " ms");


        long startTimeLinkedList = System.currentTimeMillis();
        for (int i = 0; i < 100000; i++) {
            int random = (int)(Math.random()*(arrayList.size()));
            arrayList.remove(random);
        }
        long endTimeLinkedList = System.currentTimeMillis();
        System.out.println("The time spent to remove 100.000 elements from LinkedList is: " + (endTimeLinkedList - startTimeLinkedList) + " ms");

        if ((endTimeArrList - startTimeArrList) > (endTimeLinkedList - startTimeLinkedList)) {
            System.out.println("LinkedList is faster then ArrayList as LinkedList has just to modify the references to elements from the list, while ArrayList has" +
                    " to copy the array in order to eliminate empty memory slots from the list after removal of these elements");
        } else if ((endTimeArrList - startTimeArrList) < (endTimeLinkedList - startTimeLinkedList)) {
            System.out.println("ArrayList is faster then LinkedList");
        } else {
            System.out.println("ArrayList's speed is the same as LinkedList's speed");
        }
    }
}
