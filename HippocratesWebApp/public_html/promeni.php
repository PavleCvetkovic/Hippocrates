<?php
include_once '../MySmarty.php';
include_once '../lib.php';
session_start();
if(!isset($_SESSION['isValid'])){
    header("Location: login.php");
    die();
}
else{
     if(!(strlen($_SESSION['email'])>0 && strlen($_SESSION['telefon'])>0))
            header("Location: podesavanja.php");

}
if(!isset($_POST['MATBRL'])){
    header("Location: index.php");
    die();
}
$status= zahtevZaPromenu($_SESSION['JMBG'], $_POST['MATBRL']);
$smarty=new MySmarty();
$smarty->assign("status",$status);
$smarty->display("promeni.tpl");

?>
