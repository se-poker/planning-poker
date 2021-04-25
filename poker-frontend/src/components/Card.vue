<template>
  <button  class="poker-card" v-on:click="cardSelected">
      {{cardNumber}}
  </button >
</template>

<script>
export default {
  name: "Card",
  props: {
    cardNumber: Number
  },
  methods: {
    cardSelected : function (){

    }
  }
}
</script>

<style lang="scss">
.poker-card{
  height: 250px;
  width: 150px;
  background-color: darkgray;
  border: 3px solid black;
  font-size: xx-large;
  margin: 10px;
}
</style>