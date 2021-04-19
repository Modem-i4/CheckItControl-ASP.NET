
export default {
    data() {
        return {
            pagination: {},
            search: '',
            filters: [],
            items: [],
            newItem: {},

            loading: true,
            options: {
                itemsPerPage: 10,
                sortDesc: 'desc',
                sortBy: '',
            },
            footerOptions: {
                itemsPerPageOptions: [10, 25, 50, 100],
            },

            CRUD: '',
            headers: [],
            defaultSortByField: 'Id',
            defaultSortDirection: 'DESC',

            editedItem: {}
        }
    },
    computed: {
        sortBy() {
            if (this.options.sortBy.length === 0) {    // If no column is selected for sorting, return the default value
                return this.defaultSortByField;
            }
            return this.options.sortBy[0];
        },
        sortDirection() {
            if(this.options.sortDesc[0] === 'd') {
                return this.defaultSortDirection;
            }
            return this.sortBy == null ? null : this.options.sortDesc[0] ? 'asc' : 'desc';
        },
    },
    watch: {
        options: {
            handler() {
                this.fetch()
            },
            deep: true,
        },
        items: {
            handler() {
                console.log(this.items)
            }
        }
        /*search: _.debounce(function () {
            this.applySearch()

        }, 400),*/
    },
    methods: {
        applySearch() {
            this.options.page = 1;
            this.fetch()
        },
        setFilter(title, value) {
            let filter = [{ Title: title, Value: value }];
            this.filters = filter;
            this.applySearch();
        },
        fetch() {
            this.loading = true;
            $.post(this.CRUD + "get", {
                search: this.search,
                filters: this.filters,

                page: this.options.page,
                perPage: this.options.itemsPerPage,

                sortBy: this.sortBy,
                sortDirection: this.sortDirection,
            }, (response) => {
                this.items = response;
                this.loading = false;
            });
        },




    }
}
