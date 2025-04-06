<?php
include 'validar.php';
$nome=$_SESSION["nome"];
if(@$_GET["idFilme"]!="" || @$_GET["idfilme"]!=null){
    include 'ligaBD.php';
    $idfilme=$_GET["idFilme"];
    $strSelect="Select * from Filme where idFilme = '".$_GET["idFilme"]."'";
    $consultaAluno=mysqli_query($ligaBD, $strSelect);
    $linha=mysqli_fetch_array($consultaAluno);
    $update="atualizar";
    $imagem= $linha["imagem"];
    $img_path= "WatchListV2\WatchList\Contents"."\\".str_replace('"', "", $linha["imagem"]);
    $cntnt="Editar Filme";
    $z="Salvar";

    $text = array();
    $result = mysqli_query($ligaBD,"Select genero_idgenero from filme_has_genero where filme_idFilme = '".$_GET["idFilme"]."'");
    while ($row = mysqli_fetch_array($result)) 
    {
        $text[] =$row['genero_idgenero'];  
    }
    $names = array();

    foreach($text as $id){
        $result2 = mysqli_query($ligaBD,"Select nome from genero where idgenero = '".$id."'");
        while ($row2 = mysqli_fetch_array($result2)) 
        {
            $names[] =$row2['nome'];  
        }
    }
    


}
else{
    $linha["idFilme"]="novo";
    $linha["titulo"]="";
    $linha["duracao"]="";
    $linha["ano"]="";
    $linha["data"]="";
    $linha["imagem"]="";
    $linha["trailer"]="";
    $linha["resumo"]="";
    $cntnt="Novo Filme";
    $z="Adicionar";
}
?>

<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0, shrink-to-fit=no">
    <title>Profile - Brand</title>
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
        <nav class="navbar navbar-dark align-items-start sidebar sidebar-dark accordion bg-gradient-primary p-0">
            <div class="container-fluid d-flex flex-column p-0"><a class="navbar-brand d-flex justify-content-center align-items-center sidebar-brand m-0" href="#">
                    <div class="sidebar-brand-icon rotate-n-15"></div>
                    <div class="sidebar-brand-text mx-3"><span>Watchlist</span></div>
                </a>
                <hr class="sidebar-divider my-0">
                <ul class="navbar-nav text-light" id="accordionSidebar">
                    <li class="nav-item"></li>
                    <li class="nav-item"></li>
                    <li class="nav-item"><a class="nav-link" href="Utilizadores.php"><i class="fas fa-user"></i><span>Utilizadores</span></a></li>
                    <li class="nav-item"><a class="nav-link active" href="Filmes.php"><i class="fa fa-film"></i><span>Filmes</span></a></li>
                </ul>
                <div class="text-center d-none d-md-inline">
                    <button class="btn rounded-circle border-0" id="sidebarToggle" type="button"></button>
                </div>
                <form method="POST" action=sair.php>
                    <button class="btn btn-primary btn-sm" type="submit" style="background-color: #002d04;">Sair</button>
                </form>
            </div>
        </nav>
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
                <div class="container">
                    <h3 class="text-dark mb-4">Gerir Filmes</h3>
                    <form method="POST" action=InfoPage.php?idfilme=<?php echo $linha["idFilme"]?>>
                        <div class="row">
                            <div class="col-md-6"><img src="<?php echo $img_path?>" alt=" " height="270" width="215"  style="margin-bottom: 15px;">
                                <div class="input-group"><input class="form-control" name="imagem" type="text" value="<?php echo $linha["imagem"];?>" placeholder="Caminho da imagem" style="margin-bottom: 15px;" required> </div>
                                <div class="input-group"><input class="form-control" name="trailer" type="text"  value="<?php echo $linha["trailer"];?>" placeholder="Caminho do trailer" style="margin-bottom: 15px;" required></div>
                                <label>Escolha no máximo 3 categorias diferentes:</label>
                                <br>
                                <select name="combo1">
                                    <option value=<?php echo @$names[0]?> disabled selected hidden><?php echo @$names[0]?></option>
                                    <option value="apagar"></option>
                                    <option value="Ação">Ação</option>
                                    <option value="Aventura">Aventura</option>
                                    <option value="Terror">Terror</option>
                                    <option value="Comédia">Comédia</option>
                                    <option value="Ficção científica">Ficção científica</option>
                                    <option value="Animação">Animação</option>
                                    <option value="Fantasia">Fantasia</option>
                                    <option value="Drama">Drama</option>
                                    <option value="Documentário">Documentário</option>
                                    <option value="Mistério">Mistério</option>
                                    <option value="Musical">Musical</option>
                                    <option value="Romance">Romance</option>
                                </select>  
                                <select name="combo2">
                                    <option value=<?php echo @$names[1]?> disabled selected hidden><?php echo @$names[1]?></option>
                                    <option value="apagar"></option>
                                    <option value="Ação">Ação</option>
                                    <option value="Aventura">Aventura</option>
                                    <option value="Terror">Terror</option>
                                    <option value="Comédia">Comédia</option>
                                    <option value="Ficção científica">Ficção científica</option>
                                    <option value="Animação">Animação</option>
                                    <option value="Fantasia">Fantasia</option>
                                    <option value="Drama">Drama</option>
                                    <option value="Documentário">Documentário</option>
                                    <option value="Mistério">Mistério</option>
                                    <option value="Musical">Musical</option>
                                    <option value="Romance">Romance</option>
                                </select>  
                                <select name="combo3">
                                    <option value=<?php echo @$names[2]?> disabled selected hidden><?php echo @$names[2]?></option>
                                    <option value="apagar"></option>
                                    <option value="Ação">Ação</option>
                                    <option value="Aventura">Aventura</option>
                                    <option value="Terror">Terror</option>
                                    <option value="Comédia">Comédia</option>
                                    <option value="Ficção científica">Ficção científica</option>
                                    <option value="Animação">Animação</option>
                                    <option value="Fantasia">Fantasia</option>
                                    <option value="Drama">Drama</option>
                                    <option value="Documentário">Documentário</option>
                                    <option value="Mistério">Mistério</option>
                                    <option value="Musical">Musical</option>
                                    <option value="Romance">Romance</option>
                                </select>                            
                            </div>
                            <div class="col-md-6">
                                <div class="card shadow">
                                    <div class="card-header py-3">
                                        <p class="text-primary m-0 fw-bold"><?php echo $cntnt?></p>
                                    </div>
                                    <div class="card-body">
                                        <form>
                                            <div class="mb-3">
                                            <input class="form-control" type="text" name="titulo" placeholder="Titulo" value="<?php echo $linha["titulo"];?>" style="margin-bottom: 15px;" required>
                                            <input class="form-control" type="text" placeholder="Duração" value="<?php echo $linha["duracao"];?>" name="duracao" style="margin-bottom: 15px;" required>
                                            <input class="form-control" type="text" placeholder="Ano" value="<?php echo $linha["ano"];?>" name="ano" style="margin-bottom: 15px;" required>
                                            <textarea class="form-control" placeholder="Resumo" style="margin-bottom: 15px;" name="resumo" required><?php echo $linha["resumo"];?></textarea>
                                            <button class="btn btn-primary btn-sm" name="submit" type="submit" style="background-color: #002d04;"><?php echo $z?></button></div>
                                            <div class="mb-3"></div>
                                        </form>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </form>
                </div>
            </div>
        </div><a class="border rounded d-inline scroll-to-top" href="#page-top"><i class="fas fa-angle-up"></i></a>
    </div>
    <footer class="bg-white sticky-footer">
        <div class="container my-auto">
            <div class="text-center my-auto copyright"><span>Copyright © WatchList 2022</span></div>
        </div>
    </footer>
    <script src="assets/bootstrap/js/bootstrap.min.js"></script>
    <script src="assets/js/Table-With-Search.js"></script>
    <script src="assets/js/theme.js"></script>
</body>

</html>