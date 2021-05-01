<template>
  <div class="game">
    <div class="header">
      <h1>Planning poker</h1>
      <router-link class="link-to-home outline" to="/">Leave</router-link>
    </div>
    <UsersCards class="game-table" />
    <div class="game-stats">
      <ControlPanel />
    </div>
    <CardPicker :cards="cards" class="pick-cards"></CardPicker>
  </div>
</template>

<script lang="ts">
import { defineComponent, computed } from "vue";
import { useStore } from "@/js/store";
import CardPicker from "@/components/CardPicker.vue";
import UsersCards from "@/components/UsersCards.vue";
import ControlPanel from "@/components/ControlPanel.vue";

export default defineComponent({
  name: "GamePage",
  components: { ControlPanel, UsersCards, CardPicker },
  setup() {
    const store = useStore();

    return {
      // access a state in computed function
      gamename: computed(() => store.state.game && store.state.game.name),
      cards: computed(() => store.state.game && store.state.game.cards),
    };
  },
});
</script>

<style lang="scss">
.game {
  height: 100%;
  display: grid;
  grid-template-rows: [row1] 10% [row2] 60% [row3];
  grid-template-columns: [col1] 70% [col2] 30% [col2-end];
}

.header {
  grid-row: row1;
  grid-column: col1/col2-end;
  box-shadow: grey 0 2px 2px;
  display: flex;
  flex-direction: row;
  justify-content: space-around;
  align-items: center;
}

.game-table {
  //background-color: darkgray;
  grid-row: row2;
  grid-column: col1;
}

.pick-cards {
  grid-row: row3;
  grid-column: col1;
}

.game-stats {
  grid-column: col2;
  grid-row: row2/row3-end;
  box-shadow: #ccc -2px 0 3px;
}
</style>
