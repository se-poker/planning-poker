import * as signalR from "@microsoft/signalr";

const connection = new signalR.HubConnectionBuilder()
  .withUrl("http://poker-backend.local:5000/game")
  .configureLogging(signalR.LogLevel.Information)
  .build();

async function start() {
  try {
    await connection.start();
    console.log("SignalR Connected.");
  } catch (err) {
    console.log(err);
    setTimeout(start, 5000);
  }
}

connection.onclose(start);

// Start the connection.
start();

export const joinGame = (gamename: string, username: string): void => {
  connection.send("JoinGame", gamename, username);
};

export default connection;
