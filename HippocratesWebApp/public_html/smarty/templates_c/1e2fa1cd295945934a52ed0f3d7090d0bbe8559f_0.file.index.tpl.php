<?php
/* Smarty version 3.1.30, created on 2017-03-20 22:21:20
  from "C:\xampp\htdocs\HippocratesWebApp\public_html\tpl\index.tpl" */

/* @var Smarty_Internal_Template $_smarty_tpl */
if ($_smarty_tpl->_decodeProperties($_smarty_tpl, array (
  'version' => '3.1.30',
  'unifunc' => 'content_58d047d0941aa9_56086365',
  'has_nocache_code' => false,
  'file_dependency' => 
  array (
    '1e2fa1cd295945934a52ed0f3d7090d0bbe8559f' => 
    array (
      0 => 'C:\\xampp\\htdocs\\HippocratesWebApp\\public_html\\tpl\\index.tpl',
      1 => 1490044877,
      2 => 'file',
    ),
  ),
  'includes' => 
  array (
  ),
),false)) {
function content_58d047d0941aa9_56086365 (Smarty_Internal_Template $_smarty_tpl) {
?>
<html>

<head>

    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, shrink-to-fit=no, initial-scale=1">
    <title>Hippocrates system</title>

    <link href="bootstrap-3.3.7-dist/css/bootstrap.min.css" rel="stylesheet">

    <link href="css/index.css" rel="stylesheet">
</head>

<body>

    <div id="wrapper">

        <div id="sidebar-wrapper">
            <ul class="sidebar-nav">
                <li>
                    <a href="#">Zakaži</a>
                </li>
                <li>
                    <a href="#">Terapije</a>
                </li>
                <li>
                    <a href="#">Dijagnoze</a>
                </li>
                <li>
                    <a href="#">Vakcine</a>
                </li>
                <li>
                    <a href="#">Promeni lekara</a>
                </li>
                <li>
                  <a href="logout.php">Izloguj se</a>
                </li>
            </ul>
        </div>


        <div id="page-content-wrapper">
            <div class="container-fluid">
                <div class="row">
                    <a href="#menu-toggle" class="btn btn-default" id="menu-toggle">Otvori\Zatvori meni</a><p id="labelime"><?php echo $_smarty_tpl->tpl_vars['ime']->value;?>
 <?php echo $_smarty_tpl->tpl_vars['prezime']->value;?>
 <?php echo $_smarty_tpl->tpl_vars['izabranilekar']->value;?>
 </p>
                    <h1>Zakaži</h1>
                    <div class="col-lg-12">


                    </div>
                </div>
            </div>
        </div>


    </div>

    <?php echo '<script'; ?>
 src="bootstrap-3.3.7-dist/js/jquery.js"><?php echo '</script'; ?>
>

    <?php echo '<script'; ?>
 src="bootstrap-3.3.7-dist/js/bootstrap.min.js"><?php echo '</script'; ?>
>

    <?php echo '<script'; ?>
>
    $("#menu-toggle").click(function(e) {
        e.preventDefault();
        $("#wrapper").toggleClass("toggled");
    });
    <?php echo '</script'; ?>
>

</body>

</html>
<?php }
}
