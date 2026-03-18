function toggleMenu(element) {
    let submenu = element.nextElementSibling;

    let display = window.getComputedStyle(submenu).display;

    if (display === "block") {
        submenu.style.display = "none";
    } else {
        submenu.style.display = "block";
    }
}
//function toggleGig() {
//    //alert("Clicked");  // working ✔

//    let menu = document.getElementById("gigMenu");
//    let arrow = document.getElementById("gigArrow");

//    menu.classList.toggle("open");

//    if (menu.classList.contains("open")) {
//        arrow.style.transform = "rotate(180deg)";
//    } else {
//        arrow.style.transform = "rotate(0deg)";
//    }
//}
//function toggleGig() {
//    let menu = document.getElementById("gigMenu");
//    let arrow = document.getElementById("gigArrow");

//    menu.classList.toggle("open");

//    if (menu.classList.contains("open")) {
//        arrow.style.transform = "rotate(180deg)";
//    } else {
//        arrow.style.transform = "rotate(0deg)";
//    }
//}

    function toggleGig() {
    const menu = document.getElementById("gigMenu");
    const arrow = document.getElementById("gigArrow");

    if (menu.style.display === "none") {
        menu.style.display = "block";
    arrow.style.transform = "rotate(180deg)";
    } else {
        menu.style.display = "none";
    arrow.style.transform = "rotate(0deg)";
    }
}