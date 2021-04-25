<template>
  <JoinGame />
  <CreateGame />
</template>

<script>
import JoinGame from "@/components/JoinGame";
import CreateGame from "@/components/CreateGame";
export default {
  name: "Menu",
  components: { CreateGame, JoinGame },
};
</script>

<style scoped></style>
