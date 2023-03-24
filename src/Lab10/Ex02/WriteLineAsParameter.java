package Lab10.Ex02;

import java.io.*;

public class WriteLineAsParameter {
    void WriteLineAsParam(String inputString) {
        try (BufferedWriter writer = new BufferedWriter(new FileWriter("src/Lab10/Ex02/SampleEx02.txt"))) {
            writer.write(inputString);
        } catch (IOException e) {
            System.err.println("Error: " + e.getMessage());
        }
    }
}
