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
                    <a href="#menu-toggle" class="btn btn-default" id="menu-toggle">Otvori\Zatvori meni</a><p id="labelime">Dobrodošli: [[$pacijent->ime]] [[$pacijent->prezime]] Vaš izabrani lekar: [[$izabranilekar->ime]] [[$izabranilekar->prezime]] </p>
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
                        [[if $status]]
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
                                [[foreach $listatermina as $termin]]
                                <tr>
                                <form action='zakazi.php' method='GET'>
                                    <td>
                                        [[$termin->datum->dan]]/[[$termin->datum->mesec]]/[[$termin->datum->godina]]
                                        <input type="hidden" name="dan" value='[[$termin->datum->dan]]' />
                                        <input type="hidden" name="mesec" value='[[$termin->datum->mesec]]' />
                                    </td>
                                    <td>
                                        [[$termin->sat]] : [[$termin->minut]]
                                        <input type="hidden" name="sat" value='[[$termin->sat]]' />
                                        <input type="hidden" name="minut" value='[[$termin->minut]]' />
                                    </td>
                                    <td>
                                        <input type='text' name='napomena'/>
                                    </td>
                                    <td>
                                        <input type='submit' value='Zakaži' /> 
                                    </td>
                                </form>
                                </tr>
                                [[/foreach]]
                        </table>
                        [[else]]
                        <h3>Još uvek nije određena smena lekara za taj datum.</h3>
                        [[/if]]
                    </div>
                </div>
            </div>
        </div>


    </div>

    <script src="bootstrap-3.3.7-dist/js/jquery.js"></script>

    <script src="bootstrap-3.3.7-dist/js/bootstrap.min.js"></script>

    <script>
    $("#menu-toggle").click(function(e) {
        e.preventDefault();
        $("#wrapper").toggleClass("toggled");
    });
    </script>

</body>

</html>
