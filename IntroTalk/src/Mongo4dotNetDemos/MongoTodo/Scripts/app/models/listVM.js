(function() {

    mongoTodo.app.models.ListVM = function(data) {

        var self = this;

        this.id = -1;
        this.name = ko.observable();
        this.items = ko.observableArray();

        this.addEditItem = ko.observable();

        this.addEditItemMode = ko.observable();
        this.addEditItemTitle = ko.computed(function() {
            switch (self.addEditItemMode()) {
                case "edit":
                    return "Edit";
                case "add":
                    return "Add";
                default:
                    return "";
            }
        });

        this.addEditItemVisible = ko.computed(function () {
            switch (self.addEditItemMode()) {
                case "edit":
                case "add":
                    return true;
                default:
                    return false;
            }
        });

        this.saveItemClickHandler = function () {
            if (self.addEditItemMode() === "add") {
                self.items.push(self.addEditItem());
            }

            self.addEditItemMode("");
        }

        this.addItemClickHandler = function () {
            self.addEditItemMode("add");
            self.addEditItem(new mongoTodo.app.models.ListItemVM());
        }

        if (data) {
            this.id = data.Id;
            this.name(data.Name);

            self.addEditItem(new mongoTodo.app.models.ListItemVM());
        }

    };

    mongoTodo.app.models.ListItemVM = function(data) {

        this.id = -1;
        this.title = ko.observable();
        this.details = ko.observable();
        this.done = ko.observable(false);

        if (data) {
            this.id = data.Id;
            this.title(data.Title);
            this.details(data.Details);
            this.done(data.Done);
        }

        this.toJSON = function() {
            return {
                this.id = -1;
            this.title = ko.observable();
            this.details = ko.observable();
            this.done = ko.observable(false);
        
            }
        }
    };

})();