package Lab10.Ex03;

import java.io.*;

public class Main {
    public static void main(String[] args) throws IOException {
        MergeTxtFiles mergeTxtFiles = new MergeTxtFiles();
        String pathToFirstFile = "src/Lab10/Ex01/SampleEx01.txt";
        String pathToSecondFile = "src/Lab10/Ex02/SampleEx02.txt";
        String PathToThirdFile = "src/Lab10/Ex03/thirdTxtFile.txt";

        mergeTxtFiles.mergeTxtFiles(pathToFirstFile, pathToSecondFile, PathToThirdFile);
    }
}
