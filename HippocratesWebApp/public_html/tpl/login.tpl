<html lang="en">
  <head>
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">

    <link rel="icon" href="images/favicon.ico">

    <title>Hippocrates prijava</title>
    
    <link href="bootstrap-3.3.7-dist/css/bootstrap.min.css" rel="stylesheet">
    <link href="css/login.css" rel="stylesheet">
  </head>

  <body>

    <div class="container">
      <h1>Hippocrates</h1>
      <img src="images/logo.jpg" />
      <form class="form-signin" action="login.php" method="post">
        <h2 class="form-signin-heading">Molimo prijavite se</h2>
        <input name="JMBG" type="number" id="JMBG" class="form-control" placeholder="JMBG" required autofocus>
        <input  name="LBO" type="number" id="LBO" class="form-control" placeholder="LBO" required>
        <button class="btn btn-lg btn-primary btn-block" id="loginbtn" type="submit">Prijava</button>
      </form>

    </div> 

  </body>
</html>
