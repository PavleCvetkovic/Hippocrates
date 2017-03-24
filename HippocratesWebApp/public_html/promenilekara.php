<?php
date_default_timezone_set("Europe/Belgrade");
include_once '../MySmarty.php';
include_once '../lib.php';
session_start();
if(!isset($_SESSION['isValid'])){
    header("Location: login.php");
    die();
}

$nizLekara= vratiLekareIzDomaZdravljaPacijenta($_SESSION['JMBG']);
$domZdravlja= vratiDomZdravljaPacijenta($_SESSION['JMBG']);

$smarty=new MySmarty();

$smarty->assign("domZdravlja",$domZdravlja);
$smarty->assign("nizLekara",$nizLekara);
$smarty->display("promenilekara.tpl");

?>