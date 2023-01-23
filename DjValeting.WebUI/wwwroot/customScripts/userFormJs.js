


$(document).ready(function () {
    CreateForm();

    //$("#createDate").datetimepicker({
    //    format: "DD/MM/YYYY"
    //});


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
                    window.location.reload();
                }
            });

        });
}