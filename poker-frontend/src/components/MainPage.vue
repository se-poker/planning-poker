<template>
  <h1>Strona główna</h1>
  <div class="container">
    <div class="row">
      <JoinGame />
      <CreateGame />
    </div>
  </div>
</template>

<script lang="ts">
import { defineComponent } from "vue";
import JoinGame from "@/components/JoinGame.vue";
import CreateGame from "@/components/CreateGame.vue";

export default defineComponent({
  name: "MainPage",
  components: { JoinGame, CreateGame },
});
</script>

<style scoped>
.container {
  height: 100%;
  width: 100%;
  padding: 0 100px;
  display: flex;
  align-items: start;
  justify-content: center;
  background-color: #70b5ffff;
}
.row {
  width: 950px;
  display: flex;
  justify-content: space-between;
  align-items: center;
}
</style>
