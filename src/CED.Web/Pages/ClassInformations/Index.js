
$(function () {
    var l = abp.localization.getResource('CED');
    var createModal = new abp.ModalManager(abp.appPath + 'ClassInformations/CreateModal');
   var editModal = new abp.ModalManager(abp.appPath + 'ClassInformations/EditModal');
   

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
                    title: l('Actions'),
                    rowAction: {
                        items:
                            [
                                {
                                    text: l('Edit'),
                                    visible: abp.auth.isGranted('CED.ClassInformations.Edit'),
                                    action: function (data) {
                                        //editModal.open({ id: data.record.id });
                                        window.location.href = '/ClassInformations/EditModal?id=' + data.record.id;
                                    }
                                },
                                {
                                    text: l('Delete'),
                                    visible: abp.auth.isGranted('CED.ClassInformations.Delete'),
                                    confirmMessage: function (data) {
                                        return l(
                                            'ClassDeletionConfirmationMessage',
                                            data.record.name
                                        );
                                    },
                                    action: function (data) {
                                        cED.classInformations.classInformation
                                            .delete(data.record.id)
                                            .then(function () {
                                                abp.notify.info(
                                                    l('SuccessfullyDeleted')
                                                );
                                                dataTable.ajax.reload();
                                            });
                                    }
                                }
                            ]
                    }
                },
                {
                    title: l('Title'),
                    data: "title"
                },
                {
                    title: l('Status'),
                    data: "status",
                    render: function (data) {
                        return l('Enum:Status.' + data);
                    }
                },
                {
                    title: l('LearningMode'),
                    data: "learningMode",
                    render: function (data) {
                        return l('Enum:LearningMode.' + data);
                    }
                },
                {
                    title: l('Fee'),
                    data: "fee"
                },
                {
                    title: l('ChargeFee'),
                    data: "chargeFee"
                },
                {
                    title: l('AcademicLevel'),
                    data: "academicLevel",
                    render: function (data) {
                        return l('Enum:AcademicLevel.' + data);
                    }
                },
                {
                    title: l('NumberOfStudent'),
                    data: "numberOfStudent"
                },
                {
                    title: l('MinutePerSession'),
                    data: "minutePerSession"
                },
                {
                    title: l('SessionPerWeek'),
                    data: "sessionPerWeek"
                },
                {
                    title: l('Subject'),
                    data: "subjectName"
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

    createModal.onResult(function () {
        dataTable.ajax.reload();
    });
    $('#CreateEditButtonSubmit').click(function () {
        dataTable.ajax.reload();
    });

    $('#NewClassButton').click(function (e) {
        e.preventDefault();
        //createModal.open();
        window.location.href = '/ClassInformations/CreateModal/';
    });
});


function CreateUpdateClassInformationFormSubmited(form) {
    var formdata = new FormData(form);
    abp.ajax({
        type: 'POST',
        processData: false,
        contentType: false,
        data: formdata,
        url: form.action
    }).then(function () {
        debugger;
        window.location.href = '/ClassInformations';
    });
    return false;
    
}