<?php
//Ficheiro responsavel por destrui a sessão.
//pode ser feito de 2 formas:
//session_start();
//session_destroy();
//ou 
//session_start();
//unset($_SESSION["email"]);

session_start();
unset($_SESSION["nome"]);
header ("location: index.php");

?>