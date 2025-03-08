<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="contato.aspx.cs" Inherits="OProjeto.Site.Contato" %>

<!DOCTYPE html>
<html lang="pt-BR">
<head>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no" />
    <meta name="description" content="Apoio psicológico para vítimas de trânsito e familiares" />
    <meta name="author" content="Faculdade Maurício de Nassau" />
    <title>Contato - Apoio Psicológico</title>
    <link rel="icon" type="image/x-icon" href="assets/favicon.ico" />
    <!-- Ícones do Font Awesome -->
    <script src="https://use.fontawesome.com/releases/v6.3.0/js/all.js" crossorigin="anonymous"></script>
    <!-- Fontes do Google -->
    <link href="https://fonts.googleapis.com/css?family=Lora:400,700,400italic,700italic" rel="stylesheet" type="text/css" />
    <link href="https://fonts.googleapis.com/css?family=Open+Sans:300italic,400italic,600italic,700italic,800italic,400,300,600,700,800" rel="stylesheet" type="text/css" />
    <!-- CSS do Bootstrap -->
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.2.3/dist/css/bootstrap.min.css" rel="stylesheet" />
    <!-- CSS principal do tema -->
    <link rel="stylesheet" href="/Content/main.css">
</head>
<body>
    <!-- Nav -->
    <nav class="navbar navbar-expand-lg navbar-dark bg-dark" id="mainNav">
        <div class="container px-4 px-lg-5">
            <a class="navbar-brand text-white" href="index.aspx">Apoio Psicológico</a>
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
                        <h1>Contato</h1>
                        <span class="subheading">Estamos aqui para ajudar você e sua família.</span>
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
                    <p>Entre em contato conosco preenchendo o formulário abaixo. Retornaremos o mais rápido possível!</p>
                    <div class="my-5">
                        <form id="contactForm" runat="server">
                            <div class="form-floating mb-3">
                                <input class="form-control" id="nome" type="text" placeholder="Digite seu nome..." runat="server" required />
                                <label for="nome">Nome</label>
                            </div>
                            <div class="form-floating mb-3">
                                <input class="form-control" id="email" type="email" placeholder="Digite seu e-mail..." runat="server" required />
                                <label for="email">E-mail</label>
                            </div>
                            <div class="form-floating mb-3">
                                <input class="form-control" id="telefone" type="tel" placeholder="Digite seu telefone..." runat="server" required />
                                <label for="telefone">Telefone</label>
                            </div>
                            <div class="form-floating mb-3">
                                <textarea class="form-control" id="mensagem" placeholder="Digite sua mensagem aqui..." style="height: 12rem" runat="server" required></textarea>
                                <label for="mensagem">Mensagem</label>
                            </div>
                            <asp:Button CssClass="btn btn-primary text-uppercase" ID="btnEnviar" runat="server" Text="Enviar" OnClick="EnviarFormulario" />
    
   
   
    

                            <a class="btn btn-success text-uppercase ms-3" href="https://wa.me/seunumero" target="_blank">Fale pelo WhatsApp</a>
                            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False">
                                 <Columns>
                                    <asp:BoundField DataField="Nome" HeaderText="Nome" />
                                    <asp:BoundField DataField="Email" HeaderText="E-mail" />
                                    <asp:BoundField DataField="Telefone" HeaderText="Telefone" />
                                    <asp:BoundField DataField="Mensagem" HeaderText="Mensagem" />
                                    <asp:BoundField DataField="DataEnvio" HeaderText="Data de Envio" />
                                 </Columns>
                            </asp:GridView>
                            <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                                   ConnectionString="<%$ ConnectionStrings:DefaultConnection %>" 
                                   SelectCommand="SELECT Nome, Email, Telefone, Mensagem, DataEnvio FROM Contato">
                            </asp:SqlDataSource>
                        </form>
                    </div>
                </div>
            </div>
        </div>
    </main>

    <!-- Rodapé -->
    <footer class="bg-light py-4">
        <div class="container text-center">
            <p class="small text-muted mb-0">Copyright &copy; Faculdade Maurício de Nassau 2024.</p>
            
        </div>
    </footer>

    <!-- Scripts JS -->
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.2.3/dist/js/bootstrap.bundle.min.js"></script>
    <script src="js/scripts.js"></script>
</body>
</html>

