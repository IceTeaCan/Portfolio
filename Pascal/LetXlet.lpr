program LetXlet;

var l1,l2,l3,l4: char;

begin
  write('Ingrese una palabnra de 4 letras: ');
  read(l1,l2,l3,l4);readln;  { no olvidar que cuando se usa read no se toma en cuenta el salto de el enter
                               por lo que debe terminar con la lectura de tal}

  write(l1+#13#10+l2+#13#10+l3+#13#10+l4);
  readln();
end.

