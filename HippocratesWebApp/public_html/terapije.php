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

$smarty=new MySmarty();
$nizTerapija= vratiTerapije($_SESSION["JMBG"]);
$smarty->assign("nizTerapija",$nizTerapija);
$smarty->display("terapije.tpl");
?>
