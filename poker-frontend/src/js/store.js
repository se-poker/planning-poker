import { createStore } from 'vuex'

const store = createStore({
    state () {
        return {
            game: null
        }
    },
    mutations: {
        setGame (state, game) {
            state.game = game;
        }
    }
})

export default store;