import { getAnimalDetails } from "./api/animal-client.js"

async function onInit() {
  const queryPart = window.location.href.split("?")[1]
  const animalId = queryPart.split("&")[0].split("=")[1]
  const animalDetails = await getAnimalDetails(animalId)
  displayAnimalDetails(animalDetails)
}

onInit()

function displayAnimalDetails(animalDetails) {
  document.getElementById("details-container").innerHTML = `
  <nav class="navbar navbar-dark">
    <h1 id="animal-name">${animalDetails.name}</h1>
        <a href="index.html">
      <button type="button" id="back-btn" class="btn btn-primary">
        Back to main
      </button></a>
    </nav>
    <h3 id="animal-continents">continents: ${animalDetails.continents}</h3>
    <h3 id="animal-habitat">habitat: ${animalDetails.habitat}</h3>
    <h3 id="animal-food">food: ${animalDetails.food}</h3>
    
    <h2>health: </h2>
        <div class="progress">
      <div
        class="progress-bar progress-bar-striped bg-success"
        role="progressbar"
        style="width: ${animalDetails.health}%"
        aria-valuenow="10"
        aria-valuemin="0"
        aria-valuemax="100"
      ></div>
    </div>
    <h2>stamina: </h2>
    <div class="progress">
      <div
        class="progress-bar progress-bar-striped"
        role="progressbar"
        style="width: ${animalDetails.stamina}%"
        aria-valuenow="25"
        aria-valuemin="0"
        aria-valuemax="100"
      ></div>
    </div>
    <h2>intelligence: </h2>
    <div class="progress">
      <div
        class="progress-bar progress-bar-striped bg-info"
        role="progressbar"
        style="width: ${animalDetails.intelligence}%"
        aria-valuenow="50"
        aria-valuemin="0"
        aria-valuemax="100"
      ></div>
    </div>
    <h2>speed: </h2>
    <div class="progress">
      <div
        class="progress-bar progress-bar-striped bg-warning"
        role="progressbar"
        style="width: ${animalDetails.speed}%"
        aria-valuenow="75"
        aria-valuemin="0"
        aria-valuemax="100"
      ></div>
    </div>
    <h2>attack: </h2>
    <div class="progress">
      <div
        class="progress-bar progress-bar-striped bg-danger"
        role="progressbar"
        style="width: ${animalDetails.attack}%"
        aria-valuenow="100"
        aria-valuemin="0"
        aria-valuemax="100"
      ></div>
    </div>
        <h2>defence: </h2>
    <div class="progress">
      <div
        class="progress-bar progress-bar-striped bg-secondary"
        role="progressbar"
        style="width: ${animalDetails.defence}%"
        aria-valuenow="100"
        aria-valuemin="0"
        aria-valuemax="100"
      ></div>
    </div>
    `
}
