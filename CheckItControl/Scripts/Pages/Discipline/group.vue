<template>
    <v-app>
        <v-card-title>
            <h2>Disciplimes of group {{this.groupName}}</h2>
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
    export default {
        mixins: [DataTableCore],
        data() {
            return {
                CRUD: "/discipline/",
                headers: [
                    { text: "id", value: 'id' },
                    { text: "title", value: 'title' },
                ],
                groupName: '',
                groupId: 0
            }
        },
        methods: {
            getGroups() {
                const url = window.location.href;
                this.groupId = url.split("/").slice(-1)[0];
                $.get("/group/getTitle/" + this.groupId,
                    (response) => { this.groupName = response })
                this.setFilter('GroupId', this.groupId)
            }
        },
        mounted() {
            this.getGroups();
        }
    };
</script>