<template>
  <div>
    <h1>Enter username</h1>
    <input v-model="username"/>
    <input v-model="gamename"/>
    <button @click="join">Dołącz</button>
  </div>
</template>

<script>

import {joinGame} from "../js/signalr/gamehub";

export default {
  name: "UsernamePrompt",
  data: () => {
    return {
      username: '',
      gamename: ''
    }
  },
  methods: {
    join: function() {
      joinGame(this.gamename, this.username);
    }
  }
}
</script>

<style scoped>

</style>