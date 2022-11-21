function Veriler() {
    var url = '/Personel/Veriler',
        $('table').html();


    var thead = '<thead><tr><th>Title</th><th>First Name</th><th>Last Name</th><th>Birth Date</th><th>Position</th><th>Hire Date</th><th>State</th><th></th></tr></thead>';
    $('table').append(thead);


    $.getJSON(url, function (data)){
        for (var item in data.Result) {
            var deger = '<tbody><tr><td>' + data.Result[item].Title + '</td><td>' + data.Result[item].First_Name + '</td><td>' + data.Result[item].Last_Name + '</td><td>' + data.Result[item].Birth_Date + '</td><td>' + data.Result[item].Position + '</td><td>' + data.Result[item].Hire_Date + '</td><td>' + data.Result[item].State + '</td></tr></tbody>'
            $('table').append(deger);
        }
    }
}