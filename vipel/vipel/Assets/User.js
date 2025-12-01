import * as config from "./config.js";

export async function CheckToken(token) {
	const response = await fetch(config.Endpoint.Access.UserCheck, {
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
}

export async function CheckStatus(token) {
	const response = await fetch(config.Endpoint.Access.UserStatus, {
		headers: {
			Authorization: "Bearer " + token,
		},
	});

	if (!response.ok) {
		throw new Error("Error: " + response.status);
	}

	const data = await response.json();

	return data.Data;
}

export const Roles = {
	Banned: -2,
	Inactive: -1,
	Applicant: 0,
	Invited: 1,
	User: 2,
	Moderator: 10,
	Admin: 100,
};
