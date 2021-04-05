<template>
    <div id="teacher">
        <h1>Home -Vue</h1>
        <button @click="count++">—чЄтчик кликов Ч {{ count }}</button>
        <ul id="example-2">
            <li v-for="teacher in teachers">
                {{ teacher. }}
            </li>
        </ul>
    </div>
</template>
<script>
    export default {
        data() {
            return {
                count: 0
            }
        },
        props: {
            teachers: {
                default: [],
            },
        },
        name: "teacher-component"
    };
</script>