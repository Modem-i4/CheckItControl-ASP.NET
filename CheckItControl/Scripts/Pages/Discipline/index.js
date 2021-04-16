import Vue from 'vue';
import Vuetify from 'vuetify';
import 'vuetify/dist/vuetify.min.css';
import DisciplineComponent from './discipline.vue';
import '@mdi/font/css/materialdesignicons.css'
Vue.use(Vuetify);

new Vue({
    el: "#app",
    vuetify: new Vuetify(),
    components: {
        DisciplineComponent
    },
    icons: {
        iconfont: 'mdi',
    },
});