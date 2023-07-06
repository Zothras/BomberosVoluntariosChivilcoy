let fotoMovil = document.querySelector('#fotoMovil');
fotoMovil.addEventListener('change',() => {
    document.querySelector('#path').innerText =
        fotoMovil.files[0].name;
});