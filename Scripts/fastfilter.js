(function ($) {
    $.fn.filterByColum = function (options) {
        var filterTable = this;
        var setting = $.extend({
            filterClass :'filterByMe',
            field: 'filter',
            on: 'input'
        }, options)
        $('#' + setting.field).on(setting.on, function () {
            $.each(filterTable.find('td.' + setting.filterClass), function () {
                if ($(this).is(':contains("' + $('#' + setting.field).val() + '")')) {
                    $(this).parent().show();
                } else {
                    $(this).parent().hide();
                }
            });
        });
        return this;
    }
}(jQuery));