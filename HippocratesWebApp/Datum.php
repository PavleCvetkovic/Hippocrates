<?php
class Datum {
    public $dan;
    public $mesec;
    public $godina;
    public  function __construct($dan,$mesec,$godina){
        $this->dan=$dan;
        $this->mesec=$mesec;
        $this->godina=$godina;
    }
}
?>