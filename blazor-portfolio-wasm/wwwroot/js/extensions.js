let prevScrollPos = window.pageYOffset;

window.onscroll = () => {
    const currentScrollPos = window.pageYOffset;
    document.getElementById("contextBar").style.top =
        prevScrollPos > currentScrollPos ? "0" : "-100px";
    prevScrollPos = currentScrollPos;
}