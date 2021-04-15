
export default {
    data() {
        return {
            pagination: {},
            search: '',
            searches:{},
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
        /*search: _.debounce(function () {
            this.applySearch()

        }, 400),*/
    },
    created() {
        this.fetch();
    },
    methods: {
        applySearch() {
            this.options.page = 1;
            this.fetch()
        },
        fetch() {
            this.loading = true;
            $.get(this.CRUD, {
                    search: this.search,

                    page: this.options.page,
                    perPage: this.options.itemsPerPage,

                    sortBy: this.sortBy,
                    sortDirection: this.sortDirection,
            }).then(response => {
                this.items = response.data.data;
                this.pagination.total = response.data.total;

                this.loading = false;
            })
        },
    }
}
