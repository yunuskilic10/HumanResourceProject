//AddDemand ***
$(document).ready(function () {
    $('#profile-img-file-input').on('change', function (e) {
        readURL(this);
        showFileName(e);
    });
});

function readURL(input) {
    if (input.files && input.files[0]) {
        var reader = new FileReader();
        reader.onload = function (e) {
            $('#imageResult').attr('src', e.target.result);
        };
        reader.readAsDataURL(input.files[0]);
    }
}

function showFileName(event) {
    var input = event.target;
    var fileName = input.files[0].name;
    var infoArea = document.getElementById('upload-label');

    if (input.files[0].type.includes("image")) {

        infoArea.textContent = '';
    } else {

        infoArea.textContent = 'File name: ' + fileName;
    }

}

