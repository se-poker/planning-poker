<template>
  <div class="app-header">
    <div class="link-to-home">
      <router-link class="link-to-home" to="/">Home</router-link>
    </div>
  </div>
</template>

<script lang="ts">
import { defineComponent } from "vue";

export default defineComponent({
  name: "Header",
});
</script>

<style lang="scss">
.app-header {
  background-color: darkslategray;
  width: 100%;
  height: 10%;
  .link-to-home {
    text-align: left;
    color: darkgray;
    font-size: xx-large;
    margin: 10px;
  }
}
</style>
