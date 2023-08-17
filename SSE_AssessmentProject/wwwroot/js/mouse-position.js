document.addEventListener('mousemove', function (event) {
    const mouseX = event.clientX;
    const mouseY = event.clientY;
    document.getElementById('mouseX').innerText = mouseX;
    document.getElementById('mouseY').innerText = mouseY;
});