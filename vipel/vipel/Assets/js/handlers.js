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

handlers.onFormSubmitIndex = async (event) => {
	event.preventDefault();
	

	console.log(event);

	if (event.submitter.id.includes("add_module")) {

		window.location.href = "/vipel/add";
		return;
	}

	let timeout = null;

	if (event.target.matches("input")) {
		event.preventDefault();

		const input = event.target;

		const val =  input.value;

		clearTimeout(timeout);

        timeout = setTimeout(async () => {
            if (!val) return;

            console.log("Searching:", val);

        }, 300);

	}
};

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
			html += templates.vipel.add.edit.mod.main(crypto.randomUUID());
			moduleContainer.insertAdjacentHTML("beforeend", html);
		case 1:
			const randomUUID = crypto.randomUUID()
			html = templates.vipel.add.edit.mod.section(randomUUID);
			moduleContainer.insertAdjacentHTML("beforeend", html);

			const div = document.querySelector(`div[data-module-id="${randomUUID}"]`);
			const textarea = div.querySelector('[name="description"]');

			textarea.addEventListener("input", () => {
				textarea.style.height = "auto";
				textarea.style.height = textarea.scrollHeight + "px";
			});


			break;
		case 2:
			html += templates.vipel.add.edit.mod.img(crypto.randomUUID());
			moduleContainer.insertAdjacentHTML("beforeend", html);
			break;
		case 3:
			break;
			html += templates.vipel.add.edit.mod.compost(crypto.randomUUID());
			moduleContainer.insertAdjacentHTML("beforeend", html);
		case 4:
			break;
			html += templates.vipel.add.edit.mod.H20(crypto.randomUUID());
			moduleContainer += html;
		default:
			break;
	}
};



// appendModuleRow
handlers.onFormSubmitAdd = async (event) => {
	event.preventDefault();

	const pageEdit = document.querySelector("#PageEditor");
	const modules = Array.from(pageEdit.querySelectorAll(".module[data-module]"));
	const formData = new FormData();


	const jsonModules = modules.map((module, index) => {

		const read = (name) => module.querySelector(`[name="${name}"]`)?.value?.trim() ?? null;
		const getFile = () => module.querySelector('input[type="file"][name="image"]')?.files?.[0] ?? null;


		const order = index + 1;
		const moduleType = module.dataset.module;
		const moduleId = module.dataset.moduleId || (module.dataset.moduleId = crypto.randomUUID());


		switch (moduleType) 
		{
			case "Main": {
				const file = getFile() ?? null;

				let attachKey = null;
				if (file) {
					attachKey = `image_${moduleId}`;
					formData.append(attachKey, file);
				}

				return {
					action: "Insert",
					type: moduleType,
					idName: module.dataset.moduleTypeName ?? null,
					idType: module.dataset.moduleTypeId ?? null,
					order: Number(order ?? 0),
					id: moduleId,

					data: {
						title: read("title"),
						subtitle: read("subtitle"),
						description: read("description"),
						image: file?{attachKey, name: file.name, type: file.type, size: file.size}: null
					},
				};
			}

			case "Section": {
				return {
					action: "Insert",
					type: moduleType,
					idName: module.dataset.moduleTypeName ?? null,
					idType: module.dataset.moduleTypeId ?? null,
					order,
					id: moduleId,
					data: {
						title: read("title"),
						description: read("description")
					}
				};
			}

			case "Img": {
				const file = getFile();

				let attachKey = null;
				if (file) {
					attachKey = `image_${moduleId}`;
					formData.append(attachKey, file);
				}

				return {
					action: "Insert",
					type: moduleType,
					idName: module.dataset.moduleTypeName ?? null,
					idType: module.dataset.moduleTypeId ?? null,
					order,
					id: moduleId,
					data: {
						image: file
						? { attachKey, name: file.name, type: file.type, size: file.size, OriginalName: file.name, }
						: null
					}
				};
			}
				
			default: {
				return {
					action: "Insert",
					type: moduleType ?? "Unknown",
					order,
					id: moduleId,
					data: {}
				};
			}
		}
	});

	console.log(pageEdit.dataset.pageId);
	const payload = {
		// pageId: Number(pageEdit.dataset.pageId ?? 0),
		// pageId: 5,
		modules: jsonModules
	};
	formData.append("pageId", JSON.stringify(10));
	formData.append("payload", JSON.stringify(payload));

	const tokenLoad = localStorage.getItem("jwt");

	const json = await utils.fetch.server.post.insertPost(utils.config.endPoint.access.userInsertPost, tokenLoad, formData);


	console.log(json);
	window.location.href = "/vipel";
};


handlers.adminUserPanel = async (event) =>  {
	console.log(event);
	if (!event.target.matches("select[data-key='role']")) return;
	
	const tr = event.target.closest("tr");
	const tds = tr.querySelectorAll("td");


	const rowData = {
		id: tds[0].textContent,
		username: tds[1].textContent,
		email: tds[2].textContent,
		role: event.target.value
	};

 	console.log(rowData);

	const tokenLoad = localStorage.getItem("jwt");

	utils.fetch.server.post.updatePut(
		utils.config.endPoint.access.adminSetRole, 
		tokenLoad, 
		rowData
	);
};