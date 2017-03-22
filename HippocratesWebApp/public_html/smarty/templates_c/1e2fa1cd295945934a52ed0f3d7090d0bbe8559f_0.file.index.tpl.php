<?php
/* Smarty version 3.1.30, created on 2017-03-22 15:18:12
  from "C:\xampp\htdocs\HippocratesWebApp\public_html\tpl\index.tpl" */

/* @var Smarty_Internal_Template $_smarty_tpl */
if ($_smarty_tpl->_decodeProperties($_smarty_tpl, array (
  'version' => '3.1.30',
  'unifunc' => 'content_58d287a49493e7_88929001',
  'has_nocache_code' => false,
  'file_dependency' => 
  array (
    '1e2fa1cd295945934a52ed0f3d7090d0bbe8559f' => 
    array (
      0 => 'C:\\xampp\\htdocs\\HippocratesWebApp\\public_html\\tpl\\index.tpl',
      1 => 1490191320,
      2 => 'file',
    ),
  ),
  'includes' => 
  array (
  ),
),false)) {
function content_58d287a49493e7_88929001 (Smarty_Internal_Template $_smarty_tpl) {
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
                  <a href="logout.php">Izloguj se</a>
                </li>
            </ul>
        </div>


        <div id="page-content-wrapper">
            <div class="container-fluid">
                <div class="row">
                    <a href="#menu-toggle" class="btn btn-default" id="menu-toggle">Otvori\Zatvori meni</a><p id="labelime">Dobrodošli: <?php echo $_smarty_tpl->tpl_vars['pacijent']->value->ime;?>
 <?php echo $_smarty_tpl->tpl_vars['pacijent']->value->prezime;?>
 Vaš izabrani lekar: <?php echo $_smarty_tpl->tpl_vars['izabranilekar']->value->ime;?>
 <?php echo $_smarty_tpl->tpl_vars['izabranilekar']->value->prezime;?>
 </p>
                    <h1>Zakaži</h1>
                    <div class="col-lg-12">
                        <form action="index.php" method="GET">
                            <h4>Izaberi datum</h4>
                            <select name='dan'>
                                <option value='1'>1</option>
                                <option value='2'>2</option>
                                <option value='3'>3</option>
                                <option value='4'>4</option>
                                <option value='5'>5</option>
                                <option value='6'>6</option>
                                <option value='7'>7</option>
                                <option value='8'>8</option>
                                <option value='9'>9</option>
                                <option value='10'>10</option>
                                <option value='11'>11</option>
                                <option value='12'>12</option>
                                <option value='13'>13</option>
                                <option value='14'>14</option>
                                <option value='15'>15</option>
                                <option value='16'>16</option>
                                <option value='17'>17</option>
                                <option value='18'>18</option>
                                <option value='19'>19</option>
                                <option value='20'>20</option>
                                <option value='21'>21</option>
                                <option value='22'>22</option>
                                <option value='23'>23</option>
                                <option value='24'>24</option>
                                <option value='25'>25</option>
                                <option value='26'>26</option>
                                <option value='27'>27</option>
                                <option value='28'>28</option>
                                <option value='29'>29</option>
                                <option value='30'>30</option>
                                <option value='31'>31</option>
                            </select>
                            <select name='mesec'>
                                <option value='1'>1</option>
                                <option value='2'>2</option>
                                <option value='3'>3</option>
                                <option value='4'>4</option>
                                <option value='5'>5</option>
                                <option value='6'>6</option>
                                <option value='7'>7</option>
                                <option value='8'>8</option>
                                <option value='9'>9</option>
                                <option value='10'>10</option>
                                <option value='11'>11</option>
                                <option value='12'>12</option>
                            </select>
                            <button class="btn btn-default" id="btnizaberi" type="submit">Izaberi</button>
                        </form>
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
                                        ZAKAŽI
                                    </th>
                                </tr>
                            </thead>
                                <?php
$_from = $_smarty_tpl->smarty->ext->_foreach->init($_smarty_tpl, $_smarty_tpl->tpl_vars['listatermina']->value, 'termin');
if ($_from !== null) {
foreach ($_from as $_smarty_tpl->tpl_vars['termin']->value) {
?>
                                <tr>
                                <form action='zakazi.php' method='GET'>
                                    <td>
                                        <?php echo $_smarty_tpl->tpl_vars['termin']->value->datum->dan;?>
/<?php echo $_smarty_tpl->tpl_vars['termin']->value->datum->mesec;?>
/<?php echo $_smarty_tpl->tpl_vars['termin']->value->datum->godina;?>

                                        <input type="hidden" name="dan" value='<?php echo $_smarty_tpl->tpl_vars['termin']->value->datum->dan;?>
' />
                                        <input type="hidden" name="mesec" value='<?php echo $_smarty_tpl->tpl_vars['termin']->value->datum->mesec;?>
' />
                                    </td>
                                    <td>
                                        <?php echo $_smarty_tpl->tpl_vars['termin']->value->sat;?>
 : <?php echo $_smarty_tpl->tpl_vars['termin']->value->minut;?>

                                        <input type="hidden" name="sat" value='<?php echo $_smarty_tpl->tpl_vars['termin']->value->sat;?>
' />
                                        <input type="hidden" name="minut" value='<?php echo $_smarty_tpl->tpl_vars['termin']->value->minut;?>
' />
                                    </td>
                                    <td>
                                        <input type='text' name='napomena'/>
                                    </td>
                                    <td>
                                        <input type='submit' value='Zakaži' /> 
                                    </td>
                                </form>
                                </tr>
                                <?php
}
}
$_smarty_tpl->smarty->ext->_foreach->restore($_smarty_tpl);
?>

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

</html>
<?php }
}
