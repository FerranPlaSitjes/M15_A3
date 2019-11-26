using Model.ModelDTO.Client;
using Model.ModelDTO.Empresa;
using Model.ModelDTO.Factura;
using Model.ModelDTO.Habitacio;
using Model.ModelDTO.Hoste;
using Model.ModelDTO.LineaFactura;
using Model.ModelDTO.Ocupacio;
using Model.ModelDTO.Pensio;
using Model.ModelDTO.Persona;
using Model.ModelDTO.Preu;
using Model.ModelDTO.Reserva;
using Model.ModelDTO.Servei;
using Model.ModelDTO.ServeiOcupacio;
using Model.ModelDTO.Temporada;
using Model.ModelDTO.TipusHabitacio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Model1
    {
        hotelEntities context;
        RepositoryClient rclient;
        RepositoryEmpresa rempresa;
        RepositoryFactura rfactura;
        RepositoryHabitacio rhabitacio;
        RepositoryHoste rhoste;
        RepositoryLiniaFactura rlinia;
        RepositoryOcupacio rocupacio;
        RepositoryPersona rpersona;
        RepositoryPreu rpreu;
        RepositoryReserva rreserva;
        RepositoryServei rservei;
        RepositoryServeiOcupacio rserveiocupa;
        RepositoryTemporada rtemporada;
        RepositoryTipusHabitacio rtipushab;

        public Model1()
        {
            context = new hotelEntities();
            rclient = new RepositoryClient();
            rempresa = new RepositoryEmpresa();
            rfactura = new RepositoryFactura();
            rhabitacio = new RepositoryHabitacio();
            rhoste = new RepositoryHoste();
            rlinia = new RepositoryLiniaFactura();
            rocupacio = new RepositoryOcupacio();
            rpersona = new RepositoryPersona();
            rpreu = new RepositoryPreu();
            rreserva = new RepositoryReserva();
            rservei = new RepositoryServei();
            rserveiocupa = new RepositoryServeiOcupacio();
            rtemporada = new RepositoryTemporada();
            rtipushab = new RepositoryTipusHabitacio();
        }
        
    }
}
