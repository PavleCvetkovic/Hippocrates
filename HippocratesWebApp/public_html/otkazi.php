<?php
date_default_timezone_set("Europe/Belgrade");
include_once '../MySmarty.php';
include_once '../lib.php';
include_once '../Datum.php';
include_once '../Pacijent.php';
include_once '../IzabraniLekar.php';
include_once '../Termin.php';
session_start();
if(!isset($_SESSION['isValid'])){
    header("Location: login.php");
    die();
}
else{
     if(!(strlen($_SESSION['email'])>0 && strlen($_SESSION['telefon'])>0))
            header("Location: podesavanja.php");
        
}
    
$smarty= new MySmarty(); 
if(isset($_GET['datum'])){
    $datum=$_GET['datum'];
    $vreme=$_GET['vreme'];
    //glupi format za u bazu
    $datum=date("Y-m-d",strtotime(str_replace('/', '-', $datum)));
    otkazi($_SESSION['JMBG'],$datum,$vreme);
}
$statusOtkazivanja="Uspešno ste otkazali termin za ".$_GET['datum'] ;

$smarty->assign("statusOtkazivanja",$statusOtkazivanja);
$smarty->display("otkazi.tpl");

?>