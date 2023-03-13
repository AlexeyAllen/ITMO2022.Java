package Lab02.Ex02;

public class Main {
    public static void main(String[] args) {
        House residential = new House("Wood", 3, Foundation.PILES, true);
        residential.setDoorsQty(10);
        residential.setFloorsArea(234.5);
        residential.setPrice(1000000L);
        //System.out.println(residential);

        String foundation = residential.getFoundation().getDescription();
        System.out.println(foundation);

        Long totalPrice = HouseReparation.totalPrice(residential, 7000);
        System.out.println(totalPrice);
    }
}
