using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.ModelDTO.Reserva
{
    public class RepositoryReserva
    {
        hotelEntities context;
        public RepositoryReserva()
        {
            context = new hotelEntities();
        }

        public void afegirReserva(DateTime dataInici, DateTime dataFinal, decimal preuTotal, decimal bestreta, string pensioFk, int idClientFk)
        {
            reserva r = new reserva(dataInici, dataFinal, preuTotal, bestreta, pensioFk, idClientFk);
            context.reservas.Add(r);
            context.SaveChanges();
        }

        public void modificarReserva(int id, DateTime dataInici, DateTime dataFinal, decimal preuTotal, decimal bestreta, string pensioFk, int idClientFk)
        {
            var result = context.reservas.SingleOrDefault(r => r.id == id);
            if (result != null)
            {
                result.dataInici = dataInici;
                result.dataFinal = dataFinal;
                result.preuTotal = preuTotal;
                result.bestreta = bestreta;
                result.pensioFk = pensioFk;
                result.idClientFk = idClientFk;
                context.SaveChanges();
            }
        }

        public void eliminarReserva(int id)
        {
            var reserva = context.reservas.Single(r => r.id == id);
            context.reservas.Remove(reserva);
            context.SaveChanges();
        }
    }
}
