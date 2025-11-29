import * as htmlElement from "./htmlElement.js";
import * as config from "./config.js";

export async function onFormSubmit(e) {
	e.preventDefault();

	console.log(e);
	console.log(e.submitter);

	if (!e.submitter) {
		return;
	}

	if (e.submitter.id.includes("singup")) {
		const json_user = {
			Username: htmlElement.SignUp.inputName.value,
			Email: htmlElement.SignUp.inputEmail.value,
			Password: htmlElement.SignUp.inputPassword.value,
		};

		console.log(json_user);

		const response = await fetch(config.Endpoint.Access.SingUp, {
			method: "POST",
			headers: {
				Accept: "application/json",
				"Content-Type": "application/json",
			},
			body: JSON.stringify(json_user),
		});

		if (!response.ok) {
			throw new Error("Error: " + response.status);
		}

		const json = await response.json();

		console.log(json);
		return;
	}

	if (e.submitter.id.includes("login")) {
		const json_user = {
			Username: htmlElement.LogIn.inputName.value,
			Email: htmlElement.LogIn.inputEmail.value,
			Password: htmlElement.LogIn.inputPassword.value,
		};

		const response = await fetch(config.Endpoint.Access.Login, {
			method: "POST",
			headers: {
				Accept: "application/json",
				"Content-Type": "application/json",
			},
			body: JSON.stringify(json_user),
		});

		if (!response.ok) {
			throw new Error("Error: " + response.status);
		}

		const data = await response.json();

		console.log(data);
		return;
	}
}
