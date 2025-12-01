export function parseJwt(token) {
	const base64Url = token.split(".")[1];
	const base64 = base64Url.replace(/-/g, "+").replace(/_/g, "/");
	const jsonPayload = decodeURIComponent(
		atob(base64)
			.split("")
			.map((c) => "%" + ("00" + c.charCodeAt(0).toString(16)).slice(-2))
			.join(""),
	);
	return JSON.parse(jsonPayload);
}

const token = localStorage.getItem("jwt");
const payload = parseJwt(token);

console.log("User ID:", payload.sub);
console.log("Username:", payload.unique_name);
console.log("Role:", payload.role);
console.log("Expires:", payload.exp);

function isTokenExpired(token) {
	const payload = parseJwt(token);
	const now = Date.now() / 1000; // seconds
	return payload.exp < now;
}

const token = localStorage.getItem("jwt");

if (isTokenExpired(token)) {
	console.log("JWT expired");
	localStorage.removeItem("jwt");
	window.location.href = "/login";
}

const token = localStorage.getItem("jwt");
const payload = parseJwt(token);

if (payload.role !== "Admin") {
	window.location.href = "/not-authorized";
}

const token = localStorage.getItem("jwt");

const response = await fetch("/api/user/profile", {
	headers: {
		Authorization: "Bearer " + token,
	},
});

//const route = (event) => {
//    event = event || window.event;
//    event.preventDefault();
//    windows.history.pushState({}, "", event.target.href)
//};
