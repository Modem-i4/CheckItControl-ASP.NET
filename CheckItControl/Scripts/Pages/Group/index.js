import Vue from 'vue';
import Vuetify from 'vuetify';
import 'vuetify/dist/vuetify.min.css';
import GroupComponent from './group.vue';
import '@mdi/font/css/materialdesignicons.css'

Vue.use(Vuetify);

new Vue({
    el: "#app",
    vuetify: new Vuetify(),
    components: {
        GroupComponent
    },
    icons: {
        iconfont: 'mdi',
    },
});