package Lab06.Ex02;

public class BankWorker extends Person implements CashOperation {

    String bankName;

    public BankWorker(String name, String lastName, String bankName) {
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
        System.out.println("Cash handed by: " + name + lastName + "at" + bankName);
    }
}
