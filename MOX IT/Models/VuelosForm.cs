using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MOX_IT.Models
{
    public class VuelosForm
    {
        [Required]
        public string numeroDeVuelo { get; set; }

        [Required]
        public TimeSpan horaLlegada { get; set; }

        [Required]
        public int lineaAerea { get; set; }

        public bool demorado { get; set; }


    }
}