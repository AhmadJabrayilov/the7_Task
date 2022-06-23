const header = document.querySelector("header");

window.addEventListener("scroll", function () {
  if (window.scrollY > 50) {
    header.style.backgroundColor = "#2c2d31";
    header.style.transition = "all .3s";
  } else {
    header.style.backgroundColor = "transparent";
    header.style.transition = "all .3s";
  }
});