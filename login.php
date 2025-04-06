<?php

$username=$_POST["username"];
$password=$_POST["password"];

include 'ligaBD.php';

$strSelect="Select * from admin where nome='".$username."' and password='".$password."'";
$consultaUser=mysqli_query($ligaBD, $strSelect);
$numLinhas=mysqli_num_rows($consultaUser);
if ($numLinhas==0)
{
    echo "<br> Erro: correspondencia errada";
	
}else
{
		$linha=mysqli_fetch_array($consultaUser);
		session_start();
		$_SESSION["nome"]=$linha["nome"];
		header('location: Utilizadores.php');
}
?>
