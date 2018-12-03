using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Collections;

namespace Hangman
{
    class Game
    {
        //SQL CONNECTION
        SqlConnection con = new SqlConnection(@"Data Source=yousef;Initial Catalog=Hangman_Game;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader sdr;

        //CURRENT GAME DATA
        public string word;
        public string game_mode;
        public string words_mode;
        public string category;

        //This function generates a word to guess
        public string Generate_Word()
        {
            //GENERATING RANDOMLY
            if (words_mode == "Random")
            {
                if (game_mode == "Easy")
                {
                    cmd = new SqlCommand("SELECT TOP 1 Word FROM Easy ORDER BY NEWID()", con);
                    con.Open();
                    sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                        word = sdr["Word"].ToString();
                    sdr.Close();
                    con.Close();
                }

                else if (game_mode == "Medium")
                {
                    cmd = new SqlCommand("SELECT TOP 1 Word FROM Medium ORDER BY NEWID()", con);
                    con.Open();
                    sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                        word = sdr["Word"].ToString();
                    sdr.Close();
                    con.Close();
                }

                else if (game_mode == "Hard")
                {
                    cmd = new SqlCommand("SELECT TOP 1 Word FROM Hard ORDER BY NEWID()", con);
                    con.Open();
                    sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                        word = sdr["Word"].ToString();
                    sdr.Close();
                    con.Close();
                }
            }

            //GENERATING BY CATEGORY
            else if (words_mode == "ByCategory")
            {
                if (game_mode == "Easy")
                {
                    if (category == "History")
                    {
                        cmd = new SqlCommand("SELECT TOP 1 Word FROM Easy WHERE Category='History' ORDER BY NEWID()", con);
                        con.Open();
                        sdr = cmd.ExecuteReader();
                        while (sdr.Read())
                            word = sdr["Word"].ToString();
                        sdr.Close();
                        con.Close();
                    }
                    else if (category == "Animals")
                    {
                        cmd = new SqlCommand("SELECT TOP 1 Word FROM Easy WHERE Category='Animals' ORDER BY NEWID()", con);
                        con.Open();
                        sdr = cmd.ExecuteReader();
                        while (sdr.Read())
                            word = sdr["Word"].ToString();
                        sdr.Close();
                        con.Close();
                    }
                    else if (category == "Sports")
                    {
                        cmd = new SqlCommand("SELECT TOP 1 Word FROM Easy WHERE Category='Sports' ORDER BY NEWID()", con);
                        con.Open();
                        sdr = cmd.ExecuteReader();
                        while (sdr.Read())
                            word = sdr["Word"].ToString();
                        sdr.Close();
                        con.Close();
                    }
                    else if (category == "Movies")
                    {
                        cmd = new SqlCommand("SELECT TOP 1 Word FROM Easy WHERE Category='Movies' ORDER BY NEWID()", con);
                        con.Open();
                        sdr = cmd.ExecuteReader();
                        while (sdr.Read())
                            word = sdr["Word"].ToString();
                        sdr.Close();
                        con.Close();
                    }
                    else if (category == "Geography")
                    {
                        cmd = new SqlCommand("SELECT TOP 1 Word FROM Easy WHERE Category='Geography' ORDER BY NEWID()", con);
                        con.Open();
                        sdr = cmd.ExecuteReader();
                        while (sdr.Read())
                            word = sdr["Word"].ToString();
                        sdr.Close();
                        con.Close();
                    }
                    else if (category == "Science")
                    {
                        cmd = new SqlCommand("SELECT TOP 1 Word FROM Easy WHERE Category='Science' ORDER BY NEWID()", con);
                        con.Open();
                        sdr = cmd.ExecuteReader();
                        while (sdr.Read())
                            word = sdr["Word"].ToString();
                        sdr.Close();
                        con.Close();
                    }
                }

                else if (game_mode == "Medium")
                {
                    if (category == "History")
                    {
                        cmd = new SqlCommand("SELECT TOP 1 Word FROM Medium WHERE Category='History' ORDER BY NEWID()", con);
                        con.Open();
                        sdr = cmd.ExecuteReader();
                        while (sdr.Read())
                            word = sdr["Word"].ToString();
                        sdr.Close();
                        con.Close();
                    }
                    else if (category == "Animals")
                    {
                        cmd = new SqlCommand("SELECT TOP 1 Word FROM Medium WHERE Category='Animals' ORDER BY NEWID()", con);
                        con.Open();
                        sdr = cmd.ExecuteReader();
                        while (sdr.Read())
                            word = sdr["Word"].ToString();
                        sdr.Close();
                        con.Close();
                    }
                    else if (category == "Sports")
                    {
                        cmd = new SqlCommand("SELECT TOP 1 Word FROM Medium WHERE Category='Sports' ORDER BY NEWID()", con);
                        con.Open();
                        sdr = cmd.ExecuteReader();
                        while (sdr.Read())
                            word = sdr["Word"].ToString();
                        sdr.Close();
                        con.Close();
                    }
                    else if (category == "Movies")
                    {
                        cmd = new SqlCommand("SELECT TOP 1 Word FROM Medium WHERE Category='Movies' ORDER BY NEWID()", con);
                        con.Open();
                        sdr = cmd.ExecuteReader();
                        while (sdr.Read())
                            word = sdr["Word"].ToString();
                        sdr.Close();
                        con.Close();
                    }
                    else if (category == "Geography")
                    {
                        cmd = new SqlCommand("SELECT TOP 1 Word FROM Medium WHERE Category='Geography' ORDER BY NEWID()", con);
                        con.Open();
                        sdr = cmd.ExecuteReader();
                        while (sdr.Read())
                            word = sdr["Word"].ToString();
                        sdr.Close();
                        con.Close();
                    }
                    else if (category == "Science")
                    {
                        cmd = new SqlCommand("SELECT TOP 1 Word FROM Medium WHERE Category='Science' ORDER BY NEWID()", con);
                        con.Open();
                        sdr = cmd.ExecuteReader();
                        while (sdr.Read())
                            word = sdr["Word"].ToString();
                        sdr.Close();
                        con.Close();
                    }
                }
                else if (game_mode == "Hard")
                {
                    if (category == "History")
                    {
                        cmd = new SqlCommand("SELECT TOP 1 Word FROM Hard WHERE Category='History' ORDER BY NEWID()", con);
                        con.Open();
                        sdr = cmd.ExecuteReader();
                        while (sdr.Read())
                            word = sdr["Word"].ToString();
                        sdr.Close();
                        con.Close();
                    }
                    else if (category == "Animals")
                    {
                        cmd = new SqlCommand("SELECT TOP 1 Word FROM Hard WHERE Category='Animals' ORDER BY NEWID()", con);
                        con.Open();
                        sdr = cmd.ExecuteReader();
                        while (sdr.Read())
                            word = sdr["Word"].ToString();
                        sdr.Close();
                        con.Close();
                    }
                    else if (category == "Sports")
                    {
                        cmd = new SqlCommand("SELECT TOP 1 Word FROM Hard WHERE Category='Sports' ORDER BY NEWID()", con);
                        con.Open();
                        sdr = cmd.ExecuteReader();
                        while (sdr.Read())
                            word = sdr["Word"].ToString();
                        sdr.Close();
                        con.Close();
                    }
                    else if (category == "Movies")
                    {
                        cmd = new SqlCommand("SELECT TOP 1 Word FROM Hard WHERE Category='Movies' ORDER BY NEWID()", con);
                        con.Open();
                        sdr = cmd.ExecuteReader();
                        while (sdr.Read())
                            word = sdr["Word"].ToString();
                        sdr.Close();
                        con.Close();
                    }
                    else if (category == "Geography")
                    {
                        cmd = new SqlCommand("SELECT TOP 1 Word FROM Hard WHERE Category='Geography' ORDER BY NEWID()", con);
                        con.Open();
                        sdr = cmd.ExecuteReader();
                        while (sdr.Read())
                            word = sdr["Word"].ToString();
                        sdr.Close();
                        con.Close();
                    }
                    else if (category == "Science")
                    {
                        cmd = new SqlCommand("SELECT TOP 1 Word FROM Hard WHERE Category='Science' ORDER BY NEWID()", con);
                        con.Open();
                        sdr = cmd.ExecuteReader();
                        while (sdr.Read())
                            word = sdr["Word"].ToString();
                        sdr.Close();
                        con.Close();
                    }
                }

            }

            return word;
        }

        //This function recieves the generated word and generates dashes with the same length
        public string CreatDashes(string w)
        {
            string guessing_word = w;
            for(int i=0;i<w.Length;i++)
            {
               guessing_word = guessing_word.Replace(w[i], '-'); //Replacing letters with dashes in the string
            }
            return guessing_word;
        }

    }
}
