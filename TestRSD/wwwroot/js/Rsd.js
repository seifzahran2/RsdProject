const upload = document.querySelector('input[type="file"]');
const customUpload = document.querySelector('input[type="file"] + label');

customUpload.addEventListener('click', () => upload.click())

upload.addEventListener('change', () => customUpload.innerHTML = `${upload.files.item(0).name}<i class="fa-solid fa-paperclip"></i>`)
