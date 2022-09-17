async function PessoaBusca(cpf) {
    return new Promise((resolve, reject) => {
        Get('Pessoa/Busca?cpf=' + cpf).then(function (response) {
            if (response.status === 'success') {
                resolve(response.data);
            } else {
                reject(response.message);
            }
        }, function (err) {
            console.error(err);
            reject('Erro desconhecido');
        });
    });
}
async function PessoaListaPessoa(cpf, nome) {
    return new Promise((resolve, reject) => {
        Get('Pessoa/ListaPessoa?cpf=' + cpf + '&nome=' + nome).then(function (response) {
            if (response.status === 'success') {
                resolve(response.data);
            } else {
                reject(response.message);
            }
        }, function (err) {
            console.error(err);
            reject('Erro desconhecido');
        });
    });
}

async function PessoaSalvar(nome, cpf, email) {
    return new Promise((resolve, reject) => {
        Post('Pessoa/Salvar?nome=' + nome + '&cpf=' + cpf + '&email=' + email).then(function (response) {
            if (response.status === 'success') {
                resolve(response.data);
            } else {
                reject(response.message);
            }
        }, function (err) {
            console.error(err);
            reject('Erro desconhecido');
        });
    });
}

async function PessoaRemover(id) {
    return new Promise((resolve, reject) => {
        Delete('Pessoa/Remover?id=' + id).then(function (response) {
            if (response.status === 'success') {
                resolve(response.data);
            } else {
                reject(response.message);
            }
        }, function (err) {
            console.error(err);
            reject('Erro desconhecido');
        });
    });