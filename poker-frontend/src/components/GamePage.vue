<template>
  <div>
    <h1>Strona gry</h1>
    <h2>{{ gamename }}</h2>
  </div>
  <div class="game">
    <div class="game-table">
      <PickCard v-for="card in cards" :key="card" :user="card" :card="card" />
    </div>
    <div class="user-list">
      <User v-for="user in users" :key="user.connection" :user="user" />
    </div>
    <div class="game-stats">game-stats</div>
  </div>
</template>

<script lang="ts">
import { defineComponent, computed } from "vue";
import { useStore } from "@/js/store";
import PickCard from "@/components/PickCard.vue";
import User from "@/components/User.vue";

export default defineComponent({
  name: "GamePage",
  components: { PickCard, User },
  data: () => {
    return {
      cards: [1, 2, 3, 5, 8, 13, 21, 34],
    };
  },
  setup() {
    const store = useStore();

    return {
      // access a state in computed function
      gamename: computed(() => store.state.game && store.state.game.name),
      users: computed(() => store.state.game && store.state.game.users),
    };
  },
});
</script>

<style lang="scss">
.game {
  height: 900px;
  width: 1650px;
  display: grid;
  grid-template-rows: [row1] 60% [row2] 40% [row2-end];
  grid-template-columns: [col1] 60% [col2] 40% [col2-end];
}

.game-table {
  border: 3px solid black;
  background-color: darkgray;
  grid-row: row1;
  grid-column: col1;
  align-content: center;
}

.game-stats {
  border: 3px solid black;
  background-color: red;
  grid-row: row2;
  grid-column: col1;
}

.user-list {
  border: 3px solid black;
  background-color: yellow;
  grid-column: col2;
  grid-row: row1/row2-end;
}
</style>
