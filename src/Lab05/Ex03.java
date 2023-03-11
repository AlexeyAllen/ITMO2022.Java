package Lab05;

public class Ex03 {
    public static void main(String[] args) {
        String stringSample = "бяка Ipsum - это текст-рыба, часто используемый в печати и вэб-дизайне. " +
                "Lorem Ipsum является стандартной рыбой для текстов на латинице с начала XVI века. В то время " +
                "некий безымянный печатник создал большую коллекцию размеров и форм шрифтов, используя бяка Ipsum " +
                "для распечатки образцов. бяка Ipsum не только успешно пережил без заметных изменений пять веков, " +
                "но и перешагнул в электронный дизайн. Его популяризации в новое время послужили публикация листов " +
                "Letraset с образцами бяка Ipsum в 60-х годах и, в более недавнее время, программы электронной " +
                "вёрстки типа Aldus PageMaker, в шаблонах которых используется бяка Ipsum.";

        String regex = "бяка";
        String replacement = "[вырезано цензурой]";
        wordsSubstitution(stringSample, regex, replacement);
    }

    public static void wordsSubstitution(String str, String regex, String replacement) {
        str = str.replaceAll(regex, replacement);
        System.out.println("The String after substitution : " + str);
    }
}
