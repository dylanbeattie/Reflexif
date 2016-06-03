var dropzone = document.getElementById('dropzone');
var tests = {
    filereader: typeof FileReader != 'undefined',
    dnd: 'draggable' in document.createElement('span'),
    formdata: !!window.FormData,
    progress: "upload" in new XMLHttpRequest
};
var support = {
    filereader: document.getElementById('filereader'),
    formdata: document.getElementById('formdata'),
    progress: document.getElementById('progress')
};
var acceptedTypes = {
    'image/png': true,
    'image/jpeg': true,
    'image/gif': true
};
var progress = document.getElementById('uploadprogress');
var fileupload = document.getElementById('upload');

"filereader formdata progress".split(' ').forEach(function (api) {
    if (tests[api] === false) {
        support[api].className = 'fail';
    } else {
        // FFS. I could have done el.hidden = true, but IE doesn't support
        // hidden, so I tried to create a polyfill that would extend the
        // Element.prototype, but then IE10 doesn't even give me access
        // to the Element object. Brilliant.
        support[api].className = 'hidden';
    }
});

function previewfile(file) {
    if (tests.filereader === true && acceptedTypes[file.type] === true) {
        var reader = new FileReader();
        reader.onload = function (event) {
            var image = new Image();
            image.src = event.target.result;
            if (image.width > image.height) {
                image.width = 200;
            } else {
                image.height = 200;
            }
            dropzone.innerHTML = '';
            dropzone.appendChild(image);
        };

        reader.readAsDataURL(file);
    } else {
        dropzone.innerHTML = '<p><strong>' + file.name + '</strong></p><br /><p>' + (file.size ? (file.size / 1024 | 0) + 'K' : '') + "</p>";
        console.log(file);
    }
}

function readfiles(files) {
    var formData = tests.formdata ? new FormData() : null;
    for (var i = 0; i < files.length; i++) {
        if (tests.formdata) formData.append('file', files[i]);
        previewfile(files[i]);
    }

    // now post a new XHR request
    if (tests.formdata) {
        var xhr = new XMLHttpRequest();
        xhr.open('POST', "/home/upload");
        xhr.onload = function () {
            progress.value = progress.innerHTML = 100;
            $("#metadata-form").css('visibility', 'visible');
            var data = jQuery.parseJSON(xhr.responseText);
            var list = $("#metadata-list");
            for (var key in data) {
                if (data[key]) {
                    list.append($("<dt/>").html(key));
                    list.append($("<dd/>").html(data[key]));
                }
            }
            alert(data);

            var form = $("#metadata-form")[0];
            form.title.value = data.Image_ImageDescription || data.Image_Title || data.Image_XPTitle;
            form.copyright.value = data.Image_Copyright || data.Image_Authors || data.Image_XPAuthors;
            form.filename.value = data.filename;
            form.authors.value = data.Image_Authors || data.Image_XPAuthors;
            form.keywords.value = data.Image_XPKeywords;
            if (data.CameraMake && data.CameraModel) {
                $("#camera-info").html(data.Image_Make + " " + data.Image_Model);
            } else {
                $("#camera-info").html('');
            }

        };

        if (tests.progress) {
            xhr.upload.onprogress = function (event) {
                if (event.lengthComputable) {
                    var complete = (event.loaded / event.total * 100 | 0);
                    progress.value = progress.innerHTML = complete;
                }
            }
        }

        xhr.send(formData);
    }
}

if (tests.dnd) {
    dropzone.ondragover = function () {
        this.className = 'hover';
        return false;
    };
    dropzone.ondragend = function () {
        this.className = '';
        return false;
    };
    dropzone.ondrop = function (e) {
        this.className = '';
        e.preventDefault();
        readfiles(e.dataTransfer.files);
    }
} else {
    fileupload.className = 'hidden';
    fileupload.querySelector('input').onchange = function () {
        readfiles(this.files);
    };
}

