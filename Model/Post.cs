using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace EntityFramework.Model
{
    public class Post
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [MaxLength(5000, ErrorMessage = "Este campo não pode ter mais do que 5000 caracteres")]
        [MinLength(1, ErrorMessage = "Este campo deve ser preenchido")]
        public string Text { get; set; }
        public User Author { get; set; }
        public DateTime CreateDate { get; set; }

        public Topic Topic { get; set; }
        public Post Parent { get; set; }

        [Required(ErrorMessage = "Este campo não pode ser vazio")]
        public DateTime Date { get; set; }
    }
}
