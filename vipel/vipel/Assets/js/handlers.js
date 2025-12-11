import { htmlElements } from "./html-elements.js";
import { utils } from "./utils.js";
import { templates } from "./templates.js";

/**
 * @typedef {Object} handlers
 */
export const handlers = {};

handlers.onFormSubmit = async (e) => {
	e.preventDefault();

	// console.log(e);
	// console.log(e.submitter);

	if (!e.submitter) {
		return;
	}

	if (e.submitter.id.includes("login")) {
		e.submitter.disabled = true;
		const json_user = {
			// Username: htmlElements.vipel.logIn.inputName.value,
			Email: htmlElements.vipel.logIn.form.input.email().value,
			Password: htmlElements.vipel.logIn.form.input.password().value,
		};

		const response = await fetch(utils.config.endPoint.access.logIn, {
			method: "POST",
			headers: {
				Accept: "application/json",
				"Content-Type": "application/json",
			},
			body: JSON.stringify(json_user),
		});

		e.submitter.disabled = false;

		if (!response.ok) {
			throw new Error("Error: " + response.status);
		}

		const json = await response.json();

		document.querySelector(".status").textContent = json.Message;
		document.querySelector(".status").classList.remove("hidden");

		if (json.Result == true) {
			const tokenData = json.Data;
			localStorage.setItem("jwt", tokenData);
			const token = localStorage.getItem("jwt");

			utils.router.replace.state("/vipel");
			utils.router.vipel.init(token);
		}

		return;
	}

	if (e.submitter.id.includes("singup")) {
		e.submitter.disabled = true;
		const json_user = {
			Username: htmlElements.vipel.signUp.form.input.name().value,
			Email: htmlElements.vipel.signUp.form.input.email().value,
			Password: htmlElements.vipel.signUp.form.input.password().value,
		};

		const response = await fetch(utils.config.endPoint.access.singUp, {
			method: "POST",
			headers: {
				Accept: "application/json",
				"Content-Type": "application/json",
			},
			body: JSON.stringify(json_user),
		});

		e.submitter.disabled = false;

		if (!response.ok) {
			throw new Error("Error: " + response.status);
		}

		const json = await response.json();

		htmlElements.vipel.signUp.form().reset();
		document.querySelector(".status").textContent = json.Data;
		document.querySelector(".status").classList.remove("hidden");
		return;
	}
};

// const form = document.querySelector("#searchForm");
// const searchBox = document.querySelector("#searchBox");
// const resultsList = document.querySelector("#results");

// let timerId = null;
// const DEBOUNCE_MS = 300; // wait a bit after typing

// handlers.onInputSearch = async (e) => {
// 	const term = queueSelector('input[data-name="search"]').value.trim();

// 	// stop previous timer
// 	if (timerId !== null) {
// 		clearTimeout(timerId);
// 	}

// 	// if empty, clear list
// 	if (term === "") {
// 		resultsList.innerHTML = "";
// 		return;
// 	}

// 	// small delay so it doesn’t spam fetch
// 	timerId = setTimeout(async () => {
// 		try {
// 			// CHANGE THIS URL to your API
// 			const response = await fetch(
// 				`https://localhost:44305/api/Search?term=${encodeURIComponent(term)}`,
// 			);

// 			if (!response.ok) {
// 				console.error("HTTP error:", response.status);
// 				return;
// 			}

// 			// if you return Reply<T>:
// 			// const reply = await response.json();
// 			// renderResults(reply.Data);

// 			const data = await response.json(); // simple array
// 			renderResults(data);
// 		} catch (err) {
// 			console.error("Fetch error:", err);
// 		}
// 	}, DEBOUNCE_MS);
// };


handlers.adminPanel = {};

handlers.adminPanel.onClick = (event) => {
	event.preventDefault();

	const select = document.querySelector("#module_type");
	const moduleTypeId = Number(select.value);

	let moduleContainer = document.querySelector('[data-module="Module-Container"]');

	let html = "";
	switch (moduleTypeId) {
		case 0:
			break;
			html += templates.vipel.add.edit.mod.main();
			moduleContainer.innerHTML += html;
		case 1:
			html += templates.vipel.add.edit.mod.section();
			moduleContainer.innerHTML += html;
			break;
		case 2:
			html += templates.vipel.add.edit.mod.img();
			moduleContainer.innerHTML += html;
			break;
		case 3:
			html += templates.vipel.add.edit.mod.compost();
			moduleContainer.innerHTML += html;
			break;
		case 4:
			html += templates.vipel.add.edit.mod.H20();
			moduleContainer.innerHTML += html;
			break;
		default:
			break;
	}
	console.log();
	// console.log("dsafas");
};



// appendModuleRow