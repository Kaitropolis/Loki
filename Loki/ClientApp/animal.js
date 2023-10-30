function onInit() {
  const queryPart = window.location.href.split("?")[1]
  const animalId = queryPart.split("&")[0].split("=")[1]

  console.log(animalId)
}

onInit()
