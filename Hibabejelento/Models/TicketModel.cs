using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Hibabejelento.Models
{
    public class TicketModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "A hiba rövid megadása szükséges.")]
        [StringLength(40, ErrorMessage = "A hiba rövid leírása  max. {1} karakter lehet.")]
        [Display(Name = "A hiba rövid leírása")]
        public string ShortDescription { get; set; } = "";

        [Required(ErrorMessage = "A probléma teljes leírása szükséges.")]
        [StringLength(400, ErrorMessage = "A hiba teljes max. {1} karakter lehet")]
        [Display(Name = "A probléma teljes leírása")]
        public string LongDescription { get; set; } = "";
       

        [Required(ErrorMessage = "Név megadása szükséges.")]
        [Display(Name = "A bejelentő neve")]
        public string Name { get; set; } = "";
        
        [Required(ErrorMessage = "Email cím megadása szükséges.")]
        [EmailAddress(ErrorMessage = "Érvénytelen email-cím.")]
        [Display(Name = "Email")]
        public string Email { get; set; } = "";

        [RegularExpression("[0-9]{2}/[0-9]{3}-[0-9]{4}",
            ErrorMessage = "Telefonszám formája hibás. A szükséges forma: 12/345-6789")]
        [Display(Name = "Telefonszám")]
        public string Phone { get; set; } = "";

        [Required(ErrorMessage = "Cím megadása szükséges.")]
        [Display(Name = "Cím")]
        public string Address { get; set; } = "";

        [Required, Range(typeof(bool), "true", "true",
            ErrorMessage = "Hozzá kell járulnia a személyes adatai kezeléséhez.")]
        [Display(Name="Hozzájárulok a személyes adataim kezeléséhez")]
        public bool IsConsent { get; set; } = false;

        [StringLength(1000, ErrorMessage = "A hiba teljes max. {1} karakter lehet")]
        [Display(Name = "Ügyintéző megjegyzése")]
        public string? HelpdeskNote { get; set; }

        // Hibajegy sikeresen lezárva
        public bool IsClosed { get; set; } = false;

        // Jelenleg ki van-e adva ügyintézőnek?
        // Ha igen = még nincs megoldva, de ne szerepeljen a lekérhető ticketek között
        public bool IsInProcess { get; set; } = false;
    }
}
