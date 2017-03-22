<?php

class Terapija {
    public $opis;
    public $datumOd;
    public $datumDo;
    public $dijagnoza;
    
    public function __construct($opis,$datumOd,$datumDo){
        $this->opis=$opis;
        $this->datumOd=$datumOd;
        $this->datumDo=$datumDo;
    }
}
?>