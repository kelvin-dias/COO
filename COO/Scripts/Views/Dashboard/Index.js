let app;
class Index {
    constructor() {
        this.ObterDados();
    }

    ObterDados() {
        $.ajax(
            {
                type: 'GET',
                url: '/Dashboard/ObterDados',
                dataType: 'json',
                cache: false,
                async: true,
                success: function (data) {
                    $(".ribbon-box").html(data);
                    if (data > 0) {
                        $("#qtdOcorrencia").removeClass("ribbon-primary");
                        $("#qtdOcorrencia").addClass("ribbon-danger");
                    }
                    else {
                        $("#qtdOcorrencia").removeClass("ribbon-danger");
                        $("#qtdOcorrencia").addClass("ribbon-primary");
                    }
                    
                }
            });

    }
}

$(document).ready(function () {
    app = new Index();
    setInterval(app.ObterDados, 10000);
});