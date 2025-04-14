<?php
$username = $_POST["username"];
$password = $_POST["password"];

include 'ligaBD.php';

$stmt = $ligaBD->prepare("SELECT * FROM admin WHERE nome = ? AND password = ?");
$stmt->bind_param("ss", $username, $password); // "ss" = both parameters are strings

$stmt->execute();
$result = $stmt->get_result();

if ($result->num_rows == 0) {
    echo "<br> Erro: correspondência errada";
} else {
    $linha = $result->fetch_assoc();
    session_start();
    $_SESSION["nome"] = $linha["nome"];
    header('Location: Utilizadores.php');
}
?>
