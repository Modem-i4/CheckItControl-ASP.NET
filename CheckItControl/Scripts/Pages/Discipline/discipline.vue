<template>
    <v-app>
        <subject-selector @setFilter="setFilter" @fetch="fetch" />
        <v-card-title>
            <h2>Disciplines</h2>
            <v-spacer></v-spacer>
            <v-text-field v-model="search"
                          append-icon="mdi-magnify"
                          :label="'Search'"
                          single-line
                          hide-details
                          clearable
                          autocomplete="nope"
                          @input="applySearch()" />
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
    import SubjectSelector from "../../components/SubjectSelector";
    export default {
        mixins: [DataTableCore],
        components: {
            SubjectSelector
        },
        data() {
            return {
                CRUD: "/discipline/",
                headers: [
                    { text: "id", value: 'id' },
                    { text: "title", value: 'title' },
                ],
            }
        },
    };
</script>