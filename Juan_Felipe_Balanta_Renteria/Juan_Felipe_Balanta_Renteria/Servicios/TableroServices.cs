using Juan_Felipe_Balanta_Renteria.DataContext;
using Juan_Felipe_Balanta_Renteria.Entities;
using Microsoft.EntityFrameworkCore;

namespace Juan_Felipe_Balanta_Renteria.Servicios
{
    public class TableroServices : ITableroServices
    {
        private readonly TableroContext context;

        public TableroServices(TableroContext context)
        {
            this.context = context;
        }



        public async Task<List<TableroEntity>> GetAllTablero()
        {
            List<TableroEntity> tablero = await context.Tableros
                .OrderByDescending(p => p.TotalPeso)
                .ToListAsync();


            return tablero;
        }

        public async Task<TableroEntity> GetTablero(int id)
        {
            TableroEntity tablero =  context.Tableros.FirstOrDefault(x => x.Id == id);
            return tablero!;
        }

        public async Task CreateTablero(TableroEntity entity)
        {
            context.Tableros.Add(entity);
            await context.SaveChangesAsync();
        }


        public async Task UpdateTablero(TableroEntity entity)
        {
            context.Tableros.Update(entity);
            await context.SaveChangesAsync();
        }

        public async Task ELiminarTablero(int id)
        {
            TableroEntity tableroExiste = context.Tableros.FirstOrDefault(x => x.Id == id);

            context.Tableros.Remove(tableroExiste);
            await context.SaveChangesAsync();
        }
    }
}
