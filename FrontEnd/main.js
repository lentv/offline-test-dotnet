
document.getElementById('getBeers').addEventListener('click', getBeers);
function getBeers() {
  fetch('https://localhost:7289/api/Punk/beers', { headers: {
    "Content-type": "application/json; charset=UTF-8",
    "Access-Control-Allow-Origin": "*"

}})
  .then( res => res.json() )
  .then( data => {
    let output = '<h2 class="mb-4">Beers</h2>';
    data.forEach( beer => {
      output += `
        <div class="card card-body mb-3">
          <h3>${beer.name}</h3>
          <p>${beer.description}</p>
        </div>
      `;
    });
    document.getElementById('response').innerHTML = output;
  })
}