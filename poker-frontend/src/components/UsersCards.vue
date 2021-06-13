<template>
  <div class="cards">
    <User v-for="user in users" :key="user.connection" :user="user" />
  </div>
</template>

<script lang="ts">
import { computed, defineComponent } from "vue";
import { useStore } from "@/js/store";
import User from "@/components/User.vue";
import UserModel from "@/js/models/user";

export default defineComponent({
  name: "UsersCards",
  components: { User },
  setup() {
    const store = useStore();

    return {
      users: computed(
        (): UserModel[] | null => store.state.game && store.state.game.users
      ),
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
