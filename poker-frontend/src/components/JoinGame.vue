<template>
  <div class="join-game">
    <h1>Join Name</h1>
    <div class="username">
      <label>Username:</label>
      <input type="text" v-model="username" name="username"/>
    </div>
    <div class="game-name">
      <label>Game Name: </label>
      <input type="text" v-model="gameName" name="username"/>
    </div>
    <button class="create-game-butt">Create Game</button>
  </div>
</template>

<script>
export default {
  name: "JoinGame",
  data() {
    return {
      username: "",
      gameName: ""
    }
  },
  methods: {}
}
</script>

<style lang="scss">

</style>