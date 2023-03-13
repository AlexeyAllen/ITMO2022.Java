package Lab06.Ex01;

public class BankWorker extends Person {

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
}
