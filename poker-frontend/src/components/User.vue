<template>
  <div class="userElement">
    <div class="userLogo">
      <Card :card="user.card" />
    </div>
    <div class="userName">
      <p>{{ user.name }}</p>
    </div>
    <div class="userReady">
      <img src="@/assets/ready.png" alt="ready" />
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

<style lang="scss">
* {
  -webkit-box-sizing: border-box;
  -moz-box-sizing: border-box;
  box-sizing: border-box;
  margin: 0;
  padding: 0;
}

img {
  max-width: 100%;
  max-height: 100%;
}

.userElement {
  border: 1px solid black;
  display: flex;
  align-items: center;
  justify-content: space-between;
  height: 100px;
}

.userLogo {
  width: 100px;
  height: 80%;
  margin-left: 30px;
}

.userName {
  margin-left: 40px;
  padding: 5px;
}

.userReady {
  width: 100px;
  height: 70%;
  margin-right: 40px;
}

.userName p {
  font-size: xx-large;
}
</style>
