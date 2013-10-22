using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using CodeFirst.Model;

namespace CodeFirst.Model
{
    public class User
    {
        public int Id { get; set; }

        #region UserType   STRING: Username, DisplayName, AuthCode, AccessToken, Mail, Phone, Location
        [Required]
        [MinLength(6)]
        [MaxLength(30)]
        [StringLength(30)]
        public string Username { get; set; }

        [Required]
        [MinLength(6)]
        [MaxLength(30)]
        [StringLength(30)]
        public string DisplayName { get; set; }

        [MinLength(40)]
        [MaxLength(40)]
        [StringLength(40)]
        public string AuthCode { get; set; }

        [MinLength(50)]
        [MaxLength(50)]
        [StringLength(50)]
        public string AccessToken { get; set; } 
        
        public UserType UserType { get; set; }

        public string Mail { get; set; }

        public string Phone { get; set; }

        public string Location { get; set; }
        #endregion
        
        public virtual ICollection<Job> OwnRequests { get; set; } 
        public virtual ICollection<Job> Jobs { get; set; }


        public User()
        {
            this.OwnRequests = new HashSet<Job>();
            this.Jobs = new HashSet<Job>();
        }
    } 
}
