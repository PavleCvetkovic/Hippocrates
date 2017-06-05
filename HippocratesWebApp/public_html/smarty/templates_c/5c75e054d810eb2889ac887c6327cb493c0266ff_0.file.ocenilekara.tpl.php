<?php
/* Smarty version 3.1.30, created on 2017-03-31 17:56:38
  from "C:\xampp\htdocs\HippocratesWebApp\public_html\tpl\ocenilekara.tpl" */

/* @var Smarty_Internal_Template $_smarty_tpl */
if ($_smarty_tpl->_decodeProperties($_smarty_tpl, array (
  'version' => '3.1.30',
  'unifunc' => 'content_58de7c369bb568_69745057',
  'has_nocache_code' => false,
  'file_dependency' => 
  array (
    '5c75e054d810eb2889ac887c6327cb493c0266ff' => 
    array (
      0 => 'C:\\xampp\\htdocs\\HippocratesWebApp\\public_html\\tpl\\ocenilekara.tpl',
      1 => 1490974784,
      2 => 'file',
    ),
  ),
  'includes' => 
  array (
  ),
),false)) {
function content_58de7c369bb568_69745057 (Smarty_Internal_Template $_smarty_tpl) {
?>
<html lang="en">
  <head>
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <?php if ($_smarty_tpl->tpl_vars['status']->value) {?>
    <meta http-equiv="refresh" content="1;url=terapije.php">
    <?php }?>

    <link rel="icon" href="images/favicon.ico">

    <title>Hippocrates system</title>
    
    <link href="bootstrap-3.3.7-dist/css/bootstrap.min.css" rel="stylesheet">
    <link href="css/login.css" rel="stylesheet">
  </head>

  <body>

    <div class="container">
      <?php if ($_smarty_tpl->tpl_vars['status']->value) {?>
      <h1>Već ste ocenili svog izabranog lekara.</h1>
      <?php } else { ?>
      <h1>Oceni lekara</h1>
      <form class="form-signin" action="ocenilekara.php" method="post">
          <h3> Ocena: </h3>
         <select name='ocena'>
            <option value='1'>1</option>
            <option value='2'>2</option>
            <option value='3'>3</option>
            <option value='4'>4</option>
            <option value='5' selected>5</option>
         </select>
        <button class="btn btn-primary "  type="submit">Oceni</button>
      </form>
      <?php }?>
    </div> 

  </body>
</html>
<?php }
}
