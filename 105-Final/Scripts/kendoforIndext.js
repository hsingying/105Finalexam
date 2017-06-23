$(function () {
    $.getScript("../../Scripts/kendo.all.min.js", function () {

        $("#grid").kendoGrid({
            dataSource: {
                transport: {
                    read: {
                        url: "../Customer/getQueryData",
                        dataType: "json"
                    },
                },
                pageSize: 30
            },
            columns: [{
                field: "CustomerID",
                title: "顧客編號",
                width: "80px"
            }, {
                field: "CompanyName",
                title: "顧客名稱",
                width: "100px"
            }, {
                field: "ContactName",
                title: "聯絡人姓名",
                width: "100px"
            }, {
                field: "CodeVal",
                title: "聯絡人職稱",
                width: "100px"
            }, {
                Command: [{
                    name: "Update",
                    click: "UpdateCustomer"
                }, {
                    name: "Delete",
                    click: "DeleteCustomer"
                }
                ], pageable: {
                    pageSize: 30,
                    buttonCount: 5,
                }, editable: true,
                sortable: true
            }]



        });
        $("#CodeVal").kendoComboBox({
            dataTextField: "Text",
            dataValueField: "Value",
            dataSource: {
                transport: {
                    read: "../Customer/getVal",
                    dataType: "json"
                }, schema: {
                    model: {
                        fields: {
                            Text: { type: "string" },
                            Value: { type: "string" }
                        },
                    },
                },
                pageSize: 80,
                serverPaging: true,
                serverFiltering: true,

            }
        });



    })


})