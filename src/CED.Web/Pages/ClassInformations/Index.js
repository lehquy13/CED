$(function () {
    var l = abp.localization.getResource('CED');

    var dataTable = $('#ClassesTable').DataTable(
        abp.libs.datatables.normalizeConfiguration({
            serverSide: true,
            paging: true,
            order: [[1, "asc"]],
            searching: false,
            scrollX: true,
            ajax: abp.libs.datatables.createAjax(cED.classInformations.classInformation.getList),
            columnDefs: [
                {
                    title: l('Title'),
                    data: "Title"
                },
                {
                    title: l('Status'),
                    data: "Status"
                },
                {
                    title: l('LearningFormality'),
                    data: "LearningFormality"
                },
                {
                    title: l('Fee'),
                    data: "Fee"
                },
                {
                    title: l('ChargeFee'),
                    data: "ChargeFee"
                },
                {
                    title: l('AcademicLevel'),
                    data: "AcademicLevel"
                },
                {
                    title: l('NumberOfStudent'),
                    data: "NumberOfStudent"
                },
                {
                    title: l('MinutePerSession'),
                    data: "MinutePerSession"
                },
                {
                    title: l('SessionPerWeek'),
                    data: "SessionPerWeek"
                },
                {
                    title: l('Subject'),
                    data: "Subject"
                },
                //{
                //    title: l('Type'),
                //    data: "type",
                //    render: function (data) {
                //        return l('Enum:BookType.' + data);
                //    }
                //},
                //{
                //    title: l('PublishDate'),
                //    data: "publishDate",
                //    render: function (data) {
                //        return luxon
                //            .DateTime
                //            .fromISO(data, {
                //                locale: abp.localization.currentCulture.name
                //            }).toLocaleString();
                //    }
                //},
                
                {
                    title: l('CreationTime'), data: "creationTime",
                    render: function (data) {
                        return luxon
                            .DateTime
                            .fromISO(data, {
                                locale: abp.localization.currentCulture.name
                            }).toLocaleString(luxon.DateTime.DATETIME_SHORT);
                    }
                }
            ]
        })
    );
});

//var createModal = new abp.ModalManager(abp.appPath + 'Books/CreateModal');
var createModal = new abp.ModalManager(abp.appPath + 'ClassInformations/Create');

createModal.onResult(function () {
    dataTable.ajax.reload();
});

$('#NewClassButton').click(function (e) {
    e.preventDefault();
    //createModal.open();
    window.location.href = '/ClassInformations/Create/';
});