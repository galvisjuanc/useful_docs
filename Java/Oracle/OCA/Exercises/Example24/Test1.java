package Java.Oracle.OCA.Exercises.Example24;

import java.util.Arrays;
import java.util.HashSet;
import java.util.Set;

class Test1 {
    public static void main(String[] args) {
        Set<String> set = new HashSet<>(Arrays.asList("one", "two", "three"));
        set.add("one"); //this is a duplicated value. It will not be stored on the set.
        set.add(null);
        set.add(null); // same values can't be added to a set. A set doesn't accept duplicated values
        System.out.println(set.size());
        for (String value : set) {
            System.out.println(value + " ");
        }
    }
}