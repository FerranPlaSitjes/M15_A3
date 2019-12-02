using Model.ModelDTO.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Model.ModelDTO.Hoste
{
    public class RepositoryHoste
    {
        hotelEntities context;
        RepositoryClient rc;
        public RepositoryHoste(hotelEntities context)
        {
            this.context = context;
        }

        public void afegirHoste(string dni, string nom, string cognom, string nacionalitat, string telefon, string cp, string poblacio)
        {
            hoste h = new hoste(dni, nom, cognom, nacionalitat, telefon, cp, poblacio);
            context.hostes.Add(h);
            context.SaveChanges();
        }

        public void modificarHoste(string dni, string nom, string cognom, string nacionalitat, string telefon, string cp, string poblacio)
        {
            var result = context.hostes.SingleOrDefault(h => h.dni == dni);
            if (result != null)
            {
                result.nom = nom;
                result.cognom = cognom;
                result.nacionalitat = nacionalitat;
                result.telefon = telefon;
                result.cp = cp;
                result.poblacio = poblacio;                
                context.SaveChanges();
            }
        }

        public hosteDTO hosteDTOFromRow(DataGridViewCellCollection row)
        {
            return new hosteDTO((string)row["dni"].Value, (string)row["nom"].Value, (string)row["cognom"].Value, (string)row["nacionalitat"].Value, (string)row["telefon"].Value, (string)row["cp"].Value, (string)row["poblacio"].Value);
        }

        public void eliminarHoste(string dni)
        {
            var hoste = context.hostes.Single(h => h.dni == dni);
            context.hostes.Remove(hoste);
            context.SaveChanges();
        }

        public List<hosteDTO> MostrarHoste()
        {
            List<hosteDTO> dades = context.hostes.ToList().Select(c => new hosteDTO(c)).ToList();
            return dades;
        }
    }
}
