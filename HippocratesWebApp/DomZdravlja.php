<?php

class DomZdravlja {
    public $mbr;
    public $ime;
    public $opstina;
    public $lokacija;
    public $adresa;
    
    public function __construct($mbr,$ime,$opstina,$lokacija,$adresa){
        $this->mbr=$mbr;
        $this->ime=$ime;
        $this->opstina=$opstina;
        $this->lokacija=$lokacija;
        $this->adresa=$adresa;
    }
}
?>