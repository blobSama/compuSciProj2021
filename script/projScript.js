// JavaScript source file
function validateForm() {
    if (document.getElementById("noAccnt").innerHTML == "") {
        if (document.getElementById("mailWrng").innerHTML == "") {
            if (document.getElementById("phoneWrng").innerHTML == "") {
                if (document.getElementById("costWrng").innerHTML == "") {
                    if (document.getElementById("amntWrng").innerHTML == "") {
                        if (document.getElementById("ftrsWrng").innerHTML == "") {
                            if (document.getElementById("enqWrng").innerText == "") {
                                if (document.getElementById("linkWrng").innerText == "") {
                                   document.getElementById("submit").disabled = false;
                                   document.getElementById("submitWrng").innerHTML = "Ready to submit!";
                                }
                                else {
                                    document.getElementById("submitWrng").innerHTML = "Please check your picture.";
                                }
                            }
                            else {
                                document.getElementById("submitWrng").innerHTML = "Please check the watch type.";
                            }
                        }
                        else {
                            document.getElementById("submitWrng").innerHTML = "Please check the features.";
                        }
                    }
                    else {
                        document.getElementById("submitWrng").innerHTML = "Please check amnt. for sale(between 0 to 1000).";
                    }
                }
                else {
                    document.getElementById("submitWrng").innerHTML = "Please check the cost(between 1 to 1500).";
                }
            }
            else {
                document.getElementById("submitWrng").innerHTML = "Please check phone number.";
            }
        }
        else {
            document.getElementById("submitWrng").innerHTML = "Please check your mail address.";
        }
    }
    else {
        document.getElementById("submitWrng").innerHTML = "Please create an account."
    }
}
/*
function removeMsg() {
    document.getElementById("submitWrng").innerHTML = ""
}*/

function hello() {
    document.getElementById("costWrng").innerHTML = "red";
}
function validateImage() {
    var url = document.getElementById("watchPic").value;
    if (url.match(/jpg$/) == null) {
        document.getElementById("linkWrng").innerText = "Please enter a jpg format picture.";
        document.getElementById("watchPic").value = "";
    }
    else {
        document.getElementById("linkWrng").innerText = "";
    }
}

function accntCheck() {
    if (document.getElementById('no').checked) {
        document.getElementById("noAccnt").innerHTML = "Please make an account before entering a watch";
        var radioButton = document.getElementById("no");
        radioButton.checked = false;
    }
    else {
        document.getElementById("noAccnt").innerHTML = "";
    }
}

function ftrsCheck() {
    if (document.getElementById("ftrs").value == "") {
        document.getElementById("ftrsWrng").innerHTML = "Please fill in features.";
    }
    else {
        document.getElementById("ftrsWrng").innerHTML = "";
    }
}

function checkType() {
    if (document.getElementById("enquiry").value == "Choose...") {
        document.getElementById("enqWrng").innerText = "Please choose a valid category.";
    }
    else {
        document.getElementById("enqWrng").innerText = "";
    }
}

function ValidateEmail() {
    var mailformat = /^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)*$/;
    var inputText = document.getElementById("mail");
    if(inputText.value.match(mailformat)) {
        document.getElementById("mailWrng").innerHTML = "";
    }
    else {
        document.getElementById("mailWrng").innerHTML = "Please enter valid email address.";
        document.getElementById("mail").value = '';
    }
}

function ValidatePhone() {
    var phoneno = /^[0-9]{10}$/;
    var inputtxt = document.getElementById("phone");
    if((inputtxt.value.match(phoneno))) {
        document.getElementById("phoneWrng").innerHTML = "";
    }
    else {
        document.getElementById("phoneWrng").innerHTML = "Please enter valid phone number.";
        document.getElementById("phone").value = '';
    }
}

function validateCost() {
    var num = document.getElementById("cost").value;
    if (num >= 1 && num <= 1500) {
        document.getElementById("costWrng").innerHTML = "";
    }
    else {
        document.getElementById("costWrng").innerHTML = "Please enter valid cost.";
        document.getElementById("cost").value = '';
    }
}

function validateAmnt() {
    var num = document.getElementById("amnt").value;
    if (num >= 0 && num <= 1000) {
        document.getElementById("amntWrng").innerHTML = "";
    }
    else {
        document.getElementById("amntWrng").innerHTML = "Please enter valid amount.";
        document.getElementById("amnt").value = '';
    }
}

function checkName(name) {
    var letters = /^[A-Za-z]+$/;
    if (!document.getElementById("fName").value.match(letters)) {
        document.getElementById("wrngName").innerText = "Please enter valid name";
        document.getElementById("fName").value = "";
        return false;
    }
    else {
        document.getElementById("wrngName").innerText = "";
        return true;
    }
}

function checkLName(name) {
    var letters = /^[A-Za-z]+$/;
    if (!document.getElementById("lName").value.match(letters)) {
        document.getElementById("wrngFmly").innerText = "Please enter valid surname";
        document.getElementById("lName").value = "";
        return false;
    }
    else {
        document.getElementById("wrngFmly").innerText = "";
        return true;
    }
}

function checkUMail() {
    var mailformat = /^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)*$/;
    var inputText = document.getElementById("mail");
    if (!inputText.value.match(mailformat)) {
        document.getElementById("mailWrng").innerText = "Please enter valid email address.";
        document.getElementById("mail").value = "";
        return false;
    }
    else {
        document.getElementById("mailWrng").innerText = "";
        return true;
    }
}

function checkAge() {
    var uAge = document.getElementById("age").value;
    if (uAge == null || uAge < 16) {
        document.getElementById("ageWrng").innerText = "Please enter valid age.";
        document.getElementById("age").value = "";
        return false;
    }
    else {
        document.getElementById("ageWrng").innerText = "";
        return true;
    }
}

function checkPass() {
    var pass = document.getElementById("pass").value;
    var passConf = document.getElementById("passConf").value;
    if (!(pass.length >= 8 && pass.length <= 16)) {
        document.getElementById("passWrng").innerText = "Please enter valid password(between 8 to 16 chars).";
        document.getElementById("pass").value = "";
        return false;
    }
    else {
        if (passConf == "" || passConf.localeCompare(pass) != 0) {
            document.getElementById("passConfWrng").innerText = "Password and password confirmation must be same.";
            document.getElementById("passConf").value = "";
            return false;
        }
        else {
            document.getElementById("passWrng").innerText = "";
            document.getElementById("passConfWrng").innerText = "";
            return true;
        }
    }
}

function checkId() {
    var userId = document.getElementById("UId").value;
    if (isNaN(userId)) {
        document.getElementById("idWrng").innerText = "Please enter valid ID.";
        document.getElementById("UId").value = "";
        return false;
    }
    else {
        document.getElementById("idWrng").innerText = "";
        return true;
    }
}

function checkAll() {
    var id = checkId(), Lname = checkLName(), name = checkName(), UMail = checkUMail(), age = checkAge(), pass = checkPass();
    if (id&&pass&&Lname&&checkName&&checkUMail&&checkAge) {
        document.getElementById("submit").disabled = false;
        document.getElementById("checkWrng").innerText = "All good to go!";
    }
    else {
        document.getElementById("checkWrng").innerText = "Something's wrong here...";
    }
}

function dis() {
    document.getElementById("submit").disabled = true;
}