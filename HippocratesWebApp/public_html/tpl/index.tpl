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
                    <a href="#menu-toggle" class="btn btn-default" id="menu-toggle">Otvori\Zatvori meni</a><p id="labelime">[[$ime]] [[$prezime]] [[$izabranilekar]] </p>
                    <h1>Zakaži</h1>
                    <div class="col-lg-12">


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
