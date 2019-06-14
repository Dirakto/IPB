using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace ipb.Models
{
    public class List
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string GraczName { get; set; }
        public string Opis { get; set; }
        public Kategoria Kategoria { get; set; }
        public Stan Stan { get; set; }
        public bool CzyPowazny { get; set; } = true;
    }

    public enum Stan{
        Nowy = 0, Rozpatrzony = 1, Przyjety = 2
    }

    public enum Kategoria{
        Ogolne, DzialTechniczny, DzialKarania
    }

    public class ListWrapper{
        public bool canRender { get; set; } = false;
        public IEnumerable<Kategoria> Kategorie { get; set; }
        public List List { get; set; } = new List();

        public ICollection<List> Listy { get; set; }

        public ListWrapper(){
            Kategorie = Enum.GetValues(typeof(Kategoria)).Cast<Kategoria>();
        }

        public ListWrapper(ICollection<List> listy) : this(){
            Listy = listy;
        }
    }

}