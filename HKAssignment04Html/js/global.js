/**
 * File Name: global.js
 *
 * Revision History:
 *       Heejin Ko, 4/9/2020 : Created
 */
var sellernames = [];
var addresses = [];
var cities = [];
var phones = [];
var emails = [];
var makes = [];
var models = [];
var years = [];

// Click save button
function btnSave_click() {

    if(DoValidate_InfoForm()){
        console.info("Form is Valid");
        var sellername = ($("#txtSellerName").val() + "").trim();
        var address = ($("#txtAddress").val() + "").trim();
        var city = ($("#txtCity").val() + "").trim();
        var phone = ($("#txtPhone").val() + "").trim();
        var email = ($("#txtEmail").val() + "").trim();
        var make = ($("#txtMake").val() + "").trim();
        var model = ($("#txtModel").val() + "").trim();
        var year = ($("#txtYear").val() + "").trim();

        sellernames.push(sellername);
        addresses.push(address);
        cities.push(city);
        phones.push(phone);
        emails.push(email);
        makes.push(make);
        models.push(model);
        years.push(year);

        localStorage.setItem("sellernames", sellernames);
        localStorage.setItem("addresses", addresses);
        localStorage.setItem("cities", cities);
        localStorage.setItem("phones", phones);
        localStorage.setItem("emails", emails);
        localStorage.setItem("makes", makes);
        localStorage.setItem("models", models);
        localStorage.setItem("years", years);

        btnSearch_click();

        alert("Record added successfully");
    }
    else{
        console.info("Form is Invalid");
    }
}

// Click Search button
function btnSearch_click() {
    document.getElementById("InfoForm").reset();
    DisplaySearch();
}

// Click Home button
function btnHome_click() {
    $("#InfoPage").show();
    $("#SearchPage").hide();
}

// Display list of search
function DisplaySearch() {

    if (sellernames.length == 0)
    {
        alert("No data on storage");
        $("#InfoPage").show();
        $("#SearchPage").hide();
    }
    else
    {
        var htmlCode = "";

        htmlCode +=
            "<table class='table table-bordered' id='tblSearchList'>" +
            " <thead class='thead-light table-sm'>" +
            "   <tr>" +
            "       <th>Seller Name</th>" +
            "       <th>Address</th>" +
            "       <th>City</th>" +
            "       <th>Phone Number</th>" +
            "       <th>Email</th>" +
            "       <th>Vehicle Make</th>" +
            "       <th>Model</th>" +
            "       <th>Year</th>" +
            "       <th>Link</th>" +
            " </tr>" +
            "</thead>";

        for (var i = 0; i < sellernames.length; i++)
        {
            var link = "http://www.jdpower.com/cars/" +
                    makes[i] + "/" + models[i] + "/" + years[i];
            console.info("Link: " + link);
            htmlCode +=
                "<tbody><tr>" +
                "   <td>" + sellernames[i] + "</td>" +
                "   <td>" + addresses[i] + "</td>" +
                "   <td>" + cities[i] + "</td>" +
                "   <td>" + phones[i] + "</td>" +
                "   <td>" + emails[i] + "</td>" +
                "   <td>" + makes[i] + "</td>" +
                "   <td>" + models[i] + "</td>" +
                "   <td>" + years[i] + "</td>" +
                "   <td>" +
                "       <a href='" + link + "'>JD Link</a>" +
                "   </td>" +
                "</tr></tbody>";
        }

        htmlCode += "</table>";

        $("#SearchList").html(htmlCode);

        $("#errorTxt").hide();
        $("#InfoPage").hide();
        $("#SearchPage").show();
    }
}

function init() {
    console.info("DOM is ready");
    setSearch();
    $("#SearchPage").hide();
    $("#btnSave").on("click", btnSave_click);
    $("#btnSearch").on("click", btnSearch_click);
    $("#btnHome").on("click", btnHome_click);
}

$(document).ready(function () {
    init();
})

// get data from the storage and set to list
function setSearch() {
    if (localStorage.getItem("sellernames") != null)
    {
        sellernames = localStorage.getItem("sellernames");
        sellernames = splitArray(sellernames);
    }

    if (localStorage.getItem("addresses") != null)
    {
        addresses = localStorage.getItem("addresses");
        addresses = splitArray(addresses);
    }

    if (localStorage.getItem("cities") != null)
    {
        cities = localStorage.getItem("cities");
        cities = splitArray(cities);
    }

    if (localStorage.getItem("phones") != null)
    {
        phones = localStorage.getItem("phones");
        phones = splitArray(phones);
    }

    if (localStorage.getItem("emails") != null)
    {
        emails = localStorage.getItem("emails");
        emails = splitArray(emails);
    }

    if (localStorage.getItem("makes") != null)
    {
        makes = localStorage.getItem("makes");
        makes = splitArray(makes);
    }

    if (localStorage.getItem("models") != null)
    {
        models = localStorage.getItem("models");
        models = splitArray(models);
    }

    if (localStorage.getItem("years") != null)
    {
        years = localStorage.getItem("years");
        years = splitArray(years);
    }
}

// Formatting array list
function splitArray(input) {

    if(!Array.isArray(input))
    {
        var newArray = input.split(',');
        return newArray;
    }
    else return input;
}

// Valicate
function DoValidate_InfoForm() {
    var form = $("#InfoForm");


    form.validate({
        rules: {
            txtSellerName: {
                required: true
            },
            txtAddress: {
                required: true
            },
            txtCity: {
                required: true
            },
            txtPhone: {
                required: true,
                PhoneCheck: true
            },
            txtEmail: {
                required: true
               // email: true
            },
            txtMake: {
                required: true
            },
            txtModel: {
                required: true
            },
            txtYear: {
                required: true
            }
        },
        messages: {
            txtSellerName: {
                required: "Seller name is required"
            },
            txtAddress: {
                required: "Address is required"
            },
            txtCity: {
                required: "City is required"
            },
            txtPhone: {
                required: "Phone number is required",
                PhoneCheck: "Please enter a valid Phone number" +
                    "(formats: 123-123-1234, or (123)123-1234)"
            },
            txtEmail: {
                required: "Email is required"
            },
            txtMake: {
                required: "Vehicle Make is required",
            },
            txtModel: {
                required: "Model is required",
            },
            txtYear: {
                required: "Year is required",
            }
        }
        // errorElement : 'div',
        // errorLabelContainer: '.errorTxt'
    });

    return form.valid();
}

// Phone validator
jQuery.validator.addMethod("PhoneCheck",
    function (value, element) {
        var regex = /\d{3}-\d{3}-\d{4}|\(\d{3}\)\d{3}-\d{4}/;
        return this.optional(element) || regex.test(value);
    },
    "Phone number checker"
);
