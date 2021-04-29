import { createRouter, createWebHashHistory } from "vue-router";
import MainPage from "@/components/MainPage.vue";
import GamePage from "@/components/GamePage.vue";

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
  history: createWebHashHistory(),
});
