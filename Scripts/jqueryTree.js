//Author: Bryan Cruz
//Description: Fast tree collapsable creator 
(function ($) {

    $.fn.ramify = function (data) {
        var tree = this;

        if (!tree.hasClass("tree")) {
            tree.addClass("tree");
        }
        if (!tree.hasClass("well")) {
            tree.addClass("well");
        }
        tree.html("");
        console.log("Conteo de hijos:" + data.length);
        if (data.length > 0)
        {
            item = "";
            item += "<ul>";
            $.each(data, function ($i, row) {
                item += "<li>";
                item += "<span class='" +  row.styleClass + "'>" + row.label + "</span>";
                if (row.children.length > 0) {
                    item += "<ul>";
                    
                    $.each(row.children, function ($i2, row2) {
                        item += "<li>";
                        item += "<span class='" + row2.styleClass + "'>" + row2.label + "</span>";
                        if (row2.children.length > 0) {
                            item += "<ul>";

                            $.each(row2.children, function ($i3, row3) {
                                item += "<li>";
                                item += "<span class='" + row3.styleClass +"'>" + row3.label + "</span>";
                                if (row3.children.length > 0) {
                                    item += "<ul>";

                                    $.each(row3.children, function ($i4, row4) {
                                        item += "<li>";
                                        item += "<span class='" + row4.styleClass + "'>" + row4.label + "</span>";
                                        item += "</li>";
                                    });

                                    item += "</ul>";
                                }
                                item += "</li>";
                            });

                            item += "</ul>";
                        }
                        item += "</li>";
                    });

                    item += "</ul>";
                }
                item += "</li>";
            });
            item += "</ul>";
            tree.append(item);
            tree.find('li:has(ul)').addClass('parent_li');
            tree.find('li.parent_li > span').bind('click', function (e) {
                var children = $(this).parent('li.parent_li').find(' > ul > li');
                if (children.is(":visible")) {
                    children.hide('fast');
                } else {
                    children.show('fast');
                }
                e.stopPropagation();
            });
            tree.find('li.parent_li').find(' > ul > li').hide();
        }

        return this;
    };
}(jQuery));