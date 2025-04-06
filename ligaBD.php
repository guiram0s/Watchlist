<?php
$ligaBD=mysqli_connect('localhost','root','');
if(!$ligaBD){
    echo "<br> Erro: Não foi possivel estabelecer ligação com o mysql";
    exit;
}

$escolheBD=mysqli_select_db($ligaBD, 'watchlistv4');
if(!$escolheBD){
    echo "<br> Erro: a BD não existe";
    exit;
}
?>
