import { baseUrl } from "../config/server.js";

export async function GetAnimals() {
    const response = await fetch(`${baseUrl}/import`);
    return await response.json();
}