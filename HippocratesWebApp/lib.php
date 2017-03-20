<?php
include_once 'IzabraniLekar.php';
include_once 'Pacijent.php';
function check_login($jmbg,$lbo){
    $con = new mysqli("139.59.132.29", "paja", "pajapro1234", "Hippocrates");
    if ($con->connect_errno) {
        // u slucaju greske odstampati odgovarajucu poruku
        print ("Connection error (" . $con->connect_errno . "): $con->connect_error");
    }
    else{
        $res=$con->query("SELECT * FROM PACIJENT WHERE JMBG='$jmbg' AND LBO='$lbo'");
        if ($res) {
            $row = $res->fetch_assoc();
            if($row['LBO']==$lbo&&$row['JMBG']==$jmbg)
            {
                return true;
            }
        }
        else
        {
            print("QUERY FAILED");
            return false;
        }
        $con->close();
    }
}
function vratiIzabranogLekara($matbrpacijenta){
     $con = new mysqli("139.59.132.29", "paja", "pajapro1234", "Hippocrates");
    if ($con->connect_errno) {
        print ("Connection error (" . $con->connect_errno . "): $con->connect_error");
    }
    else{
        $res=$con->query("SELECT * FROM PACIJENT WHERE JMBG=$matbrpacijenta");
        if ($res) {
            $row = $res->fetch_assoc();
            if($row)
            {
                $matbrl=$row['MATBRL'];
                $res2=$con->query("SELECT * FROM IZABRANI_LEKAR WHERE JMBG='$matbrl'");
                $row2=$res2->fetch_assoc();
                $lekar=new IzabraniLekar($row2['JMBG'],$row2['IME'],$row2['SREDNJE_SLOVO'],$row2['PREZIME'],$row2['DATUM_ROĐENJA'],$row2['MBRZU'],$row2['SMENA']);
                return $lekar;
            }
        }
        else
        {
            print("QUERY FAILED");
        }
        $con->close();
    }
}
function vratiPacijenta($matbrpacijenta){
    $con = new mysqli("139.59.132.29", "paja", "pajapro1234", "Hippocrates");
    if ($con->connect_errno) {
        // u slucaju greske odstampati odgovarajucu poruku
        print ("Connection error (" . $con->connect_errno . "): $con->connect_error");
    }
    else{
        $res=$con->query("SELECT * FROM PACIJENT WHERE JMBG='$matbrpacijenta'");
        if ($res) {
            $row = $res->fetch_assoc();
            if($row)
            {
                $pacijent=new Pacijent($row['JMBG'],$row['LBO'],$row['IME'],$row['PREZIME'],$row['SREDNJE_SLOVO'],$row['DATUM_ROĐENJA'],$row['PRAVO_DA_ZAKAZE'],$row['MATBRL'],$row['VAZI_DO']);
                return $pacijent;
            }
        }
        else
        {
            print("QUERY FAILED");
        }
        $con->close();
    }
}
function vrati_sve_iz_tabele() {
    // funkcija za konektovanje na bazu podataka
    // parametri su server_baze, username, password, ime_baze
    $con = new mysqli("localhost", "root", "", "ime_baze");
    if ($con->connect_errno) {
        // u slucaju greske odstampati odgovarajucu poruku
        print ("Connection error (" . $con->connect_errno . "): $con->connect_error");
    }
    else {
        // $res je rezultat izvrsenja upita
        $res = $con->query("select * from ime_tabele");
        if ($res) {
            $niz = array();
            // fetch_assoc() pribavlja jedan po jedan red iz rezulata 
			// u redosledu u kom ga je vratio db server
            while ($row = $res->fetch_assoc()) {
				
				// TODO: DODATI KOD ZA SMESTANJE PODATAKA U ASOCIJATIVNI NIZ!!!!

            }
            // zatvaranje objekta koji cuva rezultat
            $res->close();
            return $niz;
        }
        else
        {
            print ("Query failed");
        }
    }
}


?>
