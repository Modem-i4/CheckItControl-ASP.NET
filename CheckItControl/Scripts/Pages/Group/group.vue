<template>
    <v-app>

        <v-card-title>
            <h2>Groups</h2>
            <v-spacer></v-spacer>
            <v-text-field v-model="search"
                          append-icon="mdi-magnify"
                          label="Search"
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
            <template #item.controls="{ item }">

                <v-btn-toggle shaped>
                    <v-btn :href="`/student/group/` + item.id">
                        Students
                    </v-btn>

                    <v-btn :href="`/discipline/group/` + item.id">
                        Disciplines
                    </v-btn>
                </v-btn-toggle>
            </template>
        </v-data-table>
    </v-app>
</template>
<script>

    import DataTableCore from "../../mixins/DataTableCore";
    export default {
        mixins: [DataTableCore],
        data() {
            return {
                CRUD: "/group/",
                headers: [
                    { text: "id", value: 'id' },
                    { text: "title", value: 'title' },
                    { value: 'controls', sortable: false, width: "1%" },                    
                ],
            }
        },
        created() {
            this.fetch();
        },
    };
</script>