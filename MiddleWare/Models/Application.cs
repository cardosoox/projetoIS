using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace MiddleWare.Models
{
    public class Application
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreationDateTime { get; set; }
        public ICollection<Container> Containers { get; set; } = new List<Container>();
    }

    public class Container
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreationDateTime { get; set; }
        public int ApplicationId { get; set; }
        public Application Application { get; set; }
        public ICollection<Record> Records { get; set; } = new List<Record>();
        public ICollection<Notification> Notifications { get; set; } = new List<Notification>();
    }

    public class Record
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Content { get; set; }
        public DateTime CreationDateTime { get; set; }
        public int ContainerId { get; set; }
        public Container Container { get; set; }
    }

    public class Notification
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreationDateTime { get; set; }
        public int Event { get; set; } // 1 = Creation, 2 = Deletion
        public string Endpoint { get; set; }
        public bool Enabled { get; set; }
        public int ContainerId { get; set; }
        public Container Container { get; set; }
    }
}