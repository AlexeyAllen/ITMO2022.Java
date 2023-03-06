package Lab03;

public class Study {
    private String course;

    public Study(String course) {
        this.course = course;
    }

    //TODO

    public String printCourse() {
        return this.course;
    }
}

class JavaProgram {
    public static void main(String[] args) {
        Study study = new Study("Изучение Java - это просто!");

        //TODO
        System.out.println(study.printCourse());
    }

}
