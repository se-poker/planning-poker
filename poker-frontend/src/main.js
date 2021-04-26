import {createApp} from 'vue'
import router from './js/router'
import App from "./App";
import store from "./js/store";

createApp(App)
    .use(router)
    .use(store)
    .mount('#app')
