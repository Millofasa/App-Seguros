/// <reference path="jquery-1.10.2.intellisense.js" />
var ProductoId = 0;
$(function () {

    //$("form").submit(function () {

    //    $("#Asesor").val($("#ddlAsesor").val());
    //    $("#Compania").val($("#ddlCompania").val());
    //    $("#TipoItem").val($("#ddlTipoItem").val());

    //});

    $("#PopUpCliente").dialog({
        autoOpen: false,
        show: {
            effect: "blind",
            duration: 1000
        },
        hide: {
            effect: "explode",
            duration: 1000
        },
        height: "auto",
        width: "60%",
        buttons: {
            "AGREGAR": function () {
                var res = NewItem();
                if (res) {
                    $(this).dialog("close");
                }
            },
            "CANCELAR": function () {
                $(this).dialog("close");
            },
        }
    });
});


function AddVenta(idProducto) {
    this.ProductoId = idProducto;
    $("#PopUpCliente").dialog("open");

}

function NewVenta() {
    var IsOk = false;
    var ItemId = parseInt($('#ddlAsesor  :selected').val());
    var Desc = $("#TxtDescripcion").val();;

    $.ajax({
        type: "POST",
        data: { IdProducto: this.ProductoId, IdItem: ItemId, Descripcion: Desc },
        url: "../../ItemsProducto/Create",
        success: function (response) {
            if (response) {
                alert(response.message);
                IsOk = true;
            }
            else {
                alert(response.message);
                IsOk = true;
            }
        },
        error: function (xhr, ajaxOptions, thrownError) {
            alert(" Error interno. " + xhr.statusText + "   " + thrownError);
        }
    });
    return IsOk;
}
