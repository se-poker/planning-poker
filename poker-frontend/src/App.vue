<template>
  <Network />
  <router-view />
</template>

<style lang="scss">
@import "assets/scss/colors";

#app {
  font-family: Avenir, Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50;
}

#nav {
  padding: 30px;

  a {
    font-weight: bold;
    color: #2c3e50;

    &.router-link-exact-active {
      color: #42b983;
    }
  }
}
</style>
<script lang="ts">
import { defineComponent } from "vue";
import Network from "@/components/Network.vue";

export default defineComponent({
  components: { Network },
});
</script>
