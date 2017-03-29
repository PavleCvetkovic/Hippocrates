<html lang="en">
  <head>
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">

    <link rel="icon" href="images/favicon.ico">

    <title>Hippocrates podešavanja</title>
    
    <link href="bootstrap-3.3.7-dist/css/bootstrap.min.css" rel="stylesheet">
    <link href="css/login.css" rel="stylesheet">
  </head>

  <body>

    <div class="container">
      <h1>Podešavanja</h1>
      <h3>Da bi ste koristili aplikaciju morate imati podešen telefon i email.</h3>
      <form class="form-signin" action="podesavanja.php" method="post">
        <h2 class="form-signin-heading">Telefon/Email</h2>
        <input name="telefon" type="tel"  class="form-control" placeholder="Telefon" value="[[$telefon]]" required autofocus>
        <input  name="email" type="email" i class="form-control" placeholder="Email" value="[[$email]]" required>
        <button class="btn btn-lg btn-primary btn-block"  type="submit">Sačuvaj</button>
      </form>

    </div> 

  </body>
</html>
