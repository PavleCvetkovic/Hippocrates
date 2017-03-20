<?php
/* Smarty version 3.1.30, created on 2017-03-19 23:22:50
  from "C:\xampp\htdocs\HippocratesWebApp\public_html\tpl\login.tpl" */

/* @var Smarty_Internal_Template $_smarty_tpl */
if ($_smarty_tpl->_decodeProperties($_smarty_tpl, array (
  'version' => '3.1.30',
  'unifunc' => 'content_58cf04ba518386_70046621',
  'has_nocache_code' => false,
  'file_dependency' => 
  array (
    '56dab4d93880839d4b9ccba3298f31b43b687e41' => 
    array (
      0 => 'C:\\xampp\\htdocs\\HippocratesWebApp\\public_html\\tpl\\login.tpl',
      1 => 1489962156,
      2 => 'file',
    ),
  ),
  'includes' => 
  array (
  ),
),false)) {
function content_58cf04ba518386_70046621 (Smarty_Internal_Template $_smarty_tpl) {
?>
<html lang="en">
  <head>
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">

    <link rel="icon" href="images/favicon.ico">

    <title>Hippocrates prijava</title>
    
    <link href="bootstrap-3.3.7-dist/css/bootstrap.min.css" rel="stylesheet">
    <link href="css/login.css" rel="stylesheet">
  </head>

  <body>

    <div class="container">
      <h1>Hippocrates</h1>
      <img src="images/logo.jpg" />
      <form class="form-signin">
        <h2 class="form-signin-heading">Molimo prijavite se</h2>
        <input type="number" id="JMBG" class="form-control" placeholder="JMBG" required autofocus>
        <input  type="number" id="LBO" class="form-control" placeholder="LBO" required>
        <button class="btn btn-lg btn-primary btn-block" id="loginbtn" type="submit">Prijava</button>
      </form>

    </div> 

  </body>
</html>
<?php }
}
