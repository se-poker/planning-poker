<template>
  <h1>Strona główna</h1>
  <UsernamePrompt />
</template>

<script lang="ts">
import { defineComponent } from "vue";
import UsernamePrompt from "@/components/UsernamePrompt.vue";

export default defineComponent({
  name: "MainPage",
  components: { UsernamePrompt },
});
</script>

<style scoped></style>
