<?php


class Pacijent {
    public $ime;
    public $prezime;
    public $datum_rodjenja;
    public $srednje_slovo;
    public $pravo_da_zakaze;
    public $lbo;
    public $jmbg;
    public $matbrl;
    public $vazi_do;
    
    public function __construct($jmbg,$lbo,$ime,$prezime,$srednje_slovo,$datum_rodjenja,$pravo_da_zakaze,$matbrl,$vazi_do){
        $this->jmbg=$jmbg;
        $this->lbo=$lbo;
        $this->ime=$ime;
        $this->prezime=$prezime;
        $this->srednje_slovo=$srednje_slovo;
        $this->pravo_da_zakaze=$pravo_da_zakaze;
        $this->matbrl=$matbrl;
        $this->vazi_do=$vazi_do;
        $this->datum_rodjenja=$datum_rodjenja;
    }
}
