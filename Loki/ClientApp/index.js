const baseUrl = "https://localhost:7016"

async function displayTable() {
    const response = await fetch(`${baseUrl}/import`);
    const data = await response.json();
    console.log(data);
}

displayTable()