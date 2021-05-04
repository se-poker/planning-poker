<template>
  <div class="create-game">
    <h1>Configure your table</h1>

    <label>
      User name
      <input v-model="username" />
    </label>
    <label>
      Game name
      <input v-model="gamename" />
    </label>
    <label>
      Cards set
      <select>
        <option>Fibbonaci</option>
      </select>
    </label>
    <button @click="join">Create game</button>
  </div>
</template>

<script lang="ts">
import { defineComponent } from "vue";
import { joinGame } from "@/js/signalr/gamehub";

export default defineComponent({
  name: "CreateGame",
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
.create-game {
  background-color: white;
  border-radius: 15px;
  padding: 25px 50px;
  box-shadow: 0 2px 4px 2px #ccc;
  width: 450px;
  height: 350px;
  flex-direction: column;
  display: flex;
  align-items: flex-end;
  justify-content: space-evenly;

  h1 {
    align-self: start;
  }
}
</style>
