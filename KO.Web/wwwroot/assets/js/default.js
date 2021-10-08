var aryTreathment;

$(function () {

    getThreathments();

    $('.search-text').keyup(function () {
        $('#hdnTreatmentId').val('');
    });

});

function getThreathments() {
    
    $.ajax({
        type: 'GET',
        dataType: 'json',
        url: '/handlers/action.ashx?q=UsingAllTreatments',
        success: function (response) {
            aryTreathment = $.map(response, function (data) {
                //return { 'id': data[2].Value, 'value': data[3].Value, 'data': { 'category': data[1].Value, 'value': data[0].Value } };
                return { 'id': data[0].Value, 'value': data[1].Value };
            });
            autoComplete();
        },
        error: function (query, jqXHR, textStatus, errorThrown) {
            console.log('hata oluştu: Ajax Tedavi Liste Getir');
        }
    });

}

function autoComplete() {

    $('.search-text').autocomplete({
        lookup: aryTreathment,
        autoSelectFirst: true,
        minChars: 3,
        lookupLimit: 12,
        deferRequestBy: 1,
        //groupBy: 'category',
        transformResult: function (response) {
            return {
                suggestions: $.map(response.teams, function (dataItem) {
                    return { id: dataItem.id, value: dataItem.value/*, data: dataItem.data*/ };
                })
            };
        },
        onSelect: function (suggestion) {
            $('#hdnTreatmentId').val(suggestion.id);
        }
    });

}