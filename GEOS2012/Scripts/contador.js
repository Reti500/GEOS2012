$(function () {
    var cadena = $('#mensaje').text();
    var palabra = $('#mensaje span').text();
    var dialogo = $('#dialog').dialog();

    $('#dialog p').append("Tiene " + cadena.length + " caracteres!!");
    $('#dialog').append("<p>La palabra " + palabra + " tiene " + palabra.length + " caracteres!!");
});