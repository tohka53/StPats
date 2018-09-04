$(function () {
    $('#bancoModalCaller').click(function () {
        $('#clienteCatalog').modal({
            backdrop: false
        });
    });
    $('#insumosModalCaller').click(function () {
        $('#seriesCatalog').modal({
            backdrop: false
        });
    });
    $('#paquetes').filterByColum();
    $('#detalles').filterByColum({
        field: 'filter2'
    });
});


$(document).ready(function () {
    $.validator.addMethod("date",
       function (value, element) {
           return this.optional(element) || parseDate(value, "dd-MM-yyyy") !== null;
       });
});