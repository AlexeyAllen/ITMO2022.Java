package Lab07.Ex02;

public class Plane {

    Wing wing1 = new Wing(500.0);
    Wing wing2 = new Wing(1000.0);
    Wing wing3 = new Wing(800.0);

    public class Wing {
        double wingWeight;

        Wing(double wingWeight) {
            this.wingWeight = wingWeight;
        }

        void showWingWeight() {
            System.out.println(wingWeight);
        }
    }
}
