/// <reference path="../knockout-3.3.0.debug.js" />

(function() {

    var dataService = mongoTodo.app.services.dataService;
    var app = new mongoTodo.app.models.AppVM(dataService);

    ko.applyBindings(app);


}())