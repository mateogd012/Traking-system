using Microsoft.AspNetCore.Mvc;

namespace Traking_system.Controllers
{
    [ApiController]
    [Route("api/trips")]
    public class TripsController : ControllerBase
    {
        private readonly TripsData _tripsData;
        public TripsController(TripsData tripsData)
        {
            _tripsData = tripsData;
        }


        [HttpGet]
        public JsonResult GetTrips()
        {
            return new JsonResult(_tripsData);
        }
        [HttpGet("{id}")]
        public IActionResult GetTrip(int id) //Ahora devolvemos un IActionResult para que sea más genérico, ya que ahora podemos devolver CiudadDto o CiudadSinPuntosDeInteresDto
        {
            var trip = _tripsData.GetTrip(id);
            if (trip == null)
                return NotFound();
            return Ok(trip);
        }
        /*[HttpPost]
        public ActionResult<PuntoDeInteresDto> CrearPuntoDeInteres(int idCiudad, PuntoDeInteresParaCreacionDto puntoDeInteres)
        {
            if (!_repository.ExisteCiudad(idCiudad))
            {
                return NotFound();
            }

            var nuevoPuntoDeInteres = _mapper.Map<Entities.PuntoDeInteres>(puntoDeInteres);

            _repository.AgregarPuntoDeInteresACiudad(idCiudad, nuevoPuntoDeInteres);
            _repository.GuardarCambios();

            var puntoDeInteresParaDevolver = _mapper.Map<PuntoDeInteresDto>(nuevoPuntoDeInteres);

            return CreatedAtRoute(//CreatedAtRoute es para q devuelva 201, el 200 de post.
                "GetPuntoDeInteres", //El primer parámetro es el Name del endpoint que hace el Get
                new //El segundo los parametros q necesita ese endpoint
                {
                    idCiudad,
                    idPuntoDeInteres = puntoDeInteresParaDevolver.Id
                },
                puntoDeInteresParaDevolver);//El tercero es el objeto creado. 
        }

        [HttpPut("{idTrip}")]
        public ActionResult ActualizarPuntoDeInteres(int idCiudad, int idPuntoDeInteres, PuntoDeInteresParaUpdateDto puntoDeInteres)
        {
            if (!_repository.ExisteCiudad(idCiudad))
                return NotFound();

            var puntoDeInteresEnLaBase = _repository.GetPuntoDeInteresDeCiudad(idCiudad, idPuntoDeInteres);
            if (puntoDeInteresEnLaBase == null)
                return NotFound();

            _mapper.Map(puntoDeInteres, puntoDeInteresEnLaBase); // Ojo que este es distinto.

            _repository.GuardarCambios();

            return NoContent();
        }


        [HttpDelete("{idTrip}")]
        public ActionResult DeletePointOfInterest(int idCiudad, int idPuntoDeInteres)
        {
            if (!_repository.ExisteCiudad(idCiudad))
                return NotFound();

            var puntoDeInteresAEliminar = _repository.GetPuntoDeInteresDeCiudad(idCiudad, idPuntoDeInteres);
            if (puntoDeInteresAEliminar is null)
                return NotFound();

            _repository.EliminarPuntoDeInteres(puntoDeInteresAEliminar);
            _repository.GuardarCambios();

            return NoContent();
        }
    }*/
}
}
