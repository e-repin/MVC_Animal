var modeButton = document.getElementById("buttonMode");
var link = document.getElementById("refButtonMode");


function ChangeTheme() {
    let lightTheme = "https://localhost:44373/Content/NightMode/LightMode.css";
    let darkTheme = "https://localhost:44373/Content/NightMode/NightMode.css";

    var name = modeButton.innerHTML;

    var currTheme = link.getAttribute("href");

    if (name == "Night mode") {
        modeButton.innerHTML = "Light mode";
        modeButton.className = "LightMode"
        currTheme = darkTheme;
    }
    else {
        modeButton.innerHTML = "Night mode";
        modeButton.className = "NightMode"
        currTheme = lightTheme;
    }
    link.setAttribute("href", currTheme);
}

modeButton.addEventListener("click", ChangeTheme);