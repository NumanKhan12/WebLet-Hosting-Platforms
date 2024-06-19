
//    function LoadBlocks(PJ_CODE) {
//        data = { "PJ_ID": PJ_CODE }
//        AjaxBookingFormCall('GET', 'LoadBlocks', data, 'Blocks');
//}
//    function Disable(check) {
//        if (check.checked) {
//        document.getElementById('Save').disabled = false;
//    }
//        else {
//        document.getElementById('Save').disabled = true;
//    }
//}
//    function AddMember(BOK_ID) {
//        var CNIC = document.getElementById('TEXT_MEMBER').value;
//        if (CNIC.length<15) {
//        Alert("error", "Invalid CNIC");
//    }
//        else {
//        data = {
//            "CNIC": CNIC,
//            "BOK_ID": BOK_ID
//        }
//            AjaxBookingFormCall('GET', '/Member/GetMember', data, 'MEMBER_INFO');
//}
//}
//    function SubmitValidation(btn) {
//        var PAY_ACC_ID = document.getElementById("PAY_ACC_ID").value;
//    var PAY_TYPE = document.getElementById("PAY_TYPE").value;
//    var PAY_REF = document.getElementById("PAY_REF").value;
//    var PAY_TR_DATE = document.getElementById("PAY_TR_DATE").value;
//    var BOK_ID = document.getElementById("BOK_ID").value;
//        if (PAY_ACC_ID == '0') {
//        Alert('error', 'Select Account ');
//    document.getElementById('PAY_ACC_ID').focus();
//        } else if (PAY_TYPE == '0') {
//        Alert('error', 'Select Type');
//    document.getElementById('PAY_TYPE').focus();
//        } else if (PAY_REF == '') {
//        Alert('error', 'Enter Reference');
//    document.getElementById('PAY_REF').focus();
//        } else if (PAY_TR_DATE == '') {
//        Alert('error', 'Enter Date');
//    document.getElementById('PAY_TR_DATE').focus();
//        } else {
//        data = {
//            "PAY_ACC_ID": PAY_ACC_ID,
//            "PAY_TYPE": PAY_TYPE,
//            "PAY_REF": PAY_REF,
//            "PAY_TR_DATE": PAY_TR_DATE,
//            "BOK_ID": BOK_ID
//        }
//            var file_data = $("#TR_EVIDENCE").prop("files")[0];
//    var form_data = new FormData();
//    form_data.append("data", JSON.stringify(data));
//    form_data.append("file", file_data);
//    var apicall = ['SaveSubmission', btn, form_data, "Saved Successfully", MoveToPage, []];
//    ConfirmationAlert("Do you want to Save the record? ", "Yes", "No", AjaxImageCallResponse, apicall);
//}
//}
//    function MoveToPage(sd) {
//        window.location.href = '/Attachments/SubmitAttachments?BID=' + sd;
//    }


//    // Get the modal
//    var modal = document.getElementById("myModal");

//    // Get the button that opens the modal
//    var btn = document.getElementById("myBtn");

//    // Get the <span> element that closes the modal
//    var span = document.getElementsByClassName("close")[0];

//    // When the user clicks the button, open the modal
//    btn.onclick = function () {
//            modal.style.display = "block";
//        }
    
//    // When the user clicks on <span> (x), close the modal
//    span.onclick = function () {
//                modal.style.display = "none";
//            }
        
//            // When the user clicks anywhere outside of the modal, close it
//    window.onclick = function (event) {
//        if (event.target == modal) {
//                modal.style.display = "none";
//            }
//        }
    
//    function CNICChnagefunction(input, evt) {
//                evt = (evt) ? evt : window.event;
//            var charCode = (evt.which) ? evt.which : evt.keyCode;
//        if ((input.value.length == 5 || input.value.length == 13) && charCode !== 8) {
//                input.value = input.value + '-';
//            }
//        }
//    function isnumber(evt, input) {
//                evt = (evt) ? evt : window.event;
//            var charCode = (evt.which) ? evt.which : evt.keyCode;
//        if (charCode > 31 && (charCode < 48 || charCode > 57) || input.value.length > 14) {
//            return false;
//        }
//        return true;
//    }

//    function isnumer2(evt, input) {
//                evt = (evt) ? evt : window.event;
//            var charCode = (evt.which) ? evt.which : evt.keyCode;
//        if (charCode > 31 && (charCode < 48 || charCode > 57) || input.value.length > 10) {
//            return false;
//        }
//        return true;
//    }
//    function phonefunc(input, evt) {
//                evt = (evt) ? evt : window.event;
//            var charCode = (evt.which) ? evt.which : evt.keyCode;
//            console.log(input.value);
//        if ((input.value.length == 3) && charCode !== 8) {
//                input.value = input.value + '-';
//            }
//        }
    
    
