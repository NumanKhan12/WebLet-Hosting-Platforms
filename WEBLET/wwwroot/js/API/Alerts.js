function ConfirmationAlert(message,CText,CancelText,callback,args)
{
    const swalWithBootstrapButtons = Swal.mixin({
        customClass: {
            confirmButton: 'btn btn-success',
            cancelButton: 'btn btn-danger'
        },
        buttonsStyling: false
    })

    swalWithBootstrapButtons.fire({
        title: 'Are you sure?',
        text: message,
        icon: 'warning',
        showCancelButton: true,
        confirmButtonText: CText,
        cancelButtonText: CancelText,
        reverseButtons: true
    }).then((result) => {
        if (result.isConfirmed) {
            callback.apply(this, args);
           
        } else if (
            /* Read more about handling dismissals below */
            result.dismiss === Swal.DismissReason.cancel
        ) {
            swalWithBootstrapButtons.fire(
                'Cancelled',
                'Transaction Cannceled',
                'error'
            )
        }
    })
    //cuteAlert({
    //    type: "question",
    //    title: "Confirm",
    //    message: message,
    //    confirmText: CText,
    //    cancelText: CancelText
    //}).then((e) => {
    //    if (e == 'confirm') {
    //        callback.apply(this, args);
    //    }
    //    else {
    //        return false;
    //    }
    //})
}
