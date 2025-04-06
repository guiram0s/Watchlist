<?php
include 'validar.php';
$nome=$_SESSION["nome"];

if(@$_GET["idUser"]!="" || @$_GET["idUser"]!=null){
    include 'ligaBD.php';

    $strSelect="Select * from Utilizador where idUtilizador = '".$_GET["idUser"]."'";
    $consultaAluno=mysqli_query($ligaBD, $strSelect);
    $linha=mysqli_fetch_array($consultaAluno);
    $cntnt="Editar Utilizador";
    $z="Salvar";
}
else{
    $linha["idUtilizador"]="novo";
    $linha["nome"]="";
    $linha["email"]="";
    $linha["password"]="";
    $linha["recuperacao"]="";
    $cntnt="Novo Utilizador";
    $z="Adicionar";
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
        <nav class="navbar navbar-dark align-items-start sidebar sidebar-dark accordion bg-gradient-primary p-0">
            <div class="container-fluid d-flex flex-column p-0"><a class="navbar-brand d-flex justify-content-center align-items-center sidebar-brand m-0" href="#">
                    <div class="sidebar-brand-icon rotate-n-15"></div>
                    <div class="sidebar-brand-text mx-3"><span>Watchlist</span></div>
                </a>
                <hr class="sidebar-divider my-0">
                <ul class="navbar-nav text-light" id="accordionSidebar">
                    <li class="nav-item"></li>
                    <li class="nav-item"></li>
                    <li class="nav-item"><a class="nav-link active" href="Utilizadores.php"><i class="fas fa-user"></i><span>Utilizadores</span></a></li>
                    <li class="nav-item"><a class="nav-link" href="Filmes.php"><i class="fa fa-film"></i><span>Filmes</span></a></li>
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
                <div class="container-fluid">
                    <h3 class="text-dark mb-4">Gerir Utilizadores</h3>
                    <div class="row mb-3">
                        <div class="col-xl-12 offset-xl-0">
                            <div class="row register-form">
                                <div class="col-md-8 offset-md-2">
                                    <form class="custom-form" method="POST" action=InfoPage.php?idUser=<?php echo $linha["idUtilizador"]?>>
                                        <h1><?php echo $cntnt?></h1>
                                        <div class="row form-group">
                                            <div class="col-sm-4 label-column"><label class="col-form-label" for="name-input-field">Nome </label></div>
                                            <div class="col-sm-6 input-column"><input name="nome" class="form-control" type="text" value="<?php echo $linha["nome"];?>" required></div>
                                        </div>
                                        <div class="row form-group">
                                            <div class="col-sm-4 label-column"><label class="col-form-label" for="email-input-field">Email </label></div>
                                            <div class="col-sm-6 input-column"><input name="email" class="form-control" type="email" value="<?php echo $linha["email"];?>" required></div>
                                        </div>
                                        <div class="row form-group">
                                            <div class="col-sm-4 label-column"><label class="col-form-label" for="pawssword-input-field">Password </label></div>
                                            <div class="col-sm-6 input-column"><input class="form-control" name="password" type="password" value="<?php echo $linha["password"];?>" required></div>
                                        </div>
                                        <div class="row form-group">
                                            <div class="col-sm-4 label-column"><label class="col-form-label" for="email-input-field">Email de Recuperação</label></div>
                                            <div class="col-sm-6 input-column"><input class="form-control" name="recuperacao" type="email" value="<?php echo $linha["recuperacao"];?>" required></div>
                                        </div><button class="btn btn-light submit-button" type="submit" style="background-color: #002d04;"><?php echo $z?></button>
                                    </form>
                                </div>
                            </div>
                        </div>
                    </div>
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