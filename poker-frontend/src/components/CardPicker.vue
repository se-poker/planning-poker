<template>
  <div>
    <p>Choose cards</p>
    <div class="picker">
      <PickCard
        v-for="card in cards"
        :key="card"
        :user="card"
        :card="card"
        :class="{ selected: selected == card }"
        @click="setCard(card)"
      />
    </div>
  </div>
</template>

<script lang="ts">
import { computed, defineComponent } from "vue";
import PickCard from "@/components/PickCard.vue";
import { useStore } from "@/js/store";
import connection from "@/js/signalr/gamehub";

export default defineComponent({
  name: "CardPicker",
  components: { PickCard },
  props: {
    cards: [],
  },
  setup() {
    const store = useStore();
    return {
      setCard: (card: number | null) => {
        store.commit("setCard", card);
        connection.send("VoteCard", card);
      },
      selected: computed(() => store.state.card),
      users: computed(() => store.state.game && store.state.game.users),
    };
  },
});
</script>

<style scoped lang="scss">
.picker {
  display: flex;
  margin-top: 50px;
  flex-wrap: wrap;
  justify-content: center;
}
</style>
