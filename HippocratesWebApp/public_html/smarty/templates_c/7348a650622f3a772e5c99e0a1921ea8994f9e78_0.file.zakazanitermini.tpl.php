<?php
/* Smarty version 3.1.30, created on 2017-05-01 12:21:03
  from "C:\xampp\htdocs\HippocratesWebApp\public_html\tpl\zakazanitermini.tpl" */

/* @var Smarty_Internal_Template $_smarty_tpl */
if ($_smarty_tpl->_decodeProperties($_smarty_tpl, array (
  'version' => '3.1.30',
  'unifunc' => 'content_59070c0f70acc7_96931173',
  'has_nocache_code' => false,
  'file_dependency' => 
  array (
    '7348a650622f3a772e5c99e0a1921ea8994f9e78' => 
    array (
      0 => 'C:\\xampp\\htdocs\\HippocratesWebApp\\public_html\\tpl\\zakazanitermini.tpl',
      1 => 1493633815,
      2 => 'file',
    ),
  ),
  'includes' => 
  array (
  ),
),false)) {
function content_59070c0f70acc7_96931173 (Smarty_Internal_Template $_smarty_tpl) {
?>
<html>

<head>

    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, shrink-to-fit=no, initial-scale=1">
    <link rel="icon" href="images/favicon.ico">
    <title>Hippocrates system</title>

    <link href="bootstrap-3.3.7-dist/css/bootstrap.min.css" rel="stylesheet">

    <link href="css/index.css" rel="stylesheet">
</head>

<body>

    <div id="wrapper" class="toggled">
        <div id="sidebar-wrapper">
            <ul class="sidebar-nav">
                <li>
                    <a href="index.php">Zakaži</a>
                </li>
                <li>
                    <a href="zakazanitermini.php">Zakazani termini</a>
                </li>
                <li>
                    <a href="terapije.php">Terapije</a>
                </li>
                <li>
                    <a href="dijagnoze.php">Dijagnoze</a>
                </li>
                <li>
                    <a href="vakcine.php">Vakcine</a>
                </li>
                <li>
                    <a href="ocenilekara.php">Oceni lekara</a>
                </li>
                <li>
                    <a href="promenilekara.php">Promeni lekara</a>
                </li>
                <li>
                    <a href="podesavanja.php">Podešavanja</a>
                </li>
                <li>
                  <a href="logout.php">Izloguj se</a>
                </li>
            </ul>
        </div>


        <div id="page-content-wrapper">
            
            <div class="container-fluid">
                <div class="row">
                    <a href="#menu-toggle" class="btn btn-default" id="menu-toggle">Otvori\Zatvori meni</a>
                    <h1>Vaši zakazani termini</h1>
                    <div class="col-lg-12">
                        <table class="table-sm table table-hover table-striped table-responsive ">
                            <thead class="theadboja">
                                <tr>
                                    <th>
                                        DATUM
                                    </th>
                                    <th>
                                        VREME
                                    </th>
                                    <th>
                                        NAPOMENA
                                    </th>
                                    <th>
                                        OTKAŽI
                                    </th>
                                </tr>
                            </thead>
                                <?php
$_from = $_smarty_tpl->smarty->ext->_foreach->init($_smarty_tpl, $_smarty_tpl->tpl_vars['nizTermina']->value, 'termin');
if ($_from !== null) {
foreach ($_from as $_smarty_tpl->tpl_vars['termin']->value) {
?>
                                <tr>
                                    <td>
                                        <?php echo $_smarty_tpl->tpl_vars['termin']->value->datum;?>

                                    </td>
                                    <td>
                                        <?php echo $_smarty_tpl->tpl_vars['termin']->value->sat;?>
 : <?php echo $_smarty_tpl->tpl_vars['termin']->value->minut;?>

                                    </td>
                                    <td>
                                        <?php echo $_smarty_tpl->tpl_vars['termin']->value->napomena;?>

                                    </td>
                                    <td>
                                        <a class="btn btn-default" href="otkazi.php?datum=<?php echo $_smarty_tpl->tpl_vars['termin']->value->datum;?>
&vreme=<?php echo $_smarty_tpl->tpl_vars['termin']->value->vreme();?>
">OTKAŽI</a>
                                    </td>
                                </tr>
                                <?php
}
}
$_smarty_tpl->smarty->ext->_foreach->restore($_smarty_tpl);
?>

                            </thead>
                        </table>
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
</html><?php }
}
