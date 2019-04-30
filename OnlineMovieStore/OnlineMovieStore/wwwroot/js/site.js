$(".card-block").mouseover(function () {
    console.log("show");
    viewDetail = GetViewDetailDiv(this);
    viewDetail.style.display = "block";

});

$(".card-block").mouseout(function () {
    console.log("hide");
    viewDetail = GetViewDetailDiv(this);
    viewDetail.style.display = "none";

})

function GetViewDetailDiv(node) {

    return node.getElementsByClassName("view-detail")[0];

}