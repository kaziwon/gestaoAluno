$(function () {
   
    $(document).on("click", "#cadastrar", function () {

        if (validaCampos()) {
            
            $.ajax({
                method: "POST",
                url: "/Aluno/CadastrarAluno",
                data: {"RM" : $('#rm').val(), "Nome": $('#nome').val()},
                success: function (retorno) {
                    if (retorno) {
                        alert(retorno);
                    }
                    else {
                        alert('erro');
                    }
                },
                error: function() {
                    alert('erro');
                }
            });
            
        };
        
    });

    const validaCampos = function () {
        let nome = $('#nome').val();
        let rm = $('#rm').val();
        if (nome == "" || rm == "") {
            alert("Preenche os campos carai");
            return false;
        } else {
            return true;
        }
    };
});