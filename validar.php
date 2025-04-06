<?php
session_start();
if (!isset($_SESSION["nome"])){
	echo '<html>

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
		<div class="col-xl-12 offset-xl-0">
		<div class="card shadow mb-3">
			<div class="card-header py-3">
				<p class="text-primary m-0 fw-bold" style="color: #002d04;">Página reservada a utilizadores registados!</p>
			</div>
		</div>
		<div class="card shadow"></div>
		<div class="card shadow"></div>
		<div class="card shadow">
			<div class="card-body">
				<form action=index.php>
					<div class="mb-3"><button class="btn btn-primary btn-sm" type="submit" style="background-color: #002d04;">voltar</button></div>
					<div class="mb-3"></div>
				</form>
			</div>
		</div>
		<div class="card shadow"></div>
	</div>
	<html>';
	exit;
}
