<?php
//set_include_path('/var/www/hippocrates.pavlecvetkovic.me/public_html');
include_once '../MySmarty.php';
include_once '../lib.php';
session_start();
if(!isset($_SESSION['JMBG'])||!isset($_SESSION['isValid'])){
    header("Location: login.php");  
    die();
    }
else if($_SESSION['isValid']==false){
        header("Location: login.php");
        die();
    }
$smarty=new MySmarty();
$izabranilekar= vratiIzabranogLekara($_SESSION['JMBG']);
$pacijent=vratiPacijenta($_SESSION['JMBG']);
$smarty->assign("ime",$pacijent->ime);
$smarty->assign("prezime",$pacijent->datum_rodjenja);
$smarty->assign(IzabraniLekar,$izabranilekar->ime . $izabranilekar->prezime);
$smarty->display("index.tpl");

?>
