<template>
  <div class="create-game">
    <h1>Configure your table</h1>
    <div class="inputs">
      <label id="lblUsername">
        User name
        <input v-model="username" />
      </label>
      <label id="lblGamename">
        Game name
        <input v-model="gamename" />
      </label>
    </div>
    <div class="bottomRow">
      <label>
        Cards set
        <select v-model="gametype">
          <option value="1">Fibbonaci</option>
          <option value="2">Power of 2</option>
          <option value="3">Power of 3</option>
        </select>
      </label>
      <button :disabled="!username || !gamename" @click="join">
        Create game
      </button>
    </div>
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
      gametype: 1,
    };
  },
  methods: {
    join: function () {
      joinGame(this.gamename, this.username, this.gametype);
    },
  },
});
</script>

<style scoped lang="scss">
.create-game {
  margin-top: 40px;
  background-color: white;
  border-radius: 15px;
  padding: 0 50px;
  box-shadow: 0 2px 4px 2px #ccc;
  width: 450px;
  height: 350px;
  flex-direction: column;
  display: flex;
  align-items: flex-end;
  justify-content: space-evenly;

  h1 {
    align-self: center;
  }

  .inputs {
    display: flex;
    flex-direction: column;
    align-items: flex-end;
    margin-right: 20px;

    #lblUsername {
      margin-bottom: 10px;

      input {
        margin-left: 10px;
      }
    }

    #lblGamename {
      input {
        margin-left: 10px;
      }
    }
  }

  .bottomRow {
    display: flex;
    flex-direction: row;
    justify-content: space-between;
    align-items: center;

    label {
      margin-right: 10px;
    }
  }
}
</style>
