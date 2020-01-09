let app;
class DetalharOcorrencia {
    constructor() {
        this.PluginCaixaTexto();
        this.CarregarIteracoes();
        this.Eventos();
    }

    Eventos() {
        $('#btn-salvar-oc').click(function () {
            let objeto = {
                TextoIteracao: $('.note-editable').text()
                , OcorrenciaId: $("#hddnOcorrenciaId").val()
            }
debugger
            $.ajax({
                dataType: "json",
                type: "POST",
                url: "/Ocorrencia/AdicionarIteracoes",
                data: { iteracao: objeto },
                success: function (dados) {
                    console.log(dados);
                }
            });
        })
    }
    
    PluginCaixaTexto() {
        jQuery(function () {
            Codebase.helpers(['summernote', 'ckeditor', 'simplemde']);
        });
    }

    CarregarIteracoes() {
        $(function () {
            $.ajax({
                dataType: "json",
                type: "POST",
                url: "/Ocorrencia/ListarIteracoes",
                data: { Id: $("#hddnOcorrenciaId").val() },
                success: function (dados) {
                    $(dados).each((i) =>{
                        $("#iteracoesCarregadas").append(
                        `<tr class="table-active">
                            <td class="d-none d-sm-table-cell"></td>
                            <td class="font-size-sm text-muted">
                                <a>${dados[i].Assinatura}</a> on <em>February 1, 2017 16:15</em>
                            </td>
                        </tr>
                        <tr>
                            <td class="d-none d-sm-table-cell text-center" style="width: 140px;">
                                <div class="mb-10">
                                    <a href="be_pages_generic_profile.html"></a>
                                </div>
                                <small></small>
                            </td>
                        <td>
                            <p>${dados[i].TextoIteracao}</p>
                            <hr>
                        </td>
                        </tr>`);
                    });
                }
            });
        });
    }

}

$(document).ready(function () {
    app = new DetalharOcorrencia();
});