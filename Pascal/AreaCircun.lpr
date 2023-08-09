program AreaCircun;

var radio: real;
begin
       write('Escriba el radio de la circunferencia: ');
       readln(radio);
       write('El area de la circunferencia es: ',3.14*radio*radio:4:2 ); //los 2 puntos despues de el numero son para indicar la cantidad de digitos antes y despues de el punto
       readln();
end.

