
$(document).ready(function () {
    deleteFunction();
    //var adminTable = $('#adminTable').DataTable({

    //    ajax: {
    //        "url": "/Admin/Index",
    //        type: 'POST',
    //        "data": function (d) {
    //            console.log($('#dateRange').val());
    //            return $.extend({}, d, {
    //                "dateRange": $('#dateRange').val()
    //            });
    //        }
    //    },
    //    });
});

function deleteFunction() {

    $(".deleteIcon").on("click", function () {
        var guid = $(this).attr("data-id");
        
        $.ajax({
            method: "Delete",
            url: "/Admin/DeleteForm",
            data: { id: guid },
            success: function (msg) {
                window.location.href = "/Admin/Index";
            },
            error: function (xhr, status, error) {
                alert(error);
            }
        });
    });
}