<template>
  <div class="poker-card clickable">
    <p>{{ card }}</p>
  </div>
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

<style lang="scss" scoped>
@import "src/assets/scss/poker-card";
</style>
