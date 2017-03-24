<?php
    //set_include_path('/var/www/hippocrates.pavlecvetkovic.me/public_html');
    include_once '../lib.php';
    session_start();
    if(isset($_SESSION['isValid'])){
        header("Location: index.php");
        die();
    }
    if(isset($_POST['JMBG'])&&isset($_POST['LBO'])){ 
        if(check_login($_POST['JMBG'], $_POST['LBO'])) 
        { 
            $_SESSION['JMBG']=$_POST['JMBG']; 
            $_SESSION['LBO']=$_POST['LBO']; 
            $_SESSION['isValid']=true; 
            header("Location: index.php"); 
        } 
        else{ 
            session_destroy(); 
        } 
    }
    include_once '../MySmarty.php';
    $smarty=new MySmarty();
    $smarty->display("login.tpl");
?>