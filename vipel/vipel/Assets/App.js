// import * as htmlElemnts from "./js/html-elements.js";
// import * as templates from "./js/templates.js";
// import * as utils from "utils.js";
// import * as handlers from "./js/handlers.js";

import { utils } from "./js/utils.js";

/**
 * App.
 * @param {void} a
 * @param {void} b
 * @property {Function} init
 */
async function App(event) {
	const token = localStorage.getItem("jwt");
		
	// if (token != null && utils.token.jwt.checkExpired(token)) {
	// 	localStorage.removeItem("jwt");
	// 	location.href = "/login";
	// }

	if (utils.router.vipel.logIn(token) == utils.struct.Result.OK) return;
	if (utils.router.vipel.singUp(token) == utils.struct.Result.OK) return;
	if (await utils.router.vipel.init(token) == utils.struct.Result.OK) return;
	
	utils.router.vipel.unknown(token);
	return;
}

document.addEventListener("DOMContentLoaded", App);
window.addEventListener("hashchange", App);
