<template>
  <div></div>
</template>

<script lang="ts">
import { useStore } from "@/js/store";
import connection from "@/js/signalr/gamehub";
import router from "@/js/router";
import { defineComponent } from "vue";

export default defineComponent({
  name: "Network",
  setup() {
    const store = useStore();

    connection.on("Joined", (game) => {
      store.commit("setGame", game);
      router.push("/game/" + game.name);
    });

    connection.on("Game", (game) => {
      store.commit("setGame", game);
    });
  },
});
</script>
