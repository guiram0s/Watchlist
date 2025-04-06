<?php
    include ('ligaBD.php');
    include 'validar.php';
    $nome=$_SESSION["nome"];

	$strSelect="select * from Filme";
	$consultaAluno=mysqli_query($ligaBD, $strSelect);
	$numlinhas=mysqli_num_rows($consultaAluno);
    function foundData($numlinhas,$consultaAluno) {

        if ($numlinhas==0){
            echo "<br>&nbsp&nbsp Não existem registos para listar!";
            exit;
        }
        echo "&nbsp&nbspNumero de registos encontrados: ".$numlinhas."<br><br>";
    }

	function fillTable($numlinhas,$consultaAluno) {
        $a='Link1';
		if($_SESSION["nome"]=="admin"){
			for ($i=0;$i<$numlinhas;$i++){

				$linha=mysqli_fetch_array($consultaAluno);
				echo"<tr>";
                echo "<td>".$linha["idFilme"]."</td>";
				echo"<td>".$linha["titulo"]."</td>";
				echo"<td>".$linha["duracao"]."</td>";
                echo"<td>".$linha["ano"]."</td>";
                echo"<td>".$linha["visto"]."</td>";
                echo"<td>".$linha["data"]."</td>";
                echo '<td>  <form style="float:left;" method="POST" action=Movie.php?idFilme='.$linha['idFilme'].'>
                <button class="btn btn-success" style="margin-left: 5px;" type="submit"><i class="fa fa-gear" style="font-size: 15px;"></i></button>
                </form>
                <form style="float:right;" method="POST" action=InfoPage.php?apagar='.$linha['idFilme'].'>
                <button class="btn btn-danger" style="margin-left: 5px;" type="submit"><i class="fa fa-trash" style="font-size: 15px;"></i></button>
                </form> </td>';
				echo"</tr>";
			}
		}
		else{
			echo"Erro";
		}
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
                <div class="container-fluid">
                    <h3 class="text-dark mb-4">Gerir Filmes
                    <form style="float:right;" method="POST" action=Movie.php>
                        <button class="btn btn-success" style="margin-left: 5px;" type="submit"><i class="fa fa-plus" style="font-size: 15px;"></i></button>
                    </form>
                    </h3>
                    <div class="row mb-3">
                        <div class="col-xl-12 offset-xl-0">
                            <div class="card shadow">
                                <div class="table-responsive table table-hover table-bordered results">
                                    <table class="table table-hover table-bordered">
                                        <thead class="bill-header cs">
                                            <tr>
                                                <th id="trs-hd-1" class="col-lg-1" style="background-color: #002d04;">Id</th>
                                                <th id="trs-hd-2" class="col-lg-2" style="background-color: #002d04;">Titulo</th>
                                                <th id="trs-hd-3" class="col-lg-2" style="background-color: #002d04;">Duração</th>
                                                <th id="trs-hd-5" class="col-lg-2" style="background-color: #002d04;">ano</th>
                                                <th id="trs-hd-7" class="col-lg-1" style="background-color: #002d04;">visto</th>
                                                <th id="trs-hd-8" class="col-lg-2" style="background-color: #002d04;">Data</th>
                                                <th id="trs-hd-6" class="col-lg-1" style="background-color: #002d04;">Action</th>
                                            </tr>
                                        </thead>
                                        <tbody>
                                            <tr>
                                                <td><?php fillTable($numlinhas,$consultaAluno);?> </td>
                                            </tr>
                                        </tbody>
                                    </table>
                                </div>
                            </div>
                        </div>
                        <div class="col-lg-8">
                            <div class="row">
                                <div class="col">
                                    <div class="card shadow"></div>
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