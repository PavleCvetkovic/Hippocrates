<?php
//set_include_path('/var/www/hippocrates.pavlecvetkovic.me/public_html');
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
    
if(!isset($_GET['dan']))
{
    if(date(H)>20)
        $datum=new Datum (date('d')+1, date('m'),date('Y'));
    else
        $datum=new Datum(date('d'),date('m'),date('Y'));
}
else
    $datum=new Datum($_GET['dan'],$_GET['mesec'],date('Y'));
if($datum->mesec<date('m'))
    header("Location: index.php");
if(($datum->mesec==date('m'))&&($datum->dan< date('d')))
    header("Location: index.php");
if(!checkdate($datum->mesec, $datum->dan, $datum->godina))
    header("Location: index.php");

$izabranilekar= vratiIzabranogLekara($_SESSION['JMBG']);
$pacijent=vratiPacijenta($_SESSION['JMBG']);
$smena=$izabranilekar->smena;

//generisanje termina za datum
$listatermina=array();
$k=0;
$pocetnisat=7;
$pocetniminut=0;
if($smena==2)
{    $pocetnisat=13;$pocetniminut=30;}
for($i=0;$i<26;$i++){
    if(slobodanTermin($izabranilekar->jmbg,$datum,$pocetnisat*100+$pocetniminut)){
       if($datum->dan==date('d')&&$datum->mesec==date('m'))
       { if($pocetnisat>date('H'))
           if(!((($pocetnisat==9&&$pocetniminut==30)||($pocetnisat==9&&$pocetniminut==45))||(($pocetnisat==16&&$pocetniminut==30)||($pocetnisat==16&&$pocetniminut==45))))
               $listatermina[$k++]=new Termin($pocetnisat,$pocetniminut,$datum);
       }
       else{
           if(!((($pocetnisat==9&&$pocetniminut==30)||($pocetnisat==9&&$pocetniminut==45))||(($pocetnisat==16&&$pocetniminut==30)||($pocetnisat==16&&$pocetniminut==45))))
               $listatermina[$k++]=new Termin($pocetnisat,$pocetniminut,$datum);
       }
    }
    $pocetniminut+=15;
    if($pocetniminut==60)
    {
        $pocetniminut=0;
        $pocetnisat++;
    }
}




$smarty=new MySmarty();
$smarty->assign("listatermina",$listatermina);
$smarty->assign("pacijent",$pacijent);
$smarty->assign("izabranilekar",$izabranilekar);
$smarty->display("index.tpl");

?>