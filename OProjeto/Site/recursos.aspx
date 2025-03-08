<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="recursos.aspx.cs" Inherits="OProjeto.Site.recursos" %>

<!DOCTYPE html>
<html lang="pt-BR">
<head>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no" />
    <meta name="description" content="Apoio psicológico para vítimas de trânsito e familiares" />
    <meta name="author" content="Faculdade Maurício de Nassau" />
    <title>Recursos de Suporte</title>
    <link rel="icon" type="image/x-icon" href="assets/favicon.ico" />
    <!-- Ícones do Font Awesome -->
    <script src="https://use.fontawesome.com/releases/v6.3.0/js/all.js" crossorigin="anonymous"></script>
    <!-- CSS do Bootstrap -->
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.2.3/dist/css/bootstrap.min.css" rel="stylesheet" />
    <!-- CSS principal do tema -->
    <link rel="stylesheet" href="/Content/main.css">
</head>
<body> 
    <!--nav-->
    <nav class="navbar navbar-expand-lg navbar-dark bg-dark" id="mainNav">
        <div class="container px-4 px-lg-5">
            <a class="navbar-brand text-white" href="inicio.aspx">Apoio Psicológico</a>
            <button class="navbar-toggler" type="button" data-bs-toggle="collapse" data-bs-target="#navbarResponsive" aria-controls="navbarResponsive" aria-expanded="false" aria-label="Toggle navigation">
                <span class="navbar-toggler-icon"></span>
            </button>
            <div class="collapse navbar-collapse" id="navbarResponsive">
                <ul class="navbar-nav ms-auto py-4 py-lg-0">
                    <li class="nav-item"><a class="nav-link px-lg-3 py-3 py-lg-4 text-white" href="inicio.aspx">Início</a></li>
                    <li class="nav-item"><a class="nav-link px-lg-3 py-3 py-lg-4 text-white" href="sobre.aspx">Sobre</a></li>
                    <li class="nav-item"><a class="nav-link px-lg-3 py-3 py-lg-4 text-white" href="recursos.aspx">Recursos</a></li>
                    <li class="nav-item"><a class="nav-link px-lg-3 py-3 py-lg-4 text-white" href="contato.aspx">Contato</a></li>
                </ul>
            </div>
        </div>
    </nav>
    <!-- Cabeça da Página -->
    <header class="masthead" style="background: linear-gradient(135deg, #bd688c, #bd688c); color: white;">
        <div class="container position-relative px-4 px-lg-5 text-white text-center py-5">
            <div class="row gx-4 gx-lg-5 justify-content-center">
                <div class="col-md-10 col-lg-8 col-xl-7">
                    <div class="page-heading">
                        <h1>Recursos de Suporte</h1>
                        <span class="subheading">Conectando vítimas de trânsito com psicólogos e assistência especializada.</span>
                    </div>
                </div>
            </div>
        </div>
    </header>

    <!-- Principal -->
    <main class="mb-4">
        <div class="container px-4 px-lg-5">
            <div class="row gx-4 gx-lg-5 justify-content-center">
                <div class="col-md-10 col-lg-8 col-xl-7 text-center">
                    <p>Nosso objetivo é oferecer suporte emocional e psicológico para vítimas de trânsito e seus familiares. Através desta página, conectamos você a profissionais qualificados para ajudá-lo em momentos difíceis.</p>
                    <div class="py-4">
                        <h2 class="text-primary mb-3">Como Podemos Ajudar?</h2>
                        <ul class="list-group mb-4">
                            <li class="list-group-item">📞 <strong>Aconselhamento psicológico:</strong> Encontre um psicólogo para suporte individual.</li>
                            <li class="list-group-item">📋 <strong>Orientações:</strong> Recursos para lidar com o trauma e reconstruir sua rotina.</li>
                            <li class="list-group-item">🤝 <strong>Grupos de apoio:</strong> Participe de grupos de suporte para compartilhar experiências.</li>
                        </ul>
                    </div>
                    <div>
                        <a href="#!" class="btn btn-primary btn-lg my-3">Entrar em Contato com Psicólogos</a>
                        <a href="#!" class="btn btn-outline-secondary btn-lg my-3">Saber Mais</a>
                    </div>
                </div>
            </div>
        </div>
    </main>

    <!-- Rodapé -->
    <footer class="border-top mt-5">
        <div class="container px-4 px-lg-5 text-center">
            <p class="small text-muted fst-italic">Copyright &copy; Seu Projeto 2024. Criado com propósito e solidariedade.</p>
        </div>
    </footer>

    <!-- Scripts JS -->
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.2.3/dist/js/bootstrap.bundle.min.js"></script>
</body>
</html>

