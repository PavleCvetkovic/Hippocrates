<?php
class Termin {
    public $sat;
    public $minut;
    public $datum;
    public $napomena;
    
    public function __construct($sat,$minut,$datum){
        $this->sat=$sat;
        $this->minut=$minut;
        $this->datum=$datum;
    }
    public function vreme(){
        return $this->sat*100+$this->minut;
    }
    public function dodajNapomenu($napomena){
        $this->napomena=$napomena;
    }
}
?>