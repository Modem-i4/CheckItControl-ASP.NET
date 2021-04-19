<template>
    <div id="subject-selector" class="form-inline w-50 justify-content-between">
        <template v-for="subject in subjects">

            <div
                     @click="changeSubject(subject.id)">
                <div class="btn btn-info" v-if="subject.id == selected">{{subject.title}}</div>
                <div class="btn btn-outline-info" v-else>{{subject.title}}</div>
            </div>
        </template>
    </div>
</template>
<script>
    export default {
        data() {
            return {
                selected: -1,
                subjects: [],
            }
        },
        created() {
            this.getSubjects();
        },
        props: {
            filters: [],
        },
        methods: {
            getSubjects() {
                $.get("/subject/getall", (response) => {
                    console.log(response);
                    this.subjects = response;
                });
            },
            changeSubject(id) {
                localStorage.setItem('SubjectId', id);
                this.selectSublect(id);
            },
            loadSubject() {
                let id = localStorage.getItem('SubjectId');
                if (id) {
                    this.selectSublect(id);
                }
                else {
                    this.$emit('fetch');
                }
            },
            selectSublect(id) {
                this.$emit('setFilter', 'SubjectId', id);
                this.selected = id;
            }
        },
        mounted() {
            this.loadSubject()
        },
        name: "sublect-selector"
    };
</script>