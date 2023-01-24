

var toastr;
$(document).ready(function () {
    CreateForm();
});

function CreateForm() {
    $("#Save").on("click",
        function () {
            var formData = new FormData();
            var formCreateDate = $(".datetimepicker-input").val();
            var name = $(".Name").val();
            var email = $(".email").val();
            var flexibilityId = $("#flexibilityId").val();
            var vehicleSizeId = $("#vehicleSizeId").val();
            var contactNumber = $(".contact").val();

            formData.append("Name", name);
            formData.append("CreateDate", formCreateDate);
            formData.append("Email", email);
            formData.append("FlexibilityId", flexibilityId);
            formData.append("VehicleSizeId", vehicleSizeId);
            formData.append("ContactNumber", contactNumber);
            $.ajax({
                type: "POST",
                url: "/User/CreateForm",
                data: formData,
                processData: false,
                contentType: false,
                success: function (data) {
                    showSuccessMessage("Successfully created", "Information");
                    window.location.reload();
                }
            });
        }
    );
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