<template>
  <div class="app-header">
    <router-link class="home" to="/app">Home</router-link>
  </div>
</template>

<script>
export default {
  name: "Header",
};
</script>

<style lang="scss">
.app-header {
  background-color: darkslategray;
  width: 100%;
  height: 10%;
  .home {
    color: darkgray;
    font-size: xx-large;
    text-align: left;
    margin: 10px;
  }
}
</style>
