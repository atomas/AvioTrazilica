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
using static AvioTrazilica.AerodromInfo;

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
                "&number_of_results=" + "20" +
                "&apikey=" + apiKey +
                "&adults=" + brPutnika +
                "&currency=" + valuta;
            
            parsiranjeRezultata(noviZahtjev);
        }

        public string nazivAerodroma(string kratica)
        {
            string url1 = urlAerodromi + "apikey=" + apiKey + "&term=" + kratica;
            var json1 = new WebClient().DownloadString(url1);
            Aerodrom a = new Aerodrom();
            //a = JsonConvert.DeserializeObject<Aerodrom>(json1);
            var aer = JsonConvert.DeserializeObject<List<Aerodrom>>(json1);

            a = aer[0];

            string naziv = "";
            if (a.label.ToString().Split('[')[1] == kratica + "]")
            {
                naziv = a.label.ToString().Split('[')[0];
            }
            else
            {
                naziv = kratica;
            }

            return naziv;
        }

        public void parsiranjeRezultata(string Zahtjev)
        {
            var json = new WebClient().DownloadString(Zahtjev);
            RootObject r = new RootObject();
            r = JsonConvert.DeserializeObject<RootObject>(json);
            
            string polaziste, odrediste, polazak, datumPolaska, povratak, datumPovratka, brojPutnika, valuta, cijena;
            int brPresjedanjaOdlazni, brPresjedanjaPovratni;

            for (int i = 0; i < r.results.Count(); i++)
            {
                //spremanje rezultata json-a
                polaziste = r.results[i].itineraries[0].outbound.flights[0].origin.airport.ToString();
                polazak = r.results[i].itineraries[0].outbound.flights[0].departs_at.ToString();
                datumPolaska = polazak.Split('T')[0];  //odvoji samo datum traže
                if (r.results[i].itineraries[0].outbound.flights.Count() > 1) //odredišni aerodrom samo uzimamo
                {
                    int zadnjiLet = r.results[i].itineraries[0].outbound.flights.Count();
                    odrediste = r.results[i].itineraries[0].outbound.flights[zadnjiLet-1].destination.airport.ToString();
                    povratak = r.results[i].itineraries[0].outbound.flights[zadnjiLet - 1].arrives_at.ToString();
                    datumPovratka = povratak.Split('T')[0];
                }
                else
                {
                    odrediste = r.results[i].itineraries[0].outbound.flights[0].destination.airport.ToString();
                    povratak = r.results[i].itineraries[0].outbound.flights[0].arrives_at.ToString();
                    datumPovratka = povratak.Split('T')[0];
                }
                brPresjedanjaOdlazni = r.results[i].itineraries[0].outbound.flights.Count();
                brPresjedanjaPovratni = r.results[i].itineraries[0].inbound.flights.Count();
                brojPutnika = r.results[i].itineraries[0].outbound.flights[0].booking_info.seats_remaining.ToString(); ;
                valuta = r.currency.ToString();
                cijena = r.results[i].fare.total_price.ToString();

                //dodavanje rezultata pretraživanja u datagrid
                DataGridViewRow red = new DataGridViewRow();
                red.CreateCells(dataGridView1);
                red.Cells[0].Value = nazivAerodroma(polaziste);
                red.Cells[1].Value = nazivAerodroma(odrediste);
                red.Cells[2].Value = datumPolaska + " / " + datumPovratka;
                red.Cells[3].Value = brPresjedanjaOdlazni.ToString() + " / " + brPresjedanjaPovratni.ToString();
                red.Cells[4].Value = brojPutnika;
                red.Cells[5].Value = valuta;
                red.Cells[6].Value = cijena;
                dataGridView1.Rows.Add(red);
            }
        }

        private void buttonPotragaKratice_Click(object sender, EventArgs e)
        {
            string trazi = txtBoxKratica.Text;

            string url1 = urlAerodromi + "apikey=" + apiKey + "&term=" + trazi;
            var json1 = new WebClient().DownloadString(url1);
            Aerodrom a = new Aerodrom();
            var aer = JsonConvert.DeserializeObject<List<Aerodrom>>(json1);

            for (int i = 0; i < aer.Count(); i++)
            {
                DataGridViewRow red = new DataGridViewRow();
                red.CreateCells(dataGridView2);
                red.Cells[0].Value = aer[i].value.ToString();
                red.Cells[1].Value = aer[i].label.ToString();
                dataGridView2.Rows.Add(red);
            }
        }
    }
}
