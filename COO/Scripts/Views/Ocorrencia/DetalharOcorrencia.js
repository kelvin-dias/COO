let app;
class DetalharOcorrencia {
    constructor() {
        this.PluginCaixaTexto();
        this.CarregarIteracoes();
    }

    PluginCaixaTexto() {
        jQuery(function () {
            Codebase.helpers('ckeditor');
        });
    }

    CarregarIteracoes() {
        $(function () {
            debugger
            $.ajax({
                dataType: "json",
                type: "POST",
                url: "/Ocorrencia/ListarIteracoes",
                data: { Id: $("#hddnOcorrenciaId").val() },
                success: function (dados) {
                    $(dados).each((i) =>{
                        $("#iteracoesCarregadas").html(
                        `<tr class="table-active">
                            <td class="d-none d-sm-table-cell"></td>
                            <td class="font-size-sm text-muted">
                            <a>${dados[i].Assinatura}</a> on <em>February 1, 2017 16:15</em>
                            </td>
                        </tr>
                        <tr>
                            <td class="d-none d-sm-table-cell text-center" style="width: 140px;">
                                <div class="mb-10">
                                    <a href="be_pages_generic_profile.html">
                                    <img class="img-avatar" src="assets/media/avatars/avatar5.jpg" alt="">
                                    </a>
                                </div>
                                <small>111 Posts<br>Level 2</small>
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