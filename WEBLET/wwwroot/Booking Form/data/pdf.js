window.onload = function () {
    document.getElementById("download")
        .addEventListener("click", () => {
            const Invoice = this.document.getElementById("Invoice");
            console.log(Invoice);
            console.log(window);
            //html2pdf().from(Invoice).save();
            var opt = {

                margin: 1,
                filename: 'BookingForm.pdf',
                image: { type: 'jpeg', quality: 0.99 },
                html2canvas: { scale: 1 },
                jsPDF: { unit: 'in', format: 'letter', orientation: 'portrait' }
            };
            html2pdf().from(Invoice).set(opt).save();
        })
}