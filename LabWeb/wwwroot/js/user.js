var dataTable;

$(document).ready(function () {
    loadDataTable();
});

function loadDataTable() {
    dataTable = $('#tblData').DataTable({
        "ajax": { url: '/admin/user/getall' },
        "columns": [
            
            { data: 'name', "width": "15%" },
            { data: 'email', "width": "15%" },
            { data: 'pnumb', "width": "15%" },
            { data: 'officer.name', "width": "5%" },
            { data: '', "width": "20%" },
           
            {
                data: 'id',
                "render": function (data) {
                    return `<div class="w-75 btn-group" role="group">
                     <a href="/admin/user/upsert?id=${data}" class="btn btn-primary mx-2"> <i class="bi bi-pencil-square"></i> Edit</a>
                     
                    </div>`
                },
                "width": "30%"
            }
        ]
    });
}

