program Rectangulo;

var area,perimetro,ancho, largo: integer;
begin
  write('Ingrese el ancho de el rectangulo: ');
  readln(ancho);
  write('Ingrese el largo de el rectangulo: ');
  readln(largo);
  perimetro:= (ancho*2)+(largo*2);
  area:= largo*ancho;
  write('El area es: ', area,' y el perimetro es: ',perimetro);
  readln();
end.

