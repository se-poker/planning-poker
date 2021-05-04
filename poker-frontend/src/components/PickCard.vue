<template>
  <div class="clickable-card">
    <Card :card="card" />
  </div>
</template>

<script lang="ts">
import { computed, defineComponent } from "vue";
import Card from "@/components/Card.vue";
import CardModel from "@/js/models/card";

export default defineComponent({
  name: "PickCard",
  components: { Card },
  props: {
    value: {
      type: Number,
      required: true,
    },
    voting: Boolean,
  },
  setup(props) {
    return {
      card: computed(
        (): CardModel => {
          return {
            value: props.value,
            hidden: !props.voting,
          };
        }
      ),
    };
  },
});
</script>

<style lang="scss" scoped>
@import "./src/assets/scss/colors";

.clickable-card {
  transition: transform 0.5s;

  &:hover {
    cursor: pointer;
  }

  &.selected {
    transform: translateY(-50px);
    transition: transform 0.5s;
    //box-shadow: 0 2px 5px 1px $themeColor;
  }
}
</style>
