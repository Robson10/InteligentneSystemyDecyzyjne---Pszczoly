using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sklep
{
    class TFM : List<dItem>
    {
        static List<dItem> d = new List<dItem>();
        public static List<string> t = new List<string>()
        {
            "Pierścień Do Powałki",
            "Sitko Pająk Do Powałki",
            "Przegonka 8-wylotowa",
            "Etykiety Na Miód Gryczany E217 – 100 Szt",
            "Podkarmiaczka Powałkowa 4l",
            "Pokarm Ciasto Fondant 15kg Diamant",
            "Podkurzacz Typu Dadant Nierdzewny Duży",
            "Książka „Łatwe Pszczelarstwo” (dr Gerhard Liebig)",
            "Rękawice Pszczelarskie Z Owczej Skóry Długie XL",
            "Miotełka Pasieczna Dwurzędowa Z Końskiego Włosia",
            "Fajka do łapania matek pszczelich",
            "Bluza Pszczelarska Z Kapeluszem Rozpinana XL",
            "Kapelusz Pszczelarski BIAŁY",
            "Wiaderko Odstojnik Na Miód Z Zaworem 33l Biały",
            "Drut Do Ramek – Stal Nierdzewna – 0,25 Kg",
            "Uchwyt Do Ramek Nierdzewny",
            "Dwufunkcyjny Nóż Pasieczny Z Dłutem",
            "Ramka Wielkopolska Hoffmanowska – 10 Szt",
            "Uniwersalny Skrobak Pasieczny",
            "Nakrętki Na Słoik Z Miodem ND47 – 10 Szt",
            "Ulik Odkładowy Wielkopolski",
           
            "Godzina",
            "Wiek",
            "Płeć",
            "Miasto",
            "Województwo",
            "Name"
        };

        public void Wypelnij()
        {
            List<dItem> temp = new List<dItem>();
            temp.Add(new dItem(10, 40, true, "Koszalin", "ZP", "User" + (temp.Count + 1)){ PierscienDoPowalki = true, SitkoPajakDoPowalki= true, PodkarmiaczkaPowalkowa= true });
            temp.Add(new dItem(11, 50, false, "Koszalin", "ZP", "User" + (temp.Count + 1)) { EtykietaNaMiodGryczany= true, NakretkiNaSloikZMiodem= true });
            temp.Add(new dItem(13, 60, false, "Koszalin", "ZP", "User" + (temp.Count + 1)) { PierscienDoPowalki = true, SitkoPajakDoPowalki = true, PodkarmiaczkaPowalkowa = true, PokarmCiastoFondant=true});
            temp.Add(new dItem(16, 40, true, "Koszalin", "ZP", "User" + (temp.Count + 1)) { PodkurzaczDadant = true, MiotelkaPasieczna= true });
            temp.Add(new dItem(15, 50, true, "Koszalin", "ZP", "User" + (temp.Count + 1)) { PodkurzaczDadant = true, MiotelkaPasieczna = true, RekawicePszczelarskie=true });

            temp.Add(new dItem(17, 60, true, "Białogard", "ZP", "User" + (temp.Count + 1)) { PodkurzaczDadant = true, MiotelkaPasieczna = true, RekawicePszczelarskie = true,BluzaPszczelarskaZKapeluszem=true, });
            temp.Add(new dItem(14, 30, true, "Białogard", "ZP", "User" + (temp.Count + 1)) { PodkurzaczDadant = true, MiotelkaPasieczna = true, RekawicePszczelarskie = true,KapeluszPszczelarski=true });
            temp.Add(new dItem(15, 40, false, "Białogard", "ZP", "User" + (temp.Count + 1)) { RamkaWielkopolska=true, DrutDoRamek=true,UchwytDoRamek=true});
            temp.Add(new dItem(12, 50, true, "Białogard", "ZP", "User" + (temp.Count + 1)) { RamkaWielkopolska = true, DrutDoRamek = true, UchwytDoRamek = true,UniwersalnySkrobakPasieczny=true });
            temp.Add(new dItem(16, 20, true, "Białogard", "ZP", "User" + (temp.Count + 1)) { RamkaWielkopolska = true, DrutDoRamek = true, UchwytDoRamek = true });

            temp.Add(new dItem(13, 40, true, "Karlino", "ZP", "User" + (temp.Count + 1)) { PodkurzaczDadant = true, MiotelkaPasieczna = true, RekawicePszczelarskie = true, BluzaPszczelarskaZKapeluszem = true,WiaderkoOdstojnikNaMiod=true });
            temp.Add(new dItem(12, 50, false, "Karlino", "ZP", "User" + (temp.Count + 1)) { PodkurzaczDadant = true, MiotelkaPasieczna = true, RekawicePszczelarskie = true, BluzaPszczelarskaZKapeluszem = true,WiaderkoOdstojnikNaMiod=true,UniwersalnySkrobakPasieczny=true });
            temp.Add(new dItem(13, 60, true, "Karlino", "ZP", "User" + (temp.Count + 1)) {  MiotelkaPasieczna = true, RekawicePszczelarskie = true, BluzaPszczelarskaZKapeluszem = true, WiaderkoOdstojnikNaMiod = true, UniwersalnySkrobakPasieczny = true });
            temp.Add(new dItem(15, 30, true, "Karlino", "ZP", "User" + (temp.Count + 1)) { PodkurzaczDadant = true, MiotelkaPasieczna = true, WiaderkoOdstojnikNaMiod = true, UniwersalnySkrobakPasieczny = true });
            temp.Add(new dItem(18, 30, false, "Karlino", "ZP", "User" + (temp.Count + 1)) { MiotelkaPasieczna = true, UniwersalnySkrobakPasieczny = true });

            temp.Add(new dItem(17, 40, true, "Gorzów", "Lubuskie", "User" + (temp.Count + 1)) { UlikOdkladowyWielkopolski=true, RamkaWielkopolska=true, DrutDoRamek=true });
            temp.Add(new dItem(18, 50, true, "Gorzów", "Lubuskie", "User" + (temp.Count + 1)) { UlikOdkladowyWielkopolski = true, RamkaWielkopolska = true, DrutDoRamek = true ,BluzaPszczelarskaZKapeluszem=true, DwufunkcyjnyNozPasiecznyZDlutem=true});
            temp.Add(new dItem(19, 50, false, "Gorzów", "Lubuskie", "User" + (temp.Count + 1)) { UlikOdkladowyWielkopolski = true, RamkaWielkopolska = true, DrutDoRamek = true, FajkaDoLapaniaMatekPszczelich=true });
            temp.Add(new dItem(20, 30, false, "Gorzów", "Lubuskie", "User" + (temp.Count + 1)) { UlikOdkladowyWielkopolski = true, RamkaWielkopolska = true, DrutDoRamek = true,FajkaDoLapaniaMatekPszczelich=true, KsiazkaLatwePszczelarstwo=true,PodkurzaczDadant=true});
            temp.Add(new dItem(21, 30, true, "Gorzów", "Lubuskie", "User" + (temp.Count + 1)) { UlikOdkladowyWielkopolski = true, RamkaWielkopolska = true,   KsiazkaLatwePszczelarstwo = true, PodkurzaczDadant = true });

            temp.Add(new dItem(16, 50, true, "Zielona Góra", "Lubuskie", "User" + (temp.Count + 1)) { RamkaWielkopolska=true,UchwytDoRamek=true,DwufunkcyjnyNozPasiecznyZDlutem=true });
            temp.Add(new dItem(15, 40, true, "Zielona Góra", "Lubuskie", "User" + (temp.Count + 1)) { UniwersalnySkrobakPasieczny = true, NakretkiNaSloikZMiodem = true, EtykietaNaMiodGryczany = true});
            temp.Add(new dItem(14, 40, false, "Zielona Góra", "Lubuskie", "User" + (temp.Count + 1)) { PodkarmiaczkaPowalkowa = true, PokarmCiastoFondant=true});
            temp.Add(new dItem(13, 40, false, "Zielona Góra", "Lubuskie", "User" + (temp.Count + 1)) { PodkurzaczDadant = true, MiotelkaPasieczna = true, RekawicePszczelarskie = true, BluzaPszczelarskaZKapeluszem = true, WiaderkoOdstojnikNaMiod = true });
            temp.Add(new dItem(15, 50, true, "Zielona Góra", "Lubuskie", "User" + (temp.Count + 1)) { UlikOdkladowyWielkopolski = true, RamkaWielkopolska = true, DrutDoRamek = true, BluzaPszczelarskaZKapeluszem = true, DwufunkcyjnyNozPasiecznyZDlutem = true });

            temp.Add(new dItem(16, 20, true, "Poznań", "Wielkopolskie", "User" + (temp.Count + 1)) { EtykietaNaMiodGryczany = true, NakretkiNaSloikZMiodem = true });
            temp.Add(new dItem(17, 20, false, "Poznań", "Wielkopolskie", "User" + (temp.Count + 1)) { PodkurzaczDadant = true, MiotelkaPasieczna = true, RekawicePszczelarskie = true, KapeluszPszczelarski = true });
            temp.Add(new dItem(18, 30, true, "Poznań", "Wielkopolskie", "User" + (temp.Count + 1)) { PodkurzaczDadant = true, MiotelkaPasieczna = true, RekawicePszczelarskie = true, BluzaPszczelarskaZKapeluszem = true, WiaderkoOdstojnikNaMiod = true, UniwersalnySkrobakPasieczny = true });
            temp.Add(new dItem(19, 30, true, "Poznań", "Wielkopolskie", "User" + (temp.Count + 1)) { UlikOdkladowyWielkopolski = true, RamkaWielkopolska = true, DrutDoRamek = true, BluzaPszczelarskaZKapeluszem = true, DwufunkcyjnyNozPasiecznyZDlutem = true });
            temp.Add(new dItem(18, 50, false, "Poznań", "Wielkopolskie", "User" + (temp.Count + 1)) { UniwersalnySkrobakPasieczny = true, NakretkiNaSloikZMiodem = true, EtykietaNaMiodGryczany = true });

            temp.Add(new dItem(16, 50, false, "Gdańsk", "Pomorskie", "User" + (temp.Count + 1)) { PodkurzaczDadant = true, MiotelkaPasieczna = true, RekawicePszczelarskie = true });
            temp.Add(new dItem(15, 20, true, "Gdańsk", "Pomorskie", "User" + (temp.Count + 1)) { RamkaWielkopolska = true, DrutDoRamek = true, UchwytDoRamek = true });
            temp.Add(new dItem(14, 20, true, "Gdańsk", "Pomorskie", "User" + (temp.Count + 1)) { MiotelkaPasieczna = true, UniwersalnySkrobakPasieczny = true });
            temp.Add(new dItem(18, 50, true, "Gdańsk", "Pomorskie", "User" + (temp.Count + 1)) { UlikOdkladowyWielkopolski = true, RamkaWielkopolska = true, KsiazkaLatwePszczelarstwo = true, PodkurzaczDadant = true });
            temp.Add(new dItem(19, 30, false, "Gdańsk", "Pomorskie", "User" + (temp.Count + 1)) { UlikOdkladowyWielkopolski = true, RamkaWielkopolska = true, DrutDoRamek = true, BluzaPszczelarskaZKapeluszem = true, DwufunkcyjnyNozPasiecznyZDlutem = true });

            temp.Add(new dItem(18, 50, true, "Warszawa", "Mazowieckie", "User" + (temp.Count + 1)) { PodkurzaczDadant = true, MiotelkaPasieczna = true, RekawicePszczelarskie = true, BluzaPszczelarskaZKapeluszem = true, WiaderkoOdstojnikNaMiod = true });
            temp.Add(new dItem(18, 50, false, "Warszawa", "Mazowieckie", "User" + (temp.Count + 1)) { UlikOdkladowyWielkopolski = true, RamkaWielkopolska = true, DrutDoRamek = true, FajkaDoLapaniaMatekPszczelich = true, KsiazkaLatwePszczelarstwo = true, PodkurzaczDadant = true });
            temp.Add(new dItem(17, 10, false, "Warszawa", "Mazowieckie", "User" + (temp.Count + 1)) { PodkurzaczDadant = true, MiotelkaPasieczna = true, WiaderkoOdstojnikNaMiod = true, UniwersalnySkrobakPasieczny = true });
            temp.Add(new dItem(19, 20, false, "Warszawa", "Mazowieckie", "User" + (temp.Count + 1)) { RamkaWielkopolska = true, DrutDoRamek = true, UchwytDoRamek = true, UniwersalnySkrobakPasieczny = true });
            temp.Add(new dItem(16, 20, true, "Warszawa", "Mazowieckie", "User" + (temp.Count + 1)) { PodkurzaczDadant = true, MiotelkaPasieczna = true });

            temp.Add(new dItem(16, 20, true, "Lublin", "Lubelskie", "User" + (temp.Count + 1)) { PierscienDoPowalki = true, SitkoPajakDoPowalki = true, PodkarmiaczkaPowalkowa = true, PokarmCiastoFondant = true });
            temp.Add(new dItem(17, 20, false, "Lublin", "Lubelskie", "User" + (temp.Count + 1)) { RamkaWielkopolska = true, DrutDoRamek = true, UchwytDoRamek = true });
            temp.Add(new dItem(17, 20, false, "Lublin", "Lubelskie", "User" + (temp.Count + 1)) { MiotelkaPasieczna = true, RekawicePszczelarskie = true, BluzaPszczelarskaZKapeluszem = true, WiaderkoOdstojnikNaMiod = true, UniwersalnySkrobakPasieczny = true });
            temp.Add(new dItem(18, 30, true, "Lublin", "Lubelskie", "User" + (temp.Count + 1)) { UlikOdkladowyWielkopolski = true, RamkaWielkopolska = true, DrutDoRamek = true, FajkaDoLapaniaMatekPszczelich = true });
            temp.Add(new dItem(19, 30, false, "Lublin", "Lubelskie", "User" + (temp.Count + 1)) { PodkarmiaczkaPowalkowa = true, PokarmCiastoFondant = true });

            temp.Add(new dItem(17, 20, false, "Kielce", "Świętokrzyskie", "User" + (temp.Count + 1)) { PierscienDoPowalki = true, SitkoPajakDoPowalki = true, PodkarmiaczkaPowalkowa = true });
            temp.Add(new dItem(16, 20, false, "Kielce", "Świętokrzyskie", "User" + (temp.Count + 1)) { PodkurzaczDadant = true, MiotelkaPasieczna = true, RekawicePszczelarskie = true, KapeluszPszczelarski = true });
            temp.Add(new dItem(16, 30, true, "Kielce", "Świętokrzyskie", "User" + (temp.Count + 1)) { MiotelkaPasieczna = true, RekawicePszczelarskie = true, BluzaPszczelarskaZKapeluszem = true, WiaderkoOdstojnikNaMiod = true, UniwersalnySkrobakPasieczny = true });
            temp.Add(new dItem(15, 30, true, "Kielce", "Świętokrzyskie", "User" + (temp.Count + 1)) { PodkurzaczDadant = true, MiotelkaPasieczna = true, WiaderkoOdstojnikNaMiod = true, UniwersalnySkrobakPasieczny = true });
            temp.Add(new dItem(18, 20, false, "Kielce", "Świętokrzyskie", "User" + (temp.Count + 1)) { UlikOdkladowyWielkopolski = true, RamkaWielkopolska = true, KsiazkaLatwePszczelarstwo = true, PodkurzaczDadant = true });
            this.AddRange(temp);
        }
    }
    class dItem
    {
        public dItem(int godzina, int wiek, bool mezczyzna, string miasto, string wojewodztwo, string name)
        {
            Godzina = godzina;
            Wiek = wiek;
            Plec = mezczyzna;
            Miasto = miasto;
            Wojewodztwo = wojewodztwo;
            Name = name;
        }


        private bool pierscienDoPowalki = false;//0
        private bool sitkoPajakDoPowalki = false;//1
        private bool przegonkaOsmioWylotowa = false;//2
        private bool etykietaNaMiodGryczany = false;//3
        private bool podkarmiaczkaPowalkowa = false;//4
        private bool pokarmCiastoFondant = false;//5
        private bool podkurzaczDadant = false;//6
        private bool ksiazkaLatwePszczelarstwo = false;//7
        private bool rekawicePszczelarskie = false;//8
        private bool miotelkaPasieczna = false;//9
        private bool fajkaDoLapaniaMatekPszczelich = false;//10
        private bool bluzaPszczelarskaZKapeluszem = false;//11
        private bool kapeluszPszczelarski = false;//12
        private bool wiaderkoOdstojnikNaMiod = false;//13---
        private bool drutDoRamek = false;//14
        private bool uchwytDoRamek = false;//15
        private bool dwufunkcyjnyNozPasiecznyZDlutem = false;//16
        private bool ramkaWielkopolska = false;//17
        private bool uniwersalnySkrobakPasieczny = false;//18
        private bool nakretkiNaSloikZMiodem = false;//19
        private bool ulikOdkladowyWielkopolski = false;//20
        private int godzina;
        private int wiek;
        private bool plec;
        private string miasto;
        private string wojewodztwo;
        private string name;


        public bool PierscienDoPowalki { get => pierscienDoPowalki; set => pierscienDoPowalki = value; }
        public bool SitkoPajakDoPowalki { get => sitkoPajakDoPowalki; set => sitkoPajakDoPowalki = value; }
        public bool PrzegonkaOsmioWylotowa { get => przegonkaOsmioWylotowa; set => przegonkaOsmioWylotowa = value; }
        public bool EtykietaNaMiodGryczany { get => etykietaNaMiodGryczany; set => etykietaNaMiodGryczany = value; }
        public bool PodkarmiaczkaPowalkowa { get => podkarmiaczkaPowalkowa; set => podkarmiaczkaPowalkowa = value; }
        public bool PokarmCiastoFondant { get => pokarmCiastoFondant; set => pokarmCiastoFondant = value; }
        public bool PodkurzaczDadant { get => podkurzaczDadant; set => podkurzaczDadant = value; }
        public bool KsiazkaLatwePszczelarstwo { get => ksiazkaLatwePszczelarstwo; set => ksiazkaLatwePszczelarstwo = value; }
        public bool RekawicePszczelarskie { get => rekawicePszczelarskie; set => rekawicePszczelarskie = value; }
        public bool MiotelkaPasieczna { get => miotelkaPasieczna; set => miotelkaPasieczna = value; }
        public bool FajkaDoLapaniaMatekPszczelich { get => fajkaDoLapaniaMatekPszczelich; set => fajkaDoLapaniaMatekPszczelich = value; }
        public bool BluzaPszczelarskaZKapeluszem { get => bluzaPszczelarskaZKapeluszem; set => bluzaPszczelarskaZKapeluszem = value; }
        public bool KapeluszPszczelarski { get => kapeluszPszczelarski; set => kapeluszPszczelarski = value; }
        public bool WiaderkoOdstojnikNaMiod { get => wiaderkoOdstojnikNaMiod; set => wiaderkoOdstojnikNaMiod = value; }
        public bool DrutDoRamek { get => drutDoRamek; set => drutDoRamek = value; }
        public bool UchwytDoRamek { get => uchwytDoRamek; set => uchwytDoRamek = value; }
        public bool DwufunkcyjnyNozPasiecznyZDlutem { get => dwufunkcyjnyNozPasiecznyZDlutem; set => dwufunkcyjnyNozPasiecznyZDlutem = value; }
        public bool RamkaWielkopolska { get => ramkaWielkopolska; set => ramkaWielkopolska = value; }
        public bool UniwersalnySkrobakPasieczny { get => uniwersalnySkrobakPasieczny; set => uniwersalnySkrobakPasieczny = value; }
        public bool NakretkiNaSloikZMiodem { get => nakretkiNaSloikZMiodem; set => nakretkiNaSloikZMiodem = value; }
        public bool UlikOdkladowyWielkopolski { get => ulikOdkladowyWielkopolski; set => ulikOdkladowyWielkopolski = value; }
        public int Godzina { get => godzina; set => godzina = value; }
        public int Wiek { get => wiek; set => wiek = value; }
        public bool Plec { get => plec; set => plec = value; }
        public string Miasto { get => miasto; set => miasto = value; }
        public string Wojewodztwo { get => wojewodztwo; set => wojewodztwo = value; }
        public string Name { get => name; set => name = value; }
    }


}