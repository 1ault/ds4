/**
 * @typedef {Object} handlers
 */
export const templates = {};
templates.init = {};
templates.vipel = {};


templates.vipel.logIn = () =>  `
<main id="content" class="height-100percent flex flex-align-center flex-justify-center font-size-1rem flex-nowrap">
    <div class="tmp-border background-color-a3dc7e border-radius-0-5rem">
        <form action="" id="form" class="flex-gap-1rem form-vipel padding-1rem font-color-7D6D11 flex flex-column text-align-center">
            <h1 class="">Log in</h1>

            <div class="flex flex-gap-0-5rem flex-align-center flex-justify-center">
                <label for="email" class="font-weight-600 text-align-center">Email</label>
                <input type="email" class="width-100percent ackground-color-#C7E6A3 font-size-1rem outline-none padding-y-0-75rem padding-x-0-80rem" name="email" id="email" placeholder="Email">
            </div>

            <div class="flex flex-gap-0-5rem flex-align-center flex-justify-center">
                <label for="password" class="font-weight-bold">Password</label>
                <input type="password" class="width-100percent ackground-color-#C7E6A3 font-size-1rem outline-none padding-y-0-75rem padding-x-0-80rem" name="password" id="password" placeholder="Password">
            </div>

            <div class="status hidden"></div>

            <div class="flex flex-justify-space-between flex-align-center flex-justify-center">
                <a href="/signup" class="text-decoration-none font-weight-600">Sign up</a>
                <button type="submit" id="login" class="font-weight-bold padding-y-0-75rem padding-x-0-80rem">🔐 Log in</button>
            </div>
        </form>
    </div>
</main>`;

templates.vipel.singUp = () =>  `
<main id="content" class="height-100percent flex flex-align-center flex-justify-center font-size-1rem flex-nowrap">
    <div class="tmp-border background-color-a3dc7e border-radius-0-5rem">
        <form action="" id="form" class="border-radius-0-5rem flex-gap-1rem form-vipel padding-1rem font-color-7D6D11 flex flex-column text-align-center">
            <h1 class="">Sign up</h1>

            <div class="flex flex-gap-0-5rem flex-align-center flex-justify-center">
                <label for="name" class="font-weight-bold">Name</label>
                <input placeholder="Name" type="text" name="name" id="name" class="width-100percent ackground-color-#C7E6A3 font-size-1rem outline-none padding-y-0-75rem padding-x-0-80rem">
            </div>

            <div class="flex flex-gap-0-5rem flex-align-center flex-justify-center">
                <label for="name" class="font-weight-bold">Email</label>
                <input placeholder="Email" type="email" name="email" id="email"  class="width-100percent ackground-color-#C7E6A3 font-size-1rem outline-none padding-y-0-75rem padding-x-0-80rem">
            </div>

            <div class="flex flex-gap-0-5rem flex-align-center flex-justify-center">
                <label for="password" class="font-weight-600">Password</label>
                <input placeholder="Password" type="password" name="password" id="password"  class="width-100percent ackground-color-#C7E6A3 font-size-1rem outline-none padding-y-0-75rem padding-x-0-80rem">
            </div>

            <div class="status hidden"></div>

            <div class="flex flex-justify-space-between flex-align-center flex-justify-center">
                <a href="/login" class="text-decoration-none font-weight-600">Log in</a>
                <button type="submit" id="singup" class="font-weight-bold padding-y-0-75rem padding-x-0-80rem">👤➕ Sign Up</button>
            </div>
        </form>
    </div>
</main>
`;

templates.initVipel = () =>  `
<div class="flex flex-justify-center">
	<form action="" class="bgtest">
		<input data-name="search" type="search" autocomplete="off" name="search" id="search" placeholder="Que planta buscas?">
		<button type="submit">
			<img src="/assets/img/icon/1.png" alt="Search icon" class="icon" >
		</button>
	</form>
</div>

<main data-name="main-content" class="tmp-grid">
</main>

<div id="scrollSpacer"></div>
<footer>
</footer>
`;

templates.vipel.page = (imageBase64, title) => `
<a>
	<div>
		<img src="${imageBase64}" class="" alt="" srcset="">
		<span class="">${title}</span>
	</div>
</a>
`;

templates.vipel.admin = () => {
	return `
	<div class="status hidden"></div>
	<form 
	id="form"
	action=""
	class="container background-color-a3dc7e flex flex-justify-center">
		<table class="data-table">
			<thead>
		    	<tr>
					<th>ID</th>
					<th>Username</th>
					<th>Email</th>
					<th>Role</th>
				</tr>
			</thead>
			<tbody id="form-table-body">
			<tbody>
		</table>
	</form>
	`;
};

templates.vipel.admin.addUser = (id, username, email, role) => {
	return `
<tr>
	<td>${id}</td>
	<td>${username}</td>
	<td>${email}</td>
	<td>
		<select  id="roles" required>
			<option value="" disabled selected>...</option>
			<option value="-2" ${role == -2 ? "selected" : ""}>Banned</option>
			<option value="-1" ${role == -1 ? "selected" : ""}>Inactive</option>
			<option value="0" ${role == 0 ? "selected" : ""}>Applicant</option>
			<option value="1" ${role == 1 ? "selected" : ""}>Invited</option>
			<option value="2" ${role == 2 ? "selected" : ""}>User</option>
			<option value="10" ${role == 10 ? "selected" : ""}>Moderator</option>
			<option value="100" ${role == 100 ? "selected" : ""}>Admin</option>
		</select>
	</td>
</tr>
	`;
};


templates.vipel.admin.user = (json_user) => {};

templates.vipel.index = {};

templates.vipel.index.header = () => `
<header class="flex flex-justify-space-between">
	<a href="/vipel"><img class="" src="/assets/img/icon/logo1.png" alt="logo"></a>
    <a href="/vipel/admin"><img src="" class="avatar" alt="avatar" srcset=""></a>
</header>
`;

templates.vipel.add = (title) => `
<div data-module="Main">
	<div>
		<h1>${title}</h1>
	</div>

	<div>
		<span>
	</div>
<div>

	<div>
		<div>
			<label for="">Variant:</label>
			<input type="text" name="" id="">
		</div>
		<div>
			<label for="">Detalles:</label>
			<input type="text" name="" id="">
		</div>
  <div>

<div data-module="Section">
<div>

<div data-module="IMG">
<div>

<div data-module="Compost">
<div>

<div data-module="H20">
<div>
`;


templates.vipel.add.edit = () => `
<div data-module="Module-Container" class="margin-1rem flex flex-column flex-gap-0-5rem">

</div>
`;

templates.vipel.add.edit.mod = {};
templates.vipel.add.edit.mod.main = () => `
<div data-module="Main" 
	class="background-color-a3dc7e flex flex-justify-center flex-grow-1"
>
	<div class="width-fit-content width-100percent padding-1rem">
		<div class="padding-y-0-75rem image-block flex flex-column flex-justify-center flex-align-center flex-grow-1">
			<img id="ImagePreview" class="image-preview" >
			<input type="file" id="ImageInput" class="width-100percent ImageInput" accept="image/*">
		</div>

		<div class="font-size-2rem">
			<label class="width-100percent">
				Title:
				<input class="width-100percent font-size-1-5rem" type="text" id="Title" placeholder="Enter title">
			</label>
		</div>
		
		<div class="font-size-2rem">
			<label>
				Subtitle:
				<input class="font-size-1-5rem width-100percent" type="text" id="Subtitle" placeholder="Enter subtitle">
			</label>
		</div>

		<div class="font-size-2rem">
			<div>
				<label for="Description">Description:</label>
			</div>
			<textarea class="font-size-2rem width-100percent auto-grow" id="Description" placeholder="Description..."></textarea>
		</div>
	</div>
</div>
`;


templates.vipel.add.edit.mod.section = () => `
<div data-module="section" class="background-color-a3dc7e flex flex-justify-center flex-grow-1">
	<div>
		<div>
			<label>
				Title:
				<input type="text" id="movieTitle" placeholder="Enter movie title">
			</label>
		</div>
		
		<div>
			<div>
				<label for="Description">Description:</label>
			</div>
			<textarea class="width-100percent" id="Description" placeholder="Description..."></textarea>
		</div>
	</div>
</div>
`;

templates.vipel.add.edit.mod.img = () => `
<div class="image-block background-color-a3dc7e flex flex-justify-center flex-column flex-align-center flex-grow-1">
	<img class="image-preview" style="width:200px; display:none;">
	<input type="file" class="ImageInput" accept="image/*">
</div>
`;



templates.vipel.add.edit.gui = () => `
<div class="admin-toolbar flex flex-justify-center">
	<div>
		<button id="insert_module">Insert</button>
	</div>

	<div>
		<label for="module_type">Add component:</label>
		<select  id="module_type" required>
			<option value="" disabled selected>...</option>
			<option value="0" disabled>Main</option>
			<option value="1">Section</option>
			<option value="2">IMG</option>
			<option value="3">Compost</option>
			<option value="4">H2O</option>
		</select>
		<button id="add_module">Add</button>
	</div>
</div>

`

templates.vipel.add.edit.mod.compost = () => `
`;

templates.vipel.add.edit.mod.H20 = () => `
`;

templates.vipel.post = (id) => `
<div class="flex flex-justify-center">
	<form action="" class="bgtest">
		<button type="submit">Preview</button>
		<span>${id}</span>
		<button type="submit">Next</button>
	</form>
</div>

<div class="flex flex-justify-center">
	<form action="" class="bgtest">
		<button type="submit">Preview</button>
		<span>${id}</span>
		<button type="submit">Next</button>
	</form>
</div>


<div class="flex flex-justify-center">
	<button type="submit">Edit</button>
	<button type="submit">View</button>

	<button type="submit">Add</button>
	<button type="submit">Refresh</button>

	<button type="submit">Save</button>
	<button type="submit">Remove</button>

	<button type="submit">Order</button>
	<input type="number" name="" id="">
</div>


<main data-name="main-content" class="tmp-grid">

	<div>
		<div>
			<input type="file" id="imagePicker"  alt="Submit image" accept="image/*" hidden>
			<img src="upload-icon.png" id="uploadBtn" class="upload-btn">
		</div>
		<div>
			<input type="text" name="" id="">
		</div>
	</div>



 	<div data-name="module-section">
		<div>
		 <h2>Espada de San Jorge (SANSEVIERIA)<h2>
		</div>
		<div>
			<input type="text" name="" id="">
		</div>
   <div>

  	<div data-name="module-img">
		<div>
		 <h2>Espada de San Jorge (SANSEVIERIA)<h2>
		</div>
		<div>
			<input type="text" name="" id="">
		</div>
    <div>

   	<div data-name="module-abono">
			<div>
			 <h2>Espada de San Jorge (SANSEVIERIA)<h2>
			</div>
			<div>
				<input type="text" name="" id="">
			</div>
     <div>

     <div data-name="module-h20">
			<div>
			 <h2>Espada de San Jorge (SANSEVIERIA)<h2>
			</div>
			<div>
				<input type="text" name="" id="">
			</div>
      <div>

</main>

<footer id="footer">Footer</footer>
`;
