namespace List_method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, dynamic> dic = new()
            {
                ["name"] = "张三",
                ["age"] = 12
            };

            dic.Add("height", 180);
            //Console.WriteLine(dic["height"]);
            //dic.Add("name", "李四"); // 报错, 不能添加同名键名

           /* Console.WriteLine(dic.ContainsKey("name"));//判断键名是否存在
            Console.WriteLine(dic.ContainsValue(180));//判断键值是否存在*/

            //dic.Remove("height");
            foreach (dynamic res in dic)
            {
                Console.WriteLine(res);
            }

            //dic.Clear();
            Console.WriteLine(dic.Count);






            //思路一
            /*List<int> ints = [1, 3, 3, 3, 3, 4, 5, 6, 7, 7, 8, 6, 4, 2, 3];
            for (int i = 0;i<ints.Count;i++)
            {
                for (int j = i+1; j < ints.Count; j++)
                {
                    if (ints[i] == ints[j])
                    {
                        ints.RemoveAt(j);
                        j--;//防止数据左移时跳过漏检
                    }
                }
            }
            foreach (int n in ints) Console.WriteLine(n);*/

            /*List<Dictionary<string, dynamic>> goods = new List<Dictionary<string, dynamic>>
        {
            new Dictionary<string, dynamic>
            {
                {"name", "机械键盘"},
                {"price", 299.99},
                {"code", "G001"},
                {"stock", 120}
            },
            new Dictionary<string, dynamic>
            {
                {"name", "无线鼠标"},
                {"price", 89.50},
                {"code", "G002"},
                {"stock", 356}
            },
            new Dictionary<string, dynamic>
            {
                {"name", "27寸显示器"},
                {"price", 1299.00},
                {"code", "G003"},
                {"stock", 48}
            },
            new Dictionary<string, dynamic>
            {
                {"name", "电竞耳机"},
                {"price", 199.00},
                {"code", "G004"},
                {"stock", 85}
            },
            new Dictionary<string, dynamic>
            {
                {"name", "电脑支架"},
                {"price", 69.90},
                {"code", "G005"},
                {"stock", 210}
            }
        };
            Console.WriteLine("您要查询price/stock?:");
            string lei = Console.ReadLine();
            if (lei == "price")
            {
                Console.WriteLine("您想如何排序(ASC升序/DSC降序)?:");
                string xu = Console.ReadLine();
                if (xu == "ASC")
                {

                    for (int i = 0; i < goods.Count - 1; i++)
                    {
                        for (int j = 0; j < goods.Count - 1 - i; j++)
                        {
                            if (goods[j]["price"] > goods[j + 1]["price"])
                            {
                                dynamic tmp = goods[j];
                                goods[j] = goods[j + 1];
                                goods[j + 1] = tmp;
                            }
                        }
                    }
                    //foreach (dynamic n in goods) Console.WriteLine($"{n["name"]}------{n["price"]}");
                }
                else
                {

                    for (int i = 0; i < goods.Count - 1; i++)
                    {
                        for (int j = 0; j < goods.Count - 1 - i; j++)
                        {
                            if (goods[j]["price"] < goods[j + 1]["price"])
                            {
                                dynamic tmp = goods[j];
                                goods[j] = goods[j + 1];
                                goods[j + 1] = tmp;
                            }
                        }
                    }
                    //foreach (dynamic n in goods) Console.WriteLine($"{n["name"]}------{n["price"]}");
                }
            }

            else
            {
                Console.WriteLine("您想如何排序(ASC升序/DSC降序)?:");
                string xu = Console.ReadLine();
                if (xu == "ASC")
                {

                    for (int i = 0; i < goods.Count - 1; i++)
                    {
                        for (int j = 0; j < goods.Count - 1 - i; j++)
                        {
                            if (goods[j]["stock"] > goods[j + 1]["stock"])
                            {
                                dynamic tmp = goods[j];
                                goods[j] = goods[j + 1];
                                goods[j + 1] = tmp;
                            }
                        }
                    }
                    //foreach (dynamic n in goods) Console.WriteLine($"{n["name"]}------{n["stock"]}件");
                }
                else
                {

                    for (int i = 0; i < goods.Count - 1; i++)
                    {
                        for (int j = 0; j < goods.Count - 1 - i; j++)
                        {
                            if (goods[j]["stock"] < goods[j + 1]["stock"])
                            {
                                dynamic tmp = goods[j];
                                goods[j] = goods[j + 1];
                                goods[j + 1] = tmp;
                            }
                        }
                    }
                    //foreach (dynamic n in goods) Console.WriteLine($"{n["name"]}------{n["stock"]}件");
                }
            }

            foreach (dynamic n in goods)
            { 
                if(lei == "price")
                Console.WriteLine($"{n["name"]}------{n["price"]}件");
                else
                Console.WriteLine($"{n["name"]}------{n["stock"]}件");
            }*/







            // 数据使用案例中的数据

            // 通过歌曲查找歌手
            /* List<Dictionary<string, dynamic>> singerList = new List<Dictionary<string, dynamic>>
              {
                  new Dictionary<string, dynamic>
                  {
                      {"singerId", 1001},
                      {"singerName", "周杰伦"},
                      {"genre", "流行"}
                  },
                  new Dictionary<string, dynamic>
                  {
                      {"singerId", 1002},
                      {"singerName", "林俊杰"},
                      {"genre", "华语流行"}
                  },
                  new Dictionary<string, dynamic>
                  {
                      {"singerId", 1003},
                      {"singerName", "邓紫棋"},
                      {"genre", "流行、摇滚"}
                  },
                  new Dictionary<string, dynamic>
                  {
                      {"singerId", 1004},
                      {"singerName", "薛之谦"},
                      {"genre", "抒情流行"}
                  },
                  new Dictionary<string, dynamic>
                  {
                      {"singerId", 1005},
                      {"singerName", "毛不易"},
                      {"genre", "民谣流行"}
                  }
              };

             List<Dictionary<string, dynamic>> songList = new List<Dictionary<string, dynamic>>
              {
                  new Dictionary<string, dynamic>
                  {
                      {"songId", 10001},
                      {"singerId", 1001},
                      {"songName", "青花瓷"},
                      {"duration", 239}
                  },
                  new Dictionary<string, dynamic>
                  {
                      {"songId", 10002},
                      {"singerId", 1001},
                      {"songName", "发如雪"},
                      {"duration", 253}
                  },
                  new Dictionary<string, dynamic>
                  {
                      {"songId", 10003},
                      {"singerId", 1001},
                      {"songName", "东风破"},
                      {"duration", 215}
                  },
                  new Dictionary<string, dynamic>
                  {
                      {"songId", 1004},
                      {"singerId", 3002},
                      {"songName", "不为谁而作的歌"},
                      {"duration", 296}
                  },
                  new Dictionary<string, dynamic>
                  {
                      {"songId", 1005},
                      {"singerId", 1002},
                      {"songName", "背对背拥抱"},
                      {"duration", 262}
                  }
              };

             Console.WriteLine("请输入歌曲名称");
             string song = Console.ReadLine();
             int songID = 0;

             foreach (Dictionary<string, dynamic> item in songList)
             {
                 if (item["songName"] == song)
                     songID = item["singerId"];
             }

             var res = new List<Dictionary<string, dynamic>>();


             foreach (Dictionary<string, dynamic> item in singerList)
             {
                 if (item["singerId"] == songID)
                     res.Add(item);
             }


             foreach (Dictionary<string, dynamic> item in res)
             {
                 Console.WriteLine(item["singerName"]);
             }*/












        }
    }
}
