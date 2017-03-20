<?php
//set_include_path('/var/www/hippocrates.pavlecvetkovic.me/public_html');


include_once '../MySmarty.php';
$smarty=new MySmarty();
$smarty->display("login.tpl");
?>
