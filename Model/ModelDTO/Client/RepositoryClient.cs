using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Model.ModelDTO.Client
{
    public class RepositoryClient
    {
        public hotelEntities context;

        public RepositoryClient()
        {
            this.context = new hotelEntities();
        }

        public List<clientDTO> llistar()
        {
            List<clientDTO> dades = context.clients.ToList().Select(c => new clientDTO(c)).ToList();            
            return dades;
        }

        public void afegirClient(string nom, string tipus)
        {
            client c = new client(nom, tipus);
            context.clients.Add(c);
            context.SaveChanges();
        }

        public void modificarClient(int id, string nom, string tipus)
        {
            var result = context.clients.SingleOrDefault(c => c.id == id);
            if (result != null)
            {
                result.nom = nom;
                result.tipus = tipus;
                context.SaveChanges();
            }
        }

        public void eliminarClient(int id)
        {
            var client = context.clients.Single(c => c.id == id);
            context.clients.Remove(client);
            context.SaveChanges();
        }

        public clientDTO clientDTOFromRow(DataGridViewCellCollection row)
        {
            return new clientDTO((int)row["Id"].Value, (string)row["Nom"].Value, (string)row["Tipus"].Value);
        }

        public client returnClient(string nomClient)
        {
            var result = context.clients.Where(a => a.nom == nomClient).Single();

            return result;
        }

        public client returnClientId(int? id)
        {
            var result = context.clients.Where(a => a.id == id).Single();

            return result;
        }
    }
}
