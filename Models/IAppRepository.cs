using System;
using System.Collections.Generic;

namespace ipb.Models
{
    public interface IAppRepository
    {
        ICollection<List> Listy();
        void UpdateList(List l);
        void AddList(List l);
        void Save();
    }
}