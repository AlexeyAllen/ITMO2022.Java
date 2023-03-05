package Lab03;

public class Car {
    String color;
    String name;
    double weight;

    public Car() {
    }

    public Car(String color) {
        this.color = color;
    }

    public Car(String color, double weight) {
        this.color = color;
        this.weight = weight;
    }

    public void carProps() {
        System.out.println(color);
        System.out.println(name);
        System.out.println(weight);
    }

    public static void main(String[] args) {
        Car Volga = new Car("Red");
        Car Zhiguli = new Car("Blue", 2500.76);
        Volga.carProps();
        Zhiguli.carProps();
    }
}
