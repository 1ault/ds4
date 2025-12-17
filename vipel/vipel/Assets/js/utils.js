import { templates } from "./templates.js";
import { htmlElements } from "./html-elements.js";
import { handlers } from "./handlers.js";

/**
 * @typedef {Object} Utils
 */
export const utils = {};

utils.struct = {};

utils.struct.Result = {
	OK: true,
	ERR: false,
};

utils.struct.Roles = {
	Banned: -2,
	Inactive: -1,
	Applicant: 0,
	Invited: 1,
	User: 2,
	Moderator: 99,
	Admin: 100,
};


utils.config = {};
utils.config.endPoint = {};

utils.config.endPoint.access = {
	logIn: `${window.appConfig.endPoint.access}/Login`,
	singUp: `${window.appConfig.endPoint.access}/SingUp`,
	userCheck: `${window.appConfig.endPoint.access}/UserCheck`,
	userStatus: `${window.appConfig.endPoint.access}/UserStatus`,
	userGetAvatar: `${window.appConfig.endPoint.access}/UserGetAvatar`,
	
	adminGetUser: `${window.appConfig.endPoint.access}/AdminGetUser`,
	userGetPost: `${window.appConfig.endPoint.access}/UserGetPost`,

	userInsertPost: `${window.appConfig.endPoint.access}/userInsertPost`,
	adminSetRole: `${window.appConfig.endPoint.access}/AdminSetRole`,

	getImage: `${window.appConfig.endPoint.access}/GetImage`,
	
};


utils.fetch = {};
utils.fetch.server = {};


utils.fetch.server.assets = {};
utils.fetch.server.assets.getAvatar = async (token) => {
	try {
		const response = await fetch(utils.config.endPoint.access.userGetAvatar, {
			headers: {
				Authorization: "Bearer " + token,
			},
		});
	
		if (!response.ok) {
			throw new Error("Error: " + response.status);
		}

		const data = await response.json();
		return data;
	} catch (err) {
		console.error("Fetch error:", err);
	}
};

utils.fetch.server.post = {};

utils.fetch.server.post.updatePut = async (url, token, body) => {
	try {
		const response = await fetch(url, {
			method: "PUT",
			headers: {
				"Authorization": `Bearer ${token}`,
				"Content-Type": "application/json; charset=utf-8",
        		"Accept": "application/json"
			},
			body: JSON.stringify({
				ID: body.id,
				Username: body.username,
				Email: body.email,
				Role: body.role,
			}),
		});

	if (!response.ok) {
		throw new Error("Error: " + response.status);
	}

	const json = await response.json();

	return json;
	} catch (err) {
		console.error("Fetch error:", err);
	}
};

utils.fetch.server.post.insertPost = async (url, token, body) => {
	
	let json = null;
	try {
		const response = await fetch(`${url}`, {
			method: "POST",
			headers: {
				Authorization: "Bearer " + token,
			},
			body: body
		});

		if (!response.ok) {
			throw new Error("Error: " + response.status);
		}

		json = await response.json();
	} catch (err) {
		console.error("Fetch error:", err);
	}

	return json;
};

utils.fetch.server.post.tokenAndVal = async (url, val) => {
	try {
		const response = await fetch(`${url}`, {
			method: "POST",
			headers: {
				Authorization: "Bearer " + token,
			},
			body: JSON.stringify({
				id: val,
			}),
		});

		if (!response.ok) {
			throw new Error("Error: " + response.status);
		}

		const json = await response.json();

		return json;
	} catch (err) {
		console.error("Fetch error:", err);
	}
};

utils.fetch.server.token = async (url, token, method) => {
	try {
		const response = await fetch(`${url}`, {
			method: `${method}`,
			headers: {
				Authorization: "Bearer " + token,
			},
		});

		if (!response.ok) {
			throw new Error("Error: " + response.status);
		}
		
		const json = await response.json();

		return json;
	} catch (err) {
		console.error("Fetch error:", err);
	}
}

utils.fetch.server.get = {};

utils.fetch.server.get.image = async (token, hash) =>
{
	try {
		// console.log(`${utils.config.endPoint.access.getImage}/${hash}`);
		
		const response = await fetch(`${utils.config.endPoint.access.getImage}/${hash}`, {
			method: "GET",
			headers: {
				Authorization: "Bearer " + token,
			},
			// body: JSON.stringify({
			// 	hash: hash,
			// }),
		});

		if (!response.ok) {
			throw new Error("Error: " + response.status);
		}
		
		const blob = await response.blob();

		return URL.createObjectURL(blob); 
	} catch (err) {
		console.error("Fetch error:", err);
	}
};

utils.fetch.server.get.post = {};
utils.fetch.server.get.post.id = async (url, token, id) => {
	try {
		const response = await fetch(`${url}/${id}`, {
			method: "GET",
			headers: {
				Authorization: "Bearer " + token,
			},
		});

		if (!response.ok) {
			throw new Error("Error: " + response.status);
		}
		
		const json = await response.json();

		return json;
	} catch (err) {
		console.error("Fetch error:", err);
	}
};

utils.fetch.server.get.token = async (url, token) => {
	try {
		const response = await fetch(`${url}`, {
			method: "GET",
			headers: {
				Authorization: "Bearer " + token,
			},
		});

		if (!response.ok) {
			throw new Error("Error: " + response.status);
		}
		
		const json = await response.json();

		return json;
	} catch (err) {
		console.error("Fetch error:", err);
	}
};

utils.fetch.server.post.token = async (url, token) => {
	try {
		const response = await fetch(`${url}`, {
			method: "POST",
			headers: {
				Authorization: "Bearer " + token,
			},
		});

		if (!response.ok) {
			throw new Error("Error: " + response.status);
		}
		
		const json = await response.json();

		return json;
	} catch (err) {
		console.error("Fetch error:", err);
	}
};




utils.router = {};

utils.router.replace = {};
utils.router.replace.state = async (url) => {
	window.history.replaceState({}, "", `${url}`);
};

utils.router.vipel = {};

/**
 *
 * @param {json} token
 * @returns {boolean} Err, Ok
*/

utils.router.vipel.logIn = (token) => {
	if (
		(!token && window.location.pathname === "/login")
	) {
		utils.router.replace.state("/login");

		htmlElements.body.innerHTML = templates.vipel.logIn();
		
		htmlElements.vipel.logIn
		.form()
		.addEventListener("submit", handlers.onFormSubmit);
		
		return utils.struct.Result.OK;
	}

	return utils.struct.Result.ERR;
};

utils.router.vipel.singUp = (token) => {
	if (!token && window.location.pathname === "/signup") {
		utils.router.replace.state("/signup");
		
		htmlElements.body.innerHTML = templates.vipel.singUp();
		
		htmlElements.vipel.signUp
		.form()
		.addEventListener("submit", handlers.onFormSubmit);
		
		return utils.struct.Result.OK;
	}

	return utils.struct.Result.ERR;
};

utils.router.vipel.unknown = (token) => {
	if (token != null && utils.token.jwt.checkExpired(token)) {
		localStorage.removeItem("jwt");
		location.href = "/login";
	}

	if (token == null && !window.location.pathname === "/login" || token == null && !window.location.pathname === "/signup") {
		location.href = "/login";
	}

	utils.router.replace.state("/404");
	return true;
}

utils.router.vipel.index = async (token) => {
	if (token) {
		const userRole = await utils.token.jwt.checkRole(token);

		switch (Number(userRole.Role)) {
			case 100: {
				htmlElements.body.innerHTML = templates.vipel.index.header("/Assets/img/icon/100.png");
				break;
			}
			case 99: {
				htmlElements.body.innerHTML = templates.vipel.index.header("/Assets/img/icon/99.png");
				break;
			}
			case 1: {
				htmlElements.body.innerHTML = templates.vipel.index.header("/Assets/img/icon/1.png");
				break;
			}
			case 2: {
				htmlElements.body.innerHTML = templates.vipel.index.header("/Assets/img/icon/2.png");
				break;
			}
			case 3: {
				htmlElements.body.innerHTML = templates.vipel.index.header("/Assets/img/icon/3.png");
				break;
			}
			default: {
				htmlElements.body.innerHTML = templates.vipel.index.header("/Assets/img/icon/0.png");
				break;
			}
		}
	}

	if (token && window.location.pathname === "/vipel") {
		if ((await utils.token.jwt.checkToken(token)) == false) {
			window.location.href = "/login";
			return utils.struct.Result.OK;
		}

		utils.router.replace.state("/vipel");
		const userRole = await utils.token.jwt.checkRole(token);
		console.log(userRole);

		let img_avatar = localStorage.getItem("avatar");
		if (img_avatar == null) {
			// const reply_avatar = await utils.fetch.server.assets.getAvatar(token);
			// img_avatar = reply_avatar;

		}
		console.log(htmlElements.vipel.index.avatar());
		// htmlElements.vipel.index.avatar().src = utils.image.base64(
		// 	img_avatar.Data.ContentType,
		// 	img_avatar.Data.Image,
		// );
		htmlElements.body.innerHTML += templates.initVipel();

		htmlElements.vipel.index.form().addEventListener("submit", handlers.onFormSubmitIndex)
		const input = document.getElementById("search");

		const contentPost = htmlElements.vipel.index.contentPost();

		console.log(input);
	
		input.addEventListener("input", handlers.onFormSubmitIndex);
		// 		return await utils.fetch.server.post.tokenAndVal(
	// 	utils.config.endPoint.access.userGetPost,
	// 	token,
	// 	id,
	// );
		
		const postData = await utils.fetch.server.get.token(utils.config.endPoint.access.userGetPost, token);
		
		console.log("------------------------------------------");
		console.log(postData);
		for (const post of postData.Data) {
		const moduleData = JSON.parse(post.ModuleJson);

		const postOBJ = {
			pageId: post.PageID,
			moduleId: post.ModuleID,
			moduleType: post.ModuleTypeID,
			data: {
			order: moduleData?.Order ?? null,
			idType: moduleData?.IdType ?? null,
			title: moduleData?.Data?.title ?? null,
			image: moduleData?.Data?.image ?? null,
			subtitle: moduleData?.Data?.subtitle ?? null,
			description: moduleData?.Data?.description ?? null,
			},
		};

		let html = "";
		
		if (postOBJ.data.image != null) {
			const fetchImage = await utils.fetch.server.get.image(token, postOBJ.data.image.Hash);
			html = templates.vipel.index.post(postOBJ.pageId, postOBJ.data.title, fetchImage, postOBJ.data.title);
		} else {
			html = templates.vipel.index.postDefaultImg(postOBJ.pageId, postOBJ.data.title);
		}

		contentPost.insertAdjacentHTML("beforeend", html);
		}

		return utils.struct.Result.OK;
	}
	return utils.struct.Result.ERR;
};

utils.router.vipel.admin = async (token) => {
	if (token && window.location.pathname.startsWith("/vipel/admin")) {
		htmlElements.body.innerHTML += templates.vipel.admin();
		
		let table = htmlElements.vipel.admin.form.table.body();
		let form = htmlElements.vipel.admin.form.table.form();

		// table.addEventListener("change", handlers.adminUserPanel);
		form.addEventListener("change", handlers.adminUserPanel);
		let html = "";
		const json = await utils.fetch.server.get.token(utils.config.endPoint.access.adminGetUser, token);
		// localStorage.setItem("admin_user_get", json);
		// let img_avatar = localStorage.getItem("avatar");

		// if (img_avatar == null) {
		// 	const reply_avatar = await utils.assets.getAvatar(token);
		// 	img_avatar = reply_avatar;
		// }
		

		for (const val of json.Data) {
			html += templates.vipel.admin.addUser(
				val.ID,
				val.Username,
				val.Email,
				val.Role,
			);
		}

		table.innerHTML += html;

		return utils.struct.Result.OK;
	}

	return utils.struct.Result.ERR;
};

utils.router.vipel.add = async (token) => {
	if (token && window.location.pathname.startsWith("/vipel/add"))  {

		// console.log(templates.init.vipel.post());
		// console.log(templates.vipel.add.edit());
		htmlElements.body.innerHTML += templates.vipel.add.edit.gui();
		htmlElements.body.innerHTML += templates.vipel.add.edit(crypto.randomUUID());

		// console.log(htmlElements.vipel.add.form());
		htmlElements.vipel.add.form().addEventListener("submit", handlers.onFormSubmitAdd);

		
		let moduleContainer = document.querySelector('[data-module="Module-Container"]');
		moduleContainer.innerHTML += templates.vipel.add.edit.mod.main(crypto.randomUUID());
		
		const textarea = document.querySelector('[name="description"]');

		textarea.addEventListener("input", () => {
			textarea.style.height = "auto";
			textarea.style.height = textarea.scrollHeight + "px";
		});


		const btnAdd = document.querySelector("#add_module");
    	btnAdd.addEventListener("click", handlers.adminPanel.onClick);

		moduleContainer.addEventListener("change", (e) => {
			if (!e.target.matches(".ImageInput")) return;

			const file = e.target.files[0];
			if (!file) return;

			console.log(e.target.closest(".image-block"));
			const block = e.target.closest(".image-block");
			const preview = block.querySelector(".image-preview");

			preview.src = URL.createObjectURL(file);
			preview.style.display = "block";
		});

		return utils.struct.Result.OK;
	}
	return utils.struct.Result.ERR;
};

utils.router.vipel.post = async (token) => {
	if (token && window.location.pathname.startsWith("/vipel/post/")) {
		// let img_avatar = localStorage.getItem("avatar");

		// if (img_avatar == null) {
		// 	const reply_avatar = await utils.assets.getAvatar(token);
		// 	img_avatar = reply_avatar;
		// }

		const id = window.location.pathname.split("/")[3]?.trim();

		if (id && /^\d+$/.test(id)) {
			utils.router.replace.state(window.location.href);

			

			// {
			// 	let img_avatar = localStorage.getItem("avatar");

			// 	if (img_avatar == null) {
			// 		const reply_avatar = await utils.assets.getAvatar(token);
			// 		img_avatar = reply_avatar;
			// 	}

			// 	htmlElements.vipel.index.avatar().src = utils.image.base64(
			// 		img_avatar.Data.ContentType,
			// 		img_avatar.Data.Image,
			// 	);
			// }
			htmlElements.body.innerHTML += templates.initVipelPost(id);

			const url = utils.config.endPoint.access.userGetPost;
			const contentPost = document.querySelector('[data-module="Module-Container"]');

			const json = await utils.fetch.server.get.post.id(url, token, id);
			
			console.log(json);
			console.log(contentPost);

			for (const post of json.Data) {
				let html = "";
				const jsonPostParser = JSON.parse(post.ModuleJson); 


				switch(post.ModuleTypeID) {
					case 1: {
						contentPost.insertAdjacentHTML(
							"beforeend",
							templates.vipel.add.edit.mod.post.main()
						);

						const mod = contentPost.lastElementChild;

						const image =  mod.querySelector('img[data-role="image-preview"]');

						if (jsonPostParser?.Data?.image?.Hash ?? null != null) {
							const fetchImage = await utils.fetch.server.get.image(token, jsonPostParser?.Data?.image?.Hash ?? null);
							image.src = fetchImage;
						}

						const title = mod.querySelector('input[name="title"]');
						title.value = jsonPostParser.Data.title;

						const subtitle = mod.querySelector('input[name="subtitle"]');
						subtitle.value = jsonPostParser.Data.subtitle;

						const description = mod.querySelector('textarea[name="description"]');
						description.addEventListener("input", () => {
							description.style.height = "auto";
							description.style.height = description.scrollHeight + "px";
						});
						description.value = jsonPostParser.Data.description;
						description.style.height = "auto";
						description.style.height = description.scrollHeight + "px";

						break;
					}
					case 2: {
						contentPost.insertAdjacentHTML(
							"beforeend",
							templates.vipel.add.edit.mod.section()
						);

						
						const mod = contentPost.lastElementChild;

						const title = mod.querySelector('input[name="title"]');
						title.value = jsonPostParser.Data.title;

						const description = mod.querySelector('textarea[name="description"]');
						description.addEventListener("input", () => {
							description.style.height = "auto";
							description.style.height = description.scrollHeight + "px";
						});
						description.value = jsonPostParser.Data.description;
						description.style.height = "auto";
						description.style.height = description.scrollHeight + "px";
						break;
					}
					case 3: {
						break;
					}
					default: {
						break;
					}
				};
				
			}
			// json.Data.forEach( async (post) => {
				
				
			// });

			console.log(json);
		}
		return utils.struct.Result.OK;
	}

	return utils.struct.Result.ERR;
};

utils.router.vipel.init = async (token) => {
	if (await utils.router.vipel.index(token) == utils.struct.Result.OK) { return utils.struct.Result.OK; }
	if (await utils.router.vipel.admin(token) == utils.struct.Result.OK) { return utils.struct.Result.OK; }
	if (await utils.router.vipel.add(token) == utils.struct.Result.OK) { return utils.struct.Result.OK; }
	if (await utils.router.vipel.post(token) == utils.struct.Result.OK) { return utils.struct.Result.OK; }

	return false;
};


utils.image = {};

/**
 * For .src
 * @param {string} ContentType
 * @param {string} Image_base64
 * @return {string}
 */
utils.image.base64 = (ContentType, Image_base64) => {
	return `data:${ContentType};base64,${Image_base64}`;
};

utils.token = {};

utils.token.jwt = {};

utils.token.jwt.checkTokenExp = async (token) => {
	const response = await fetch(utils.config.endPoint.access.userCheck, {
		headers: {
			Authorization: "Bearer " + token,
		},
	});

	if (response.status === 401) {
		localStorage.removeItem("jwt");
		window.location.href = "/login";
		return;
	}

	if (!response.ok) {
		throw new Error("Error: " + response.status);
	}

	const data = await response.json();

	return data.Data;
};


utils.token.jwt.checkToken = async (token) => {
	const response = await fetch(utils.config.endPoint.access.userCheck, {
		headers: {
			Authorization: "Bearer " + token,
		},
	});

	if (response.status === 401) {
		localStorage.removeItem("jwt");
		window.location.href = "/login";
		return;
	}

	if (!response.ok) {
		throw new Error("Error: " + response.status);
	}

	const data = await response.json();

	return data.Data;
};

utils.token.jwt.checkRole = async (token) => {
	try {
		const response = await fetch(utils.config.endPoint.access.userStatus, {
			headers: {
				Authorization: "Bearer " + token,
			},
		});

		if (!response.ok) {
			throw new Error("Error: " + response.status);
		}

		const data = await response.json();

		return data.Data;
	} catch (err) {
		console.error("Fetch error:", err);
		localStorage.removeItem("jwt");
		location.href = "/login";
	}
};




// const token = localStorage.getItem("jwt");
// const payload = parseJwt(token);

// console.log("User ID:", payload.sub);
// console.log("Username:", payload.unique_name);
// console.log("Role:", payload.role);
// console.log("Expires:", payload.exp);

// function isTokenExpired(token) {
// 	const payload = parseJwt(token);
// 	const now = Date.now() / 1000; // seconds
// 	return payload.exp < now;
// }

// const token = localStorage.getItem("jwt");

// if (isTokenExpired(token)) {
// 	console.log("JWT expired");
// 	localStorage.removeItem("jwt");
// 	window.location.href = "/login";
// }

// const token = localStorage.getItem("jwt");
// const payload = parseJwt(token);

// if (payload.role !== "Admin") {
// 	window.location.href = "/not-authorized";
// }

// const token = localStorage.getItem("jwt");

// const response = await fetch("/api/user/profile", {
// 	headers: {
// 		Authorization: "Bearer " + token,
// 	},
// });

// import * as utils from "./config.js";

//const route = (event) => {
//    event = event || window.event;
//    event.preventDefault();
//    windows.history.pushState({}, "", event.target.href)
//};


// utils.module.read.val = (name) => {
//   module.querySelector(`[name="${name}"]`)?.value?.trim() ?? null;
// };