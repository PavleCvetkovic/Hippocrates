<?php
class IzabraniLekar {
    public $jmbg;
    public  $ime;
    public $srednje_slovo;
    public $prezime;
    public $datum_rodjenja;
    public $mbrzu;
    public $smena;
    
    public function __construct($jmbg,$ime,$srednje_slovo,$prezime,$datum_rodjenja,$mbrzu,$smena){
        $this->jmbg=$jmbg;
        $this->ime=$ime;
        $this->prezime=$prezime;
        $this->srednje_slovo=$srednje_slovo;
        $this->datum_rodjenja=$datum_rodjenja;
        $this->mbrzu=$mbrzu;
        $this->smena=$smena;
    }
}
