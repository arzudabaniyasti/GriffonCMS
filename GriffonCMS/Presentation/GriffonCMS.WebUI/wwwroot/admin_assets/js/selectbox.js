$('select[name=things]').change(function () {
    if ($(this).val() == '') {
        window.location.href = '#main';
    }
});