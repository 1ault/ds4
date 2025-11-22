const htmlElemnts = {
    buttonNuevo: document.querySelector(".button-nuevo"),
    buttonGuardar: document.querySelector(".button-guardar"),

    buttonCancelar: document.querySelector(".button-cancelar"),
    buttonEliminar: document.querySelector(".button-eliminar"),


    fromRegistro: document.querySelector("form[name='registro']"),
    fromRegistroInputBuscarPorId: document.querySelector(".buscar-por-id"),


    fromRegistroId: document.querySelector(".id"),
    fromRegistroNombre: document.querySelector(".nombre"),
    fromRegistroPrecio: document.querySelector(".precio"),
    fromRegistroStock: document.querySelector(".stock"),

    fromRegistroStatus: document.querySelector(".label-status")  
};


//htmlElemnts.fromRegistroTextareaNombre.textContent = "dsad";

const handlers = {
    async onFormRequest(e) {
        
        e.preventDefault();

        const endpoint = "https://localhost:44386/api/";

        ////formTextareaId.textContent = data.id;
        ////formTextareaNombre.textContent = data.nombre;

        //fromInputBuscarPorId.textContent = "";

        if (e.submitter.classList.contains("button-buscar"))
        {
            e.preventDefault();

            if (htmlElemnts.fromRegistroInputBuscarPorId.value <= 0) {
                htmlElemnts.fromRegistroStatus.textContent = "Status: Err not <= 0";
                return;
            }

            //console.log(inputId);
            const inputId = htmlElemnts.fromRegistroInputBuscarPorId.value;
            const url = `${endpoint}Acess/get/${inputId}`;
            //const url = `https://localhost:44386/api/Acess/get/1`;
            htmlElemnts.fromRegistro.reset();
            try {
                const response = await fetch(url);

                if (!response.ok) {
                    throw new Error("Error: " + response.status);
                }

                const data = await response.json();
                console.log(data);

                console.log(data.id);
                console.log(data.nombre);
                console.log(data.precio);
                console.log(data.stock);


                if (data.id === "" || data.nombre === "" || data.precio === "" || data.stock === "") {

                    htmlElemnts.buttonNuevo.disabled = false;
                    htmlElemnts.buttonGuardar.disabled = true;
                    htmlElemnts.buttonCancelar.disabled = true;
                    htmlElemnts.buttonEliminar.disabled = true;


                    htmlElemnts.fromRegistroId.disabled = true;
                    htmlElemnts.fromRegistroNombre.disabled = true;
                    htmlElemnts.fromRegistroPrecio.disabled = true;
                    htmlElemnts.fromRegistroStock.disabled = true;


                    htmlElemnts.fromRegistroStatus.textContent = "Status: Not found";

                    htmlElemnts.buttonGuardar.classList.add("new");
                    return;
                }

                htmlElemnts.fromRegistroId.value = data.id;
                htmlElemnts.fromRegistroNombre.value = data.nombre;
                htmlElemnts.fromRegistroPrecio.value = data.precio;
                htmlElemnts.fromRegistroStock.value = data.stock;

                htmlElemnts.buttonNuevo.disabled = true;
                htmlElemnts.buttonGuardar.disabled = false;
                htmlElemnts.buttonCancelar.disabled = false;
                htmlElemnts.buttonEliminar.disabled = false;


                htmlElemnts.fromRegistroNombre.disabled = false;
                htmlElemnts.fromRegistroPrecio.disabled = false;
                htmlElemnts.fromRegistroStock.disabled = false;

                htmlElemnts.buttonGuardar.classList.add("update");

                
                //htmlElemnts.fromRegistroInputBuscarPorId.disabled = true;
                htmlElemnts.fromRegistroStatus.textContent = "Status: Found";

            } catch (err) {
                console.error("Fetch error:", err);
            }

            return;
        }


        if (e.submitter.classList.contains("button-nuevo")) {
            htmlElemnts.fromRegistro.reset();

            htmlElemnts.buttonNuevo.disabled = true;
            htmlElemnts.buttonGuardar.disabled = false;
            htmlElemnts.buttonCancelar.disabled = false;


            htmlElemnts.fromRegistroId.disabled = true;
            //htmlElemnts.fromRegistroId.value = 0;

            htmlElemnts.fromRegistroNombre.disabled = false;
            htmlElemnts.fromRegistroPrecio.disabled = false;
            htmlElemnts.fromRegistroStock.disabled = false;

            htmlElemnts.fromRegistroStatus.textContent = "Status: New";
            return;
        }

        if (e.submitter.classList.contains("button-guardar")) {


            const laptops_json = {
                id: htmlElemnts.fromRegistroId.value,
                nombre: htmlElemnts.fromRegistroNombre.value,
                precio: htmlElemnts.fromRegistroPrecio.value,
                stock: htmlElemnts.fromRegistroStock.value
            };

            let response;

            if (htmlElemnts.buttonGuardar.classList.contains("update")) {

                response = await fetch(`${endpoint}Acess/Put`, {
                    method: "PUT",
                    headers: {
                        'Accept': 'application/json',
                        "Content-Type": "application/json"
                    },
                    body: JSON.stringify(laptops_json)
                });

            } 
            else
            {

                response = await fetch(`${endpoint}Acess/Post`, {
                    method: "POST",
                    headers: {
                        'Accept': 'application/json',
                        'Content-Type': 'application/json'
                    },
                    body: JSON.stringify(laptops_json)
                });

            }

            htmlElemnts.buttonGuardar.classList.remove("update", "new");
            const result = await response.json();
            console.log(result);


            //htmlElemnts.fromRegistroStatus.textContent = `Status: Success save ${result.dat}`;
            htmlElemnts.fromRegistroStatus.textContent = `Status: ${result.Data} ${result.Message} ${result.Result}`;

            htmlElemnts.buttonCancelar.disabled = true;
            htmlElemnts.buttonGuardar.disabled = true;
            htmlElemnts.buttonNuevo.disabled = true;
            htmlElemnts.buttonEliminar.disabled = true;

            htmlElemnts.fromRegistroId.disabled = true;
            htmlElemnts.fromRegistroNombre.disabled = true;
            htmlElemnts.fromRegistroPrecio.disabled = true;
            htmlElemnts.fromRegistro.disabled = true;
            htmlElemnts.fromRegistroStock.disabled = true;
            htmlElemnts.fromRegistro.reset()

            return;
        }

        if (e.submitter.classList.contains("button-cancelar")) {
            htmlElemnts.fromRegistro.reset()
            htmlElemnts.buttonGuardar.classList.remove("update", "new");

            htmlElemnts.buttonCancelar.disabled = true;
            htmlElemnts.buttonGuardar.disabled = true;
            htmlElemnts.buttonNuevo.disabled = true;
            htmlElemnts.buttonEliminar.disabled = true;

            htmlElemnts.fromRegistroId.disabled = true;
            htmlElemnts.fromRegistroNombre.disabled = true;
            htmlElemnts.fromRegistroPrecio.disabled = true;
            htmlElemnts.fromRegistro.disabled = true;
            htmlElemnts.fromRegistroStock.disabled = true;
            htmlElemnts.fromRegistroStatus.textContent = "Status: Close";
            return;
        }

        if (e.submitter.classList.contains("button-eliminar")) {
            //utils.onClickButtonLimpiar();

            const laptops_json = {
                id: htmlElemnts.fromRegistroId.value,
                nombre: htmlElemnts.fromRegistroNombre.value,
                precio: htmlElemnts.fromRegistroPrecio.value,
                stock: htmlElemnts.fromRegistroStock.value
            };

            let response = await fetch(`${endpoint}Acess/Delete`, {
                method: "Delete",
                headers: {
                    'Accept': 'application/json',
                    'Content-Type': 'application/json'
                },
                body: JSON.stringify(laptops_json)
            });

            htmlElemnts.buttonGuardar.classList.remove("update", "new");
            const result = await response.json();
            console.log(result);


            htmlElemnts.buttonCancelar.disabled = true;
            htmlElemnts.buttonGuardar.disabled = true;
            htmlElemnts.buttonNuevo.disabled = true;
            htmlElemnts.buttonEliminar.disabled = true;


            htmlElemnts.fromRegistroId.disabled = true;
            htmlElemnts.fromRegistroNombre.disabled = true;
            htmlElemnts.fromRegistroPrecio.disabled = true;
            htmlElemnts.fromRegistro.disabled = true;
            htmlElemnts.fromRegistroStock.disabled = true;
            htmlElemnts.fromRegistro.reset();
            htmlElemnts.fromRegistroStatus.textContent = "Status: Success remove";
            return;
        }

        if (e.submitter.classList.contains("button-salir")) {
            window.close();
            return;
        }
            
    }
};

function start() {

    htmlElemnts.fromRegistro.addEventListener("submit", handlers.onFormRequest);
}
start();


//htmlElemnts.buttonNuevo.disabled = true;
//htmlElemnts.buttonGuardar.disabled = true;
//htmlElemnts.buttonCancelar.disabled = true;
//htmlElemnts.buttonEliminar.disabled = true;



//fromInputBuscarPorId.textContent = "";




// get, put get
//async function init() {}


