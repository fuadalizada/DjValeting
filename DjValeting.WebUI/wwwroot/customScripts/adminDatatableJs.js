var toastr;
$(document).ready(function () {
    deleteFunction();
    approveFunction();
    UpdateFunction();
});

function deleteFunction() {

    $(".deleteIcon").on("click", function () {
        var guid = $(this).attr("data-id");

        $.ajax({
            method: "Delete",
            url: "/Admin/DeleteForm",
            data: { id: guid },
            success: function (msg) {
                if (msg) {
                    showSuccessMessage("Successfully deleted", "Information");
                    setTimeout(() => {
                        window.location.href = "/Admin/Index";
                    }
                        , 2000);
                }
                else {

                    showErrorMessage("Not Deleted", "Problem occured while deleting form.");
                }
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
                    setTimeout(() => {
                        window.location.href = "/Admin/Index";
                    }
                        , 2000);

                }
                else {
                    showErrorMessage("Not Approved", "Problem occured while approving form.");
                }
            }
        });
    });
}

function UpdateFunction() {

    $(".editIcon").on("click", function () {
        var guid = $(this).attr("data-id");
        window.open("/Admin/Update?id=" + guid, "_blank");
    });

    $("#Confirm").on("click",
        function () {
            var formData = new FormData();
            var id = $(this).attr("data-id");
            var formCreateDate = $(".datetimepicker-input").val();
            var name = $(".Name").val();
            var email = $(".email").val();
            var flexibilityId = $("#flexibilityId").val();
            var vehicleSizeId = $("#vehicleSizeId").val();
            var contactNumber = $(".contact").val();

            formData.append("Id", id);
            formData.append("Name", name);
            formData.append("CreateDate", formCreateDate);
            formData.append("Email", email);
            formData.append("FlexibilityId", flexibilityId);
            formData.append("VehicleSizeId", vehicleSizeId);
            formData.append("ContactNumber", contactNumber);
            $.ajax({
                type: "PUT",
                url: "/Admin/Update",
                data: formData,
                processData: false,
                contentType: false,
                success: function (data) {
                    if (data) {
                        showSuccessMessage("Successfully updated", "Information");
                        setTimeout(() => {
                            window.opener.location.reload();
                            window.top.close();
                        }
                            , 2000);

                    }
                    else {
                        showErrorMessage("Not updated", "Problem occured while updating form.")
                    }
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