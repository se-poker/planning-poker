import * as signalR from '@microsoft/signalr';
import router from '../router.js'
import store from "../store";

const connection = new signalR.HubConnectionBuilder()
    .withUrl("http://poker-backend.local:5000/game")
    .configureLogging(signalR.LogLevel.Information)
    .build();

connection.on('Joined', (game) => {
    store.commit('setGame', game);   
    router.push('/game/' + game.name);
});

connection.on('Game', (game) => {
    store.commit('setGame', game);
});

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

export function joinGame(gamename, username) {
    connection.send('JoinGame', gamename, username);
}

export default connection;