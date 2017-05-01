<?php
/* Smarty version 3.1.30, created on 2017-03-24 17:59:21
  from "C:\xampp\htdocs\HippocratesWebApp\public_html\tpl\promenilekara.tpl" */

/* @var Smarty_Internal_Template $_smarty_tpl */
if ($_smarty_tpl->_decodeProperties($_smarty_tpl, array (
  'version' => '3.1.30',
  'unifunc' => 'content_58d5506990b054_24491801',
  'has_nocache_code' => false,
  'file_dependency' => 
  array (
    '934825c4b073aca3863d2b55c311124989c07347' => 
    array (
      0 => 'C:\\xampp\\htdocs\\HippocratesWebApp\\public_html\\tpl\\promenilekara.tpl',
      1 => 1490374757,
      2 => 'file',
    ),
  ),
  'includes' => 
  array (
  ),
),false)) {
function content_58d5506990b054_24491801 (Smarty_Internal_Template $_smarty_tpl) {
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
                    <h1>Zahtev za promenu lekara</h1>
                    <h3><?php echo $_smarty_tpl->tpl_vars['domZdravlja']->value->ime;?>
, <?php echo $_smarty_tpl->tpl_vars['domZdravlja']->value->adresa;?>
, <?php echo $_smarty_tpl->tpl_vars['domZdravlja']->value->lokacija;?>
</h3>
                    <div class="col-lg-12">
                        <table class="table-sm table table-hover table-striped table-responsive ">
                            <thead class="theadboja">
                                <tr>
                                    <th>
                                        IME
                                    </th>
                                    <th>
                                        PREZIME
                                    </th>
                                    <th>
                                        OCENA
                                    </th>
                                    <th>
                                        PODNESI ZAHTEV
                                    </th>
                                </tr>
                            </thead>
                                <?php
$_from = $_smarty_tpl->smarty->ext->_foreach->init($_smarty_tpl, $_smarty_tpl->tpl_vars['nizLekara']->value, 'lekar');
if ($_from !== null) {
foreach ($_from as $_smarty_tpl->tpl_vars['lekar']->value) {
?>
                                <form action="promeni.php" method="POST">
                                    <tr>
                                        <td>
                                            <?php echo $_smarty_tpl->tpl_vars['lekar']->value->ime;?>

                                        </td>
                                        <td>
                                            <?php echo $_smarty_tpl->tpl_vars['lekar']->value->prezime;?>

                                        </td>
                                        <td>
                                            <?php echo $_smarty_tpl->tpl_vars['lekar']->value->ocena;?>

                                        </td>
                                        <td>
                                            <input type="hidden" name="MATBRL" value="<?php echo $_smarty_tpl->tpl_vars['lekar']->value->jmbg;?>
" />
                                            <input type="submit" value="PROMENI" />
                                        </td>
                                    </tr>
                                </form>
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
