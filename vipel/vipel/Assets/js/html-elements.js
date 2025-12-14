/**
 * @typedef {Object} htmlElements
 */
export const htmlElements = {};

/** @type {HTMLElement} */
htmlElements.body = document.body;

/** @type {HTMLElement} */
htmlElements.head = document.head;

htmlElements.vipel = {};

htmlElements.vipel.logIn = {};

htmlElements.vipel.logIn.form = () => { return document.querySelector("#form"); };
htmlElements.vipel.logIn.form.button = () => {};
htmlElements.vipel.logIn.form.button.logIn = () => { return document.querySelector("#login"); };

htmlElements.vipel.logIn.form.input = {};
htmlElements.vipel.logIn.form.input.name = () => { return document.querySelector("#name"); };
htmlElements.vipel.logIn.form.input.email = () => { return document.querySelector("#email"); };
htmlElements.vipel.logIn.form.input.password = () => { return document.querySelector("#password"); };

htmlElements.vipel.signUp = {};

htmlElements.vipel.signUp.form = () => { return document.querySelector("#form"); };

htmlElements.vipel.signUp.form.button = () => {};
htmlElements.vipel.signUp.form.button.logIn = () => { return document.querySelector("#singup"); };

htmlElements.vipel.signUp.form.input = {};
htmlElements.vipel.signUp.form.input.name = () => { return document.querySelector("#name"); };
htmlElements.vipel.signUp.form.input.email = () => { return document.querySelector("#email"); };
htmlElements.vipel.signUp.form.input.password = () => { return document.querySelector("#password"); };


htmlElements.vipel.admin = {};
htmlElements.vipel.admin.form = () => { return document.querySelector("#form"); };

htmlElements.vipel.admin.form.table = () => {};
htmlElements.vipel.admin.form.table.body = () => { return document.querySelector("#form-table-body"); };
htmlElements.vipel.admin.form.table.form = () => { return document.querySelector("#form"); };
// htmlElements.vipel.admin.form =  () => { return document.querySelector('form[data-name="admin-user"]'); };

htmlElements.vipel.index = {};
htmlElements.vipel.index.contentPost = () => { return document.querySelector('[data-name="main-content"]'); };

htmlElements.vipel.index.form = () => { return document.querySelector("#form"); };

htmlElements.vipel.index.avatar = () => {return document.querySelector(".avatar");};

htmlElements.vipel.add = {};
htmlElements.vipel.add.form = () => { return document.querySelector("#form"); };