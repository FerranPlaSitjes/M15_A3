using Model.ModelDTO.Client;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Model.ModelDTO.Habitacio
{
    public class RepositoryHabitacio
    {
        hotelEntities context;
        RepositoryClient rc;
        public RepositoryHabitacio(hotelEntities context)
        {
            this.context = context;
        }

        public habitacioDTO habitacioDTOFromRow(DataGridViewCellCollection row)
        {
            return new habitacioDTO((int)row["numero"].Value, (int)row["metresQuadrats"].Value, (bool)row["Terrassa"].Value, (bool)row["utilitzable"].Value,(string)row["titol"].Value, (string)row["caracteristiques"].Value, (int)row["codiTipus"].Value);
        }

        public void afegirHabitacio(int numero, int metresQuadrats, bool terrassa, bool utilitzable, string titol, string caracteristiques, int codiTipus)
        {
            try
            {
                habitacio h = new habitacio(numero, metresQuadrats, terrassa, utilitzable, titol, caracteristiques, codiTipus);
                context.habitacios.Add(h);
                context.SaveChanges();
            }
            catch (System.Data.Entity.Infrastructure.DbUpdateException e)
            {
                MessageBox.Show("Duplicate Entry !!!");
            }
            
        }

        public void modificarHabitacio(int numero, int metresQuadrats, bool terrassa, bool utilitzable, string titol, string caracteristiques, int codiTipus)
        {
            var result = context.habitacios.SingleOrDefault(h => h.numero == numero);
            if (result != null)
            {
                result.metresQuadrats = metresQuadrats;
                result.terrassa = terrassa;
                result.utilitzable = utilitzable;
                result.titol = titol;
                result.caracteristiques = caracteristiques;
                result.codiTipus = codiTipus;
                context.SaveChanges();
            }
        }

        public void eliminarHabitacio(int num)
        {
            var hab = context.habitacios.Single(h => h.numero == num);
            context.habitacios.Remove(hab);
            context.SaveChanges();
        }


        public List<habitacioDTO> mostrarHabitacio()
        {
            List<habitacioDTO> dades = context.habitacios.ToList().Select(c => new habitacioDTO(c)).ToList();
            return dades;
        }

        public List<habitacioDTO> FiltreHabitacio(int numero)
        {
            List<habitacioDTO> dades = context.habitacios.ToList().Where(x => x.numero == numero).Select(c => new habitacioDTO(c)).ToList();
            return dades;
        }
    }
}
