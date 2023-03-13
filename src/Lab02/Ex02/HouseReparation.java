package Lab02.Ex02;

public class HouseReparation {

    public static Long totalPrice(House house, int repairWorksPrice){
        long repairStartWorks = house.getPrice();
        if (repairWorksPrice == 0){
            return 0L;
        }else {
            return repairStartWorks + repairWorksPrice;
        }
    }
}
