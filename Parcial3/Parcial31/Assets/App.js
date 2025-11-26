
const htmlElemnts = {
    from: document.querySelector("form")
}


const handlers = {
	onFormSubmit(e) {
		e.preventDefault();


		if (e.submitter.classList.contains("button-buscar")) {
			const url = `${window.AppConfig.EndpointAcess}get/`;

            try {
                const response = await fetch(url);

                if (!response.ok) {
					throw new Error("Error: " + response.status);
                }

                const data = await response.json();
				console.log(data);


            } catch (err) {
				console.error("Fetch error:", err);
            }
		}


		// console.log(e.submitter.classList.contains("limpiar"));
		if (e.submitter.classList.contains("limpiar")) {
			utils.onClickButtonLimpiar();
			return;
		}

		if (utils.checkFormRegistro() == false) {
			return;
		}

		if (htmlElemnts.fromRegistroEdad.value === "") {
			htmlElemnts.fromRegistroEdad.value = "void";
		}

		const nombre = htmlElemnts.fromRegistroNombre.value;
		const apellido = htmlElemnts.fromRegistroApellido.value;
		const email = htmlElemnts.fromRegistroEmail.value;
		let edad = htmlElemnts.fromRegistroEdad.value;
		let carrera =
			htmlElemnts.fromRegistroCarrera.options[
				htmlElemnts.fromRegistroCarrera.selectedIndex
			].value;

		// check void
		htmlElemnts.tableMainData.innerHTML += templates.row(
			nombre,
			apellido,
			email,
			edad,
			carrera,
		);
		// Button delete

		utils.tableResetVal();

		utils.attacDeleteButtons();
		htmlElemnts.fromRegistro.reset();
	},
}





function App() {
    htmlElemnts.from.addEventListener(
        "submit",
        handlers.onFormSubmit,
    );
}

App();