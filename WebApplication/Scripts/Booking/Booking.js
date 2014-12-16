$(document).ready(function () {

    $('#btnBook').click(function () {

        var start = new Date().getTime();

        $("#divLogs").append("------------Single Threaded-----------<br />");
        $("#divLogs").append('booking started <br />');

        var planeId = bookPlane();
        $("#divLogs").append('booking done for Plane :  ' + planeId + " <br />");

        var carId = bookCar();
        $("#divLogs").append('booking done for Car :  ' + carId + " <br />");

        var hotelId = bookHotel();
        $("#divLogs").append('booking done for Hotel :  ' + hotelId + " <br />");

        var ellapsed = +new Date() - start;
        $("#divLogs").append("Booking Finished. <br />");
        $("#divLogs").append("<b>Elapsed Time  :" + ellapsed + "(miliSeconds)<br />");
        $("#divLogs").append("------------Single Threaded Ends-----------<br />");


    });



    $('#btnBookParallel').click(function () {

        var start = new Date().getTime();

        $("#divLogs").append("------------Single Threaded Parallelism-----------<br />");
        $("#divLogs").append('booking started <br />');

        $.when(bookPlaneAsync(), bookCarAsync(), bookHotelAsync()).done(function (planeId, carId, hotelId) {
            $("#divLogs").append('booking done for Plane :  ' + planeId + " <br />");
            $("#divLogs").append('booking done for Car :  ' + carId + " <br />");
            $("#divLogs").append('booking done for Hotel :  ' + hotelId + " <br />");

            var ellapsed = +new Date() - start;
            $("#divLogs").append("Booking Finished. <br />");
            $("#divLogs").append("<b>Elapsed Time  :" + ellapsed + "(miliSeconds)<br />");
            $("#divLogs").append("------------Single Threaded Ends-----------<br />");
        });
    });

});


function bookPlaneAsync() {
    var defer = $.Deferred();

    var promise = $.ajax({
        url: "/api/booking/GetPlaneBookingConfirmationNumber",
    });

    promise.done(function (data) {
        defer.resolve(data);
    });
    promise.fail(function (error) {
        defer.resolve(null, error);
    });
    return defer.promise();
}

function bookCarAsync() {
    var defer = $.Deferred();

    var promise = $.ajax({
        url: "/api/booking/GetCarBookingConfirmationNumber",
        //async: false,
    });

    promise.done(function (response) {
        defer.resolve(response);
    });
    promise.fail(function (error) {
        defer.resolve(null, error);
    });
    return defer.promise();
}

function bookHotelAsync() {
    var defer = $.Deferred();

    var promise = $.ajax({
        url: "/api/booking/GetHotelBookingConfirmationNumber",
        //async: false,
    });

    promise.done(function (data) {
        defer.resolve(data);
    });
    promise.fail(function (error) {
        defer.resolve(null, error);
    });
    return defer.promise();
}

function bookPlane() {

    var planeId = 0;
    $.ajax({
        url: "/api/booking/GetPlaneBookingConfirmationNumber",
        //async: false,
        success: function (response) {
            planeId = response;
        },
        error: function () {
            planeId = -1;
        },
    });

    return planeId;
}

function bookHotel() {
    var hotelId = 0;

    $.ajax({
        url: "/api/booking/GetHotelBookingConfirmationNumber",
        //async: false,
        success: function (response) {
            hotelId = response;
        },
        error: function () {
            hotelId = -1;
        },
    });

    return hotelId;
}

function bookCar() {
    var carId = 0;

    $.ajax({
        url: "/api/booking/GetCarBookingConfirmationNumber",
        //async: false,
        success: function (response) {
            carId = response;
        },
        error: function () {
            carId = -1;
        },
    });
    return carId;
}
