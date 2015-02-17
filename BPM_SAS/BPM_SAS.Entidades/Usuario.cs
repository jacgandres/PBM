using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace BPM_SAS.Entidades
{
    [DataContractAttribute(Name = "Usuario")] 
    [Serializable]
    public class Usuario
    {
        [DataMemberAttribute(Name = "UsuarioID")]
        public int UsuarioID { get; set; }
        [DataMemberAttribute(Name = "Nombres")]
        public string Nombres { get; set; }
        [DataMemberAttribute(Name = "Apellidos")]
        public string Apellidos { get; set; }
        [DataMemberAttribute(Name = "Correo")]
        public string Correo { get; set; }
        [DataMemberAttribute(Name = "Estado")]
        public bool Estado { get; set; }
        [DataMemberAttribute(Name = "Telefono")]
        public long Telefono { get; set; }
    }
}
