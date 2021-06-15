<template>
  <div class="user-prompt">
    <h1>Join game</h1>
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
    <button :disabled="!username || !gamename" id="btnJoinGame" @click="join">
      Join game
    </button>
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
      joinGame(this.gamename, this.username, 0);
    },
  },
});
</script>

<style scoped lang="scss">
.user-prompt {
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

  #btnJoinGame {
    margin-right: 20px;
  }
}
</style>
