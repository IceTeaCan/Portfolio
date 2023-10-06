program DivisionEntera;

var cantManz, cantNin,cociente, resto: integer;
begin
     write('Escribe la cantidad de manzanas: ');
     readln(cantManz);
     write('Escribe la cantidad de ninios: ');
     readln(cantNin);
     cociente:= cantManz DIV cantNin;
     resto:= cantManz MOD cantNin;
     writeln('cada ninio tiene ', cociente,' manzanas.');
     write('Han sobrado ', resto,' manzanas.');
     readln;
end.

