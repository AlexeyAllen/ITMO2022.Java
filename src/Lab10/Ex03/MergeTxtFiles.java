package Lab10.Ex03;

import java.io.*;

public class MergeTxtFiles {

    void mergeTxtFiles(String pathToFirstFile, String pathToSecondFile, String PathToThirdFile) {
        PrintWriter printWriter = null;
        BufferedReader bufferedReader = null;
        try {
            printWriter = new PrintWriter(PathToThirdFile);
            bufferedReader = new BufferedReader(new FileReader(pathToFirstFile));
            String text = bufferedReader.readLine();
            while (text != null) {
                printWriter.println(text);
                text = bufferedReader.readLine();
            }
            bufferedReader = new BufferedReader(new FileReader(pathToSecondFile));
            text = bufferedReader.readLine();
            while (text != null) {
                printWriter.println(text);
                text = bufferedReader.readLine();
            }

            System.out.println("Merge of two txt files is completed");
        } catch (IOException e) {
            System.err.println("Error: " + e.getMessage());
        } finally {
            try {
                if (printWriter != null) {
                    printWriter.close();
                }

                if (bufferedReader != null) {
                    bufferedReader.close();
                }
            } catch (IOException e) {
                System.err.println("Error: " + e.getMessage());
            }
        }
    }
}
