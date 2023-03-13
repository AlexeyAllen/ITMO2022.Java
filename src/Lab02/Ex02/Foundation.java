package Lab02.Ex02;

public enum Foundation {
    PILES ("свайный"),
    SHALLOW("ленточный"),
    SLAB("плита");

    Foundation(String description) {
        this.description = description;
    }
    private final String description;
    public String getDescription() {
        return description;
    }
}
