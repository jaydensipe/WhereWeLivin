﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace WhereWeLivin.Pages
{
    public partial class EndScreen : Form
    {
        // Template form for basic use

        public EndScreen(string top10list)
        {
            InitializeComponent();
            var j = JsonConvert.DeserializeObject<List<KeyValuePair<string, double>>>(top10list);

            if (j != null)
            {
                top1.Text = j[0].Key + @" / " + j[0].Value;
                top2.Text = j[1].Key + @" / " + j[1].Value;
                top3.Text = j[2].Key + @" / " + j[2].Value;
                top4.Text = j[3].Key + @" / " + j[3].Value;
                top5.Text = j[4].Key + @" / " + j[4].Value;
                top6.Text = j[5].Key + @" / " + j[5].Value;
                top7.Text = j[6].Key + @" / " + j[6].Value;
                top8.Text = j[7].Key + @" / " + j[7].Value;
                top9.Text = j[8].Key + @" / " + j[8].Value;
                top10.Text = j[9].Key + @" / " + j[9].Value;
                
                least1.Text = j[10].Key + @" / " + j[10].Value;
                least2.Text = j[11].Key + @" / " + j[11].Value;
                least3.Text = j[12].Key + @" / " + j[12].Value;
                least4.Text = j[13].Key + @" / " + j[13].Value;
                least5.Text = j[14].Key + @" / " + j[14].Value;
                least6.Text = j[15].Key + @" / " + j[15].Value;
                least7.Text = j[16].Key + @" / " + j[16].Value;
                least8.Text = j[17].Key + @" / " + j[17].Value;
                least9.Text = j[18].Key + @" / " + j[18].Value;
                least10.Text = j[19].Key + @" / " + j[19].Value;
                
            }


        }
    }
}