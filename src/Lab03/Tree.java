package Lab03;

public class Tree {
    int age;
    boolean isAlive;
    String name;

    public Tree(int age, String name){
        this.age = age;
        this.name = name;
    }
    public Tree(int age, boolean isAlive, String name){
        this.age = age;
        this.isAlive = isAlive;
        this.name = name;
    }
    public Tree(){
        System.out.println("Пустой конструктор без параметров сработал");
    }

    public static void main(String[] args) {
        Tree oak = new Tree(56, "Дуб");
        Tree spruce = new Tree(120, true, "Ель");
        Tree сherryTree = new Tree();
    }
}
