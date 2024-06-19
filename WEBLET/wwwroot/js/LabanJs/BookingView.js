
//function SubmitValidation(btn) {
//    btn.disabled = true;
//    btn.innerHTML = '<img  src="/images/2.gif" width="20" class=" text-center" height="20"/>';
//         var NOM_ID = document.getElementById('NOM_ID').value;
//    if (!document.getElementById('SkipNominee').checked & NOM_ID=='0') {
//        //changed
//            Alert('error', 'Please Select Nominee')
//            btn.disabled = false;
//            btn.innerHTML = 'Save Booking';
//    }
//    else {
//        var PLAN_ID = document.getElementById('PLAN_ID').value;
//        var BLOCK_ID = document.getElementById('BLOCK_ID').value;
//        var PLOT_ID = document.getElementById('PLOT_ID').value;
//        data = {
//            "PLAN_ID": PLAN_ID,
//            "BLOCK_ID": BLOCK_ID,
//            "PLOT_ID": PLOT_ID,
//            "NOM_ID":NOM_ID
//        }
        
//        if (!document.getElementById('SkipNominee').checked) {
            
//        }
//        //if (document.getElementById('AddBtn') == null || document.getElementById('AddBtn').innerText != 'Added') {
//        //    data = {
//        //        "PLAN_ID": PLAN_ID,
//        //        "BLOCK_ID": BLOCK_ID,
//        //        "PLOT_ID": PLOT_ID
//        //    }
//        //} else {
//        //    //var CNIC = document.getElementById('NOMINEE_CNIC').value;
//        //    //var NAME = document.getElementById('NOMINEENAME').value;
//        //    //var REL = document.getElementById('RELATIONSHIP_NOMINEE').value;
//        //    //var PHONE = document.getElementById('NOMINEE_PHONE').value;
//        //    data = {
//        //        "NOM_ID":
//        //        //"NOMINEE_CNIC": CNIC,
//        //        //"NOMINEENAME": NAME,
//        //        //"RELATIONSHIP_NOMINEE": REL,
//        //        //"NOMINEE_PHONE": PHONE,
//        //        "PLAN_ID": PLAN_ID,
//        //        "BLOCK_ID": BLOCK_ID,
//        //        "PLOT_ID": PLOT_ID
//        //    }
//        //}
//        //console.log(data);
//        var apicall = ['SaveBooking', btn, data, "Saved Successfully", MoveToPage, []];
//        ConfirmationAlert("Do you want to Save the record? ", "Yes", "No", AjaxRecieveResponse, apicall);
//        btn.innerHTML = 'Save Booking';
//        btn.disabled = false;
//    }
//}
//function MoveToPage(sd) {
//    window.location.href = '/PaymentSubmission/PaymentSubmissionView?BID=' + sd;
//}

//function AddNominee(btn) {
//    var CNIC = document.getElementById('NOMINEE_CNIC').value;
//    var NAME = document.getElementById('NOMINEENAME').value;
//    var REL = document.getElementById('RELATIONSHIP_NOMINEE').value;
//    var PHONE = document.getElementById('NOMINEE_PHONE').value;
//    if (CNIC == '') {
//        Alert('error', 'Enter CNIC');
//        document.getElementById('NOMINEE_CNIC').focus();
//    }
//    else if (NAME == '') {
//        Alert('error', 'Enter Name');
//        document.getElementById('NOMINEENAME').focus();
//    }
//    else {
//        document.getElementById('SkipNominee').checked = true;
//        document.getElementById('SKip').hidden = true;
//        document.getElementById('AddBtn').innerText = 'Added';
//        document.getElementById('AddBtn').disabled = true;
//        //data = {
//        //    "NOMINEE_CNIC":CNIC,
//        //    "NOMINEENAME":NAME,
//        //    "RELATIONSHIP_NOMINEE":REL,
//        //    "NOMINEE_PHONE":PHONE,
//        //}
//        //  var apicall = ['/NOMINEE/CreateNominee', btn, data, "Added ", Added, []];
//        //  ConfirmationAlert("Do you want to add Nominee? ", "Yes", "No", AjaxRecieveResponse, apicall);
//    }

//}
//function Added(value) {
//    //document.getElementById('SkipNominee').checked = true;
//    //document.getElementById('SKip').hidden = true;
//    //document.getElementById('AddBtn').innerText = 'Added';
//    //document.getElementById('AddBtn').disabled = true;

//}

//function CNICChnagefunction(input, evt) {
//    evt = (evt) ? evt : window.event;
//    var charCode = (evt.which) ? evt.which : evt.keyCode;
//    if ((input.value.length == 5 || input.value.length == 13) && charCode !== 8) {
//        input.value = input.value + '-';
//    }
//}
//function isnumber(evt, input) {
//    evt = (evt) ? evt : window.event;
//    var charCode = (evt.which) ? evt.which : evt.keyCode;
//    if (charCode > 31 && (charCode < 48 || charCode > 57) || input.value.length > 14) {
//        return false;
//    }
//    return true;
//}

//window.onload = function () {

//}