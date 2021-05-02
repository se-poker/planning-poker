<template>
  <div class="poker-card not-picked" v-if="card === null"></div>
  <div class="poker-card hidden" v-if="card !== null && card.hidden"></div>
  <div class="poker-card" v-if="card !== null && !card.hidden">
    <p>{{ card && card.value }}</p>
  </div>
</template>

<script>
import { defineComponent } from "vue";
import Card from "@/js/models/card";

export default defineComponent({
  name: "Card",
  props: {
    card: Card,
  },
});
</script>

<style lang="scss" scoped>
@import "src/assets/scss/poker-card";
</style>
