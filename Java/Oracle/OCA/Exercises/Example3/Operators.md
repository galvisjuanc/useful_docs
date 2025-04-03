
    int x = 1;
    int y = 2;
    int z = x++;

    int a = --y;
    int b = z--;
    b += ++z;

    int answ = x > a ? (y > b ? y : b) : (x > z ? x : z);
    System.out.println(answ);

En el siguiente código, se puede apreciar que:
* cuando se usa el operador de incremento después de la variable --> x++, la variable que toma ese valor lo hace antes de que aumente ese valor. Es decir que z, en la línea 3, vale 1 y al seguir a la siguiente línea, x vale 2.

* la variable a toma el valor actualizado de y, que sería 1. Ambas tendrían el valor de 1.

* la variable b toma el valor de z. Sería b = 1 y z valdría 0.

* En la siguiente línea, z aumenta a 1 y se suma al valor de b. Por eso b valdría 2.

* Como x = 2 & a = 1, se aplica el primer ternario.

* Como  y = 1 & b = 2, se toma el valor de b. Por eso la respuesta correcta es 2.