import { baseUrl } from "../config/server.js";

export async function importAnimals(file) {
    const formData = new FormData()
    
    formData.append("file", file, file.name)

    await fetch(`${baseUrl}/import`, {
        method: "POST",
        body: formData
    });
}