package Lab06.Ex03;

public class Truck extends Car {
    int wheels;
    float maxWeight;

    public void newWheels(int newWheelsQty) {
        this.wheels = newWheelsQty;
        System.out.println(wheels);
    }

    public Truck(int w, String m, char c, float s, int wheels, float maxWeight) {
        super(w, m, c, s);
        this.wheels = wheels;
        this.maxWeight = maxWeight;
    }
}
