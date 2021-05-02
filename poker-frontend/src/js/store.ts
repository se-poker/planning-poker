// store.ts
import { InjectionKey } from "vue";
import { createStore, useStore as baseUseStore, Store } from "vuex";
import { Game } from "@/js/models/game";

export interface State {
  game: Game | null;
  card: number | null;
}

export const key: InjectionKey<Store<State>> = Symbol();

export const store = createStore<State>({
  state: {
    game: null,
    card: null,
  },
  mutations: {
    setGame(state: State, game: Game) {
      console.log(game);
      state.game = game;
    },
    setCard(state: State, card: number | null) {
      state.card = card;
    },
  },
});

// define your own `useStore` composition function
export function useStore(): Store<State> {
  return baseUseStore(key);
}
