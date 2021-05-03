<template>
  <h2>Statistics</h2>
  <div class="game-stats">
    <p v-if="gameStats.length == 0">Begin game and end first round</p>
    <Stats v-for="stats in gameStats" :key="stats.round" :stats="stats" />
  </div>
</template>

<script lang="ts">
import { computed, defineComponent } from "vue";
import { useStore } from "@/js/store";
import Stats from "@/components/Stats.vue";
import StatsModel from "@/js/models/stats";

export default defineComponent({
  name: "GameStats",
  components: { Stats },
  setup() {
    const store = useStore();

    return {
      gameStats: computed(
        (): StatsModel[] | null => store.state.game && store.state.game.stats
      ),
    };
  },
});
</script>

<style scoped lang="scss">
.game-stats {
  overflow: auto;
  height: 600px;
}
</style>
