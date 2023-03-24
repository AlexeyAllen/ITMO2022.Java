package Lab10.Ex01;

import java.io.BufferedReader;
import java.io.FileReader;

import java.io.IOException;
import java.util.ArrayList;
import java.util.List;

public class ReadFileAddToList {
    void addToList(String fileName) {
        List<String> words = new ArrayList<String>();

        try (BufferedReader reader = new BufferedReader(new FileReader(fileName))) {
            String text;
            while ((text = reader.readLine()) != null) {
                words.add(text);
            }
            System.out.println(words);
        } catch (IOException e) {
            System.err.println("Error: " + e.getMessage());
        }
    }
}
