<template>
  <button class="poker-card">
    {{ card }}
  </button>
</template>

<script>
import { defineComponent } from "vue";

export default defineComponent({
  name: "Card",
  props: {
    card: null,
  },
});
</script>

<style lang="scss">
.poker-card {
  height: 100px;
  width: 60px;
  background-color: white;
  color: dodgerblue;
  border: 4px solid dodgerblue;
  border-radius: 10px;
  font-size: xx-large;
  margin: 10px;
  box-shadow: 0 2px 4px rgba(0, 0, 0, 0.18);
}
</style>
