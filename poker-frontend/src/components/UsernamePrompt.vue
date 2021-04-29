<template>
  <div>
    <h1>Enter username</h1>
    <input v-model="username" />
    <input v-model="gamename" />
    <button @click="join">Dołącz</button>
  </div>
</template>

<script lang="ts">
import { defineComponent } from "vue";
import { joinGame } from "@/js/signalr/gamehub";

export default defineComponent({
  name: "UsernamePrompt",
  data: () => {
    return {
      username: "",
      gamename: "",
    };
  },
  methods: {
    join: function () {
      joinGame(this.gamename, this.username);
    },
  },
});
</script>

<style scoped></style>
