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

templates.initVipelPost = (id) => `
<div 
data-page-id="${id}"
data-module="Module-Container" 
class="margin-1rem flex flex-column flex-gap-0-5rem">

</div>
`;
templates.initVipel = () =>  `
<div class="flex flex-justify-center flex-align-center">
	<form id="form" action="" class="flex-gap-0-5rem width-100percent flex flex-justify-center flex-align-center"">
		<div class="flex-gap-0-3rem  flex flex-justify-center flex-align-center">
		<input data-name="search" type="search" autocomplete="off" name="search" id="search" placeholder="Search..."><button type="submit" class="font-weight-bold padding-y-0-75rem padding-x-0-80rem">
			<img src="/assets/img/icon/1.png" alt="Search icon" class="icon">
		</button>
		</div>

		<button type="submit"  id="add_module" class="font-weight-bold padding-y-0-75rem padding-x-0-80rem">➕ Add</button>
	</form>
</div>

<main data-name="main-content" class="tmp-grid grid-place-items-center">
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
	class="container background-color-a3dc7e flex flex-justify-center font-weight-bold">
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
		<select  data-key="role" required>
			<option value="" disabled selected>...</option>
			<option value="-2" ${role == -2 ? "selected" : ""}>Banned</option>
			<option value="-1" ${role == -1 ? "selected" : ""}>Inactive</option>
			<option value="0" ${role == 0 ? "selected" : ""}>Applicant</option>
			<option value="1" ${role == 1 ? "selected" : ""}>Invited</option>
			<option value="2" ${role == 2 ? "selected" : ""}>User</option>
			<option value="99" ${role == 99 ? "selected" : ""}>Moderator</option>
			<option value="100" ${role == 100 ? "selected" : ""}>Admin</option>
		</select>
	</td>
</tr>
	`;
};


templates.vipel.admin.user = (json_user) => {};

templates.vipel.index = {};

templates.vipel.index.postDefaultImg = (id, data_title) => 
`
<a href="/vipel/post/${id}" class="link-div">
  <div class="box card width-100percent">
	<img data-role="image-preview" class="image-preview" src="/assets/img/placeholder.png" alt="placeholder">
    <span class="padding-1rem font-size-1rem display-block width-100percent font-size-1rem text-align-center font-weight-bold">${data_title}</span>
	</div>
</a>
`; 

templates.vipel.index.post = (id, data_title, img, img_alt) => 
`
<a href="/vipel/post/${id}" class="link-div">
  <div class="box card width-100percent">
	<img data-role="image-preview" class="image-preview" src="${img}" alt="${img_alt}">
    <span class="padding-1rem font-size-1rem display-block width-100percent font-size-1rem text-align-center font-weight-bold">${data_title}</span>
  </div>
</a>
`;


templates.vipel.index.header = (pathImage) => `
<header class="flex flex-justify-space-between padding-x-0-50rem">
	<a href="/vipel"><img class="" src="/assets/img/icon/logo1.png" alt="logo"></a>
    <a href="/vipel/admin"><img src="${pathImage}" class="avatar" alt="avatar" srcset=""></a>
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


templates.vipel.add.edit = (randomUUID) => `
<div 
id="PageEditor" 
data-page-id="${randomUUID}"
data-module="Module-Container" 
class="margin-1rem flex flex-column flex-gap-0-5rem">

</div>
`;

templates.vipel.add.edit.mod = {};
templates.vipel.add.edit.mod.post = {};


templates.vipel.add.edit.mod.post.main = (id, order) => `
<div 
	data-module="Main"
	data-module-type-name="main"
	data-module-type-id="1" 
	data-module-order="${order}" 
	data-module-id="${id}"
	class="module background-color-a3dc7e flex flex-justify-center flex-grow-1"
>
	<div class="width-fit-content width-100percent padding-1rem">
		<div class="padding-y-0-75rem image-block flex flex-column flex-justify-center flex-align-center flex-grow-1">
			<img data-role="image-preview" class="image-preview" src="/assets/img/placeholder.png" alt="placeholder">
			<input name="image" type="file" class="width-100percent ImageInput" accept="image/*">
		</div>

		<div class="font-size-2rem">
			<label class="width-100percent">
				Title:
				<input name="title" class="width-100percent font-size-1-5rem" type="text" placeholder="Enter title">
			</label>
		</div>
		
		<div class="font-size-2rem">
			<label>
				Subtitle:
				<input name="subtitle" class="font-size-1-5rem width-100percent" type="text" placeholder="Enter subtitle">
			</label>
		</div>

		<div class="font-size-2rem">
			<div>
				<label for="Description">Description:</label>
			</div>
			<textarea name="description" class="font-size-2rem width-100percent auto-grow" placeholder="Description..."></textarea>
		</div>
	</div>
</div>
`;

templates.vipel.add.edit.mod.main = (randomUUID) => `
<div 
	data-module="Main"
	data-module-type-name="main"
	data-module-type-id="1" 
	data-module-order="0" 
	data-module-id="${randomUUID}"
	class="module background-color-a3dc7e flex flex-justify-center flex-grow-1"
>
	<div class="width-fit-content width-100percent padding-1rem">
		<div class="padding-y-0-75rem image-block flex flex-column flex-justify-center flex-align-center flex-grow-1">
			<img data-role="image-preview" class="image-preview" src="/assets/img/placeholder.png" alt="placeholder">
			<input name="image" type="file" class="width-100percent ImageInput" accept="image/*">
		</div>

		<div class="font-size-2rem">
			<label class="width-100percent">
				Title:
				<input name="title" class="width-100percent font-size-1-5rem" type="text" placeholder="Enter title">
			</label>
		</div>
		
		<div class="font-size-2rem">
			<label>
				Subtitle:
				<input name="subtitle" class="font-size-1-5rem width-100percent" type="text" placeholder="Enter subtitle">
			</label>
		</div>

		<div class="font-size-2rem">
			<div>
				<label for="Description">Description:</label>
			</div>
			<textarea name="description" class="font-size-2rem width-100percent auto-grow" placeholder="Description..."></textarea>
		</div>
	</div>
</div>
`;


templates.vipel.add.edit.mod.section = (randomUUID) => `
<div
	data-module="Section"
	data-module-type-name="section"
	data-module-type-id="2" 
	data-module-order="0" 
	data-module-id="${randomUUID}"
  class="module background-color-a3dc7e flex flex-justify-center flex-grow-1"
>
  <div class="width-fit-content width-100percent padding-1rem">

    <div class="font-size-2rem">
      <label class="width-100percent">
        Title:
        <input
          name="title"
          class="width-100percent font-size-1-5rem"
          type="text"
          placeholder="Enter title"
        >
      </label>
    </div>

    <div class="font-size-2rem">
      <label>Description:</label>
      <textarea
        name="description"
        class="font-size-2rem width-100percent auto-grow"
        placeholder="Description..."
      ></textarea>
    </div>

  </div>
</div>
`;

templates.vipel.add.edit.mod.img = (randomUUID) => `
<div
	data-module="Img"
	data-module-type-name="img"
	data-module-type-id="3" 
	data-module-order="0" 
	data-module-id="${randomUUID}"
	class="module background-color-a3dc7e flex flex-justify-center flex-grow-1"
>
	<div class="width-fit-content width-100percent padding-1rem">
		<div class="padding-y-0-75rem image-block flex flex-column flex-justify-center flex-align-center flex-grow-1">
			<img class="image-preview" src="/assets/img/placeholder.png" alt="placeholder">
			<input name="image" type="file" class="width-100percent ImageInput" accept="image/*">
		</div>

	</div>
</div>
`;



templates.vipel.add.edit.gui = () => `
<form 
id="form"
action="">
<div class="admin-toolbar flex flex-justify-center flex-gap-1rem ">
	<div>
		<button type="submit" id="insert_module" class="font-weight-bold padding-y-0-75rem padding-x-0-80rem">💾 Insert</button>
	</div>

	<div class="flex flex-justify-center flex-align-center text-align-center">
		<label for="module_type" class="font-weight-bold">Add component:</label>
		<select id="module_type">
			<option value="" disabled selected>...</option>
			<option value="0" disabled>Main</option>
			<option value="1">Section</option>
			<option value="2">IMG</option>
			<option value="3" disabled>Compost</option>
			<option value="4" disabled>H2O</option>
		</select>
		<button type="submit" id="add_module" class="font-weight-bold padding-y-0-75rem padding-x-0-80rem">➕ Add</button>
	</div>
</div>
</form>
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
