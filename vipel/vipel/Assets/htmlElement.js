
// const htmlElement = {
//   LogIn: {
//     get formLogin() { return document.querySelector("#form-login"); },
//   }
// };
// export default htmlElement;

/** @type {HTMLElement} */
export const body = document.body;

/** @type {HTMLElement} */
export const head = document.head;

export const LogIn = {
    get form() { return document.querySelector("#form"); },
    get buttonLogin() { return document.querySelector("#login"); },
    get inputName() { return document.querySelector("#name"); },
    get inputEmail() { return document.querySelector("#email"); },
    get inputPassword() { return document.querySelector("#password"); },
};

export const SignUp = {
    get form() { return document.querySelector("#form"); },
    get inputName() { return document.querySelector("#name"); },
    get inputEmail() { return document.querySelector("#email"); },
    get inputPassword() { return document.querySelector("#password"); },
};

// export const LogIn = {
//     // formLogin() {  return document.querySelector("#form-login"); },
//     formLogin: document.querySelector("#form-login"),
//     buttonLogin: document.querySelector("#login"),

//     inputPassword: document.querySelector("#password"),
//     inputEmail: document.querySelector("#email"),
//     inputName: document.querySelector("#name")
// };

// /** @type {HTMLElement} */
// export const a = = document.head;
// export const LogIn = {
//     get formLogin() { return document.querySelector("#form-login"); },
//     // formLogin() {  return document.querySelector("#form-login"); },

//     // buttonLogin: document.querySelector("#login"),

//     // inputPassword: document.querySelector("#password"),
//     // inputEmail: document.querySelector("#email"),
//     // inputName: document.querySelector("#name")
// };

