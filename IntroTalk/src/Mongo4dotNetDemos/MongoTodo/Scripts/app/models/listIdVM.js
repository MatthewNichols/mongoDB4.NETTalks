(function() {

    mongoTodo.app.models.ListIdVM = function(data) {

        this.id = -1;
        this.name = ko.observable();

        if (data) {
            this.id = data.Id;
            this.name(data.Name);
        }

    };
})();