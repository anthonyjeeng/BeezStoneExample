using BeezStoneExample_API.Modelos;

namespace BeezStoneExample_API.Repositorio.IRepositorio
{
    public interface IVillaRepositorio : IRepositorio<Villa>
    {
        Task<Villa> Actualizar(Villa entidad);
    }
}
