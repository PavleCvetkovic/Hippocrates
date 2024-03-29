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
                                [[foreach $nizTermina as $termin]]
                                <tr>
                                    <td>
                                        [[$termin->datum]]
                                    </td>
                                    <td>
                                        [[$termin->sat]] : [[$termin->minut]]
                                    </td>
                                    <td>
                                        [[$termin->napomena]]
                                    </td>
                                    <td>
                                        <a class="btn btn-default" href="otkazi.php?datum=[[$termin->datum]]&vreme=[[$termin->vreme()]]">OTKAŽI</a>
                                    </td>
                                </tr>
                                [[/foreach]]
                            </thead>
                        </table>
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