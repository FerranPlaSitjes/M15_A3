using Model.ModelDTO.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Model.ModelDTO.Reserva
{
    public class RepositoryReserva
    {
        hotelEntities context;
        RepositoryClient rc;
       

        public RepositoryReserva(hotelEntities context)
        {
            this.context = context;
        }

        public reservaDTO clientDTOFromRow(DataGridViewCellCollection row)
        {
            return new reservaDTO((int)row["Id"].Value, (DateTime)row["dataInici"].Value, (DateTime)row["dataFinal"].Value, (decimal)row["preuTotal"].Value, (decimal)row["bestreta"].Value, (string)row["pensioFk"].Value, (int)row["idClientFk"].Value);
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

        public List<reservaDTO> mostrarReserva()
        {
            List<reservaDTO> dades = context.reservas.ToList().Select(c => new reservaDTO(c)).ToList();
            return dades;
        }

    }
}
