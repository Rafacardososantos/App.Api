async function CidadeListaCidades(cep, nome) {
    return new Promise((resolve, reject) => {
        Get('Cidade/ListaCidades?cep=' + cep + '&nome=' + nome).then(function (response) {
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

async function CidadeBuscaPorCep(cep) {
    return new Promise((resolve, reject) => {
        Get('Cidade/BuscaPorCep?cep=' + cep).then(function (response) {
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

async function CidadeSalvar( cep,  nome, estado) {
    return new Promise((resolve, reject) => {
        Post('Cidade/Salvar?cep=' + cep + '&nome=' + nome + '&estado=' + estado).then(function (response) {
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

async function CidadeRemover(id) {
    return new Promise((resolve, reject) => {
        Delete('Cidade/Remover?id=' + id).then(function (response) {
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