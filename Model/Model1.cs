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
        hotelEntities context = new hotelEntities();
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
            rclient = new RepositoryClient();
            rempresa = new RepositoryEmpresa(context);
            rfactura = new RepositoryFactura(context);
            rhabitacio = new RepositoryHabitacio(context);
            rhoste = new RepositoryHoste(context);
            rlinia = new RepositoryLiniaFactura(context);
            rocupacio = new RepositoryOcupacio(context);
            rpersona = new RepositoryPersona(context);
            rpreu = new RepositoryPreu(context);
            rreserva = new RepositoryReserva();
            rservei = new RepositoryServei(context);
            rserveiocupa = new RepositoryServeiOcupacio(context);
            rtemporada = new RepositoryTemporada(context);
            rtipushab = new RepositoryTipusHabitacio(context);
        }
        
    }
}
