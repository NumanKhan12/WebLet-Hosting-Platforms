function CheckRightOnControll(btn,ControlId,userId, url)
{
    if (url=='') {
        window.location.href = "/Account/LogIn";

    }
    else {
        $.ajax({
            type: "GET",
            url: url,
            data: { "userId": userId, "controlId": ControlId },
            success: function (result) {
                if (result == "Yes") {
                    btn.disabled = false;       

                }
                else {
                    btn.disabled = true;

                }
            },
            statusCode: {
                401: function () {
                    window.location.href="/Account/Login"
                }
            }

        })
    }
    
}
function Alert(messagetype,message) {
    Swal.fire({
        position: 'top-end',
        icon: messagetype,
        title: message,
        showConfirmButton: false,
        timer: 3500
    })
}
function AjaxRecieveResponse(url, btn, data, toastmsg,callback,args) {
    btn.disabled = true;
    $.ajax({
        type: 'post',
        url: url,
        data: data,
        async:false,
        success: function (result) {
            if (result.Code == "Success") {
                Alert('success', toastmsg);
                args = [result.value];
                console.log(result);
                btn.disabled = false;
                callback.apply(this, args);
            }
            else {
                Alert('error', result.Description);
                btn.disabled = false;

            }
        },
        statusCode: {
            401: function () {
                window.location.href = "/Account/Login"
            }
        }
    })
}
function AjaxSendEmail(url, btn, data, toastmsg, callback, args) {
    btn.disabled = true;
    $.ajax({
        type: 'post',
        url: url,
        data: data,
        success: function (result) {
            if (result.Code == "Success") {
                Alert('success', toastmsg);
                args = [result.value];
                btn.disabled = false;
                callback.apply(this, args);
            }
            else {
                Alert('error', result.Description);
                btn.disabled = false;

            }
        },
        statusCode: {
            401: function () {
                window.location.href = "/Account/Login"
            }
        }
    })
}
function LoadDataBeforeModal(type, url, tableId, LoadReference, modal, btn, Loadingmodal)  {
    $('#' + Loadingmodal).show();
    btn.disabled = true;
    $.ajax({
        type: type,
        url: url,
        success: function (result) {
            $("#" + tableId).dataTable().fnDestroy();
            document.getElementById(LoadReference).innerHTML = result;
            $("#" + tableId).dataTable({
                "initComplete": function (settings, json) {
                    dom: 'Bfrtip',
                        $("#" + tableId).wrap("<div style='overflow:auto; width:100%;position:relative;'></div>");
                }
            });
            $('#' + Loadingmodal).hide();
            $('#' + modal).modal('show');
            btn.disabled = false;
        },
        statusCode: {
            401: function () {
                window.location.href = "/Account/Login"
            }
        }
    })
}
function Loadpartialview(type, url, data, LoadReference, modal, Loadingmodal) {
    $('#' + Loadingmodal).show();
    //btn.disabled = true;
    $.ajax({
        type: type,
        url: url,
        data: data,
        async: false,
        success: function (result) {
          
            document.getElementById(LoadReference).innerHTML = result;
           
            $('#' + Loadingmodal).hide();
            $('#' + modal).modal('show');
            //btn.disabled = false;
        },
        statusCode: {
            401: function () {
                window.location.href = "/Account/Login"
            }
        }
    })
}

function LoadpartialviewForChatLoad(type, url, data, LoadReference, modal, Loadingmodal) {
    $('#' + Loadingmodal).show();
    //btn.disabled = true;
    $.ajax({
        type: type,
        url: url,
        data: data,
        async: false,
        success: function (result) {

            document.getElementById(LoadReference).innerHTML = result;
            divScrollDown();
            $('#' + Loadingmodal).hide();
            $('#' + modal).modal('show');
            //btn.disabled = false;
        },
        statusCode: {
            401: function () {
                window.location.href = "/Account/Login"
            }
        }
    })
}

function AjaxButtonCall(type, url, btn, data, toastmsg, formToReset, refreshRequired,objname) {
    btn.disabled = true;
    $.ajax({
        type: type,
        url: url,
        data:  data ,
        success: function (result) {
            if (result == "Success") {
                Alert('success', toastmsg);
                document.getElementById(formToReset).reset();
                btn.disabled = false;
                if (refreshRequired) {
                    RefereshForm();
                }
            }
            else {
                Alert('error', result);
                btn.disabled = false;

            }
        },
        statusCode: {
            401: function () {
                window.location.href = "/Account/Login"
            }
        }
    })
}
function AjaxButtonCallLoadPartiaView(type, url, btn, data, toastmsg, formToReset, refreshRequired, objname) {
    btn.disabled = true;
    $.ajax({
        type: type,
        url: url,
        data: data,
        success: function (result) {
            if (result == "Success") {
                Alert('success', toastmsg);
                document.getElementById(formToReset).reset();
                btn.disabled = false;
                if (refreshRequired) {
                    RefereshForm();
                    LoadPanelList(btn);
                }
            }
            else {
                Alert('error', result);
                btn.disabled = false;

            }
        },
        statusCode: {
            401: function () {
                window.location.href = "/Account/Login"
            }
        }
    })
}

function AjaxLoadCall(type, url, tableId, LoadReference) {
    if (url == '') {
        window.location.href="/Account/LogIn"
    }
    $("#" + tableId).dataTable().fnDestroy()

    $.ajax({
        type: type,
        url: url,
        success: function (result) {
            document.getElementById(LoadReference).innerHTML = result;
            $("#" + tableId).dataTable({
                // ... skipped ...
            });

        },
        statusCode: {
            401: function () {
                window.location.href = "/Account/Login"
            }
        }
    })
}
function AjaxRcieveResults(type,url) {
     return $.ajax({
        type: type,
        url: url,
        async: false,
        success: function (result) {
          
                
         },
         statusCode: {
             401: function () {
                 window.location.href = "/Account/Login"
             }
         }
    })
}
function AjaxPostCall(type, url,data) {
     $.ajax({
        type: type,
        url: url,
         async: false,
         data: data,
         success: function (result) {

             return result;

         },
         statusCode: {
             401: function () {
                 window.location.href = "/Account/Login"
             }
         }
    })
}
function AjaxBookingFormCall(type,url,data,elementId) {
    document.getElementById(elementId).innerHTML = '<img  src="/images/2.gif" width="20" height="20"/>';
    $.ajax({
        type: type,
        url: url,
        data: data,
        success: function (result) {
            document.getElementById(elementId).innerHTML = result;
        },
        statusCode: {
            401: function () {
                window.location.href = "/Account/Login"
            }
        }
    });
}
function AjaxButtonCallForImage(type, url, btn, data, toastmsg, formToReset, refreshRequired) {
    btn.disabled = true;
    $.ajax({
        type: type,
        url: url,
        data: data,
        processData: false,
        contentType: false,
        success: function (result) {
            if (result == "Success") {
                Alert('success', toastmsg)
                document.getElementById(formToReset).reset();
                if (refreshRequired) {
                    RefereshForm();
                    btn.disabled = false;
                }
                else {
                    btn.disabled = false;

                }

            }
            else {
               Alert('error',result)
                btn.disabled = false;

            }
        },
        statusCode: {
            401: function () {
                window.location.href = "/Account/Login"
            }
        }
    })
}

function AjaxPostApiCall(type, url, btn, data, toastmsg, formToReset, refreshRequired) {
    btn.disabled = true;
    $.ajax({
        type: type,
        url: url,
        data: data,
        success: function (result) {
            console.log(result)
            if (result.Code == "Success") {
                Toast.fire({
                    icon: 'success',
                    title: toastmsg
                })
                document.getElementById(formToReset).reset();
                if (refreshRequired) {
                    RefereshForm();
                }
                else {
                    btn.disabled = false;

                }

            }
            else {
                Toast.fire({
                    icon: 'error',
                    title: result.Description
                })
                btn.disabled = false;

            }
        }
    })
}
function AjaxImageCallResponse(url, btn, data, toastmsg, callback, args) {
    btn.disabled = true;
    $.ajax({
        type: 'POST',
        url: url,
        data: data,
        processData: false,
        contentType: false,
        success: function (result) {
            if (result.Code == "Success") {
                Alert('success', toastmsg);
                args = [result.value];
                btn.disabled = false;
                callback.apply(this, args);
            }
            else {
                Alert('error', result.Description);
                btn.disabled = false;

            }
        },
        statusCode: {
            401: function () {
                window.location.href = "/Account/Login"
            }
        }
    })
}