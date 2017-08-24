using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Robot.Models
{
    public class Scene
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Number")]
        public int SceneID { get; set; }

        [StringLength(50, MinimumLength = 3)]
        public string Title { get; set; }
    }
}