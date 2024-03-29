# Expresiones Lambda (Lambda Expressions) con C#
<p align="justify">
Las expresiones lambda provienen del cálculo lambda (lambda calculus) desarrollado por Alonzo Church en los años 1930’s como una notación para representar todas las funciones computables equivalentes a una máquina de Turing, todos los lenguajes funcionales pueden ser vistos como una variante sintáctica del cálculo lambda.
Las expresiones Lambda son útiles para sintetizar funciones con pocos parámetros que regresan algún valor, esta expresión consiste básicamente en una regla de sustitución que expresa tal cual una función o sea un mapeo de los elementos del conjunto dominio a los elementos de un codominio por ejemplo en la siguiente expresión:
</p>
<pre>
cuadrado : integer → integer donde cuadrado(n) = n²
</pre>
<p align="justify">
Aunque C# no utiliza los símbolos de la notación matemática lambda, el operador lambda es => que significa “tiende a” o “va hacia a”, la estructura de una expresión lambda en C# es:
</p>
<pre>
(Argumentos de entrada) => (salida al procesarlos)
</pre>
<p>
Veamos algunos ejemplos:
</p>
<img src="classLambda.png"/>
<p>
La salida del programa es la siguiente imagen
</p>
<img src="lambda1.png">
<p>
Ahora un ejemplo con funciones estadísticas:
</p>
<img src="MainLambda.png">
<p>
la salida de este ejemplo es la siguiente imagen
</p>
<img src="lambda2.png">
<p>
Es importante saber que es el tipo delegate que dicta el tipo de los parámetros de entrada y de salida.
</p>
