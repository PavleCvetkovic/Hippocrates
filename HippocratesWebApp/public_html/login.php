<?php
    //set_include_path('/var/www/hippocrates.pavlecvetkovic.me/public_html');
    include_once '../lib.php';
    session_start();
    if(!isset($_SESSION['isValid'])){
        header("Location: login.php");
        die();
    }

    include_once '../MySmarty.php';
    $smarty=new MySmarty();
    $smarty->display("login.tpl");
?>