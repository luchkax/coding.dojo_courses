$(document).ready(function(){
    $('img').click(function(){
        $(this).attr('temp', $(this).attr('src'));
        $(this).attr('src', $(this).attr('alt-src'));
        $(this).attr('alt-src', $(this).attr('temp'));
    });
});