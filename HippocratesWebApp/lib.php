<?php
include_once 'IzabraniLekar.php';
include_once 'Pacijent.php';
include_once 'Terapija.php';
include_once 'Dijagnoza.php';
include_once 'Dijagnostifikovano.php';
include_once 'Vakcina.php';
include_once 'DomZdravlja.php';
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
            return false;
        }
        $con->close();
    }
}
function ocenilekara($matbrp,$ocena){
    $con = new mysqli("139.59.132.29", "paja", "pajapro1234", "Hippocrates");
    $con->set_charset('utf8mb4');
    if ($con->connect_errno) {
        // u slucaju greske odstampati odgovarajucu poruku
        print ("Connection error (" . $con->connect_errno . "): $con->connect_error");
    }
    else{
        $lekar=vratiIzabranogLekara($matbrp);
        $res=$con->query("INSERT INTO OCENA(MATBRP,MATBRL,OCENA) VALUES('$matbrp','$lekar->jmbg','$ocena');");

        $con->close();
    }
}
function vecOcenio($matbrp){
    $con = new mysqli("139.59.132.29", "paja", "pajapro1234", "Hippocrates");
    $con->set_charset('utf8mb4');
    if ($con->connect_errno) {
        // u slucaju greske odstampati odgovarajucu poruku
        print ("Connection error (" . $con->connect_errno . "): $con->connect_error");
    }
    else{
        $lekar=vratiIzabranogLekara($matbrp);
        $res=$con->query("SELECT * FROM OCENA WHERE MATBRP='$matbrp' AND MATBRL='$lekar->jmbg'");
        if($res->num_rows==0)
            return false;
        return true;
        $con->close();
    }

}
function postaviTelefonPacijenta($matbrp,$telefon){
    $con=new mysqli("139.59.132.29","paja","pajapro1234","Hippocrates");
    $con->set_charset('utf8mb4');
    if($con->connect_errno){
        print("Connection errot(".$con->connect_errno."): $con->connect_error");
    }
    else {
            $res=$con->query("UPDATE PACIJENT SET KONTAKT_TELEFON='$telefon' WHERE JMBG='$matbrp'");
        }
        $con->close();

    }


function postaviEmailPacijenta($matbrp,$email){
    $con=new mysqli("139.59.132.29","paja","pajapro1234","Hippocrates");
    $con->set_charset('utf8mb4');
    if($con->connect_errno){
        print("Connection errot(".$con->connect_errno."): $con->connect_error");
    }
            $res=$con->query("UPDATE PACIJENT SET EMAIL='$email' WHERE JMBG='$matbrp'");

        $con->close();

    }

function zahtevZaPromenu($matbrp,$matbrl){
    $con=new mysqli("139.59.132.29","paja","pajapro1234","Hippocrates");
    $con->set_charset('utf8mb4');
    if($con->connect_errno){
        print("Connection errot(".$con->connect_errno."): $con->connect_error");
    }
    else {
        $res=$con->query("SELECT * FROM ZAHTEV_ZA_PROMENU WHERE MATBRP=$matbrp;");

        if($res->num_rows==0)
            $res=$con->query("INSERT INTO ZAHTEV_ZA_PROMENU(MATBRP,MATBR_ŽELJENOG) VALUES('$matbrp',$matbrl);");
        else{
            $con->close();
            return false;
        }
        $con->close();
        return true;
    }
}
function vratiLekareIzDomaZdravljaPacijenta($matbrp){
    $con=new mysqli("139.59.132.29","paja","pajapro1234","Hippocrates");
    $con->set_charset('utf8mb4');
    if($con->connect_errno){
        print("Connection errot(".$con->connect_errno."): $con->connect_error");
    }
    else {
        $res=$con->query("SELECT DOM_ZDRAVLJA.MBR, IZABRANI_LEKAR.JMBG FROM DOM_ZDRAVLJA,PACIJENT,IZABRANI_LEKAR WHERE PACIJENT.MATBRL=IZABRANI_LEKAR.JMBG AND IZABRANI_LEKAR.MBRZU=DOM_ZDRAVLJA.MBR AND PACIJENT.JMBG='$matbrp';");
        $row=$res->fetch_assoc();
        $mbrzu=$row['MBR'];
        $matbrl=$row['JMBG'];
        $res=$con->query("SELECT * FROM IZABRANI_LEKAR WHERE MBRZU='$mbrzu' AND JMBG!='$matbrl';");
        $nizLekara=array();
        $k=0;
        while($row=$res->fetch_assoc()){
            $res2=$con->query("SELECT AVG(OCENA) AS PROSECNA FROM OCENA WHERE MATBRL=".$row['JMBG'].";");
            $row2=$res2->fetch_assoc();
            $lekar=new IzabraniLekar($row['JMBG'],$row['IME'],$row['SREDNJE_SLOVO'],$row['PREZIME'],$row['DATUM_ROĐENJA'],$row['MBRZU'],$row['SMENA']);
            $lekar->ocena=$row2['PROSECNA'];
            $nizLekara[$k++]=$lekar;
        }
        $con->close();
        return $nizLekara;
    }
}
function vratiDomZdravljaPacijenta($matbrp){
    $con=new mysqli("139.59.132.29","paja","pajapro1234","Hippocrates");
    $con->set_charset("utf8mb4");
    if($con->connect_errno){
        print("Connection errot(".$con->connect_errno."): $con->connect_error");
    }
    else{
        $res=$con->query("SELECT DOM_ZDRAVLJA.MBR, DOM_ZDRAVLJA.IME, DOM_ZDRAVLJA.LOKACIJA, DOM_ZDRAVLJA.ADRESA, DOM_ZDRAVLJA.OPŠTINA FROM DOM_ZDRAVLJA,PACIJENT,IZABRANI_LEKAR WHERE PACIJENT.MATBRL=IZABRANI_LEKAR.JMBG AND IZABRANI_LEKAR.MBRZU=DOM_ZDRAVLJA.MBR AND PACIJENT.JMBG='$matbrp';");
        $row=$res->fetch_assoc();
        $domZdravlja=new DomZdravlja($row['MBR'],$row['IME'],$row['OPŠTINA'],$row['LOKACIJA'],$row['ADRESA']);
        $con->close(    );
        return $domZdravlja;
    }
}
function vratiTelefonPacijenta($matbrp){
    $con=new mysqli("139.59.132.29","paja","pajapro1234","Hippocrates");
    $con->set_charset('utf8mb4');
    if ($con->connect_errno) {
        print ("Connection error (" . $con->connect_errno . "): $con->connect_error");
    }
    else{
        $res=$con->query("SELECT KONTAKT_TELEFON FROM PACIJENT WHERE JMBG='$matbrp'");
        if($res)
            $row=$res->fetch_assoc();
        return $row["KONTAKT_TELEFON"];
    }
}
function vratiEmailPacijenta($matbrp){
    $con=new mysqli("139.59.132.29","paja","pajapro1234","Hippocrates");
    $con->set_charset('utf8mb4');
    if ($con->connect_errno) {
        print ("Connection error (" . $con->connect_errno . "): $con->connect_error");
    }
    else{
        $res=$con->query("SELECT EMAIL FROM PACIJENT WHERE JMBG='$matbrp'");
        $row=$res->fetch_assoc();
        return $row["EMAIL"];
    }
}
function vratiVakcine($matbrp){
    $con=new mysqli("139.59.132.29","paja","pajapro1234","Hippocrates");
    $con->set_charset('utf8mb4');
    if ($con->connect_errno) {
        print ("Connection error (" . $con->connect_errno . "): $con->connect_error");
    }
    else{
        $res=$con->query("SELECT OPIS,ŠIFRA,IME FROM VAKCINA,PRIMIO_VAKCINU WHERE PRIMIO_VAKCINU.JMBGP='$matbrp' AND PRIMIO_VAKCINU.SIFRA_VAKCINE=VAKCINA.ŠIFRA
");
        $nizvakcina=array();
        $k=0;
        while($row=$res->fetch_assoc()){
                $vakcina=new Vakcina($row['ŠIFRA'],$row['IME'],$row['OPIS']);
                $nizvakcina[$k++]=$vakcina;
            }
            $con->close();
            return $nizvakcina;
    }
}
function vratiSmenuLekaraZaDatum($matbrl,$datum){
     $con = new mysqli("139.59.132.29", "paja", "pajapro1234", "Hippocrates");
     $con->set_charset('utf8mb4');
    if ($con->connect_errno) {
        print ("Connection error (" . $con->connect_errno . "): $con->connect_error");
    }
    else{
        $res=$con->query("SELECT SMENA FROM SMENA WHERE MATBRL=$matbrl AND DATUM_OD<='$datum->godina-$datum->mesec-$datum->dan' AND DATUM_DO>='$datum->godina-$datum->mesec-$datum->dan';");
        if ($res) {
            $row = $res->fetch_assoc();
            if($row)
            {
               return $row['SMENA'];
            }
        }
        else
        {
            print("QUERY FAILED");
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
                $lekar=new IzabraniLekar($row2['JMBG'],$row2['IME'],$row2['SREDNJE_SLOVO'],$row2['PREZIME'],$row2['DATUM_ROĐENJA'],$row2['MBRZU']);
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
        $res=$con->query("SELECT ŠIFRA_DIJAGNOZE,IME,DATE_FORMAT(DATUM, '%d/%m/%Y') AS DATUM FROM DIJAGNOSTIFIKOVANO,DIJAGNOZA WHERE DIJAGNOSTIFIKOVANO.MATBRP='$matbrp' AND DIJAGNOZA.ŠIFRA=DIJAGNOSTIFIKOVANO.ŠIFRA_DIJAGNOZE;");
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
        $res=$con->query("SELECT ŠIFRA_DIJAGNOZE,DATE_FORMAT(DATUM_OD, '%d/%m/%Y') AS DATUM_OD,DATE_FORMAT(DATUM_DO, '%d/%m/%Y') AS DATUM_DO,OPIS FROM TERAPIJA WHERE MATBRP='$matbrp';");
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
function otkazi($matbrp,$datum,$vreme){
    $con = new mysqli("139.59.132.29", "paja", "pajapro1234", "Hippocrates");
    $con->set_charset('utf8mb4');
    if ($con->connect_errno) {
        print ("Connection error (" . $con->connect_errno . "): $con->connect_error");
    }
    else{
        $con->query("DELETE FROM TERMIN WHERE MATBRP=$matbrp AND DATUM='$datum' AND VREME='$vreme'");
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
            if(!slobodanTermin($matbrl,$datum,$vreme))
              return false;
            if($row["PRAVO_DA_ZAKAŽE"]==1){
                if($napomena=="")
                    $napomena=" ";
                $sqlquery="INSERT INTO `TERMIN`(`MATBRL`, `MATBRP`, `DATUM`, `VREME`, `NAPOMENA`) VALUES('$matbrl','$matbrp','$datum->godina-$datum->mesec-$datum->dan',$vreme,'$napomena');";
                $res2=$con->query($sqlquery);
                $sqlquery="UPDATE PACIJENT SET PRAVO_DA_ZAKAŽE=0 WHERE JMBG=$matbrp";
                $res=$con->query($sqlquery);
                if($res2===TRUE)
                    return true;
                else{
                    return false;
                    }
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

?>
