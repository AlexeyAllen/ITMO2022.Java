package Lab06.Ex02;

public class Client extends Person implements CashOperation{
    String bankName;

    public Client(String name, String lastName, String bankName) {
        super(name, lastName);
        this.bankName = bankName;
    }

    @Override
    public void getAllInfo() {
        System.out.println(name);
        System.out.println(lastName);
        System.out.println(bankName);
    }

    @Override
    public void cashHandling() {
        System.out.println("Cash received by: " + name + lastName + "at" + bankName);
    }
}
