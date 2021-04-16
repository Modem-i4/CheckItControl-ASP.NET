import Vue from 'vue';
import Vuetify from 'vuetify';
import 'vuetify/dist/vuetify.min.css';
import SubjectComponent from './subject.vue';
import '@mdi/font/css/materialdesignicons.css'

Vue.use(Vuetify);

new Vue({
    el: "#app",
    vuetify: new Vuetify(),
    components: {
        SubjectComponent
    },
    icons: {
        iconfont: 'mdi',
    },
});