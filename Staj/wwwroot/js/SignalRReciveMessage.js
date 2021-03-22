//import { signalR } from "./SignalR/dist/browser/signalr"



    var connection = new signalR.HubConnectionBuilder().withUrl("/MonitorHub").build();


    connection.start();

document.getElementById("send").addEventListener("click", function (event) {
    var message = document.getElementById("message").value;
    connection.invoke("SendMessage", message);

})

connection.on("ReciveMessage", function (msj) {
    var tr = document.createElement("tr");
    var td = document.createElement("td");
    var td2 = document.createElement("td");
    td2.innerHTML = msj;
    tr.appendChild(td);
    tr.appendChild(td2);
    document.getElementById("list").appendChild(tr);

});
connection.on("ReciveeMessage", function (type,id, name, surname, password, email) {
    var tr = document.createElement("tr");
    var td = document.createElement("td");
    var td2 = document.createElement("td");
    var td3 = document.createElement("td");
    var td4 = document.createElement("td");
    var td5 = document.createElement("td");
    var td6 = document.createElement("td");
    td.innerHTML = type;
    td2.innerHTML = id;
    td3.innerHTML = name;
    td4.innerHTML = surname;
    td5.innerHTML = password;
    td6.innerHTML = email;
    tr.appendChild(td);
    tr.appendChild(td2);
    tr.appendChild(td3);
    tr.appendChild(td4);
    tr.appendChild(td5);
    tr.appendChild(td6);
    document.getElementById("list").appendChild(tr);

});

