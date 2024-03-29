﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextGame
{
	class Register
	{
		public string[,] chestMemory = new string[,]
		{
			{"W1", "1, 2", "Sword"},
			{"W1", "4, 5", "Backpack"}
		};
		public string[,] doorMemory = new string[,]
		{
			{"W1", "3, 7", "0001D", "0002D", "3, 6"},
			{"W2", "3, 0", "0002D", "0001D", "3, 1"},
            {"W2", "6, 3", "0003D", "0004D", "5, 3"},
            {"W3", "0, 2", "0004D", "0003D", "1, 2"}
		};

		public string[,] IdList = new string[,]
		{
			{"0000", "error"},
			{"0001", "Sword" },
			{"0002", "Backpack" },
			{"0003", "Enemy flesh" }
		};

        public string[,] ItemStatList = new string[,]
        {
            {"0000","none", "0", "0"},
            {"0001", "weapon", "10", "0"},
            {"0002", "backpack", "0", "5"},
            {"0003", "none", "0", "0"}
        };

		public string GetId(string name)
		{
			for (int i = 0; i < IdList.GetLength(0); i++)
			{
				if (name == IdList[i, 1])
				{
					return IdList[i, 0];
				}
			}
			return "0000";
		}

		public string GetName(string Id)
		{
			for (int i = 0; i < IdList.GetLength(0); i++)
			{
				if (Id == IdList[i, 0])
				{
					return IdList[i, 1];
				}
			}
			Console.WriteLine("id" + Id);
			return "error";
		}

        public void GetStatForItem(string item , out int atk, out int def)
        {
            atk = 0;
            def = 0;
            for (int i = 0; i < ItemStatList.GetLength(0); i++)
            {
                if (item == ItemStatList[i, 0])
                {
                    atk = int.Parse(ItemStatList[i, 2]);
                    def = int.Parse(ItemStatList[i, 3]);
                }
            }
        }

        public void GetCategoryForItem(string item, out string category)
        {
            category = "";
            for (int i = 0; i < ItemStatList.GetLength(0); i++)
            {
                if (item == ItemStatList[i, 0])
                {
                    category = ItemStatList[i, 1];
                }
            }
        }
    }
}
