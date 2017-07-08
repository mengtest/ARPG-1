﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using TaidouCommon.Model;

namespace TaidouServer.DB.Mapping {
    class RoleMap:ClassMap<Role>
    {
        public RoleMap()
        {
            Id(x => x.ID).Column("id");
            Map(x => x.Name).Column("name");
            Map(x => x.Level).Column("level");
            Map(x => x.IsMan).Column("isman");
            References(x => x.User).Column("userid");
            Map(x => x.Exp).Column("exp");
            Map(x => x.Diamond).Column("diamond");
            Map(x => x.Coin).Column("coin");
            Map(x => x.Energy).Column("energy");
            Map(x => x.Toughen).Column("toughen");
            Table("role");
        }
    }
}
