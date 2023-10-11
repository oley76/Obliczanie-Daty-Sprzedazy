using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObliczanieDatySprzedaży.Class
{
    public class Stado
    {
        public string numerStada { get; set; }

        public DateTime dataWstawienia { get; set; }

        public DateTime dataPrzerzutu { get; set; }

        public DateTime dataWystawieniaFaktury { get; set; }

        public int dzieńSprzedażyIndyczkiOd { get; set; } = 98;

        public int dzieńSprzedażyIndyczkiDo { get; set; } = 99;

        public int dzieńSprzedażyIndoraOd { get; set; } = 136;

        public int dzieńSprzedażyIndoraDo { get; set; } = 139;

        public int dzieńSprzedażyPrzebiórkiOd { get; set; } = 126;

        public int DzieńSprzedażyPrzebiórkiDo { get; set; } = 127;
    }
}
