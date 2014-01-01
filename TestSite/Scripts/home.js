/********************************************************************************
### The MIT License (MIT)

### Copyright (c) 2013 Jason Jackson

### Permission is hereby granted, free of charge, to any person obtaining a copy of
### this software and associated documentation files (the "Software"), to deal in
### the Software without restriction, including without limitation the rights to
### use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of
### the Software, and to permit persons to whom the Software is furnished to do so,
### subject to the following conditions:

### The above copyright notice and this permission notice shall be included in all
### copies or substantial portions of the Software.

### THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
### IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS
### FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR
### COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER
### IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN
### CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

### This software is an adaptation of Parker Smith's FEWS C# project from github
### https://github.com/parkrrr/FEWS

*********************************************************************************/


var Vehicle = function () {
    var self = this;

    self.years = ko.observableArray();
    self.selectedYear = ko.observable();

    $.getJSON("/api/vehicle/getyears", function (allData) {
        self.years.removeAll();
        $.each(allData.Items, function (k, v) {
            self.years.push(v);
        });
    }).fail(function (jqxhr, textStatus, error) {
        var error = textStatus + ", " + error;
        alert(jqxhr.responseText);
        alert(error);
    });

    self.makes = ko.observableArray();
    self.selectedMake = ko.observable();

    self.selectedYear.subscribe(function () {
        //ko.cleanNode(self.makes);
        self.selectedMake(null);
        $.getJSON("/api/Vehicle/GetMakes", { year: self.selectedYear }, function (allData) {
            self.makes.removeAll();
            $.each(allData.Items, function (k, v) {
                self.makes.push(v);
            });
        }).fail(function (jqxhr, textStatus, error) {
            var error = textStatus + ", " + error;
            alert(jqxhr.responseText);
            alert(error);
        });
    }.bind(this));

    self.models = ko.observableArray();
    self.selectedModel = ko.observable();

    self.selectedMake.subscribe(function () {
        self.selectedModel(null);
        $.getJSON("/api/Vehicle/GetModels", { year: self.selectedYear, make: self.selectedMake }, function (allData) {
            self.models.removeAll();
            if (allData.Items != null) {
                $.each(allData.Items, function (k, v) {
                    self.models.push(v);
                });
            }
        }).fail(function (jqxhr, textStatus, error) {
            var error = textStatus + ", " + error;
            alert(jqxhr.responseText);
            alert(error);
        });
    }.bind(this));

    self.options = ko.observableArray();
    self.selectedOption = ko.observable();

    self.selectedModel.subscribe(function () {
        $.getJSON("/api/Vehicle/GetOptions", { year: self.selectedYear, make: self.selectedMake, model: self.selectedModel }, function (allData) {
            self.options.removeAll();
            if (allData.Items != null) {
                $.each(allData.Items, function (k, v) {
                    self.options.push(v);
                });
            }
        }).fail(function (jqxhr, textStatus, error) {
            var error = textStatus + ", " + error;
            alert(jqxhr.responseText);
            alert(error);
        });
    }.bind(this));

    self.vehicle = ko.observable();

    self.selectedOption.subscribe(function () {        
        $.getJSON("/api/Vehicle", { id: self.selectedOption() }, function (allData) {
            self.vehicle(allData);
        });
    }.bind(this));
};

ko.applyBindings(new Vehicle());