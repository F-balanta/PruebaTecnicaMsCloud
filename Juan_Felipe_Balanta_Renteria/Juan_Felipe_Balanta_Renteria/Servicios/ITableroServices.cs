using Juan_Felipe_Balanta_Renteria.Entities;

namespace Juan_Felipe_Balanta_Renteria.Servicios
{
    public interface ITableroServices
    {
        Task<List<TableroEntity>> GetAllTablero();
        Task<TableroEntity> GetTablero(int id);
        Task CreateTablero(TableroEntity entity);
        Task UpdateTablero(TableroEntity entity);
        Task ELiminarTablero(int id);
    }
}
