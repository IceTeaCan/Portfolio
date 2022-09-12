
package tarea2proyecto2;
import java.util.Scanner;
public class Tarea2Proyecto2 {
    //variable global el scanner 
                                     //OJO!! valores de prueba:tarjeta[0]=123456;tarjetaPin{0}=1234;usuario[0]=Jonathan Salazar;contraseña[0]=contraseña;
    public static Scanner entrada=new Scanner(System.in); 
    //subprogramas de retorno 
    //cada srray global de la serie "subprogramas de retorno "
    //esta colocada por encima de su programa para que no cree un array cada vez que ingrese al proseso y por cuestión de orden se colocaron encima de donde se trabajan
    public static String[] tarjetas=new String[1000];
    //aca se crea el contenido de el array 
    //separado de la utilización deel contenido pues no podemos hacerlo en el mismo ya que seria inseguro
    static void CreaTar()
    {
        tarjetas[0]="123456";
        System.out.print("Digite la el numero de tarjeta que será entregada a el usuario \n");
        for (int i=0;i<tarjetas.length;i++)
        {
            if (tarjetas[i]==null)
            {
                tarjetas[i]=entrada.next();
                System.out.print("guardado\n");
                
            }
        }
    }
    //buscar tarjetas
    static boolean Tarjetas()
    {
        //buscar
        System.out.print("digite su número de tarjeta por favor \n");
        boolean retTar=true;
            for (int i=0;i<tarjetas.length;i++)
            {
                String num=entrada.next();
                //String numTar=entrada.next();
                if (tarjetas[i].equals(num)) 
                {
                   System.out.print("Bienvenido \n"+usuario[i]);
                   retTar=false;
                }
                else
                {
                    System.out.print("no existe esa tarjeta\n");
                }
                
                
            }
            return retTar;
    }
    //array
    static String[] tarjetaPin=new String[1000];
    //crear pin
     static void creaPin()
    {
        tarjetaPin[0]="1234";
        System.out.print("Digite la el numero de Pin que será entregada a el usuario \n");
        for (int i=0;i<tarjetaPin.length;i++)
        {
            if (tarjetaPin[i]==null)
            {
                tarjetaPin[i]=entrada.next();
                System.out.print("guardado\n");
                
            }
        }
    }
    //buscar pin
    static int TarjetasPin()
            {
                int retPin=0;
                for (int i=0;i<tarjetaPin.length;i++)
                {
                    String num=entrada.next();
                    //System.out.print(i);
                    //System.out.println(tarjetas[i]);
                    if (tarjetaPin[i].equals(num))
                    {
                        retPin=i;
                    }
                    else
                    {
                        System.out.print("este Pin es icorrecto");
                        break;
                    }
                }
                return retPin;
            }
    //array
    public static String[] usuario=new String[1000];
    //crear
    static void creaUsu()
    {
        usuario[0]="Jonathan Salazar";
        System.out.print("Digite la el numero de Pin que será entregada a el usuario \n");
        for (int i=0;i<usuario.length;i++)
        {
            if (usuario[i]==null)
            {
                usuario[i]=entrada.next();
                System.out.print("guardado\n");
                
            }
        }
    }
    //buscar
    static int Usuarios()
            {
                System.out.print("digite su usuario o el usuario a buscar ");
                int retUs=0;
                for (int i=0;i<usuario.length;i++)
                {
                    if (usuario[i].equals(entrada.next()));
                    {
                        i=retUs;
                    }
                }
                return retUs;
            }
    //modificar usuario
    static void ModifUsu()
    {
      int i=Usuarios(); 
      System.out.print("1.modificar \n"
              + "2.eliminar \n"
              + "digite una opción :");
      String opc=entrada.next();
      switch(opc)
      {
          case"1":
              System.out.print("digite el nuevo nombre \n");
              usuario[i]=entrada.next();
              System.out.print("digite la nueva contraseña \n");
              contraseña[i]=entrada.next();
          case"2":
            usuario[i]=null;
            contraseña[i]=null;
            System.out.print("Usuario eliminado con exito \n");
      }
    }
    //hacemos a contraseña global para que no cree el string cada ves que entre a colocar un dato 
    public static String[] contraseña=new String[1000];
    //crear contraseñas
    static void creaContr()
    {
        contraseña[0]="contraseña";
        System.out.print("Digite la el numero de Pin que será entregada a el usuario \n");
        for (int i=0;i<contraseña.length;i++)
        {
            if (contraseña[i]==null)
            {
                contraseña[i]=entrada.next();
                System.out.print("guardado\n");
                
            }
        }
    }
    //buscar contraseñas
    static int Contraseñas()
            {
                contraseña[0]="2210";
                int retCont=0;
                int i=Usuarios();
                System.out.print("digite su contraseña de cuenta\n");
                    if (contraseña[i].equals(entrada.next())) 
                    {
                        System.out.print("bienvenido "+usuario[i]+"\n");
                        retCont=i;
                    } 
                    else
                    {
                        
                        System.out.print("esta contraseña es incorrecta\n");
                    }
            
                
                return retCont;
            }
    // array de saldos globales 
    public static double[] saldo=new double[1000];
    //saldo no tiene subprograma porque nesecito el valor de la pocicion de el usuario o la tarjeta para saber la pocicion de el dinero de la persona 
    //este valor lo se con un return que me da el pin de la tarjeta o la contraseña de el usuario cuando lo pido 
    //por lo tanto lo nesesito directamente en el proceso 
    static double Divisas()
    {
        boolean estado=true;
        double retDiv=0;
        double dolar=562.47;
        double euro=611.65;
        do
        {
            System.out.print("1.valor de divisas en colones\n"
                + "2.Converción de colones a dolares\n"
                + "3.Convercion de colones a euros\n"
                + "4.salir\n"
                    + "digite una opción :");
            String opc=entrada.next();
            switch(opc)
            {
                case"1":
                    System.out.println("dolar= "+dolar+" colones\n"
                    + "euro= "+euro+" colones\n");
                    break;
                case"2":
                    System.out.print("digite la cantidad de colones que decea convertir:");
                    retDiv=entrada.nextDouble();
                    retDiv=retDiv/dolar;
                    System.out.print(retDiv+" dolares");
                    System.out.print("decea retirar este dinero ?\n"
                            + "1.si\n"
                            + "2.no\n");
                    String retdivisa=entrada.next();
                    if (retdivisa.equals("1")) 
                    {
                      
                    } 
                    else 
                    {
                        retDiv=1;
                     }
                    
                    return retDiv;
                case"3":
                    System.out.print("digite la cantidad de colones que decea convertir:");
                    retDiv=entrada.nextDouble();
                    retDiv=retDiv/euro;
                    System.out.print(retDiv+" euros");
                    return retDiv;
                case"4":
                    estado=false;
                    break;
            }
        }while(estado);
    return retDiv;
    }
        public static double dinCaj[] = new double [200];
        static void DinCaja()
        {
           for (int i=0;i<dinCaj.length;i++)
           {
               dinCaj[0]=1000;
           }
        }
    //vector de creditos
    public static double[][] credito=new double[1000][1000];
    //crear
    static void CreaCredi()
    {
        credito[0][0]=1000;
        int i=Usuarios();
        int j=0;
        if (credito[i][j]== 0.0)
            {
                System.out.print("Digite la cantidad de dinero que será entregada a el usuario \n");
                credito[i][j]=credito[i][j]+entrada.nextDouble();
                System.out.print("guardado\n");
            } 
    }
    //buscar 
    static void Creditos()
    {
        //en este caso no utilizo for pues uso el buscador de usuarios para saber el espacio que tengo que llenar para llevar un buen orden
        int i=Usuarios();
       System.out.print("1.revisar total de credito entregado\n"
               + "2.cancelar saldo de credito\n"
               + "digite una opción :");
        String opc=entrada.next();
        switch (opc)
        {
            
        case"1":
            System.out.print("credito total "+credito[i][0]);
            break;
        case"2":
            System.out.print("digite el monto a cancelar");
            int j=Usuarios();
            credito[i][j]=credito[i][j]-entrada.nextDouble();
            System.out.print("su saldo restante es de :"+credito[i][j]);
        }
    }
            
    ///////////
    ///////////
    //sistema de cajero automatico sin retorno
        static void CajeroAuto ()
        {
            boolean estado=true;
            System.out.print("Bienvenido a el cajero parte de la red JSR Banking\n"
                     + "porfavor digite su número de tarjeta de credito o debito\n");
            System.out.print("digite su Pin de tarjeta (4 digitos)");
            
            if (Tarjetas()==false)
            {
                int i=TarjetasPin(); 
                
                do
                {
                     System.out.print("1.Retiro y deposito de dinero\n"
                        + "2.Valor y coverción de divisas\n"
                             + "3.salir\n"
                             + "digite una opción :");
                    String opc=entrada.next();
                    switch(opc)
                    {
                        case"1":
                            System.out.print("1 depositar\n"
                                    + "2.retirar\n"
                                    + "digite una opción :");
                            String caso=entrada.next();
                            switch(caso)
                            {
                                case"1":
                                    System.out.print("digite la cantidad a depositar\n");
                                    saldo[i]= saldo[i]+entrada.nextInt();
                                    System.out.print("Su saldo total es de :"+ saldo[i]);
                                case"2":
                                    System.out.print("digite la cantidad a retirar\n");
                                    if (0==saldo[i]);
                                    {
                                        System.out.print("Saldo insuficiente para esta transacción \n");
                                    }
                                    saldo[i]= saldo[i]-entrada.nextInt();
                                    System.out.print("Su saldo total es de :"+ saldo[i]);
                                    //hacer lo de los billetes
                                           
                            }
                        case"2":
                            Divisas();
                            
                        case"3":
                            estado=false;
                                
                                
                    }
                }while(estado);
            }
        }
             //todo se maneja desde sub programas para maximizar el servicio con el menor codigo repetido
        //cajero de banco
        static void Cajero()
    {
        boolean estado=true;
        do
        {
            System.out.print("1.depositos a cuentas \n"
                    + "2. revisar cuentas \n"
                    + "3.transferencia entre cuentas \n"
                    + "4.cambios de moneda \n"
                    + "5. salir\n"
                    + "digite una opción :");
            String opc=entrada.next();
            switch(opc)
            {//realizar depositos 
                    //revisar cuentas
                    //transferencias entre cuentas
                    //cambios de moneda 
                case"1":
                    int i=0;
                    System.out.print("1 depositar\n"
                                    + "2.retirar\n"
                            + "digite una opción :");
                            String caso=entrada.next();
                            switch(caso)
                            {
                                case"1":
                                    System.out.print("digite la cantidad a depositar\n");
                                    saldo[i]= saldo[i]+entrada.nextInt();
                                    System.out.print("Su saldo total es de :"+ saldo[i]);
                                    break;
                                case"2":
                                    System.out.print("digite la cantidad a retirar \n");
                                    if (0==saldo[i]);
                                    {
                                        System.out.print("Saldo insuficiente para esta transacción \n");
                                    }
                                    saldo[i]= saldo[i]-entrada.nextInt();
                                    System.out.print("Su saldo total es de :"+ saldo[i]);
                                    break;
                            }
                            break;
                    
                case"2":
                    int j=Usuarios();
                    System.out.print("el saldo de la cuenta es :"+saldo[j]);
                    break;
                case"3":
                    int d=Usuarios();
                    System.out.print("ahora la cuenta a transferir ");
                    int e=Usuarios();
                    System.out.print("digite la cantidad en colones a tranferir ");
                    double dinero=entrada.nextDouble();
                    saldo[d]=saldo[d]-dinero;
                    saldo[e]=saldo[e]+dinero;
                    break;
                case"4":
                    Divisas();
                    break;
                case"5":
                    estado=false;
            }
        }while(estado);
    }
        //usuario
        static void Usuario()
    { //realizar transferencias 
       //revisar saldos y movimientos 
       //pagar creditos (parcial y total)
        boolean estado=true;
       int i=Contraseñas();
       System.out.print("1.Trasferencias\n"
               + "2.saldos y movimientos\n"
               + "3.pagar creditos\n"
               + "4.salir\n"
               + "digite una opción :");
       String opc=entrada.next();
       do
       {
            switch (opc)
            {
                case"1":
                    System.out.print("acontinuación \n");
                    int j=Usuarios();
                    double dinero=entrada.nextDouble();
                    if (saldo[i]<dinero)
                    {
                        System.out.print("su saldo es insuficiente para hacer la trasferencia \n");
                        break;
                    }
                    saldo[i]=saldo[i]-dinero;
                    saldo[j]=saldo[j]+dinero;
                case"2":
                    System.out.print("Su saldo actual es de :"+saldo[i]);
                case"3":
                    Creditos();
                case"4":
                    estado=false;
            }
       }while(estado);
    }
    
        //administrador de banco
        static void Administrador()
    {
        //revisar movimientos
        //cobrar creditos(parcial y total)
        //revisar el estado de dinero del cajero
        System.out.print("1.cobrar creditos\n"
                + "2.estado de dinero de cajero\n"
                + "digite una opción :");
        String opc=entrada.next();
        switch(opc)
        {
            case"1":
                Creditos();
            case"2":
                System.out.print(""+dinCaj[0]);
        }
    }
        //plataformero de banco
        static void Plataforma()
    {
        //crear ,buscar,modificar y desactivar cuentas de los usuarios , crea creditos 
        boolean estado=true;
        System.out.print("1.crear usuarios\n"
                + "2.buscar \n"
                + "3.modificar y desactivar \n"
                + "4.crear creditos \n"
                + "5.salir\n"
                + "digite una opción :");
        String opc=entrada.next();
        do
        {
            switch(opc)
            {
                case"1":
                    creaUsu();
                    creaContr();
                    CreaTar();
                    creaPin();
                case"2":
                    Usuarios();
                case"3":
                    ModifUsu();
                case"4":
                    CreaCredi();
                case"5":
                     estado=false;
            }
        }while(estado);
    
    }
        ////////////////////////////////////////////////////////////////////////////////////////////////
        //menu principal
        public static void MainMenu()
                //este es el menu central 
    {
            //variables locales
        
        boolean estado=true;
        System.out.println("Bienvenido al servicio de atención y desarollo de el Banco JSR ");
        do
        {
             System.out.print("==========================\n"
                    + "***Banco JSR ***\n\n"
                    + "1.Cajero Automatico \n"
                     + "2.Cajas\n"
                    + "3.Usuario\n"
                    + "4.administrador\n"
                    + "5.plataforma\n"
                    + "6.salida\n"
                    + "Digite una opcion: ");
            String opc=entrada.next();
            switch(opc)
            {
                case "1":
                     CajeroAuto();
                    break;
                case"2":
                    Cajero();
                    break;
                case "3":
                    Usuario();
                    break;
                case "4":
                    Administrador();
                    break;
                case "5":
                    Plataforma();
                    break;
                case "6":
                   estado=false;
                    break;
                default:
                    System.out.println("No es una opcion intente de nuevo");
                    break;
            }
        }while(estado);
        
    }
    
    public static void main(String[] args) {
        //de esta forma solo utilizamos 1 llamada para hacer el menu y todas las funciones
        MainMenu();
    }
    
}
