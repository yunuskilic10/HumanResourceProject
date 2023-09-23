//Update / Main Controller ***
function updateFormatPhoneNumber(input) {
    const phoneNumber = input.value.replace(/\D/g, ''); // Sadece rakamları al
    if (phoneNumber.length > 10) {
        phoneNumber = phoneNumber.substring(0, 10); // İlk 10 karakteri al
    }
    const formattedPhoneNumber = format(phoneNumber); // Numarayı formatla
    input.value = formattedPhoneNumber;
}

function format(phoneNumber) {
    const cleaned = ('' + phoneNumber).replace(/\D/g, '');
    const match = cleaned.match(/^(0|)?(\d{3})(\d{3})(\d{4})$/);
    if (match) {
        const intlCode = match[1] ? '+1 ' : '';
        return [intlCode, '(', match[2], ') ', match[3], ' ', match[4]].join('');
    }
    return phoneNumber;
}

/*  ==========================================
   SHOW UPLOADED IMAGE
* ========================================== */
function readURL(input) {
    if (input.files && input.files[0]) {
        var reader = new FileReader();

        reader.onload = function (e) {
            $('#imageResult')
                .attr('src', e.target.result);
        };
        reader.readAsDataURL(input.files[0]);
    }
}

$(function () {
    $('#profile-img-file-input').on('change', function () {
        readURL(input);
    });
});

/*  ==========================================
    SHOW UPLOADED IMAGE NAME
* ========================================== */
var input = document.getElementById('upload');
var infoArea = document.getElementById('upload-label');

input.addEventListener('change', showFileName);
function showFileName(event) {
    var input = event.srcElement;
    var fileName = input.files[0].name;
    infoArea.textContent = 'File name: ' + fileName;
}



    
