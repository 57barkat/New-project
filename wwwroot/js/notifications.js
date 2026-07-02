const connection = new signalR.HubConnectionBuilder()
    .withUrl("/notificationsHub")
    .withAutomaticReconnect()
    .build();

const messageInput = document.getElementById("messageInput");
const sendButton = document.getElementById("sendButton");
const messagesList = document.getElementById("messagesList");
const emptyMessages = document.getElementById("emptyMessages");
const connectionStatus = document.getElementById("connectionStatus");

function setConnectionStatus(text, className) {
    connectionStatus.textContent = text;
    connectionStatus.className = `status-pill ${className}`;
}

connection.on("ReceiveMessage", (message) => {
    emptyMessages.classList.add("d-none");

    const item = document.createElement("li");
    item.className = "list-group-item";
    item.textContent = message;
    messagesList.prepend(item);
});

async function sendMessage() {
    const message = messageInput.value.trim();

    if (!message) {
        messageInput.focus();
        return;
    }

    await connection.invoke("SendMessage", message);
    messageInput.value = "";
    messageInput.focus();
}

sendButton.addEventListener("click", sendMessage);
messageInput.addEventListener("keydown", async (event) => {
    if (event.key === "Enter") {
        event.preventDefault();
        await sendMessage();
    }
});

connection.onreconnecting(() => setConnectionStatus("Reconnecting", "status-waiting"));
connection.onreconnected(() => setConnectionStatus("Connected", "status-ready"));
connection.onclose(() => setConnectionStatus("Disconnected", "status-offline"));

connection.start()
    .then(() => setConnectionStatus("Connected", "status-ready"))
    .catch((error) => {
        setConnectionStatus("Disconnected", "status-offline");
        console.error(error);
    });
