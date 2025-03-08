// Função para validar o cadastro
function validarCadastro() {
    var username = document.getElementById("new-username").value;
    var password = document.getElementById("new-password").value;
    var confirmPassword = document.getElementById("confirm-password").value;

    if (password !== confirmPassword) {
        document.getElementById("register-error-message").textContent = "As senhas não coincidem!";
        return false;
    }

    // Armazenar os dados do usuário no LocalStorage
    var users = JSON.parse(localStorage.getItem("users")) || [];
    users.push({ username: username, password: password });
    localStorage.setItem("users", JSON.stringify(users));

    alert("Cadastro realizado com sucesso!");
    window.location.href = "teladelogin.aspx"; // Redirecionar para a página de login
    return false;
}

// Função para validar o login
function validarLogin() {
    var username = document.getElementById("username").value;
    var password = document.getElementById("password").value;

    var users = JSON.parse(localStorage.getItem("users")) || [];
    var user = users.find(user => user.username === username && user.password === password);

    if (user) {
        alert("Login bem-sucedido!");
        window.location.href = "inicio.aspx"; // Redireciona para a página inicial após o login
    } else {
        document.getElementById("error-message").textContent = "Usuário ou senha incorretos!";
    }

    return false;
}
