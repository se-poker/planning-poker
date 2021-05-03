<template>
  <div id="control-panel">
    <button @click="showCards" :disabled="!voting">Show cards</button>
    <button @click="newRound" :disabled="voting">New round</button>
  </div>
</template>

<script lang="ts">
import { computed, defineComponent } from "vue";
import connection from "@/js/signalr/gamehub";
import { useStore } from "@/js/store";

export default defineComponent({
  name: "ControlPanel",
  setup() {
    const store = useStore();

    return {
      voting: computed(() => store.state.game && store.state.game.voting),
    };
  },
  methods: {
    showCards: function () {
      connection.send("ShowCards");
    },
    newRound: function () {
      connection.send("NewRound");
    },
  },
});
</script>

<style scoped>
#control-panel {
  padding: 20px;
  display: flex;
  justify-content: space-evenly;
}
</style>
