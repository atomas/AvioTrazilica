using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static AvioTrazilica.FlightInformation;

namespace AvioTrazilica
{
    public partial class FormAvioTrazilica : Form
    {
        public static string apiKey = "XI2yGGdGN4w6NF2nXU5QM2duvy1k6rf3";
        public static string urlLetovi = "http://api.sandbox.amadeus.com/v1.2/flights/low-fare-search?";
        public static string urlAerodromi = "http://api.sandbox.amadeus.com/v1.2/airports/autocomplete?";

        public FormAvioTrazilica()
        {
            InitializeComponent();
        }

        private void buttonPretrazi_Click(object sender, EventArgs e)
        {
            /*
            //dohvati zadane parametre pretaživanja
            string polaziste = txtBoxPolazniAerodrom.Text;
            string odrediste = txtBoxOdredisniAerodrom.Text;
            string brPutnika = txtBoxBrojPutnika.Text;
            string valuta = txtBoxValuta.Text;

            //stvaranje GET zahtjeva
            string noviZahtjev = urlLetovi + 
                "origin=" + polaziste +
                "&destination=" + odrediste +
                "&departure_date=" + "2017-10-15" +
                "&return_date=" + "2017-10-21" +
                "&number_of_results=" + "2" +
                "&apikey=" + apiKey +
                "&adults=" + brPutnika +
                "&currency=" + valuta;

            //pretraži letove prema zadanim parametrima
            MessageBox.Show(dobaviLetove(noviZahtjev));
            */
            string noviZahtjev = @"http://api.sandbox.amadeus.com/v1.2/flights/low-fare-search?origin=TXL&destination=AMS&departure_date=2017-10-15&return_date=2017-10-21&number_of_results=1&apikey=XI2yGGdGN4w6NF2nXU5QM2duvy1k6rf3&adults=2&currency=HRK";
            //pokušaj nekakvog parsiranja
            parsiranjeRezultata(noviZahtjev);

            //MessageBox.Show(getJson("Zagr"));
        }

        public string getJson(string lokacija)
        {
            string url1 = urlAerodromi + "apikey=" + apiKey + "&term= " + lokacija;

            var json = new WebClient().DownloadString(url1);
            
            return json;
        }

        public string dobaviLetove(string Zahtjev)
        {
            var json = new WebClient().DownloadString(Zahtjev);
            return json;
        }

        public void parsiranjeRezultata(string Zahtjev)
        {
            var json = new WebClient().DownloadString(Zahtjev);
            RootObject r = new RootObject();
            r = JsonConvert.DeserializeObject<RootObject>(json);

            //geting the result
            string polaziste = r.results[0].itineraries[0].outbound.flights[0].origin.airport.ToString();
            string odrediste = r.results[0].itineraries[0].outbound.flights[0].destination.airport.ToString();
            string polazak = r.results[0].itineraries[0].outbound.flights[0].departs_at.ToString();
            string povratak = r.results[0].itineraries[0].outbound.flights[0].arrives_at.ToString();
            int brPresjedanjaOdlazni = r.results[0].itineraries[0].outbound.flights.Count();
            int brPresjedanjaPovratni = r.results[0].itineraries[0].inbound.flights.Count();
            string brojPutnika = r.results[0].itineraries[0].outbound.flights[0].booking_info.seats_remaining.ToString(); ;
            string valuta = r.currency.ToString();
            string cijena = r.results[0].fare.total_price.ToString();

            //adding the results to the data grid view
            DataGridViewRow row = new DataGridViewRow();
            row.CreateCells(dataGridView1);
            row.Cells[0].Value = polaziste;
            row.Cells[1].Value = odrediste;
            row.Cells[2].Value = polazak + " / "+ povratak;
            row.Cells[3].Value = brPresjedanjaOdlazni.ToString() + " / " + brPresjedanjaPovratni.ToString();
            row.Cells[4].Value = brojPutnika;
            row.Cells[5].Value = valuta;
            row.Cells[6].Value = cijena;
            dataGridView1.Rows.Add(row);
        }
    }
}
