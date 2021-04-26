<template>
  <div>
    <h1>Strona gry</h1>
    <h2>{{ gamename }}</h2>
  </div>
</template>

<script>
import {mapState} from 'vuex';

export default {
  name: "GamePage",
  data: () => {
    return {
    }
  },
  computed: {
    ...mapState({
      game: state => state.game
    }),
    gamename() {
      if (!this.game)
        return 'no game';
      return this.game.name;
    }
  }
}
</script>

<style scoped>

</style>