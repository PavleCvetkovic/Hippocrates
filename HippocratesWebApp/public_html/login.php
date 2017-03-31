<?php
    //set_include_path('/var/www/hippocrates.pavlecvetkovic.me/public_html');
    include_once '../lib.php';
    session_start();
    if(isset($_SESSION['isValid'])){
             if($_SESSION['email']!='' && $_SESSION['telefon']!='')
                header("Location: index.php");
             else
                header("Location: podesavanja.php");

    }
    if(isset($_POST['JMBG'])&&isset($_POST['LBO'])){ 
        if(check_login($_POST['JMBG'], $_POST['LBO'])) 
        { 
            $_SESSION['JMBG']=$_POST['JMBG']; 
            $_SESSION['LBO']=$_POST['LBO']; 
            $_SESSION['isValid']=true; 
            $_SESSION['email']=vratiEmailPacijenta($_SESSION['JMBG']);
            $_SESSION['telefon']= vratiTelefonPacijenta($_SESSION['JMBG']);
            header("Location: index.php");
            die();
            if($_SESSION['email']!='' && $_SESSION['telefon']!='')
                header("Location: index.php");
            else
                header("Location: podesavanja.php");
        } 
        else{ 
            session_destroy(); 
        } 
    }
     
    include_once '../MySmarty.php';
    $smarty=new MySmarty();
    $smarty->display("login.tpl");
?>