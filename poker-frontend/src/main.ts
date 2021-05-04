import { createApp } from "vue";
import App from "@/App.vue";
import router from "@/js/router";
import { store, key } from "@/js/store";
import "@/assets/scss/main.scss";

createApp(App).use(router).use(store, key).mount("#app");
