program MultiReadln;

const
  salute= 'Hola';

var nombre: string;
    edad: byte;

begin
    write('Ingrese su edad y precione enter, luego su nombre.');
    readln(edad,nombre);
    write(salute,nombre,' mucho gusto, tienes ',edad, ' anios.');
    readln();
end.

