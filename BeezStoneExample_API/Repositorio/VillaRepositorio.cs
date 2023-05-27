using BeezStoneExample_API.Datos;
using BeezStoneExample_API.Modelos;
using BeezStoneExample_API.Repositorio.IRepositorio;

namespace BeezStoneExample_API.Repositorio
{
    public class VillaRepositorio : Repositorio<Villa>, IVillaRepositorio
    {

        private readonly ApplicationDBContext _db;

        public VillaRepositorio(ApplicationDBContext db) : base(db)
        {
            _db = db;
        }

        public async Task<Villa> Actualizar(Villa entidad)
        {
            entidad.FechaActualizacion = DateTime.Now;
            _db.Villas.Update(entidad);
            await _db.SaveChangesAsync();
            return entidad;
        }
    }
}
