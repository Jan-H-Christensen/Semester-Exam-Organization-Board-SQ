using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OrganizationBoard.DTO
{
    public class EncryptPasswordBummyForWebsideResponsabiletyDto
    {
        [Required]
        public string Password { get; set; }
        [Required]
        public string PublicKeyPem { get; set; }
    }
}