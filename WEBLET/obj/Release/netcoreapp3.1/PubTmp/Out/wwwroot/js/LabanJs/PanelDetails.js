window.onload = function () {
    LoadImagesView("dummy-user.jpg", "dummy-user.jpg", "dummy-user.jpg");
};


function LoadImagesView(Pic1, Pic2, Pic3) {
    document.getElementById('Pb_List').innerHTML = 'wait';
    data = {
        "HOST1": Pic1,
        "HOST2": Pic2,
        "HOST3": Pic3,
    }
    Loadpartialview('GET', 'AdminPanelImages', data, 'Pb_List', 'modal-defaul', 'loadingModal')
}


function readURL(input, id) {
    if (input.files && input.files[0]) {
        var reader = new FileReader();
        reader.onload = function (e) {
            $('#' + id)
                .attr('src', e.target.result)
        };

        reader.readAsDataURL(input.files[0]);
        console.log(input);
        console.log(id);
    }
}
function readUR(input, id) {
    if (input != null) {
        var reader = new FileReader();
        reader.onload = function (e) {
            $('#' + id)
                .attr('src', e.target.result)
        };

        reader.readAsDataURL(input.HOST1);
        console.log(input);
        console.log(id);
    }
}
//ID, PANEL_ID, DISCRIPTION, CONDITION, DELEVERYDAY, FROM_DATE, TO_DATE, PRICE, SHIPMRNT, DEMO_LINK,RETURNS_DIS
//, HOST1, HOST2, HOST3
function SubmitValidation(btn) {
    var ID = document.getElementById("ID").value;
    var PANEL_ID = document.getElementById("PANEL_ID").value;
    var DISCRIPTION = document.getElementById("DISCRIPTION").value;
    var CONDITION = document.getElementById("CONDITION").value;
    var DELEVERYDAY = document.getElementById("DELEVERYDAY").value;
    var FROM_DATE = document.getElementById("FROM_DATE").value;
    var TO_DATE = document.getElementById("TO_DATE").value;
    var PRICE = document.getElementById("PRICE").value;
    var SHIPMRNT = document.getElementById("SHIPMRNT").value;
    var DEMO_LINK = document.getElementById("DEMO_LINK").value;
    var RETURNS_DIS = document.getElementById("RETURNS_DIS").value;
    var HOST1 = $('#HOST1').prop("files")[0];
    var HOST2 = $('#HOST2').prop("files")[0];
    var HOST3 = $('#HOST3').prop("files")[0];
 
    var USER_PIC_HOST1   = document.getElementById("USER_PIC_HOST1").src 
    var USER_PIC_HOST2  = document.getElementById("USER_PIC_HOST2").src 
    var USER_PIC_HOST3 = document.getElementById("USER_PIC_HOST3").src 
  
   
   
    if (PANEL_ID == '') {
        Alert('error', 'Select  Panel ');
        document.getElementById('PANEL_ID').focus();
    } else if (DISCRIPTION == '') {
        Alert('error', 'Enter   Panel DISCRIPTION');
        document.getElementById('DISCRIPTION').focus();

    } else if (CONDITION == '') {
        Alert('error', 'Enter   Panel CONDITION');
        document.getElementById('CONDITION').focus();

    //}
    //else if (DELEVERYDAY == '') {
    //    Alert('error', 'Enter   Panel DELEVERY DAY');
    //    document.getElementById('DELEVERYDAY').focus();

    } else if (FROM_DATE == '') {
        Alert('error', 'Enter   Panel FROM_DATE');
        document.getElementById('FROM_DATE').focus();

    } else if (TO_DATE == '') {
        Alert('error', 'Enter   Panel TO_DATE');
        document.getElementById('TO_DATE').focus();

    } else if (PRICE == '') {
        Alert('error', 'Enter   Panel PRICE');
        document.getElementById('PRICE').focus();

    } else if (SHIPMRNT == '') {
        Alert('error', 'Enter   Panel SHIPMRNT');
        document.getElementById('SHIPMRNT').focus();

    } else if (DEMO_LINK == '') {
        Alert('error', 'Enter   DELEVERY DISCRIPTION');
        document.getElementById('DEMO_LINK').focus();

    }
    else if (RETURNS_DIS == '') {
        Alert('error', 'Enter   RETURNS DISCRIPTION');
        document.getElementById('RETURNS_DIS').focus();

    }
    else if (USER_PIC_HOST1 == '~/images/dummy-user.jpg' && USER_PIC_HOST2 == '~/images/dummy-user.jpg' && USER_PIC_HOST3 == '~/images/dummy-user.jpg') {
        Alert('error', 'Enter   Panel Host Pic ');
        document.getElementById('HOST1').focus();

    } 
    else {

        data = {
            "ID": ID,
            "PANEL_ID": PANEL_ID,
            "DISCRIPTION": DISCRIPTION,
            "CONDITION": CONDITION,
            "DELEVERYDAY": DELEVERYDAY,
            "FROM_DATE": FROM_DATE,
            "TO_DATE": TO_DATE,
            "PRICE": PRICE,
            "SHIPMRNT": SHIPMRNT,
            "DEMO_LINK": DEMO_LINK,
            "RETURNS_DIS": RETURNS_DIS,
            //"HOST1": HOST1,
            //"HOST2": HOST2,
            //"HOST3": HOST3,
        }
        var data_fact = new FormData();
        data_fact.append("data", JSON.stringify(data));
        data_fact.append("HOST1", HOST1);
        data_fact.append("HOST2", HOST2);
        data_fact.append("HOST3", HOST3);
        if (ID == '') {
            var apicall = ['POST', '/Panel/AddPanelDetails', btn, data_fact, "Panel Details Saved Successfully", 'Vform', true];
            ConfirmationAlert("Do you want to Save the record? ", "Yes", "No", AjaxButtonCallForImage, apicall);
        } else {
            var apicall = ['POST', '/Panel/UpdatePanelDetails', btn, data_fact, "Panel Details Updated Successfully", 'Vform', true];
            ConfirmationAlert("Do you want to Update the record? ", "Yes", "No", AjaxButtonCallForImage, apicall);
        }
    }
}

function LoadDetails(btn) {
    LoadDataBeforeModal('GET', '/Panel/PanelDetailsModel', 'PanelModelTableId', 'ptable', 'modal-default', btn, 'loadingModal')
}
function DeleteValidation(btn) {
    if (document.getElementById('ID').value == '') {
        Alert('error', 'Select Item from list to delete ');
    } else {
        var apicall = ['POST', '/Panel/DeletePanelDetails', btn, { "ID": document.getElementById('ID').value }, "Removed Successfully", 'Vform', true];
        ConfirmationAlert("Do you want to Save the record? ", "Yes", "No", AjaxButtonCallLoadPartiaView, apicall);
    }
}

function SetPanelValues(ID, PANEL_ID, DISCRIPTION, PanelDetailsNumber, CONDITION, DELEVERYDAY, FROM_DATE, TO_DATE, PRICE, SHIPMRNT, DEMO_LINK, RETURNS_DIS, HOST1, HOST2, HOST3) {
    
    document.getElementById("ID").value = ID;
    document.getElementById("PANEL_ID").value = PANEL_ID;
    document.getElementById("DISCRIPTION").value = DISCRIPTION;
    document.getElementById("PanelDetailsNumber").value = PanelDetailsNumber;
    document.getElementById("CONDITION").value = CONDITION;
    document.getElementById("DELEVERYDAY").value = DELEVERYDAY;
    document.getElementById("FROM_DATE").value = FROM_DATE;
    document.getElementById("TO_DATE").value = TO_DATE ;
    document.getElementById("PRICE").value = PRICE;
    document.getElementById("SHIPMRNT").value = SHIPMRNT;
    document.getElementById("DEMO_LINK").value = DEMO_LINK;
    document.getElementById("RETURNS_DIS").value = RETURNS_DIS;
    LoadImagesView(HOST1, HOST2, HOST3);
    
    
    
}

function RefereshForm() {
    document.getElementById("ID").value = '';
    document.getElementById("PANEL_ID").value = '';
    document.getElementById("DISCRIPTION").value = '';
    document.getElementById("PanelDetailsNumber").value = '';
    document.getElementById("DELEVERYDAY").value = '';
    document.getElementById("FROM_DATE").value = '';
    document.getElementById("TO_DATE").value = '';
    document.getElementById("PRICE").value = '';
    document.getElementById("SHIPMRNT").value = '';
    document.getElementById("DEMO_LINK").value = '';
    document.getElementById("RETURNS_DIS").value = '';
    var Pic1= 'dummy-user.jpg';
    var Pic2= 'dummy-user.jpg';
    var Pic3= 'dummy-user.jpg';
    //document.getElementById("USER_PIC_HOST2").src = '~/images/dummy-user.jpg';
   
    LoadImagesView(Pic1, Pic2, Pic3);

}
function ModifyTable() {
    var columns = document.getElementsByClassName('P');
    for (var i = 0; i < columns.length; i++) {
        columns[i].style.display = 'none';
    }
}

function refreshImage(imgElement, imgUR) {
    // create a new timestamp 
    imgURL = '~/images/' + imgUR;
    console.log(imgUR);
    console.log(imgURL);
    console.log(imgElement);
    var timestamp = new Date().getTime();

    var el = document.getElementById(imgElement);

    var queryString = "?t=" + timestamp;

    el.src = imgURL + queryString;
}  