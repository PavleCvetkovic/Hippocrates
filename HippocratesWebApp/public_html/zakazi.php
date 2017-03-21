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
    
$dan=$_GET['dan'];
$mesec=$_GET['mesec'];
$sat=$_GET['sat'];
$minut=$_GET['minut'];
$napomena=$_GET['napomena'];
$godina=date("Y");
$termin=new Termin($sat,$minut,new Datum($dan,$mesec,$godina));

zakazi($_SESSION['JMBG'],$termin,$napomena);
?>