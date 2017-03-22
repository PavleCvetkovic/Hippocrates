<?php
date_default_timezone_set("Europe/Belgrade");
include_once '../MySmarty.php';
include_once '../lib.php';
include_once '../Datum.php';
include_once '../Pacijent.php';
include_once '../IzabraniLekar.php';
include_once '../Termin.php';
session_start();
if(!isset($_SESSION['JMBG'])||!isset($_SESSION['isValid'])){
    header("Location: login.php");  
    die();
}
else if($_SESSION['isValid']==false){
        header("Location: login.php");
        die();
    }
    
$smarty= new MySmarty(); 
if(isset($_GET['datum'])){
    otkazi($_SESSION['JMBG'],$_GET['datum']);
}
$statusOtkazivanja="Uspešno ste otkazali termin za ".$_GET['datum'] ;

$smarty->assign("statusOtkazivanja",$statusOtkazivanja);
$smarty->display("otkazi.tpl");

?>