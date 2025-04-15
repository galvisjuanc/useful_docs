package Java.Oracle.OCA.Exercises.Example13;

import java.util.ArrayList;
import java.util.List;
import java.util.function.Predicate;

public class TestClass {
    
    public static boolean checkList(List list, Predicate<List> p) {
        return p.test(list);
    }
    
    public static void main(String[] args) {
        boolean b = checkList(new ArrayList<>(), al -> al.isEmpty());
        System.out.println(b);

        //boolean c = checkList(new ArrayList<>(), ArrayList al -> al.isEmpty());
        //System.out.println(c);

        //boolean d = checkList(new ArrayList<>(), al -> return al.size() == 0);
        //System.out.println(d);

        boolean e = checkList(new ArrayList<>(), al -> al.add("hello"));
        System.out.println(e);
    }
}