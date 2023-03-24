package Lab10.Ex04;

import java.io.File;
import java.io.IOException;

public class Main {
    public static void main(String[] args){
        SubstChars substCharsNew = new SubstChars();
        File file = new File("src/Lab10/Ex04/SampleEx04.txt");
        substCharsNew.substChars(file);
    }
}
