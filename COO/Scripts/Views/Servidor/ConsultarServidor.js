let app;
class ConsultarServidor {
    constructor() {
        this.Eventos();
    }

    Eventos() {
        debugger
        $('#btnSalvar').click(function (){
            let servidor = {
                Nome: $(".txtNome").val(),
                ServidorIp: $(".txtIp").val(),
                Ambiente: $("#rblAmbiente").val(),
                Observacao: $(".txtObservacao").val()
            }
            $.ajax({
                dataType: "json",
                type: "POST",
                url: "/Servidor/AdicionarServidor",
                data:{servidor},
                success: function (dados) {
                    alert("Sucesso");
                },
                error: function (xhr, er) {
                    alert("Ocorreu erro!");
                }
            });
        });
    }

    GravarServidor() {
        
    }
}

$(document).ready(function(){
    app = new ConsultarServidor();
 });