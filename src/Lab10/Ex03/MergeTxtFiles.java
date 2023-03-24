package Lab10.Ex03;

import java.io.*;

public class MergeTxtFiles {

    void mergeTxtFiles() {
        PrintWriter printWriter = null;
        BufferedReader bufferedReader = null;
        try {
            printWriter = new PrintWriter("src/Lab10/Ex03/thirdTxtFile.txt");
            bufferedReader = new BufferedReader(new FileReader("src/Lab10/Ex01/SampleEx01.txt"));
            String text = bufferedReader.readLine();
            while (text != null) {
                printWriter.println(text);
                text = bufferedReader.readLine();
            }
            bufferedReader = new BufferedReader(new FileReader("src/Lab10/Ex02/SampleEx02.txt"));
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
