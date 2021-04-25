<template>
  <button class="poker-card" v-on:click="cardSelected">
    {{ cardNumber }}
  </button>
</template>

<script>
export default {
  name: "Card",
  props: {
    cardNumber: Number,
  },
};
</script>

<style lang="scss">
.poker-card {
  height: 250px;
  width: 150px;
  background-color: white;
  border-radius: 10px;
  font-size: xx-large;
  margin: 10px;
  box-shadow: 0 2px 4px rgba(0,0,0,0.18);
}
</style>
