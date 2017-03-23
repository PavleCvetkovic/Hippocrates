<?php
include_once 'IzabraniLekar.php';
include_once 'Pacijent.php';
include_once 'Terapija.php';
include_once 'Dijagnoza.php';
include_once 'Dijagnostifikovano.php';
function check_login($jmbg,$lbo){
    $con = new mysqli("139.59.132.29", "paja", "pajapro1234", "Hippocrates");
    $con->set_charset('utf8mb4');
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
     $con->set_charset('utf8mb4');
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
function vratiDijagnoze($matbrp){
    $con = new mysqli("139.59.132.29", "paja", "pajapro1234", "Hippocrates");
    $con->set_charset('utf8mb4');
    if ($con->connect_errno) {
        // u slucaju greske odstampati odgovarajucu poruku
        print ("Connection error (" . $con->connect_errno . "): $con->connect_error");
    }
    else{
        $res=$con->query("SELECT * FROM DIJAGNOSTIFIKOVANO,DIJAGNOZA WHERE DIJAGNOSTIFIKOVANO.MATBRP='$matbrp' AND DIJAGNOZA.ŠIFRA=DIJAGNOSTIFIKOVANO.ŠIFRA_DIJAGNOZE;");
        if ($res) {
            $nizdijagnoza=array();
            $k=0;
            while($row=$res->fetch_assoc()){
                $dijagnoza=new Dijagnostifikovano($row['ŠIFRA_DIJAGNOZE'],$row['IME'],$row['DATUM']);
                $nizdijagnoza[$k++]=$dijagnoza;
            }
            return $nizdijagnoza;
        }
        $con->close();
        }
}
function vratiTerapije($matbrp){
    $con = new mysqli("139.59.132.29", "paja", "pajapro1234", "Hippocrates");
    $con->set_charset('utf8mb4');
    if ($con->connect_errno) {
        // u slucaju greske odstampati odgovarajucu poruku
        print ("Connection error (" . $con->connect_errno . "): $con->connect_error");
    }
    else{
        $res=$con->query("SELECT * FROM TERAPIJA WHERE MATBRP='$matbrp';");
        if ($res) {
            $nizterapija=array();
            $k=0;
            while($row=$res->fetch_assoc()){
                $terapija= new Terapija($row['OPIS'],$row['DATUM_OD'],$row['DATUM_DO']);
                $sifradijagnoze=$row['ŠIFRA_DIJAGNOZE'];
                $res2=$con->query("SELECT * FROM DIJAGNOZA WHERE ŠIFRA='$sifradijagnoze';");
                $row2=$res2->fetch_assoc();
                $dijagnoza=new Dijagnoza($row2['ŠIFRA'],$row2['IME']);
                $terapija->dijagnoza=$dijagnoza;
                $nizterapija[$k++]=$terapija;
            }
            return $nizterapija;
        }
        $con->close();
}
}
function vratiZakazaneTermine($matbrp){
    $con = new mysqli("139.59.132.29", "paja", "pajapro1234", "Hippocrates");
    $con->set_charset('utf8mb4');
    if ($con->connect_errno) {
        // u slucaju greske odstampati odgovarajucu poruku
        print ("Connection error (" . $con->connect_errno . "): $con->connect_error");
    }
    else{
        $danas=date("Y")."-".date("m").'-'.date("d");
        $res=$con->query("SELECT DATE_FORMAT(DATUM, '%d/%m/%Y') AS DATUM,VREME,NAPOMENA FROM TERMIN WHERE MATBRP='$matbrp' AND DATUM>='$danas'ORDER BY DATUM DESC;");
        if ($res) {
            $nizTermina=array();
            $k=0;
            while($row=$res->fetch_assoc()){
                $vreme=$row['VREME'];
                $sat=floor($vreme/100);
                $minut=$vreme%100;
                
               $termin=new Termin($sat,$minut,$row['DATUM']);
               $termin->dodajNapomenu($row['NAPOMENA']);
               $nizTermina[$k++]=$termin;
            }
            return $nizTermina;
        }   
        $con->close();
    }
}
function slobodanTermin($matbrl,Datum $datum,$vreme){
    $con = new mysqli("139.59.132.29", "paja", "pajapro1234", "Hippocrates");
    $con->set_charset('utf8mb4');
    if ($con->connect_errno) {
        // u slucaju greske odstampati odgovarajucu poruku
        print ("Connection error (" . $con->connect_errno . "): $con->connect_error");
    }
    else{
        $res=$con->query("SELECT * FROM TERMIN WHERE MATBRL='$matbrl' AND DATUM='$datum->godina-$datum->mesec-$datum->dan' AND VREME='$vreme'");
        if ($res) {
            $row = $res->fetch_assoc();
            if($row)
            {
                return false;
            }
            return TRUE;
        }
        else
        {
            print("QUERY FAILED");
            return false;
        }
        $con->close();
    }
}
function otkazi($matbrp,$datum){
    $con = new mysqli("139.59.132.29", "paja", "pajapro1234", "Hippocrates");
    $con->set_charset('utf8mb4');
    if ($con->connect_errno) {
        // u slucaju greske odstampati odgovarajucu poruku
        print ("Connection error (" . $con->connect_errno . "): $con->connect_error");
    }
    else{
        $con->query("DELETE FROM TERMIN WHERE MATBRP=$matbrp AND DATUM='$datum'");
        $con->query("UPDATE PACIJENT SET PRAVO_DA_ZAKAŽE=1;");
        $con->close();     
    }
}
function zakazi($matbrp,Termin $termin,$napomena){
    $con = new mysqli("139.59.132.29", "paja", "pajapro1234", "Hippocrates");
    $con->set_charset('utf8mb4');
    if ($con->connect_errno) {
        // u slucaju greske odstampati odgovarajucu poruku
        print ("Connection error (" . $con->connect_errno . "): $con->connect_error");
    }
    else{
        $res=$con->query("SELECT * FROM PACIJENT WHERE JMBG='$matbrp'");
        if ($res) {
            $row = $res->fetch_assoc();
            $matbrl=$row['MATBRL'];
            $datum=$termin->datum;
            $vreme=$termin->vreme();
            if($row["PRAVO_DA_ZAKAŽE"]==1){
                if($napomena=="")
                    $napomena=" ";
                $sqlquery="INSERT INTO `TERMIN`(`MATBRL`, `MATBRP`, `DATUM`, `VREME`, `NAPOMENA`) VALUES('$matbrl','$matbrp','$datum->godina-$datum->mesec-$datum->dan',$vreme,'$napomena');";
                $res2=$con->query($sqlquery);
                if($res2===TRUE)
                    return true;
                else{
                    return false;
                    }
                $sqlquery="UPDATE PACIJENT SET PRAVO_DA_ZAKAŽE=0 WHERE JMBG=$matbrp";
                $res=$con->query($sqlquery);
                return false;
            }
            else{
                return false;
            }
            $con->close();
            
    }
}
}
function vratiPacijenta($matbrpacijenta){
    $con = new mysqli("139.59.132.29", "paja", "pajapro1234", "Hippocrates");
    $con->set_charset('utf8mb4');
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
                $pacijent=new Pacijent($row['JMBG'],$row['LBO'],$row['IME'],$row['PREZIME'],$row['SREDNJE_SLOVO'],$row['DATUM_ROĐENJA'],$row['PRAVO_DA_ZAKAŽE'],$row['MATBRL'],$row['VAŽI_DO']);
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
