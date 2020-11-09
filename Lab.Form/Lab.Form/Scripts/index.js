$("#btn-submit").on('click', () => {
    console.log("hola");
    var name = $("#name").val();
    var surname = $("#surename").val();
    if (name == null || name.length== 0) {
        if (surname == null || surname.length == 0) {
            alert("Falta cargar nombre y apellido")
        } else {
            alert("Falta cargar el nombre")
        }
    } else  if (surname == null || surname.length == 0) {
            alert("falta cargar apellido")
        } else {
            alert("Cargado")
        }
    
})

