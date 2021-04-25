<template>
  <div class="game">
    <div class="game-table">
      <Card card-number="1"/>
      <Card card-number="2"/>
      <Card card-number="3"/>
      <Card card-number="5"/>
      <Card card-number="8"/>
      <Card card-number="13"/>
      <Card card-number="20"/>
    </div>
    <div class="user-list">
      user-list
      <User username="Adam"/>
      <User username="Robert"/>
      <User username="Jan"/>
    </div>
    <div class="game-stats">
      game-stats
    </div>
  </div>
</template>

<script>
import Card from "@/components/Card";
import User from "@/components/User";
export default {
  name: "Game",
  components: {User, Card}
}
</script>

<style  lang="scss">
.game{
  height: 900px;
  width: 1650px;
  display: grid;
  grid-template-rows: [row1] 60% [row2] 40% [row2-end] ;
  grid-template-columns: [col1] 60% [col2] 40% [col2-end] ;
}

.game-table{
  border: 3px solid black;
  background-color: darkgray;
  grid-row: row1;
  grid-column: col1;
  align-content: center;
}
.game-stats{
  border: 3px solid black;
  background-color: red;
  grid-row: row2;
  grid-column: col1;
}
.user-list{
  border: 3px solid black;
  background-color: yellow;
  grid-column: col2;
  grid-row: row1/row2-end;
}
</style>