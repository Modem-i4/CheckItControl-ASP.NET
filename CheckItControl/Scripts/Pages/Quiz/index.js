import Vue from 'vue';
import Vuetify from 'vuetify';
import 'vuetify/dist/vuetify.min.css';
import QuizComponent from './quiz.vue';
import '@mdi/font/css/materialdesignicons.css'

Vue.use(Vuetify);

Vue.component('subject', {
    template: '#subject-selector',
    methods: {
        someMethod() {
            this.$Batya.someMethod();
        }
    }
});

new Vue({
    el: "#app",
    vuetify: new Vuetify(),
    components: {
        QuizComponent
    },
    icons: {
        iconfont: 'mdi',
    },
});