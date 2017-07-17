using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace Projetos_Estudos.WebSite.Convertions
{
    public class DateTime2Convertion: Convention
    {
        public DateTime2Convertion()
        {
            Properties<DateTime>().Configure(c=> c.HasColumnType("datetime2"));
        }

    }
}