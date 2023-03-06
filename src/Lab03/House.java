package Lab03;

import java.time.Year;

public class House {
    int floorNumbers;
    int builtYear;
    String name;
    int yearsInOps;

    public House() {
    }

    public void setHouseProps(int floorNumbers, int builtYear, String name) {
        this.floorNumbers = floorNumbers;
        this.builtYear = builtYear;
        this.name = name;
    }

    public void printHouseProps() {
        System.out.println(floorNumbers);
        System.out.println(builtYear);
        System.out.println(name);
        System.out.println(yearsInOps);
    }

    public void yearsInOperation() {
        yearsInOps = Year.now().getValue() - builtYear;
    }

    public static void main(String[] args) {
        House residential = new House();
        House skyScrapper = new House();
        residential.setHouseProps(2, 1996, "HomeSweetHome");
        residential.yearsInOperation();
        skyScrapper.setHouseProps(100, 2001, "Xerox");
        skyScrapper.yearsInOperation();
        residential.printHouseProps();
        skyScrapper.printHouseProps();
    }
}
