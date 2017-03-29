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
    
$dan=$_GET['dan'];
$mesec=$_GET['mesec'];
$sat=$_GET['sat'];
$minut=$_GET['minut'];
$napomena=$_GET['napomena'];
$godina=date("Y");
$termin=new Termin($sat,$minut,new Datum($dan,$mesec,$godina));
$statusZakazivanja="USPEŠNO STE ZAKAZALI TERMIN";
$status=zakazi($_SESSION['JMBG'],$termin,$napomena);
$terminText=$termin->datum->dan.'/'.$termin->datum->mesec.'/'.$termin->datum->godina." ".$termin->sat.":".$termin->minut;
if($status==FALSE)
    $statusZakazivanja="NEMATE PRAVO DA ZAKAŽETE";
$smarty=new MySmarty();
$smarty->assign("statusZakazivanja",$statusZakazivanja);
$smarty->assign("status",$status);
$smarty->assign("terminText",$terminText);
$smarty->display("zakazi.tpl");


?>