<template>
    <div id="home">
        <h1>Home -Vue11</h1>
        <button @click="count++">������� ����11�� � {{ count }}</button>
    </div>
</template>
<script>
    export default {
        data() {
            return {
                count: 0
            }
        },
        name: "login-component"
    };
</script>