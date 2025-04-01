<p>El siguiente ejemplo explica por qué los dos objetos no son iguales. Como ocupan memoria diferente no aplica la primera igualdad. Por lo tanto, al comparar un string con el método equals, la respuesta correcta es la B.</p>

<p>

    public class Example1 {
        public static void main(String[] args) {
            String str1 = "Hello";
            String str2 = "World";
            String str3 = str1.concat(str2);
            String str4 = str1 + str2;

            if (str3 == str4) {
                System.out.println("A");
            } else if (str3.equals(str4)) {
                System.out.println("B");
            } else {
                System.out.println("C");
            }
        }
    }
</p>