using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Logistic_Company.Models
{
    public class avtomobil
    {
        [Display(Name = "Регистрационный номер")]
        public short reg_number { get; set; }

        [Display(Name = "Номер кузова")]
        public short nom_kuzova { get; set; }

        [Display(Name = "Номер двигателя")]
        public short  nom_dvigatelua { get; set; }

        [Display(Name = "Год выпуска")]
        public DateTime god_vipuska { get; set; }

        [Display(Name = "Дата последнего ТО")]
        public DateTime data_pos_to { get; set; }

        [Display(Name = "Код автомобиля")]
        public short ID { get; set; }

    }
}
