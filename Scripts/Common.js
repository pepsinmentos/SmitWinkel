function Validate(formId) {
    var valid = true;
    $('#' + formId + ' .validate').each(function () {
        if ($(this).attr('type') == 'text') {
            if ($(this).val() == '') {
                $(this).addClass('error');
                valid = false;
                $(this).focus(function () {
                    $(this).removeClass('error');
                    $(this).prop('focus', null);
                });
            }
        }
        else if ($(this).attr('type') == 'checkbox') {
            if (!$(this).is(':checked')) {
                $(this).addClass('error');
                valid = false;
            }
        }
        else if ($(this).attr('type') == 'radio') {
            if (!$('input[name=' + $(this).attr('name') + ']').is(':checked')) {
                var parent = $(this).closest('.radiocontainer').addClass('error');
                valid = false;
                $(this).focus(function () {
                    parent.removeClass('error');
                    parent.prop('focus', null);
                });
            }
        }
    });
    return valid;
}


$('span.nav-btn').click(function () {
    $('ul.nav').slideToggle();
});

$(window).resize(function () {
    if ($(window).width() > 600) {
        $('ul.nav').show();
    }
    else if ($(window).width() > 600) {
        $('ul.nav').hide();
    }
});