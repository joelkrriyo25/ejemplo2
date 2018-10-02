<?php 

class fibonacci
{

    public function __construct($nro)
    {
        $this->nroingre = $nro;

    }
    
    function resuelvemetodo(){
          $x = 0;    
          $y = 1;

            for($i=0;$i<= $this->nroingre ;$i++)    
            {    
                   if ($i < 2)
                   {
                    $z = 1 ;    

                   }
                   else 
                   {
                   $z = $x + $y;
                   }

                  echo $i."\t".$z."<br />";         
                  $x=$y;       
                  $y=$z;   
                
            }   

    }

}

?>