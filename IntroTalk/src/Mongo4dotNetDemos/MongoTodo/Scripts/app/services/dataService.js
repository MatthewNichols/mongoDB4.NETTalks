(function () {

    mongoTodo.app.services.dataService = {

        insertList: function(list) {
            return $.ajax({
                headers: { 
                    'Accept': 'application/json',
                    'Content-Type': 'application/json' 
                },
                url: '/api/todolist',
                dataType: "json",
                type: 'POST',
                data: JSON.stringify(list)
            });
        },
        getAll: function () {
            return $.ajax({
                url: '/api/todolist',
                dataType: "json",
                type: 'GET'
            });
        },
        getById: function (id) {
            return $.ajax({
                url: '/api/todolist/' + id,
                dataType: "json",
                type: 'GET'
            });
        },
        updateList: function (list) {
            return $.ajax({
                headers: {
                    'Accept': 'application/json',
                    'Content-Type': 'application/json'
                },
                url: '/api/todolist/' + list.id,
                dataType: "json",
                type: 'PUT',
                data: JSON.stringify(list)
            });
        }
        //saveListItem: function(listId, listItem) {
        //    return $.ajax({
        //        url: '/api/todolist/savelistitem',
        //        headers: {
        //            'Accept': 'application/json',
        //            'Content-Type': 'application/json'
        //        },
        //        dataType: "json",
        //        type: 'POST',
        //        data: JSON.stringify({
        //            listId: listId,
        //            listItem: listItem
        //        })
        //    });
        //}

    };
}());