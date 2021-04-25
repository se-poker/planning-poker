import { createRouter, createWebHashHistory, RouteRecordRaw } from "vue-router";
import Menu from "../components/Menu.vue";
import Game from "../components/Game.vue";

const routes: Array<RouteRecordRaw> = [
  {
    path: "/app",
    name: "Menu",
    component: Menu,
  },
  {
    path: "/game",
    name: "Game",
    component: Game,
  },
];

const router = createRouter({
  history: createWebHashHistory(),
  routes,
});
export default router;
