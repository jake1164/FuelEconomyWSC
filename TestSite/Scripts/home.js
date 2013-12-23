var Vehicle = function () {
    var self = this;

    self.years = ko.observableArray();
    self.selectedYear = ko.observable();
    
    $.getJSON("/Vehicle/GetYears", function (allData) {
        alert("Foo");
        self.years.removeAll();
        $.each(allData.Items, function (k, v) {
            self.years.push(v);
        });
        
    });
};

ko.applyBindings(new Vehicle());