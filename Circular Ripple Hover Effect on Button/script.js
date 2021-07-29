const ANIMATEDCLASSNAME = "animated";
const ELEMENTS = document.querySelectorAll(".HOVER");
const ELEMENTS_SPAN = [];
ELEMENTS.forEach((element, index) => {
    let addAnimation = false;
    if (element.classList[1] == "FLASH") {
        element.addEventListener("animationend", e => {
            element.classList.remove(ANIMATEDCLASSNAME);
        });
        addAnimation = true;
    }
    if (!ELEMENTS_SPAN[index])
        ELEMENTS_SPAN[index] = element.querySelector("span");
    element.addEventListener("mouseover", e => {
        ELEMENTS_SPAN[index].style.left = e.pageX - element.offsetLeft + "px";
        ELEMENTS_SPAN[index].style.top = e.pageY - element.offsetTop + "px";
        if (addAnimation) element.classList.add(ANIMATEDCLASSNAME);
    });
    element.addEventListener("mouseout", e => {
        ELEMENTS_SPAN[index].style.left = e.pageX - element.offsetLeft + "px";
        ELEMENTS_SPAN[index].style.top = e.pageY - element.offsetTop + "px";
    });
});
