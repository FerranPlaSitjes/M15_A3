using Model.ModelDTO.Client;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Model.ModelDTO.Preu
{
    public class RepositoryPreu
    {
        hotelEntities context;
        RepositoryClient rc;

        public RepositoryPreu(hotelEntities context)
        {
            this.context = context;
        }

        public preuDTO preuDTOFromRow(DataGridViewCellCollection row)
        {
            return new preuDTO((string)row["temporada"].Value, (string)row["tipusPensio"].Value, (string)row["tipusHabitacio"].Value, (decimal)row["preu"].Value);
        }

        public List<preuDTO> llistar()
        {
            List<preuDTO> dades = context.preus.ToList().Select(p => new preuDTO(p)).ToList();
            return dades;
        }

        public void afegirPreu(int codiTem, string pensio, int codiTH, decimal preu)
        {
            try
            {
                preu p = new preu(codiTem, pensio, codiTH, preu);
                context.preus.Add(p);
                context.SaveChanges();
            } catch (DbUpdateException bdex)
            {
                MessageBox.Show("Entrada duplicada", "Atenció", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                context.SaveChanges();
            }
        }

        public void modificarPreu(int codiTem, string pensio, int codiTH, decimal preu)
        {
            var result = context.preus.SingleOrDefault(p => (p.codiTemporada == codiTem) && (p.tipusPensio == pensio) && (p.codiTipusHabitacio == codiTH));
            if (result != null)
            {
                result.codiTemporada = codiTem;
                result.tipusPensio = pensio;
                result.codiTipusHabitacio = codiTH;
                result.preu1 = preu;
                context.SaveChanges();
            }
        }

        public void eliminarPreu(int codiTem, string pensio, int codiTH)
        {
            var preu = context.preus.Single(p => (p.codiTemporada == codiTem) && (p.tipusPensio == pensio) && (p.codiTipusHabitacio == codiTH));
            context.preus.Remove(preu);
            context.SaveChanges();
        }
    }
}
