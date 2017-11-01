$(document).ready(function () {
    $("#houseStark").click(function(){
        $("#name").text("");
        $("#words").text("");
        $("#titles").text("");
        $.get("https://anapioficeandfire.com/api/houses/362/",
            function (res) {
                console.log(res),
                $("#name").append(`Name: ${res.name}`);
                $("#words").append(`Words: ${res.words}`);
                var strng = "";
                for (i = 0; i < res.titles.length; i++) {
                    strng += res.titles[i];
                    strng += "; ";
                }
                $("#titles").append(`Titles: ${strng}`);
            })
        })
    $("#houseBaratheon").click(function(){
        $("#name").text("");
        $("#words").text("");
        $("#titles").text("");
        $.get("https://anapioficeandfire.com/api/houses/15/",
            function (res) {
                console.log(res),
                $("#name").append(`Name: ${res.name}`);
                $("#words").append(`Words: No Words ${res.words}`);
                var strng = "";
                for (i = 0; i < res.titles.length; i++) {
                    strng += res.titles[i];
                    strng += "; ";
                }
                $("#titles").append(`Titles: ${strng}`);
            })
        })
        $("#houseLannister").click(function(){
            $("#name").text("");
            $("#words").text("");
            $("#titles").text("");
        $.get("https://anapioficeandfire.com/api/houses/229/",
            function (res) {
                console.log(res),
                $("#name").append(`Name: ${res.name}`);
                $("#words").append(`Words: ${res.words}`);
                var strng = "";
                for (i = 0; i < res.titles.length; i++) {
                    strng += res.titles[i];
                    strng += "; ";
                }
                $("#titles").append(`Titles: ${strng}`);
            })
        })
         $("#houseTargaryen").click(function(){
            $("#name").text("");
            $("#words").text("");
            $("#titles").text("");
        $.get("https://anapioficeandfire.com/api/houses/378/",
            function (res) {
                console.log(res),
                $("#name").append(`Name: ${res.name}`);
                $("#words").append(`Words: ${res.words}`);
                var strng = "";
                for (i = 0; i < res.titles.length; i++) {
                    strng += res.titles[i];
                    strng += "; ";
                }
                $("#titles").append(`Titles: ${strng}`);
            })
        })
        
});