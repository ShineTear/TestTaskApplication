﻿function addNewEmployee() {
    $.get('/Home/AddEmployee/', function (data) {
        $('#result').html(data);
    });
}

function addNewEmployeePosition() {
    $.get('/Home/AddEmployeePosition/', function (data) {
        $('#result').html(data);
    });
}

function addNewAbsenceReport() {
    $.get('/Home/AddAbsenceReport/', function (data) {
        $('#result').html(data);
    });
}

function employeeList() {
    $.get('/Home/EmployeeList/', function (data) {
        $('#result').html(data);
    });
}

function employeePositionList() {
    $.get('/Home/EmployeePositionList/', function (data) {
        $('#result').html(data);
    });
}