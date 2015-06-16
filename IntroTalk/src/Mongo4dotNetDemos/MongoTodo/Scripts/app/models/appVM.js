(function() {

    mongoTodo.app.models.AppVM = function(dataService) {
        var self = this;

        this.lists = ko.observableArray();
        this.selectedList = ko.observable();

        

        this.listDisplayVisible = ko.observable(false);
        this.listEditVisible = ko.observable(false);

        this.makeAddEditAreasInvisible = function() {
            this.listDisplayVisible(false);
            this.listEditVisible(false);
        };

        this.listDisplayClickHandler = function() {
            console.log(this);
            self.makeAddEditAreasInvisible();

            dataService.getById(this.id).done(function(returnData) {
                console.log(returnData);
                self.selectedList(new mongoTodo.app.models.ListVM(returnData));
                self.listDisplayVisible(true);
            });
        }

        this.listEditClickHandler = function () {
            console.log(this);

            self.makeAddEditAreasInvisible();

            dataService.getById(this.id).done(function(returnData) {
                console.log(returnData);
                self.selectedList(new mongoTodo.app.models.ListVM(returnData));
                self.listEditVisible(true);
            });
        }

        this.addListClickHandler = function () {
            console.log(this);
            
        }

        this.addItemClickHandler = function () {
            self.addEditItemTitle("Add Item");

        }

        this.saveListClickHandler = function () {
            
            dataService.updateList(self.selectedList());

        }



        //Set up
        dataService.getAll().done(function (returnData) {

            self.lists(returnData.map(function(listData) {
                return new mongoTodo.app.models.ListVM(listData);
            }));

            console.log(returnData);
        });
    };



}());