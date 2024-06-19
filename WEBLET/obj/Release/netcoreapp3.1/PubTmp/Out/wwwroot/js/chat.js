"use strict";

var connection = new signalR.HubConnectionBuilder().withUrl("/chatHub").build();

//Disable send button until connection is established
document.getElementById("sendButton").disabled = true;
document.getElementById("ConsultantsendButton").disabled = true;
var cruntIdCunsltantUser = '';
connection.on("ReceiveMessage", function (message, Name, DatTim, Email,sender) {
 
    var msg = message.replace(/&/g, "&amp;").replace(/</g, "&lt;").replace(/>/g, "&gt;");
    /*LoadSentMsgUserList();*/
    if (cruntIdCunsltantUser == Email ) {
        var li = document.createElement("li");
        li.innerHTML = '<p style="line-height:0px;color:#FBF8BE" id="contentt" >' + Name + '<span class="ml-4"></span></p>' + msg + '<p style="line-height:0px; text-align:right;color:#FBF8BE" >' + DatTim+'';
            li.className = 'client-chat';
            document.getElementById("messagesListCunsul").appendChild(li);
        LoadSentMsgUserList();

            }
    if (sender == 'Consultant') {
        var li = document.createElement("li");
        li.innerHTML = '<p style="line-height:0px;color:#FBF8BE" id="contentt" >' + Name + '<span class="ml-4"></span></p>' + msg + '<p style="line-height:0px; text-align:right;color:#FBF8BE" >' + DatTim + '';
        li.className = 'client-chat';
        document.getElementById("messagesList").appendChild(li);
       
    }
    scrolLast();
});

connection.start().then(function () {
    document.getElementById("sendButton").disabled = false;
    document.getElementById("ConsultantsendButton").disabled = false;
}).catch(function (err) {
    return console.error(err.toString());
});

document.getElementById("sendButton").addEventListener("click", function (event) {

    var message = document.getElementById("messageInput").value;
    var d = new Date();
    var datetimeNow = d.getFullYear() + '/' + (d.getMonth() + 1) + '/' + d.getDate() + '  ' + d.getHours() + ':' + d.getMinutes();
    var li = document.createElement("li");
    li.innerHTML = '' + message + '<p style="line-height:0px; text-align:right;color:#234E70"  id="contentt" >' +datetimeNow+'</p>';
    li.className = 'my-chat';
    document.getElementById("messagesList").appendChild(li);
    connection.invoke("SendMessage",  message).catch(function (err) {
        return console.error(err.toString());
    });
    document.getElementById("messageInput").value = "";
    scrolLast();
    event.preventDefault();
});

document.getElementById("ConsultantsendButton").addEventListener("click", function (event) {

    var message = document.getElementById("ConsultantmessageInput").value;
    var UsersetId = document.getElementById("setId").value;
    var li = document.createElement("li");
    var d = new Date();
    var datetimeNow = d.getFullYear() + '/' + (d.getMonth() + 1) + '/' + d.getDate() + '  ' + d.getHours() + ':' + d.getMinutes();

    li.innerHTML = '' + message + '<p style="line-height:0px; text-align:right;color:#234E70" id="contentt" >' + datetimeNow + '</p>';;
    li.className = 'my-chat';
    
    document.getElementById("messagesListCunsul").appendChild(li);
    connection.invoke("ConsultantSendMessage", message, UsersetId).catch(function (err) {
        return console.error(err.toString());
    });
    document.getElementById("ConsultantmessageInput").value = "";
    scrolLast();
    event.preventDefault();
});

function scrolLast() {
    var elmnt = document.getElementById("contentt");
    elmnt.scrollIntoView();
}