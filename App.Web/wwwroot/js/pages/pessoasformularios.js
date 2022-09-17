function salvar() {
    let obj = {
        cpf: ($("[name='cpf']").val() || ''),
        nome: ($("[name='nome']").val() || ''),
        email: ($("[name='email']").val() || '')
    };
    PessoaSalvar(obj).then(function () {
        window.location.href = '/pessoa';
    }, function (err) {
        alert(err);
    });
}