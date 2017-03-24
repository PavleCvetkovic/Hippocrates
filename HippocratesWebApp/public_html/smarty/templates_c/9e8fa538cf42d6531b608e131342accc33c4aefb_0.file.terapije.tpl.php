<?php
/* Smarty version 3.1.30, created on 2017-03-24 13:36:21
  from "C:\xampp\htdocs\HippocratesWebApp\public_html\tpl\terapije.tpl" */

/* @var Smarty_Internal_Template $_smarty_tpl */
if ($_smarty_tpl->_decodeProperties($_smarty_tpl, array (
  'version' => '3.1.30',
  'unifunc' => 'content_58d512c5651a74_22515821',
  'has_nocache_code' => false,
  'file_dependency' => 
  array (
    '9e8fa538cf42d6531b608e131342accc33c4aefb' => 
    array (
      0 => 'C:\\xampp\\htdocs\\HippocratesWebApp\\public_html\\tpl\\terapije.tpl',
      1 => 1490358977,
      2 => 'file',
    ),
  ),
  'includes' => 
  array (
  ),
),false)) {
function content_58d512c5651a74_22515821 (Smarty_Internal_Template $_smarty_tpl) {
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
                    <h1>Vaše terapije</h1>
                    <div class="col-lg-12">
                        <table class="table-sm table table-hover table-striped table-responsive ">
                            <thead class="theadboja">
                                <tr>
                                    <th>
                                        IME DIJAGNOZE
                                    </th>
                                    <th>
                                        OPIS TERAPIJE
                                    </th>
                                    <th>
                                        DATUM_OD
                                    </th>
                                    <th>
                                        DATUM_DO
                                    </th>
                                </tr>
                            </thead>
                                <?php
$_from = $_smarty_tpl->smarty->ext->_foreach->init($_smarty_tpl, $_smarty_tpl->tpl_vars['nizTerapija']->value, 'terapija');
if ($_from !== null) {
foreach ($_from as $_smarty_tpl->tpl_vars['terapija']->value) {
?>
                                <tr>
                                    <td>
                                        <?php echo $_smarty_tpl->tpl_vars['terapija']->value->dijagnoza->ime;?>

                                    </td>
                                    <td>
                                        <?php echo $_smarty_tpl->tpl_vars['terapija']->value->opis;?>

                                    </td>
                                    <td>
                                        <?php echo $_smarty_tpl->tpl_vars['terapija']->value->datumOd;?>

                                    </td>
                                    <td>
                                        <?php echo $_smarty_tpl->tpl_vars['terapija']->value->datumDo;?>

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
