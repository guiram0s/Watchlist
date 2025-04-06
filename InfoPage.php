<?php
include 'validar.php';
$nome=$_SESSION["nome"];
include 'ligaBD.php';

//-----------------------Gerir Utilizador-------------------------------------
if(@$_GET["idUser"]!="novo" && @$_GET["idUser"]!=null){
    $a="Utilizador Atualizado";
    $c="Gerir Utilizadores";
    $username=$_POST["nome"];
    $email=$_POST["email"];
    $password=$_POST["password"];
    $numero=$_POST["recuperacao"];

    $strUpdate="update Utilizador set recuperacao='".$numero.
			"', email='".$email.
			"', nome='".$username.
            "', password='".$password.
			"' Where idUtilizador ='".$_GET["idUser"]."';";

    $atualiza= mysqli_query($ligaBD,$strUpdate);
    $btn="Utilizadores.php";
}
if(@$_GET["apagarUser"]!="" || @$_GET["apagarUser"]!=null){
    $c="Gerir Utilizadores";
    
    $strDelete="Delete from Utilizador where idUtilizador = '".$_GET["apagarUser"]."'";
    $delete=mysqli_query($ligaBD, $strDelete);

    $a="Registo Apagado";
    $btn="Utilizadores.php";
}
if(@$_GET["idUser"]=="novo"){
    $a="Utilizador Adicionado";
    $c="Gerir Utilizadores";

    $nome=$_POST["nome"];
    $email=$_POST["email"];
    $password=$_POST["password"];
    $recuperacao=$_POST["recuperacao"];

    $strInsert="INSERT INTO `watchlistv4`.`Utilizador` (`nome`, `email`, `password`, `recuperacao`) 
    VALUES ('".$nome."', '".$email."', '".$password."','".$recuperacao."');";

    $atualiza= mysqli_query($ligaBD,$strInsert);
    $btn="Utilizadores.php";
}

//-----------------------Gerir Filmes-------------------------------------
//--------------------Apagar----------------------------
if(@$_GET["apagar"]!="" || @$_GET["apagar"]!=null){
    $c="Gerir Filmes";
    
    $strDelete2="Delete from filme_has_genero where filme_idfilme = '".$_GET["apagar"]."'";
    $delete2=mysqli_query($ligaBD, $strDelete2);

    $strDelete="Delete from Filme where idFilme = '".$_GET["apagar"]."'";
    $delete=mysqli_query($ligaBD, $strDelete);

    $a="Registo Apagado";
    $btn="Filmes.php";
}
//--------------------Atualizar----------------------------
if(@$_GET["idfilme"]!="novo" && @$_GET["idfilme"]!=null){
    $a="Filme Atualizado";
    $c="Gerir Filmes";

    $strSelect="Select * from Filme where idFilme = '".$_GET["idfilme"]."'";
    $consultaAluno=mysqli_query($ligaBD, $strSelect);
    $linha=mysqli_fetch_array($consultaAluno);
    
    $idfilme=$_GET["idfilme"];
    $imagem=$_POST["imagem"];
    $resumo=$_POST["resumo"];
    $trailer=$_POST["trailer"];
    $titulo=$_POST["titulo"];
    $duracao=$_POST["duracao"];
    $ano=$_POST["ano"];

     $strUpdate="update filme set titulo='".$titulo.
     "', duracao='".$duracao.
     "', resumo='".$resumo.
     "', imagem='".$imagem.
     "', ano='".$ano.
     "', trailer='".$trailer.
     "' Where idFilme ='".$_GET["idfilme"]."';";

    $atualiza= mysqli_query($ligaBD,$strUpdate);
    
//--------------------Combo1 Atualizar-------------------------------------
        if(@$_POST["combo1"]=="apagar"){
            $text = array();
            $result = mysqli_query($ligaBD,"Select genero_idgenero from filme_has_genero where filme_idFilme = '".$idfilme."'");
            while ($row = mysqli_fetch_array($result)) 
            {
                $text[] =$row['genero_idgenero'];  
            }

            $strDelete="Delete from filme_has_genero where filme_idfilme = '".$idfilme."' and genero_idgenero='".$text[0]."'";
            $delete=mysqli_query($ligaBD, $strDelete);
        }
        else{
            if(@$_POST["combo1"]!="" || @$_POST["combo1"]!=null){
                $text = array();
                $result = mysqli_query($ligaBD,"Select genero_idgenero from filme_has_genero where filme_idFilme = '".$idfilme."'");
                while ($row = mysqli_fetch_array($result)) 
                {
                    $text[] =$row['genero_idgenero'];  
                }
                $arrLength = count($text);
                if($arrLength<3){
        
                    $strSelect2="Select idgenero from genero where nome = '".$_POST["combo1"]."'";
                    $consultaAluno2=mysqli_query($ligaBD, $strSelect2);
                    $linha2=mysqli_fetch_array($consultaAluno2);
                    @$id1=@$linha2['idgenero'];
            
                    $strInsert="INSERT INTO `watchlistv4`.`filme_has_genero` (`filme_idfilme`, `genero_idgenero`) 
                    VALUES ('".$idfilme."', '".$id1."');";
        
                    $atualiza= mysqli_query($ligaBD,$strInsert);
         
                }
                else{
                    $strSelect2="Select idgenero from genero where nome = '".$_POST["combo1"]."'";
                    $consultaAluno2=mysqli_query($ligaBD, $strSelect2);
                    $linha2=mysqli_fetch_array($consultaAluno2);
                    @$id1=@$linha2['idgenero'];
            
                    $strUpdatez="update filme_has_genero set genero_idgenero='".$id1.
                            "' Where filme_idfilme ='".$idfilme."' and genero_idgenero='".$text[0]."'  ;";
            
                    $atualiza= mysqli_query($ligaBD,$strUpdatez);
                }
                
            }
        }
    

//--------------------Combo2 Atualizar-------------------------------------
    if(@$_POST["combo2"]=="apagar"){
        $text = array();
        $result = mysqli_query($ligaBD,"Select genero_idgenero from filme_has_genero where filme_idFilme = '".$idfilme."'");
        while ($row = mysqli_fetch_array($result)) 
        {
            $text[] =$row['genero_idgenero'];  
        }

        $strDelete="Delete from filme_has_genero where filme_idfilme = '".$idfilme."' and genero_idgenero='".$text[1]."'";
        $delete=mysqli_query($ligaBD, $strDelete);
    }
    else{
        if(@$_POST["combo2"]!="" || @$_POST["combo2"]!=null){
            $text = array();
            $result = mysqli_query($ligaBD,"Select genero_idgenero from filme_has_genero where filme_idFilme = '".$idfilme."'");
            while ($row = mysqli_fetch_array($result)) 
            {
                $text[] =$row['genero_idgenero'];  
            }
            $arrLength = count($text);
            if($arrLength<3){
    
                $strSelect2="Select idgenero from genero where nome = '".$_POST["combo2"]."'";
                $consultaAluno2=mysqli_query($ligaBD, $strSelect2);
                $linha2=mysqli_fetch_array($consultaAluno2);
                @$id1=@$linha2['idgenero'];
        
                $strInsert="INSERT INTO `watchlistv4`.`filme_has_genero` (`filme_idfilme`, `genero_idgenero`) 
                VALUES ('".$idfilme."', '".$id1."');";
    
                $atualiza= mysqli_query($ligaBD,$strInsert);
     
            }
            else{
                $strSelect2="Select idgenero from genero where nome = '".$_POST["combo2"]."'";
                $consultaAluno2=mysqli_query($ligaBD, $strSelect2);
                $linha2=mysqli_fetch_array($consultaAluno2);
                @$id1=@$linha2['idgenero'];
        
                $strUpdate="update filme_has_genero set genero_idgenero='".$id1.
                        "' Where filme_idfilme ='".$idfilme."' and genero_idgenero='".$text[1]."'  ;";
        
                $atualiza= mysqli_query($ligaBD,$strUpdate);
            }
            
        }
    }
    
    
//--------------------Combo3 Atualizar-------------------------------------
    if(@$_POST["combo3"]=="apagar"){
        $text = array();
        $result = mysqli_query($ligaBD,"Select genero_idgenero from filme_has_genero where filme_idFilme = '".$idfilme."'");
        while ($row = mysqli_fetch_array($result)) 
        {
            $text[] =$row['genero_idgenero'];  
        }

        $strDelete="Delete from filme_has_genero where filme_idfilme = '".$idfilme."' and genero_idgenero='".$text[2]."'";
        $delete=mysqli_query($ligaBD, $strDelete);
    }
    else{
        if(@$_POST["combo3"]!="" || @$_POST["combo3"]!=null){
            $text = array();
            $result = mysqli_query($ligaBD,"Select genero_idgenero from filme_has_genero where filme_idFilme = '".$idfilme."'");
            while ($row = mysqli_fetch_array($result)) 
            {
                $text[] =$row['genero_idgenero'];  
            }
            $arrLength = count($text);
            if($arrLength<3){
    
                $strSelect2="Select idgenero from genero where nome = '".$_POST["combo3"]."'";
                $consultaAluno2=mysqli_query($ligaBD, $strSelect2);
                $linha2=mysqli_fetch_array($consultaAluno2);
                @$id1=@$linha2['idgenero'];
        
                $strInsert="INSERT INTO `watchlistv4`.`filme_has_genero` (`filme_idfilme`, `genero_idgenero`) 
                VALUES ('".$idfilme."', '".$id1."');";
    
                $atualiza= mysqli_query($ligaBD,$strInsert);
     
            }
            else{
                $strSelect2="Select idgenero from genero where nome = '".$_POST["combo3"]."'";
                $consultaAluno2=mysqli_query($ligaBD, $strSelect2);
                $linha2=mysqli_fetch_array($consultaAluno2);
                @$id1=@$linha2['idgenero'];
        
                $strUpdate="update filme_has_genero set genero_idgenero='".$id1.
                        "' Where filme_idfilme ='".$idfilme."' and genero_idgenero='".$text[2]."'  ;";
        
                $atualiza= mysqli_query($ligaBD,$strUpdate);
            }
            
        }
    }
    

    $strUpdate="update filme set imagem='".$imagem.
                "', trailer='".$trailer.
                "', titulo='".$titulo.
                "', duracao='".$duracao.
                "', ano='".$ano.
                "' Where idFilme ='".$idfilme."';";

    $atualiza= mysqli_query($ligaBD,$strUpdate);
    $btn="Filmes.php";
}
//--------------------Adicionar----------------------------

if(@$_GET["idfilme"]=="novo"){

    $a="Filme Adicionado";
    $c="Gerir Filmes";

    $imagem=$_POST["imagem"];
    $resumo=$_POST["resumo"];
    $trailer=$_POST["trailer"];
    $titulo=$_POST["titulo"];
    $duracao=$_POST["duracao"];
    $ano=$_POST["ano"];
    
    $strInsert="INSERT INTO `watchlistv4`.`filme` (`titulo`, `duracao`, `resumo`, `imagem`, `ano`, `trailer`) 
    VALUES ('".$titulo."', '".$duracao."', '".$resumo."','".$imagem."' , '".$ano."', '".$trailer."');";

    $atualiza= mysqli_query($ligaBD,$strInsert);

    $strSelect="Select idFilme from Filme where titulo = '".$titulo."'";
    $consultaAluno=mysqli_query($ligaBD, $strSelect);
    $linha=mysqli_fetch_array($consultaAluno);
    $idfilme=$linha["idFilme"];

    $atualiza2= mysqli_query($ligaBD,$strSelect);

    if(@$_POST["combo1"]!="" || @$_POST["combo1"]!=null){
        $text = array();
        $result = mysqli_query($ligaBD,"Select genero_idgenero from filme_has_genero where filme_idFilme = '".$idfilme."'");
        while ($row = mysqli_fetch_array($result)) 
        {
            $text[] =$row['genero_idgenero'];  
        }
        
    
        $strSelect2="Select idgenero from genero where nome = '".$_POST["combo1"]."'";
        $consultaAluno2=mysqli_query($ligaBD, $strSelect2);
        $linha2=mysqli_fetch_array($consultaAluno2);
        @$id1=@$linha2['idgenero'];

        $strInsert="INSERT INTO `watchlistv4`.`filme_has_genero` (`filme_idfilme`, `genero_idgenero`) 
        VALUES ('".$idfilme."', '".$id1."');";

        $atualiza= mysqli_query($ligaBD,$strInsert);
        
    }
    if(@$_POST["combo2"]!="" || @$_POST["combo2"]!=null){
        $text = array();
        $result = mysqli_query($ligaBD,"Select genero_idgenero from filme_has_genero where filme_idFilme = '".$idfilme."'");
        while ($row = mysqli_fetch_array($result)) 
        {
            $text[] =$row['genero_idgenero'];  
        }
        
    
        $strSelect2="Select idgenero from genero where nome = '".$_POST["combo2"]."'";
        $consultaAluno2=mysqli_query($ligaBD, $strSelect2);
        $linha2=mysqli_fetch_array($consultaAluno2);
        @$id1=@$linha2['idgenero'];

        $strInsert="INSERT INTO `watchlistv4`.`filme_has_genero` (`filme_idfilme`, `genero_idgenero`) 
        VALUES ('".$idfilme."', '".$id1."');";

        $atualiza= mysqli_query($ligaBD,$strInsert);
        
    }
    if(@$_POST["combo3"]!="" || @$_POST["combo3"]!=null){
        $text = array();
        $result = mysqli_query($ligaBD,"Select genero_idgenero from filme_has_genero where filme_idFilme = '".$idfilme."'");
        while ($row = mysqli_fetch_array($result)) 
        {
            $text[] =$row['genero_idgenero'];  
        }
        
    
        $strSelect2="Select idgenero from genero where nome = '".$_POST["combo3"]."'";
        $consultaAluno2=mysqli_query($ligaBD, $strSelect2);
        $linha2=mysqli_fetch_array($consultaAluno2);
        @$id1=@$linha2['idgenero'];

        $strInsert="INSERT INTO `watchlistv4`.`filme_has_genero` (`filme_idfilme`, `genero_idgenero`) 
        VALUES ('".$idfilme."', '".$id1."');";

        $atualiza= mysqli_query($ligaBD,$strInsert);
        
    }

    $btn="Filmes.php";
}


?>
<!DOCTYPE html>
<html>

<head>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0, shrink-to-fit=no">
    <title>WatchList</title>
    <link rel="stylesheet" href="assets/bootstrap/css/bootstrap.min.css">
    <link rel="stylesheet" href="https://fonts.googleapis.com/css?family=Nunito:200,200i,300,300i,400,400i,600,600i,700,700i,800,800i,900,900i">
    <link rel="stylesheet" href="assets/fonts/fontawesome-all.min.css">
    <link rel="stylesheet" href="assets/fonts/font-awesome.min.css">
    <link rel="stylesheet" href="assets/fonts/fontawesome5-overrides.min.css">
    <link rel="stylesheet" href="assets/css/Pretty-Registration-Form.css">
    <link rel="stylesheet" href="assets/css/Table-With-Search-1.css">
    <link rel="stylesheet" href="assets/css/Table-With-Search.css">
    <link rel="stylesheet" href="assets/css/untitled-1.css">
    <link rel="stylesheet" href="assets/css/untitled-2.css">
    <link rel="stylesheet" href="assets/css/untitled-3.css">
    <link rel="stylesheet" href="assets/css/untitled-4.css">
    <link rel="stylesheet" href="assets/css/untitled.css">
</head>

<body id="page-top">
    <div id="wrapper">
        <div class="d-flex flex-column" id="content-wrapper">
            <div id="content">
                <nav class="navbar navbar-light navbar-expand bg-white shadow mb-4 topbar static-top">
                    <div class="container-fluid"><button class="btn btn-link d-md-none rounded-circle me-3" id="sidebarToggleTop" type="button"><i class="fas fa-bars"></i></button>
                        <form class="d-none d-sm-inline-block me-auto ms-md-3 my-2 my-md-0 mw-100 navbar-search">
                            <div class="input-group"></div>
                        </form>
                        <ul class="navbar-nav flex-nowrap ms-auto">
                            <li class="nav-item dropdown no-arrow">
                                <div class="nav-item dropdown no-arrow"><a class="dropdown-toggle nav-link" aria-expanded="false" data-bs-toggle="dropdown" href="#"><span class="d-none d-lg-inline me-2 text-gray-600 small"><?php echo $nome?></span></a>
                                </div>
                            </li>
                        </ul>
                    </div>
                </nav>
                <div class="container-fluid">
                    <h3 class="text-dark mb-4"><?php echo $c?></h3>
                    <div class="row mb-3">
                        <div class="col-lg-8">
                            <div class="row">
                                <div class="col-xl-12 offset-xl-0">
                                    <div class="card shadow mb-3">
                                        <div class="card-header py-3">
                                            <p class="text-primary m-0 fw-bold" style="color: #002d04;"><?php echo $a?></p>
                                        </div>
                                    </div>
                                    <div class="card shadow"></div>
                                    <div class="card shadow"></div>
                                    <div class="card shadow">
                                        <div class="card-body">
                                            <form action=<?php echo $btn?>>
                                                <div class="mb-3"><button class="btn btn-primary btn-sm" type="submit" style="background-color: #002d04;">voltar</button></div>
                                                <div class="mb-3"></div>
                                            </form>
                                        </div>
                                    </div>
                                    <div class="card shadow"></div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <footer class="bg-white sticky-footer">
                <div class="container my-auto">      
                    <div class="text-center my-auto copyright"><span>Copyright © WatchList 2022</span></div>
                </div>
            </footer>
        </div><a class="border rounded d-inline scroll-to-top" href="#page-top"><i class="fas fa-angle-up"></i></a>
    </div>
    <script src="assets/bootstrap/js/bootstrap.min.js"></script>
    <script src="assets/js/Table-With-Search.js"></script>
    <script src="assets/js/theme.js"></script>
</body>

</html>