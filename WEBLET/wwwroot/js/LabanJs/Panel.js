//this function generated A unique VOucher number for different type of vouchers
var Details = [];
var TranactionRecord = 0;

function SubmitValidatoin(btn) {
    var Id = document.getElementById("Id").value;
    var Panel_Code = document.getElementById("Panel_Code").value;
    var Panel_Name = document.getElementById("Panel_Name").value;

    if (Panel_Code == '') {
        Alert('error', 'Enter your Panel Code');
        document.getElementById('Panel_Code').focus();
    } else if (Panel_Name == '') {
        Alert('error', 'Enter your Panel Name');
        document.getElementById('Panel_Name').focus();
   
    }
    else {

        data = {
            "ID": Id,
            "Panel_Code": Panel_Code,
            "Panel_Name": Panel_Name,
          

        }

        if (Id == '') {
            var apicall = ['POST', '/Panel/SavePanel', btn, data, "Panel Saved Successfully", 'Vform', true];
            ConfirmationAlert("Do you want to Save the record? ", "Yes", "No", AjaxButtonCallLoadPartiaView, apicall);
        } else {
            var apicall = ['POST', '/Panel/UpdatePanel', btn, data, "Panel Updated Successfully", 'Vform', true];
            ConfirmationAlert("Do you want to Update the record? ", "Yes", "No", AjaxButtonCallLoadPartiaView, apicall);
        }
      
    }
}




function DeleteValidatoin(btn) {
    if (document.getElementById('Id').value == '') {
        Alert('error', 'Select Item from list to delete ');
    } else {
        var apicall = ['POST',  '/Panel/DelPanel', btn, { "ID": document.getElementById('Id').value }, "Removed Successfully", 'Vform', true];
        ConfirmationAlert("Do you want to Save the record? ", "Yes", "No", AjaxButtonCallLoadPartiaView, apicall);
    }


}

function SetValues(id,Panel_Code, Panel_Name) {
    
    document.getElementById("Id").value = id;
    document.getElementById("Panel_Code").value = Panel_Code;
    document.getElementById("Panel_Name").value = Panel_Name;
 
}
function RefereshForm() {
    document.getElementById("Id").value = '';
    document.getElementById("Panel_Code").value = '';
    document.getElementById("Panel_Name").value = '';

}

function PrintPage() {
    if (document.getElementById('Id').value == '') {
        ToastFire('error', 'There is no GatePass Please Select Before Printing')
    }
    else {
        document.getElementById('RegPrint').style.display = 'block';
        document.getElementById('Head').style.display = 'none';

        AjaxLoadPrintview('GET', 'GatePass/GatPassLoadPrint?id=' + document.getElementById('Id').value, {}, 'print', 'loadingModal')

        document.getElementById('RegPrint').style.display = 'none';
        document.getElementById('Head').style.display = 'block';

    }
}

function ModifyTable() {
    var columns = document.getElementsByClassName('P');
    for (var i = 0; i < columns.length; i++) {
        columns[i].style.display = 'none';
    }
}