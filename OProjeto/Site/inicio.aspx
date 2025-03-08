<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="inicio.aspx.cs" Inherits="OProjeto.Site.Inicio" %>

<!DOCTYPE html>
<html lang="pt-br">
<head>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no" />
    <meta name="description" content="Apoio psicológico para vítimas de trânsito e seus familiares." />
    <meta name="author" content="Equipe de Apoio" />
    <title>Apoio Psicológico - Juntos no Caminho da Recuperação</title>
    <link rel="icon" type="image/x-icon" href="assets/favicon.ico" />
    <!-- Ícones do Font Awesome -->
    <script src="https://use.fontawesome.com/releases/v6.3.0/js/all.js" crossorigin="anonymous"></script>
    <!-- Fontes do Google -->
    <link href="https://fonts.googleapis.com/css?family=Lora:400,700,400italic,700italic" rel="stylesheet" type="text/css" />
    <link href="https://fonts.googleapis.com/css?family=Open+Sans:300italic,400italic,600italic,700italic,800italic,400,300,600,700,800" rel="stylesheet" type="text/css" />
    <!-- CSS do Bootstrap -->
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.2.3/dist/css/bootstrap.min.css" rel="stylesheet" />
    <!-- CSS principal -->
    <link rel="stylesheet" href="/Content/main.css">
</head>
<body>
    <script src="script.js"></script>
    <!-- Nav -->
    <nav class="navbar navbar-expand-lg navbar-dark bg-dark" id="mainNav">
        <div class="container px-4 px-lg-5">
            <a class="navbar-brand text-white" href="inicio.aspx">Rota do Apoio</a>
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

    <!-- Cabeçalho -->
    <header class="masthead" style="background-image: url('bonitamais.jpg'); background-size: cover; background-position: center; height: 50vh;">
        <div class="container position-relative px-4 px-lg-5 text-center text-white d-flex flex-column justify-content-center align-items-center">
            <h1 class="fw-bold text-white">Apoio Psicológico</h1>
            <p class="lead text-white">Juntos no Caminho da Recuperação</p>
        </div>
    </header>

    <!-- Conteúdo principal -->
    <main class="container my-5">
        <div class="row justify-content-center">
            <div class="col-lg-8">
                <!-- Posts -->
                <article class="mb-4">
                    <a href="Recursos.aspx" class="text-decoration-none">
                        <h2 class="text-primary">Como lidar com o trauma após um acidente</h2>
                        <p>Estratégias práticas e apoio emocional para superar dificuldades.</p>
                    </a>
                    <p class="text-muted">Publicado em 20 de novembro de 2024</p>
                </article>
                <hr>
                <article class="mb-4">
                    <a href="Recursos.aspx" class="text-decoration-none">
                        <h2 class="text-primary">A importância do apoio familiar</h2>
                        <p>Como os familiares podem ajudar na recuperação emocional.</p>
                    </a>
                    <p class="text-muted">Publicado em 15 de novembro de 2024</p>
                </article>
                <hr>
                <article class="mb-4">
                    <a href="Recursos.aspx" class="text-decoration-none">
                        <h2 class="text-primary">Rede de apoio: onde buscar ajuda?</h2>
                        <p>Conheça instituições e profissionais especializados.</p>
                    </a>
                    <p class="text-muted">Publicado em 10 de novembro de 2024</p>
                </article>
                <div class="d-flex justify-content-end">
                    <a href="#!" class="btn btn-primary text-uppercase">Mais Artigos →</a>
                </div>
            </div>
        </div>
    </main>

    <!-- Rodapé -->
    <footer class="border-top">
        <div class="container px-4 px-lg-5">
            <div class="row gx-4 gx-lg-5 justify-content-center">
                <div class="col-md-10 col-lg-8 col-xl-7">
                    <ul class="list-inline text-center">
                        <li class="list-inline-item">
                            <a href="https://x.com/UNINASSAU_">
                                <span class="fa-stack fa-lg">
                                    <i class="fas fa-circle fa-stack-2x"></i>
                                    <i class="fab fa-twitter fa-stack-1x fa-inverse"></i>
                                </span>
                            </a>
                        </li>
                        <li class="list-inline-item">
                            <a href="https://www.facebook.com/UNINASSAU/?locale=pt_BR">
                                <span class="fa-stack fa-lg">
                                    <i class="fas fa-circle fa-stack-2x"></i>
                                    <i class="fab fa-facebook-f fa-stack-1x fa-inverse"></i>
                                </span>
                            </a>
                        </li>
                        <li class="list-inline-item">
                            <a href="https://www.instagram.com/uninassau.aracaju/?utm_source=ig_web_button_share_sheet">
                                <span class="fa-stack fa-lg">
                                    <i class="fas fa-circle fa-stack-2x"></i>
                                    <i class="fab fa-instagram fa-stack-1x fa-inverse"></i>
                                </span>
                            </a>
                        </li>
                    </ul>
                    <div class="small text-center text-muted fst-italic">Copyright &copy; Apoio Psicológico 2024</div>
                </div>
            </div>
        </div>
    </footer>

    <!-- JS do Bootstrap -->
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.2.3/dist/js/bootstrap.bundle.min.js"></script>
</body>
</html>
