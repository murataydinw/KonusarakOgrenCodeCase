function modalValidation() {

    var valid = true;
    $('#feedbackModal .validate').removeAttr('style');

    $('#feedbackModal .validate').each(function () {

        if ($(this).val().length == 0) {
            $(this).css({ 'border': '1px solid #f00' });
            valid = false;
        }

    });

    return valid;



}