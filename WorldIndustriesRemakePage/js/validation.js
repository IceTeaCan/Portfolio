
var btnEnviar = document.getElementById("boton_con");
var alert = document.getElementById("alert");
var nombre = document.getElementById("nombre");
var apellido = document.getElementById("apellido");
var correo = document.getElementById("correo");
var asunto = document.getElementById("asunto");
var mensaje = document.getElementById("mensaje");

btnEnviar.disabled = true;

function verificar() {
  if (nombre.value.length!=0 && apellido.value.length!=0 && correo.value.length!=0 && asunto.value.length!=0 && mensaje.value.length!=0){
  	btnEnviar.style.background = "#FFFFFF";
    alert.style.opacity = 0;
    btnEnviar.disabled = false
  } else {
    btnEnviar.style.background = "grey";
    alert.style.opacity = 1;
    btnEnviar.disabled = true;
    btnEnviar.value = "";
    btnEnviar.disabled = true;
  }
   
}