<?php 

include 'class_lib.php';

 if(isset($_POST['button']))
 { //check if form was submitted


    if  (strlen($_POST['NroIngre']) > 0)
    {
        $obj = new fibonacci($_POST['NroIngre']);
        $obj->resuelvemetodo();
    }
    else 
    {
        vista(1);
    }
}
else 
{
        vista();
}

 
 function  vista($opcion = 0){
        
      
        echo "<center><h3>Serie Fibonacci</h3>";
        if ($opcion == 1)
        {
            echo "<p style='color:red'> Debe de ingresar un Número para Continuar</p>";
        }
        echo "<form action='' method='post'>";
        echo "<input type='number' name='NroIngre'>";
        echo "<br>";
        echo "<br>";
        echo "<button type='submit' name='button' formmethod='post'>Calcular Serie</button>";
        echo "</form>";
        echo "</center>";

 }


 ?>

