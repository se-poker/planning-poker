<template>
  <div class="cards">
    <User :user="{ card: { value: 4, hidden: false }, name: 'Onufry' }" />
    <User :user="{ card: { value: 3, hidden: true }, name: 'Adam' }" />
    <User :user="{ card: null, name: 'Janek' }" />
    <User v-for="user in users" :key="user.connection" :user="user" />
  </div>
</template>

<script lang="ts">
import { useStore } from "@/js/store";
import { computed } from "vue";
import { defineComponent } from "vue";
import User from "@/components/User.vue";

export default defineComponent({
  name: "UsersCards",
  components: { User },
  setup() {
    const store = useStore();

    return {
      users: computed(() => store.state.game && store.state.game.users),
    };
  },
});
</script>

<style scoped lang="scss">
.cards {
  display: flex;
  justify-content: center;
  align-items: center;
  flex-wrap: wrap;
}
</style>
