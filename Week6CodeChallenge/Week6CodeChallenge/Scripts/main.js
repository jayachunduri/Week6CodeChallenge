/*About page start*/

$(document).ready(function () {

    $('body').on('click', '.ajax-get', function () {
        var urlRequest = $(this).data('url');
        $.get(urlRequest, function (data) {
            $('.content').html(data);
        });
    });

   

});

   var tabShow = function () {
        $.get('/About/Who', function (data) {
            $('.tabcontent').html(data);
        });
    
        $('.tabsList').on('click', '.tabid', function () {
            alert('tabs');
            var urlRequest = $(this).data('url');
            $.get(urlRequest, function (data) {
                $('.tabcontent').html(data);
            });
        });
    };