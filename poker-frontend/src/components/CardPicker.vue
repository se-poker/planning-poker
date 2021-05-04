<template>
  <div>
    <p v-if="voting">Choose your card</p>
    <p v-if="!voting">Wait for new round</p>
    <div class="picker">
      <PickCard
        v-for="card in cards"
        :key="card"
        :value="card"
        :voting="voting"
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
  setup() {
    const store = useStore();
    return {
      setCard: (card: number | null) => {
        if (store.state.game && store.state.game.voting) {
          store.commit("setCard", card);
          connection.send("VoteCard", card);
        }
      },

      selected: computed(() => store.state.card),
      voting: computed(() => store.state.game && store.state.game.voting),
      cards: store.state.game && store.state.game.cards,
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
