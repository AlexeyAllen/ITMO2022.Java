package Lab05;

public class Ex05 {
    public static void main(String[] args) {
        String string = "This is a test string";
        System.out.println("The given string is: " + string);
        System.out.println("The string reversed word by word is:");
        System.out.println(reverseWord(string));

    }

    public static String reverseWord(String sentence) {
        String[] wordsArray = sentence.split("\\s");
        String reverseWord = "";
        for (String word : wordsArray) {
            StringBuilder sb = new StringBuilder(word);
            sb.reverse();
            reverseWord += sb + " ";
        }
        return reverseWord.trim();
    }
}
