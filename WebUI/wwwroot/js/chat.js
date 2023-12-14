/*$(document).ready(() => {*/
var connection = new signalR.HubConnectionBuilder().withUrl("https://localhost:7039/signalrhub").build();
document.getElementById("sendButton").disabled = true;
connection.on("ReceiveMessage", function (user, message) {
    var currentTime = new Date();
    var currentHour = currentTime.getHours();
    var currentMunite = currentTime.getMinutes();

    var li = document.createElement("li");
    var span = document.createElement("span");
    span.style.fontWeight = "bold";
    span.textContent = user;
    li.appendChild(span);
    li.innerHTML += ` :${message}-${currentHour}:${currentMunite}`;
    document.getElementById("messageList").appendChild(li);
});
connection.start().then(function () {
    document.getElementById("sendButton").disabled = false;
}).catch(function (err) {
    return console.log(err.toString());
});

document.getElementById("sendButton").addEventListener("click", function (event) {
    var user = document.getElementById("userInput").value;
    var message = document.getElementById("messageInput").value;

    connection.invoke("SendMessage", user, message).catch(function (err) {
        return console.log(err.toString());
    });
    event.preventDefault();
});


//    $("#connstatus").text(connection.state);

//    connection.start().then(() => {
//        $("#connstatus").text(connection.state);
//        setInterval(() => {
//            connection.invoke("SendStatistic");
//        }, 1000);
//    }).catch((err) => {
//        console.log(err)
//    });
//    connection.on("ReceiveCategoryCount", (value) => {
//        $("#categoryCount").text(value)
//    });
//})

