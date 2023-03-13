package Lab02.Ex02;

public class House {

    private String material;
    private int floorsNumber;
    private Foundation foundation;
    private int doorsQty;
    private double floorsArea;
    private boolean isPrefabricated;

    private Long price;

    public House() {
    }

    public House(String material, int floorsNumber, Foundation foundation, boolean isPrefabricated) {
        this.material = material;
        this.floorsNumber = floorsNumber;
        this.foundation = foundation;
        this.isPrefabricated = isPrefabricated;
    }

    public House(String material, int floorsNumber, Foundation foundation, int doorsQty, double floorsArea, boolean isPrefabricated, Long price) {
        this.material = material;
        this.floorsNumber = floorsNumber;
        this.foundation = foundation;
        this.doorsQty = doorsQty;
        this.floorsArea = floorsArea;
        this.isPrefabricated = isPrefabricated;
        this.price = price;
    }

    public Foundation getFoundation() {
        return foundation;
    }

    public void setFoundation(Foundation foundation) {
        this.foundation = foundation;
    }

    public int getDoorsQty() {
        return doorsQty;
    }

    public void setDoorsQty(int doorsQty) {
        this.doorsQty = doorsQty;
    }

    public double getFloorsArea() {
        return floorsArea;
    }

    public void setFloorsArea(double floorsArea) {
        this.floorsArea = floorsArea;
    }

    public boolean isPrefabricated() {
        return isPrefabricated;
    }

    public void setPrefabricated(boolean prefabricated) {
        isPrefabricated = prefabricated;
    }


    public String getMaterial() {
        return material;
    }

    public void setMaterial() {
        this.material = material;
    }

    public int getFloorsNumber() {
        return floorsNumber;
    }

    public void setFloorsNumber() {
        this.floorsNumber = floorsNumber;
    }

    public Long getPrice() {
        return price;
    }

    public void setPrice(Long price) {
        this.price = price;
    }

    @Override
    public String toString() {
        return "House{" +
                "material='" + material + '\'' +
                ", floorsNumber=" + floorsNumber +
                ", foundation=" + foundation +
                ", doorsQty=" + doorsQty +
                ", floorsArea=" + floorsArea +
                ", isPrefabricated=" + isPrefabricated +
                ", price=" + price +
                '}';
    }
}
