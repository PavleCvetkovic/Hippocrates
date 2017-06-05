<?php
date_default_timezone_set("Europe/Belgrade");
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

$nizLekara= vratiLekareIzDomaZdravljaPacijenta($_SESSION['JMBG']);
$domZdravlja= vratiDomZdravljaPacijenta($_SESSION['JMBG']);

$smarty=new MySmarty();

$smarty->assign("domZdravlja",$domZdravlja);
$smarty->assign("nizLekara",$nizLekara);
$smarty->display("promenilekara.tpl");

?>