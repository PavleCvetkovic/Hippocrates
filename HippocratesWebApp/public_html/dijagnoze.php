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
$listadijagnoza= vratiDijagnoze($_SESSION['JMBG']);
$smarty=new MySmarty();

$smarty->assign("nizDijagnoza",$listadijagnoza);
$smarty->display("dijagnoze.tpl");
?>
