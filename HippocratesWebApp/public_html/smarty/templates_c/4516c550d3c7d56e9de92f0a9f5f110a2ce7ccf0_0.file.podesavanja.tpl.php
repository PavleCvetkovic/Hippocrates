<?php
/* Smarty version 3.1.30, created on 2017-03-29 17:21:29
  from "C:\xampp\htdocs\HippocratesWebApp\public_html\tpl\podesavanja.tpl" */

/* @var Smarty_Internal_Template $_smarty_tpl */
if ($_smarty_tpl->_decodeProperties($_smarty_tpl, array (
  'version' => '3.1.30',
  'unifunc' => 'content_58dbd0f9965145_72385541',
  'has_nocache_code' => false,
  'file_dependency' => 
  array (
    '4516c550d3c7d56e9de92f0a9f5f110a2ce7ccf0' => 
    array (
      0 => 'C:\\xampp\\htdocs\\HippocratesWebApp\\public_html\\tpl\\podesavanja.tpl',
      1 => 1490800887,
      2 => 'file',
    ),
  ),
  'includes' => 
  array (
  ),
),false)) {
function content_58dbd0f9965145_72385541 (Smarty_Internal_Template $_smarty_tpl) {
?>
<html lang="en">
  <head>
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">

    <link rel="icon" href="images/favicon.ico">

    <title>Hippocrates podešavanja</title>
    
    <link href="bootstrap-3.3.7-dist/css/bootstrap.min.css" rel="stylesheet">
    <link href="css/login.css" rel="stylesheet">
  </head>

  <body>

    <div class="container">
      <h1>Podešavanja</h1>
      <h3>Da bi ste koristili aplikaciju morate imati podešen telefon i email.</h3>
      <form class="form-signin" action="podesavanja.php" method="post">
        <h2 class="form-signin-heading">Telefon/Email</h2>
        <input name="telefon" type="tel"  class="form-control" placeholder="Telefon" value="<?php echo $_smarty_tpl->tpl_vars['telefon']->value;?>
" required autofocus>
        <input  name="email" type="email" i class="form-control" placeholder="Email" value="<?php echo $_smarty_tpl->tpl_vars['email']->value;?>
" required>
        <button class="btn btn-lg btn-primary btn-block"  type="submit">Sačuvaj</button>
      </form>

    </div> 

  </body>
</html>
<?php }
}
