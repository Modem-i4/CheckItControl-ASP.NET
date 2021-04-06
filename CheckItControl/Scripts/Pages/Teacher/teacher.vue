<template>
    <v-app>
        <v-data-table :headers="headers"
                        :items="items"
                        :loading="loading"
                        class="elevation-1">
        </v-data-table>
    </v-app>
</template>
<script>

    import DataTableCore from "../../mixins/DataTableCore";
    export default {
        mixins: [DataTableCore],
        data() {
            return {
                CRUD: "api/teacher",
                headers: [
                    { text: "id", value: 'id' },
                    { text: "email", value: 'email' }
                ],
            }
        },
    };
</script>