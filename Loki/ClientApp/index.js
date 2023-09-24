import { GetAnimals } from "./api/animal-client.js"

async function displayTable() {
    const animals = await GetAnimals();
    console.log(animals)
}

displayTable()