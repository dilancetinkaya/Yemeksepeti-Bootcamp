const input = document.getElementById("input-todo");
const addButton = document.querySelector("#add-todo");
const todoList = document.querySelector("#ul-todo");

addButton.addEventListener("click", () => addGlobal(input.value));
document.addEventListener("DOMContentLoaded", () => getLoadUI());

let getLoadUI = () => {
  let todos = getTodosLocalStorage();
 if(todos.length>0){
    todos.forEach((element) => {
        addTodoUI(element);
      });
 }
};

let addGlobal = (newTodo) => {
  addTodoUI(newTodo);
  addLocalStorage(newTodo);
};

let addTodoUI = (newTodo) => {
  let listElement = `
    <li class="list-group-item d-flex justify-content-between">${newTodo}</li>
  `;
  todoList.innerHTML += listElement;
  input.value = "";
};

let addLocalStorage = (todo) => {
  let todos = getTodosLocalStorage();
  todos.push(todo);
  localStorage.setItem("todos", JSON.stringify(todos));
};

let getTodosLocalStorage = () => {
  let todos;
  if (localStorage.getItem("todos") === null) {
    todos = [];
  } else {
    todos = JSON.parse(localStorage.getItem("todos"));
  }
  return todos;
};
