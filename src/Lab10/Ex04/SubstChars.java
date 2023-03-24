package Lab10.Ex04;

import java.io.*;

public class SubstChars {
    void substChars(File file) {

        try {
            BufferedReader bufferedReader = new BufferedReader(new FileReader(file));
            String stringOne;
            String stringTwo;

            while ((stringOne = bufferedReader.readLine()) != null) {

                stringTwo = stringOne.replaceAll("[^A-Za-zА-Яа-я0-9]", ("\\$"));
                try {
                    BufferedWriter bufferedWriter = new BufferedWriter(new FileWriter(file));
                    bufferedWriter.write(stringTwo);
                    bufferedWriter.close();
                } catch (IOException e) {
                    System.err.println("Error: " + e.getMessage());
                }
            }
        } catch (IOException e) {
            System.err.println("Error: " + e.getMessage());
        }
    }
}
