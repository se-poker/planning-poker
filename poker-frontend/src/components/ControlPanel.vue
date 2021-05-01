<template>
  <div id="control-panel">
    <button @click="showCards">Show cards</button>
    <button @click="newRound">New round</button>
  </div>
</template>

<script lang="ts">
import { defineComponent } from "vue";
import connection from "@/js/signalr/gamehub";

export default defineComponent({
  name: "ControlPanel",
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
}
</style>
