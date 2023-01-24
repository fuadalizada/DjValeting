var toastr;
$(document).ready(function () {
    deleteFunction();
    approveFunction();
});

function deleteFunction() {

    $(".deleteIcon").on("click", function () {
        var guid = $(this).attr("data-id");

        $.ajax({
            method: "Delete",
            url: "/Admin/DeleteForm",
            data: { id: guid },
            success: function (msg) {
                showSuccessMessage("Successfully deleted", "Information");
                window.location.href = "/Admin/Index";
            },
            error: function (xhr, status, error) {
                alert(error);
            }
        });
    });
}

function approveFunction() {

    $(".approveIcon").on("click", function () {
        var guid = $(this).attr("data-id");

        $.ajax({
            method: "Patch",
            url: "/Admin/ApproveForm",
            data: { id: guid },
            success: function (msg) {
                if (msg) {
                    showSuccessMessage("Successfully approved", "Information");
                    window.location.href = "/Admin/Index";
                }
                showErrorMessage("Not Approved", "Error");
            }
        });
    });
}

toastr.options = {
    "closeButton": true,
    "debug": false,
    "newestOnTop": true,
    "progressBar": true,
    "positionClass": "toast-top-right",
    "preventDuplicates": false,
    "onclick": null,
    "showDuration": "300",
    "hideDuration": "1000",
    "timeOut": "5000",
    "extendedTimeOut": "1000",
    "showEasing": "swing",
    "hideEasing": "linear",
    "showMethod": "fadeIn",
    "hideMethod": "fadeOut"
};

function showSuccessMessage(message, title) {
    toastr["success"](message, title);
}
function showErrorMessage(message, title) {
    toastr["error"](message, title);
}
function showInfoMessage(message, title) {
    toastr["info"](message, title);
}
function showWarningMessage(message, title) {
    toastr["warning"](message, title);
}