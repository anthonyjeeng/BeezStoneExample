using BeezStoneExample_API.Datos;
using BeezStoneExample_API.Modelos;
using BeezStoneExample_API.Repositorio.IRepositorio;

namespace BeezStoneExample_API.Repositorio
{
    public class NumeroVillaRepositorio : Repositorio<NumeroVilla>, INumeroVillaRepositorio
    {

        private readonly ApplicationDBContext _db;

        public NumeroVillaRepositorio(ApplicationDBContext db) : base(db)
        {
            _db = db;
        }

        public async Task<NumeroVilla> Actualizar(NumeroVilla entidad)
        {
            entidad.FechaActualizacion = DateTime.Now;
            _db.NumeroVillas.Update(entidad);
            await _db.SaveChangesAsync();
            return entidad;
        }
    }
}
