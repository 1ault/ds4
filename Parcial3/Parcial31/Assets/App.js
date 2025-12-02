
const htmlElemnts = {
    from: document.querySelector("#form"),
    buttonLogin: document.querySelector("#login"),
    inputName:  document.querySelector("#name"),
	inputPassword: document.querySelector("#password"),
	status: document.querySelector("#status"),
}

const Endpoint = {
	Acess: {
		Get: "${window.AppConfig.EndpointAcess}/get/",
		Put: "${window.AppConfig.EndpointAcess}/put/",
		Post: "${window.AppConfig.EndpointAcess}/post/",
		Delete: "${window.AppConfig.EndpointAcess}/delete/",
		Login: `https://localhost:44310/api/Acess/Login/`
	},
};

const handlers = {
	async onFormSubmit(e) {
		e.preventDefault();


		if (e.submitter.id.includes("login")) 
		{
			const json_user = {
				Username: htmlElemnts.inputName.value,
				Password: htmlElemnts.inputPassword.value,
			};

			const response = await fetch(Endpoint.Acess.Login, {
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

			if (data.Result == true) {
				htmlElemnts.status.innerHTML = "status: ok";
			} else {
				htmlElemnts.status.innerHTML = "status: err";
			}

			return data;
		}
	}
}


function App() {
    htmlElemnts.from.addEventListener(
        "submit",
        handlers.onFormSubmit,
    );
}

App();