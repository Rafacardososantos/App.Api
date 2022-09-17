$(document).ready(function () {
    load();
});

function load() {
    PessoaListaPessoa('', '').then(function (data) {
        data.forEach(obj => {
            $('#table tbody').append(`
                <tr id="obj-${obj.id}" >
                    <td>${obj.nome}</td>
                    <td>${obj.cpf}</td>
                    <td>${obj.email}</td>
                </tr>
                `);
        });
    });
}