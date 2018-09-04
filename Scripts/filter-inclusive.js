(function ($) {
    $.fn.filterByMultiColumn = function (filters) {
        var filterTable = this;
        baseObj = {
            filterClass: "filterByMe",
            field: "filter",
            on: "input"
        }
        $.each(filters, function ($id, filter) {
            var extFilter = $.extend({
                filterClass :'filterByMe',
                field: 'filter',
                on: 'input'
            }, filter)
            $("#" + extFilter.field).bind(extFilter.on, function () {
                filterTable.find("tr").show();
                $.each(filters, function ($id, filter) {
                    $.each(filterTable.find("td." + filter.filterClass), function () {
                        val = $("#" + filter.field).val();
                        if (val == "" || val == null) {
                            //Se loguean los valores ignorados
                            console.log(val);
                        } else {
                            if (!$(this).is(":contains('" + val + "')")) {
                                $(this).parent().hide();
                            }
                        }
                    });
                });
            })
        });
        return this;
    }
}(jQuery));