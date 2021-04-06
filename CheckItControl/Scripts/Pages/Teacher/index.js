import Vue from 'vue';
import Vuetify from 'vuetify';
import 'vuetify/dist/vuetify.min.css';
import TeacherComponent from './teacher.vue';
import '@mdi/font/css/materialdesignicons.css'

Vue.use(Vuetify);

new Vue({
    el: "#app",
    vuetify: new Vuetify(),
    components: {
        TeacherComponent
    },
    icons: {
        iconfont: 'mdi',
    },
});