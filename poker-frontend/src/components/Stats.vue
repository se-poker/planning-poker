<template>
  <div class="stats">
    <div class="stats-row stats-header">
      <p class="round">{{ stats.round }}</p>
      <p class="time">{{ stats.time }}</p>
    </div>

    <div class="stats-row stats-content">
      <p class="votes">
        Votes: <span>{{ stats.votes }}</span>
      </p>
      <p class="average">
        Average: <span>{{ stats.averageVote }}</span>
      </p>
    </div>
  </div>
</template>

<script lang="ts">
import { defineComponent, PropType } from "vue";
import Stats from "@/js/models/stats";

export default defineComponent({
  name: "Stats",
  props: {
    stats: Object as PropType<Stats>,
  },
  setup(props) {
    console.log(props);
  },
});
</script>

<style scoped lang="scss">
@import "./src/assets/scss/colors";

.stats {
  padding: 20px;
  border-bottom: 1px solid #ccc;

  &-row {
    display: flex;
    align-items: center;
  }

  &-header {
    justify-content: start;
  }

  &-content {
    margin-left: 50px;
    padding: 0 20px;
    justify-content: start;
    display: flex;
    justify-content: space-evenly;
  }

  .round {
    font-size: 30px;
    font-weight: bold;
    border: 5px solid $themeColor;
    border-radius: 25px;
    width: 50px;
    height: 50px;
    display: flex;
    align-items: center;
    justify-content: center;
  }

  .time {
    margin-left: 20px;
    color: #ccc;
  }

  .votes > span,
  .average > span {
    font-size: 30px;
    font-weight: bold;
  }
}
</style>
