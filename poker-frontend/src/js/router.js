import {createRouter, createWebHashHistory} from "vue-router";
import MainPage from "../components/MainPage";
import GamePage from "../components/GamePage";

const routes = [
    {
        path: "/",
        name: "Main",
        component: MainPage,
    },
    {
        path: "/game/:gamename",
        name: "Game",
        component: GamePage,
    },
];

export default createRouter({
    routes,
    history: createWebHashHistory()
})