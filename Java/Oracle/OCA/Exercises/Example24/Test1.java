package Java.Oracle.OCA.Exercises.Example24;

import java.util.Arrays;
import java.util.HashSet;
import java.util.Set;

class Test1 {
    public static void main(String[] args) {
        Set<String> set = new HashSet<>(Arrays.asList("one", "two", "three"));
        set.add("one");
        set.add(null);
        set.add(null);
        System.out.println(set.size());
    }
}