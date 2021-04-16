<template>
    <v-app>

        <v-card-title>
            <h2>Quizes</h2>
            <v-spacer></v-spacer>
            <v-text-field v-model="search"
                          append-icon="mdi-magnify"
                          :label="'Search'"
                          single-line
                          hide-details
                          clearable
                          autocomplete="nope"
                          @input="applySearch()"/>
        </v-card-title>
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
                CRUD: "/subject/get",
                headers: [
                    { text: "id", value: 'Id' },
                    { text: "title", value: 'Title' },                    
                ],
            }
        },
    };
</script>