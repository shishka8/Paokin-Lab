namespace LABA5555
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Motobike_csv
    {
        public int column1 { get; set; }

        [Required]
        [StringLength(50)]
        public string Brand { get; set; }

        [Required]
        [StringLength(50)]
        public string Model { get; set; }

        public double Price { get; set; }

        public int Horsepower { get; set; }

        public double Mileage { get; set; }

        [Required]
        public string column7 { get; set; }

        public int Id { get; set; }
    }
}
