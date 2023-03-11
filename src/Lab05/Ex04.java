package Lab05;

public class Ex04 {
    public static void main(String[] args) {
        String stringMain = "Lorem Ipsum - это текст-рыба, часто используемый в печати и вэб-дизайне. " +
                "Lorem Ipsum является стандартной рыбой для текстов на латинице с начала XVI века. В то время " +
                "некий безымянный печатник создал большую коллекцию размеров и форм шрифтов, используя Lorem Ipsum " +
                "для распечатки образцов. Lorem Ipsum не только успешно пережил без заметных изменений пять веков, " +
                "но и перешагнул в электронный дизайн. Его популяризации в новое время послужили публикация листов " +
                "Letraset с образцами Lorem Ipsum в 60-х годах и, в более недавнее время, программы электронной " +
                "вёрстки типа Aldus PageMaker, в шаблонах которых используется Lorem Ipsum.";
        String subString = "Lorem";


        subStrCount(stringMain, subString);
    }
    public static void subStrCount (String stringMainSample, String subStringSample) {
        int lastIndex = 0;
        int count = 0;

        while (lastIndex != -1) {

            lastIndex = stringMainSample.indexOf(subStringSample, lastIndex);

            if (lastIndex != -1) {
                count++;
                lastIndex += subStringSample.length();
            }
        }
        System.out.println("Количество вхождений одной строки в другую: " + count);
    }
}
