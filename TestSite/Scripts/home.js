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