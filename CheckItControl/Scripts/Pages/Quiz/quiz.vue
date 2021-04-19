<template>
    <v-app>
        <subject-selector @setFilter="setFilter" @fetch="fetch" />
        <v-card-title>
            <h2>Quizes</h2>
            <Dialog :items="items" :CRUD="CRUD" :editedItem="editedItem" ref="dialog">
                <v-row>
                    <v-col cols="12" sm="6" md="4">
                        <v-text-field v-model="editedItem.title" label="Title" />
                    </v-col>
                    <v-col cols="12" sm="6" md="4">
                        <v-text-field v-model="editedItem.description" label="Description" />
                    </v-col>
                </v-row>
            </Dialog>
            <v-spacer></v-spacer>
            <v-text-field v-model="search"
                          append-icon="mdi-magnify"
                          label="Search"
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

            <template #item.actions="{ item }">
                <v-icon small class="mr-2" @click="$refs.dialog.editItem(item)">mdi-pencil</v-icon>
                <v-icon small @click="$refs.dialog.deleteItem(item)">mdi-delete</v-icon>
            </template>
        </v-data-table>
    </v-app>
</template>
<script>

    import DataTableCore from "../../mixins/DataTableCore";
    import SubjectSelector from "../../components/SubjectSelector";
    import Dialog from "../../components/Dialog";
    export default {
        mixins: [DataTableCore],
        components: {
            SubjectSelector,
            Dialog
        },
        data() {
            return {
                CRUD: "/quiz/",
                headers: [
                    { text: "id", value: 'id' },
                    { text: "title", value: 'title' },
                    { text: "description", value: 'description' },
                    {value: "actions"}
                ],
            }
        }
    };
</script>