<?php
class Vakcina{
    public $ime;
    public $sifra;
    public $opis;
    
    public function __construct($sifra,$ime,$opis){
        $this->ime=$ime;
        $this->sifra=$sifra;
        $this->opis=$opis;
    }
}
?>