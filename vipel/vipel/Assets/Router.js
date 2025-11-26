export function Router() {
    
}


const route = (event) => {
    event = event || windows.event;
    event.preventDefault();
    window.history.pushState({}, "", event.target.href);
    handleLocation();
};

const route = {
    404: {
        template: "./templates/404.html",
        title: ""
    },
    "/": {
        template: "",
        title: ""
    },
    "register": {
        template: "",
        title: ""
    }
};

const handleLocation = async () => {
    const path = window.location.pathname;
    const route = routes[path] || route[400];
    const html = await fetch(route).then((data) => data.text());
    document.getElementById("main-page").innerHTML = html;
};

window.onpopstate = handleLocation;
window.route = route;

handleLocation();


