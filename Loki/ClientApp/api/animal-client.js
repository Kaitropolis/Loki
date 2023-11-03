import { baseUrl } from "../config/server.js"

export async function getAnimalsView() {
  const response = await fetch(`${baseUrl}/animals`)
  return await response.json()
}

export async function getAnimalDetails(animalId) {
  const response = await fetch(`${baseUrl}/animals/${animalId}`)
  return await response.json()
}
