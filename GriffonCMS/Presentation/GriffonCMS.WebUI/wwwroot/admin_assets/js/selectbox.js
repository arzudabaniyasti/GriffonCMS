$('select[name=things]').change(function () {
    if ($(this).val() == '') {
        window.location.href = '@Url.Action("Index","AdminCategory", new { Area = "Admin" })';
    }
});