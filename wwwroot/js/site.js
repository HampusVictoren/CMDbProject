// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function showMobileSearch() {
    let x = document.getElementsByClassName("mobilesearch")[0];
    if (x.style.display === "block") {
        x.style.display = "none";
    } else {
        x.style.display = "block";
    }
}

function readMore(id) {
    id = id - 1;
    let selectedMovies = document.getElementsByClassName("top10movie");
    let plots = document.getElementsByClassName("plotp");
    
    if (selectedMovies[id].className != "top10movie") {
        selectedMovies[id].classList.toggle("top10movie");
        plots[id].classList.toggle("plotp");
    }
    else {
        selectedMovies[id].classList.toggle("top10expanded");
        plots[id].classList.toggle("plotexpanded");
    }
}