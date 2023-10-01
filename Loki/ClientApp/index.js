import { GetAnimals } from "./api/animal-client.js"

async function displayTable() {
    const animals = await GetAnimals();
    console.log(animals)

    const tableContainer = document.getElementById("table-container")
    tableContainer.innerHTML = `<table class="table">
    <thead>
      <tr>
        <th scope="col">#</th>
        <th scope="col">Animal</th>
        <th scope="col">Continent</th>
        <th scope="col">Habitat</th>
        <th scope="col">Food</th>
      </tr>
    </thead>
    <tbody>
    ${animals.map((animal, index) => {
        return `<tr>
            <td scope="row">${index + 1}</td>
            <td>${animal.name}</td>
            <td>${animal.continents}</td>
            <td>${animal.habitat}</td>
            <td>${animal.food}</td>
        </tr>`
    })}
    </tbody>
  </table>      `
}

displayTable()