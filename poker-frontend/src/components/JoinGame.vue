<template>
  <div class="user-prompt">
    <h1>Join game</h1>

    <label>
      User name
      <input v-model="username" />
    </label>
    <label>
      Game name
      <input v-model="gamename" />
    </label>
    <button @click="join">Join game</button>
  </div>
</template>

<script lang="ts">
import { defineComponent } from "vue";
import { joinGame } from "@/js/signalr/gamehub";

export default defineComponent({
  name: "JoinGame",
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

<style scoped lang="scss">
.user-prompt {
  background-color: white;
  border-radius: 15px;
  padding: 25px 50px;
  box-shadow: 0 2px 4px 2px #ccc;
  width: 450px;
  height: 300px;
  flex-direction: column;
  display: flex;
  align-items: flex-end;
  justify-content: space-evenly;

  h1 {
    align-self: start;
  }
}
</style>
