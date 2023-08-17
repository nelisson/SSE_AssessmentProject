function loadItems() {
fetch('/api/items')
    .then(response => response.json())
    .then(data => {
        let output = '<ul>';
        data.forEach(item => {
            output += `<li>${item.name}</li>`;
        });
        output += '</ul>';
        document.getElementById('itemList').innerHTML = output;
    })
    .catch(error => console.error('Error:', error));
}