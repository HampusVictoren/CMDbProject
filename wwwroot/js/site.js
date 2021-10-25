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
    let text = document.getElementsByClassName("readmore");
    
    if (plots[id].style.overflow === "visible") {
        plots[id].style.overflow = "hidden";
        plots[id].style.whiteSpace = "nowrap";
        plots[id].style.textOverflow = "ellipsis";
        selectedMovies[id].style.height = "226px";
        text[id].innerHTML = "Read more";
    }
    else {
        plots[id].style.overflow = "visible";
        selectedMovies[id].style.height = "auto";
        plots[id].style.whiteSpace = "normal";
        plots[id].style.textOverflow = "clip";
        text[id].innerHTML = "Read less";
    }
}