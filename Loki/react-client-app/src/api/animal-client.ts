export default class AnimalClient {
  async getAnimalsView() {
    const res = await fetch("https://localhost:5000/api/animals");
    return await res.json();
  }
}
