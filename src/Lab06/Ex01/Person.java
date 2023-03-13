package Lab06.Ex01;

public abstract class Person {
    String name;
    String lastName;

    public String getName() {
        return name;
    }

    public String getLastName() {
        return lastName;
    }

    public abstract void getAllInfo();

    public Person(String name, String lastName) {
        this.name = name;
        this.lastName = lastName;
    }
}
