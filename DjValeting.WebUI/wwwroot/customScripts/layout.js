var toastr;

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