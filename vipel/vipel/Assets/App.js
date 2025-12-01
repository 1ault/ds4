// import * as htmlElement from "./htmlElement.js";
// import { LogIn } from "./htmlElement.js"; // named import
// import htmlElement from "./htmlElement.js";
import * as templates from "./templates.js";
import * as handlers from "./handlers.js";
import * as htmlElement from "./htmlElement.js";
import * as user from "./User.js";

const Result = {
	OK: 0,
	ERR: 1,
};

async function App() {
	// console.log(window.location.hash);
	// console.log(window.location.pathname);

	const token = localStorage.getItem("jwt");
	if (token && window.location.pathname != "/vipel") {
		window.location.href = "/vipel";
		return;
	}

	if (
		!window.location.pathname ||
		window.location.pathname === "/" ||
		window.location.pathname === "" ||
		window.location.pathname === "#/" ||
		window.location.pathname.includes("#/singup")
	) {
		window.location.href = "/singup";
		return;
	}

	if (window.location.pathname === "/singup") {
		htmlElement.body.innerHTML = templates.initSignUp;
		htmlElement.SignUp.form.addEventListener("submit", handlers.onFormSubmit);
		return;
	}

	if (window.location.pathname === "/login") {
		htmlElement.body.innerHTML = templates.initLogIn;
		htmlElement.LogIn.form.addEventListener("submit", handlers.onFormSubmit);
		return;
	}

	if (!token) {
		window.location.href = "/login";
	}

	if (window.location.pathname === "/vipel") {
		console.log("Vipel");

		if ((await user.CheckToken(token)) == false) {
			window.location.href = "/login";
			return;
		}

		const user_status = await user.CheckStatus(token);
		console.log(user_status);
		
		
		htmlElement.body.innerHTML = templates.initLogIn;
		// console.log(user_status);
		// htmlElement.body.innerHTML = templates.initLogIn;
		// htmlElement.LogIn.form.addEventListener("submit", handlers.onFormSubmit);
		return;
	}
	// if (window.location.pathname === "/vipel") {
	// 	htmlElement.body.innerHTML = templates.initLogIn;
	// 	htmlElement.LogIn.form.addEventListener("submit", handlers.onFormSubmit);
	// 	return;
	// }

	// if (!window.location.hash
	//     || window.location.hash === ""
	//     || window.location.hash === "#/"
	//     || window.location.hash.includes("#/register")
	// ) {

	//     htmlElement.body.innerHTML = templates.initSignUp;
	//     htmlElement.SignUp.form.addEventListener("submit", handlers.onFormSubmit);
	//     return;
	// }

	// if (window.location.hash.includes("#/login")) {
	//     htmlElement.body.innerHTML = templates.initLogIn;
	//     htmlElement.LogIn.form.addEventListener("submit", handlers.onFormSubmit);
	//     return;
	// }

	//
	// console.log("module namespace:", htmlElement);
	// console.log("available exports:", Object.keys(htmlElement));
	// console.log("default export:", htmlElement.default);

	// console.log(document.querySelector("#form-login"));
	// console.log(htmlElement);
	// console.log(htmlElement.LogIn);

	// console.log(htmlElement.LogIn);
	// console.log(htmlElement.LogIn.formLogin);
	// console.log(document.querySelector("#form-login"));
	// htmlElement.LogIn.formLogin.addEventListener("submit", handlers.onFormSubmit);

	// //let login_check = Login();

	// htmlElement.body.innerHTML = templates.initSignUp;
	// return;

	// if (login_check.Result == Result.ERR) {
	//     htmlElement.body.innerHTML = templates.initLogIn;
	//     htmlElement.LogIn.formLogin.addEventListener()
	//     return;
	// }

	// const data = await response.json();

	// console.log(data);
}

document.addEventListener("DOMContentLoaded", App);
window.addEventListener("hashchange", App);

//async function Login() {

//    const laptops_json = {
//        id: 0,
//        nombre: 1,
//        precio: 2,
//        stock: 3
//    };

//    let response = await fetch(url_access_login, {
//        method: "POST",
//        headers: {
//            'Accept': 'application/json',
//            'Content-Type': 'application/json'
//        },
//        body: JSON.stringify(laptops_json)
//    });

//    if (!response.ok) {
//        throw new Error("Error: " + response.status);
//    }

//    return Result;
//}
