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
if(isset($_POST['telefon'])){
    postaviTelefonPacijenta($_SESSION['JMBG'],$_POST['telefon']);
    postaviEmailPacijenta($_SESSION['JMBG'],$_POST['email']);
    $_SESSION['email']=vratiEmailPacijenta($_SESSION['JMBG']);
    $_SESSION['telefon']= vratiTelefonPacijenta($_SESSION['JMBG']);
    header("Location: index.php");
    die();
}
$telefon= vratiTelefonPacijenta($_SESSION['JMBG']);
$email= vratiEmailPacijenta($_SESSION['JMBG']);
$smarty = new MySmarty();
$smarty->assign("telefon",$telefon);
$smarty->assign("email",$email);
$smarty->display("podesavanja.tpl");
?>