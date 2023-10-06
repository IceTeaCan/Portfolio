program DivisionEntera;

var cantManz, cantNin,cociente, resto: integer;
begin
     write('Escribe la cantidad de manzanas: ');
     readln(cantManz);
     write('Escribe la cantidad de ninios: ');
     readln(cantNin);
     cociente:= cantManz DIV cantNin; // DIV es lo mismo que SQL
     resto:= cantManz MOD cantNin; // el MOD lo que hace es sacar el valor restante de una operacion de divicion
     writeln('cada ninio tiene ', cociente,' manzanas.');
     write('Han sobrado ', resto,' manzanas.');
     readln;
end.

