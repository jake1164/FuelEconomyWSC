var Vehicle = function () {
    var self = this;

    self.years = ko.observableArray();
    self.selectedYear = ko.observable();

    var jqxhr = $.getJSON("/Vehicle/GetYears", function (allData) {
        alert("Foo");
        self.years.removeAll();
        $.each(allData.Items, function (k, v) {
            self.years.push(v);
        });
    })
        .fail(function (jqxhr, textStatus, error) {
            var error = textStatus + ", " + error;
            alert(jqxhr.responseText);
            alert(error);
        });




};

ko.applyBindings(new Vehicle());