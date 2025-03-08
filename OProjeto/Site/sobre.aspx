<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="sobre.aspx.cs" Inherits="OProjeto.Site.Sobre" %>

<!DOCTYPE html>
<html lang="pt-BR">
<head>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no" />
    <meta name="description" content="Apoio psicológico para vítimas de trânsito e familiares" />
    <meta name="author" content="Faculdade Maurício de Nassau" />
    <title>Sobre Nós - Apoio Psicológico</title>
    <link rel="icon" type="image/x-icon" href="assets/favicon.ico" />
    <!-- Ícones do Font Awesome -->
    <script src="https://use.fontawesome.com/releases/v6.3.0/js/all.js" crossorigin="anonymous"></script>
    <!-- Fontes do Google -->
    <link href="https://fonts.googleapis.com/css2?family=Poppins:wght@300;400;600&display=swap" rel="stylesheet">
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
                    <div class="page-heading py-5">
                        <h1 class="display-4 fw-bold" style="font-family: 'Poppins', sans-serif;">Sobre Nós</h1>
                        <p class="lead subheading fw-light" style="font-family: 'Poppins', sans-serif;">Apoio para vítimas de trânsito e seus familiares.</p>
                    </div>
                </div>
            </div>
        </div>
    </header>

    <!-- Principal -->
    <main class="mb-4">
        <div class="container px-4 px-lg-5">
            <div class="row gx-4 gx-lg-5 justify-content-center">
                <div class="col-md-10 col-lg-8 col-xl-7">
                    <div class="card shadow-lg border-0" style="border-radius: 15px;">
                        <div class="card-body p-5">
                            <h2 class="text-center mb-4" style="font-family: 'Poppins', sans-serif; color: #ff758c;">Nossa Missão</h2>
                            <p class="text-muted" style="font-size: 1.1rem; font-family: 'Poppins', sans-serif;">Somos um grupo de estudantes da <span class="fw-bold" style="color: #efb410;">UNINASSAU</span> comprometidos em oferecer suporte para vítimas de trânsito e seus familiares.</p>
                            <p class="text-muted" style="font-size: 1.1rem; font-family: 'Poppins', sans-serif;">Nosso projeto visa proporcionar apoio emocional e psicológico por meio de ações que colocam as pessoas afetadas em contato direto com psicólogos capacitados. Acreditamos na importância de cuidar da saúde mental e oferecer suporte nos momentos difíceis.</p>
                            <p class="text-muted" style="font-size: 1.1rem; font-family: 'Poppins', sans-serif;">Além disso, buscamos conscientizar a sociedade sobre os impactos dos acidentes de trânsito, promovendo um ambiente de acolhimento e solidariedade para todos que necessitam.</p>
                            <footer class="border-top mt-5">
                                <div class="container px-4 px-lg-5 text-center">
                                    <p class="small text-muted fst-italic">Copyright &copy; Seu Projeto 2024. Criado com propósito e solidariedade.</p>
                                </div>
                            </footer>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </main>

    <!-- Scripts JS -->
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.2.3/dist/js/bootstrap.bundle.min.js"></script>
</body>
</html>
