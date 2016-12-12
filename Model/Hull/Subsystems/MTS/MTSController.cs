﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RSSE
{
    public class MTSController
    {
        public bool is_SPARE;
        public Vector3 position;
        public Vector3 rotation;
        public int equipBay;
        public int quad;

        public MTSController()
        {
            position = new Vector3();
            rotation = new Vector3();
        }

        public MTSController( Table table )
        {
            is_SPARE = table["is_SPARE"].Value > 0.5;
            position = new Vector3(table["position"]);
            rotation = new Vector3(table["rotation"]);
            equipBay = table["EquipBay"].IntValue;
            quad = table["Quad"].IntValue;
        }

        public Table ToTable()
        {
            Table table = new Table();
            table["is_SPARE"].Value = is_SPARE?1:0;
            table["position"] = position.ToTable();
            table["rotation"] = rotation.ToTable();
            table["EquipBay"].IntValue = equipBay;
            table["Quad"].IntValue = quad;
            return table;
        }
    }
}