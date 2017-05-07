<html lang="en">
  <head>
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <link rel="icon" href="images/favicon.ico">
    [[if $status]]
    <meta http-equiv="refresh" content="1;url=terapije.php">
    [[/if]]

    <link rel="icon" href="images/favicon.ico">

    <title>Hippocrates system</title>
    
    <link href="bootstrap-3.3.7-dist/css/bootstrap.min.css" rel="stylesheet">
    <link href="css/login.css" rel="stylesheet">
  </head>

  <body>

    <div class="container">
      [[if $status]]
      <h1>Već ste ocenili svog izabranog lekara.</h1>
      [[else]]
      <h1>Oceni lekara</h1>
      <form class="form-signin" action="ocenilekara.php" method="post">
          <h3> Ocena: </h3>
         <select name='ocena'>
            <option value='1'>1</option>
            <option value='2'>2</option>
            <option value='3'>3</option>
            <option value='4'>4</option>
            <option value='5' selected>5</option>
         </select>
        <button class="btn btn-primary "  type="submit">Oceni</button>
      </form>
      [[/if]]
    </div> 

  </body>
</html>
