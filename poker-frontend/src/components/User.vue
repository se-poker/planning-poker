<template>
  <div class="user-card">
    <Card :card="user.card" />
    <div class="name">
      <p>{{ user.name }}</p>
    </div>
  </div>
</template>

<script>
import { defineComponent } from "vue";
import User from "@/js/models/user";
import Card from "@/components/Card";

export default defineComponent({
  name: "User",
  components: { Card },
  props: {
    user: User,
  },
});
</script>

<style scoped lang="scss">
.user-card {
  width: 80px;
  display: flex;
  align-items: center;
  flex-direction: column;
}
</style>
