<template>
  <div class="flip-card not-picked" v-if="card === null"></div>
  <div
    class="flip-card"
    :class="{ hidden: card !== null && card.hidden }"
    v-if="card"
  >
    <div class="flip-card-inner">
      <div class="poker-card back"></div>
      <div class="poker-card">
        <p>{{ card && card.value }}</p>
      </div>
    </div>
  </div>
</template>

<script lang="ts">
import { defineComponent, PropType } from "vue";
import Card from "@/js/models/card";

export default defineComponent({
  name: "Card",
  props: {
    card: Object as PropType<Card>,
  },
});
</script>

<style lang="scss" scoped>
@import "./src/assets/scss/colors";

.flip-card {
  background-color: transparent;
  height: 100px;
  width: 60px;
  margin: 10px;

  &.not-picked {
    border: none;
    background-color: white;
    box-shadow: 0 2px 4px #ccc;
    border-radius: 10px;
  }
}

//.flip-card:hover .flip-card-inner,
.flip-card.hidden .flip-card-inner {
  transform: rotateX(180deg);
}

.flip-card-inner {
  transition: transform 0.8s;
  transform-style: preserve-3d;
  position: relative;
  width: 100%;
  height: 100%;
  background-color: transparent;
}

.poker-card {
  position: absolute;
  width: 100%;
  height: 100%;
  background-color: white;
  color: $themeColor;
  border: 4px solid $themeColor;
  border-radius: 10px;
  font-size: xx-large;
  font-weight: bold;
  box-shadow: 0 2px 4px #ccc;
  display: flex;
  align-items: center;
  justify-content: center;
  -webkit-backface-visibility: hidden; /* Safari */
  backface-visibility: hidden;

  &.back {
    background-color: $themeColor;
    transform: rotateX(180deg);
  }
}

.picker .poker-card.back {
  cursor: not-allowed;
}
</style>
