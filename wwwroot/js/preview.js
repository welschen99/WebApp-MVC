$("#seleccionImg").change(function () {//cuando se selecciona una imagen se ejecuta
	var fileName = this.files[0].name;//nombre del primer archivo
	var fileSize = this.files[0].size;//y su tamaño
	var esArchValido = 0;

	if(fileSize > 3000000){
		alert('El archivo no debe superar los 3MB');
		this.value = '';
		this.files[0].name = '';
		esArchValido = 1;//es invalido
	}else{
		// recuperamos la extensión del archivo
		var ext = fileName.split('.').pop();
		
		// Convertimos en minúscula
		ext = ext.toLowerCase();
    
		switch (ext) {
			case 'jpg':
			case 'jpeg':
			case 'png': break;
			default:
				alert('El archivo no tiene la extensión adecuada');
				this.value = ''; // reset del valor
				this.files[0].name = '';
				esArchValido = 1;//si no es jpg es invalido
		}
	}
	if (esArchValido == 0) {
		readURL(this);
    }
	
});

function readURL(input) {
    if (input.files && input.files[0]) {
        var reader = new FileReader();//clase para leer el archivo

        reader.onload = function (e) {//cuando carga
			$("#imagen").attr("src", e.target.result);//al atributo src lo que se cargo al seleccionar la imagen
			$("#imagen").attr("display", "block");// cuando carga la nueva imagen al editar la muestre
        }

        reader.readAsDataURL(input.files[0]); // leer el archivo cargada en el input a string base64 y mostrarlo
    }
}