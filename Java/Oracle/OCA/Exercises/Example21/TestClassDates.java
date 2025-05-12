package Java.Oracle.OCA.Exercises.Example21;

import java.time.LocalDate;
import java.time.LocalDateTime;

class TestClassDates {

    public static void main(String[] args) {
        System.out.println("Print correct dates in localDateTime");
        //LocalDateTime localDateTime = LocalDate.parse("2015-01-02");
        
        //LocalDateTime lTime = LocalDateTime.parse("2015-01-02");
        //System.out.println(lTime.toString());

        LocalDateTime lDateTime = LocalDateTime.of(2015, 10, 1, 10, 10);
        System.out.println(lDateTime);

        //LocalDateTime lTime1 = LocalDateTime.of(2015, "January", 1, 10, 10, 0, 0, 0, 0, 0);

    }
}