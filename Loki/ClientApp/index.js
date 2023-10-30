import { getAnimalsView } from "./api/animal-client.js"
import { importAnimals } from "./api/import-client.js"

async function renderTable() {
  const animalsView = await getAnimalsView()
  const tableContainer = document.getElementById("table-container")

  tableContainer.innerHTML = `<table class="table">
    <thead>
      <tr>
        <th scope="col">#</th>
        <th scope="col">Name</th>
        <th scope="col">Continents</th>
        <th scope="col">Habitat</th>
        <th scope="col">Food</th>
      </tr>
    </thead>
    <tbody>
      ${animalsView.animals
        .map(
          (animal, index) => `
                <tr id="animal-table">
                    <td scope="row">${index + 1}</td>
                    <td><a href="animal.html?id=${animal.id}">${
            animal.name
          }</a></td>
                    <td>${animal.continents}</td>
                    <td>${animal.habitat}</td>
                    <td>${animal.food}</td>
                </tr>`
        )
        .join("")}
    </tbody>
  </table>`
}

renderTable()

let importFile = null

document.getElementById("import-file").addEventListener("change", (event) => {
  importFile = event.target.files[0]
})

document
  .getElementById("import")
  .addEventListener("click", onImportAnimalsClick)

async function onImportAnimalsClick() {
  if (importFile) {
    importAnimals(importFile)
  }
}
