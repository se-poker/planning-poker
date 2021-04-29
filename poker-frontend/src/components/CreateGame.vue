<template>
  <div class="create-game">
    <h1>Create Game</h1>
    <div class="username">
      <label>Username:</label>
      <input type="text" v-model="username" name="username" />
    </div>
    <div class="game-name">
      <label>Game Name: </label>
      <input type="text" v-model="gameName" name="gameName" />
    </div>
    <button class="create-game-butt">Create Game</button>
  </div>
</template>

<script>
export default {
  name: "CreateGame",
  // eslint-disable-next-line @typescript-eslint/explicit-module-boundary-types
  data() {
    return {
      username: "",
      gameName: "",
    };
  },
  methods: {},
};
</script>

<style lang="scss"></style>
