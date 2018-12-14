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
        SqlConnection con = new SqlConnection(@"Data Source=desktop-sd63um7\sqlexpress;Initial Catalog=Hangman_Game;Integrated Security=True");
        SqlCommand cmd1, cmd2, cmd3, cmd4;
        SqlDataReader sdr1, sdr2, sdr3, sdr4;

        //Storing current game data in struct
        public struct DATA
        {
            public string word;
            public string hint;
            public string defenition;
            public string category_st;
        }

        //ALL GAME DATA
        public DATA Generated_struct = new DATA();
        public string category;
        public string game_mode;
        public string words_mode;
        public string dashes_word;
        public int trials;
        public static int score;
        public List<DATA> Easy = new List<DATA>();
        public List<DATA> Medium = new List<DATA>();
        public List<DATA> Hard = new List<DATA>();

        //Constructor
        public Game()
        {
            this.words_mode = "Random";
            this.game_mode = "Medium";
            this.category = "History";
            trials = 9;
            score = 0;
        }

        //This function gets data from sql and fill it in lists
        public void Get_data()
        {
            con.Open(); //Opening connection

            //Easy words list
            for (int i = 0; i < 60; i++)
            {
                var s = new DATA();
                cmd1 = new SqlCommand("select Word from Easy where [No.]='" + (i + 1) + "'", con);
                cmd2 = new SqlCommand("select Definition from Easy where [No.]='" + (i + 1) + "'", con);
                cmd3 = new SqlCommand("select Hint from Easy where [No.]='" + (i + 1) + "'", con);
                cmd4 = new SqlCommand("select Category from Easy where [No.]='" + (i + 1) + "'", con);

                sdr1 = cmd1.ExecuteReader();
                while (sdr1.Read())
                {
                    s.word = sdr1["Word"].ToString();
                }
                sdr1.Close();

                sdr2 = cmd2.ExecuteReader();
                while (sdr2.Read())
                {
                    s.defenition = sdr2["Definition"].ToString();
                }
                sdr2.Close();

                sdr3 = cmd3.ExecuteReader();
                while (sdr3.Read())
                {
                    s.hint = sdr3["Hint"].ToString();
                }
                sdr3.Close();

                sdr4 = cmd4.ExecuteReader();
                while (sdr4.Read())
                {
                    s.category_st = sdr4["Category"].ToString();
                }
                sdr4.Close();

                Easy.Add(s);
            }

            //Medium words list
            for (int i = 0; i < 59; i++)
            {
                var s = new DATA();
                cmd1 = new SqlCommand("select Word from Medium where [No.]='" + (i + 1) + "'", con);
                cmd2 = new SqlCommand("select Definition from Medium where [No.]='" + (i + 1) + "'", con);
                cmd3 = new SqlCommand("select Hint from Medium where [No.]='" + (i + 1) + "'", con);
                cmd4 = new SqlCommand("select Category from Medium where [No.]='" + (i + 1) + "'", con);

                sdr1 = cmd1.ExecuteReader();
                while (sdr1.Read())
                {
                    s.word = sdr1["Word"].ToString();
                }
                sdr1.Close();

                sdr2 = cmd2.ExecuteReader();
                while (sdr2.Read())
                {
                    s.defenition = sdr2["Definition"].ToString();
                }
                sdr2.Close();

                sdr3 = cmd3.ExecuteReader();
                while (sdr3.Read())
                {
                    s.hint = sdr3["Hint"].ToString();
                }
                sdr3.Close();

                sdr4 = cmd4.ExecuteReader();
                while (sdr4.Read())
                {
                    s.category_st = sdr4["Category"].ToString();
                }
                sdr4.Close();

                Medium.Add(s);
            }

            //Hard words list
            for (int i = 0; i < 60; i++)
            {
                var s = new DATA();
                cmd1 = new SqlCommand("select Word from Hard where [No.]='" + (i + 1) + "'", con);
                cmd2 = new SqlCommand("select Definition from Hard where [No.]='" + (i + 1) + "'", con);
                cmd3 = new SqlCommand("select Hint from Hard where [No.]='" + (i + 1) + "'", con);
                cmd4 = new SqlCommand("select Category from Hard where [No.]='" + (i + 1) + "'", con);

                sdr1 = cmd1.ExecuteReader();
                while (sdr1.Read())
                {
                    s.word = sdr1["Word"].ToString();
                }
                sdr1.Close();

                sdr2 = cmd2.ExecuteReader();
                while (sdr2.Read())
                {
                    s.defenition = sdr2["Definition"].ToString();
                }
                sdr2.Close();

                sdr3 = cmd3.ExecuteReader();
                while (sdr3.Read())
                {
                    s.hint = sdr3["Hint"].ToString();
                }
                sdr3.Close();

                sdr4 = cmd4.ExecuteReader();
                while (sdr4.Read())
                {
                    s.category_st = sdr4["Category"].ToString();
                }
                sdr4.Close();

                Hard.Add(s);
            }

            con.Close(); //Closing connection
        }

        //This function generates a word  to guess
        public DATA Generate_Game_Data()
        {
            Get_data();
            Random rand = new Random(); //Taking an object of random class
            if (game_mode == "Easy")
            {
                if (words_mode == "Random")
                {
                    int r = rand.Next(Easy.Count);
                    Generated_struct.word = Easy[r].word;
                    Generated_struct.defenition = Easy[r].defenition;
                    Generated_struct.hint = Easy[r].hint;
                    Generated_struct.category_st = Easy[r].category_st;
                }
                else if (words_mode == "ByCategory")
                {
                    if (category == "History")
                    {
                        //Creating a list of Easy-History only
                        List<DATA> easy_history = new List<DATA>();
                        for (int i = 0; i < Easy.Count; i++)
                        {
                            if (Easy[i].category_st.Trim() == "History")
                                easy_history.Add(Easy[i]);
                        }

                        //Choosing randomly from Easy-History list
                        int r = rand.Next(easy_history.Count);
                        Generated_struct.word = easy_history[r].word;
                        Generated_struct.defenition = easy_history[r].defenition;
                        Generated_struct.hint = easy_history[r].hint;
                        Generated_struct.category_st = easy_history[r].category_st;
                    }
                    else if (category == "Animals")
                    {
                        //Creating a list of Easy-Animals only
                        List<DATA> easy_animals = new List<DATA>();
                        for (int i = 0; i < Easy.Count; i++)
                        {
                            if (Easy[i].category_st.Trim() == "Animals")
                                easy_animals.Add(Easy[i]);
                        }

                        //Choosing randomly from Easy-Animals list
                        int r = rand.Next(easy_animals.Count);
                        Generated_struct.word = easy_animals[r].word;
                        Generated_struct.defenition = easy_animals[r].defenition;
                        Generated_struct.hint = easy_animals[r].hint;
                        Generated_struct.category_st = easy_animals[r].category_st;
                    }
                    else if (category == "Sports")
                    {
                        //Creating a list of Easy-Sports only
                        List<DATA> easy_sports = new List<DATA>();
                        for (int i = 0; i < Easy.Count; i++)
                        {
                            if (Easy[i].category_st.Trim() == "Sports")
                                easy_sports.Add(Easy[i]);
                        }

                        //Choosing randomly from Easy-Sports list
                        int r = rand.Next(easy_sports.Count);
                        Generated_struct.word = easy_sports[r].word;
                        Generated_struct.defenition = easy_sports[r].defenition;
                        Generated_struct.hint = easy_sports[r].hint;
                        Generated_struct.category_st = easy_sports[r].category_st;
                    }
                    else if (category == "Movies")
                    {
                        //Creating a list of Easy-Movies only
                        List<DATA> easy_movies = new List<DATA>();
                        for (int i = 0; i < Easy.Count; i++)
                        {
                            if (Easy[i].category_st.Trim() == "Movies")
                                easy_movies.Add(Easy[i]);
                        }

                        //Choosing randomly from Easy-Movies list
                        int r = rand.Next(easy_movies.Count);
                        Generated_struct.word = easy_movies[r].word;
                        Generated_struct.defenition = easy_movies[r].defenition;
                        Generated_struct.hint = easy_movies[r].hint;
                        Generated_struct.category_st = easy_movies[r].category_st;
                    }
                    else if (category == "Geography")
                    {
                        //Creating a list of Easy-Geography only
                        List<DATA> easy_geography = new List<DATA>();
                        for (int i = 0; i < Easy.Count; i++)
                        {
                            if (Easy[i].category_st.Trim() == "Geography")
                                easy_geography.Add(Easy[i]);
                        }

                        //Choosing randomly from Easy-Geography list
                        int r = rand.Next(easy_geography.Count);
                        Generated_struct.word = easy_geography[r].word;
                        Generated_struct.defenition = easy_geography[r].defenition;
                        Generated_struct.hint = easy_geography[r].hint;
                        Generated_struct.category_st = easy_geography[r].category_st;
                    }
                    else if (category == "Science")
                    {
                        //Creating a list of Easy-Science only
                        List<DATA> easy_science = new List<DATA>();
                        for (int i = 0; i < Easy.Count; i++)
                        {
                            if (Easy[i].category_st.Trim() == "Science")
                                easy_science.Add(Easy[i]);
                        }

                        //Choosing randomly from Easy-Science list
                        int r = rand.Next(easy_science.Count);
                        Generated_struct.word = easy_science[r].word;
                        Generated_struct.defenition = easy_science[r].defenition;
                        Generated_struct.hint = easy_science[r].hint;
                        Generated_struct.category_st = easy_science[r].category_st;
                    }
                }
            }

            else if (game_mode == "Medium")
            {
                if (words_mode == "Random")
                {
                    int r = rand.Next(Medium.Count);
                    Generated_struct.word = Medium[r].word;
                    Generated_struct.defenition = Medium[r].defenition;
                    Generated_struct.hint = Medium[r].hint;
                    Generated_struct.category_st = Medium[r].category_st;
                }
                else if (words_mode == "ByCategory")
                {
                    if (category == "History")
                    {
                        //Creating a list of Medium-History only
                        List<DATA> medium_history = new List<DATA>();
                        for (int i = 0; i < Medium.Count; i++)
                        {
                            if (Medium[i].category_st.Trim() == "History")
                                medium_history.Add(Medium[i]);
                        }

                        //Choosing randomly from Medium-History list
                        int r = rand.Next(medium_history.Count);
                        Generated_struct.word = medium_history[r].word;
                        Generated_struct.defenition = medium_history[r].defenition;
                        Generated_struct.hint = medium_history[r].hint;
                        Generated_struct.category_st = medium_history[r].category_st;
                    }
                    else if (category == "Animals")
                    {
                        //Creating a list of Medium-Animals only
                        List<DATA> medium_animals = new List<DATA>();
                        for (int i = 0; i < Medium.Count; i++)
                        {
                            if (Medium[i].category_st.Trim() == "Animals")
                                medium_animals.Add(Medium[i]);
                        }

                        //Choosing randomly from Medium-Animals list
                        int r = rand.Next(medium_animals.Count);
                        Generated_struct.word = medium_animals[r].word;
                        Generated_struct.defenition = medium_animals[r].defenition;
                        Generated_struct.hint = medium_animals[r].hint;
                        Generated_struct.category_st = medium_animals[r].category_st;
                    }
                    else if (category == "Sports")
                    {
                        //Creating a list of Medium-Sports only
                        List<DATA> medium_sports = new List<DATA>();
                        for (int i = 0; i < Medium.Count; i++)
                        {
                            if (Medium[i].category_st.Trim() == "Sports")
                                medium_sports.Add(Medium[i]);
                        }

                        //Choosing randomly from Medium-Sports list
                        int r = rand.Next(medium_sports.Count);
                        Generated_struct.word = medium_sports[r].word;
                        Generated_struct.defenition = medium_sports[r].defenition;
                        Generated_struct.hint = medium_sports[r].hint;
                        Generated_struct.category_st = medium_sports[r].category_st;
                    }
                    else if (category == "Movies")
                    {
                        //Creating a list of Medium-Movies only
                        List<DATA> medium_movies = new List<DATA>();
                        for (int i = 0; i < Medium.Count; i++)
                        {
                            if (Medium[i].category_st.Trim() == "Movies")
                                medium_movies.Add(Medium[i]);
                        }

                        //Choosing randomly from Medium-Movies list
                        int r = rand.Next(medium_movies.Count);
                        Generated_struct.word = medium_movies[r].word;
                        Generated_struct.defenition = medium_movies[r].defenition;
                        Generated_struct.hint = medium_movies[r].hint;
                        Generated_struct.category_st = medium_movies[r].category_st;
                    }
                    else if (category == "Geography")
                    {
                        //Creating a list of Medium-Geography only
                        List<DATA> medium_geography = new List<DATA>();
                        for (int i = 0; i < Medium.Count; i++)
                        {
                            if (Medium[i].category_st.Trim() == "Geography")
                                medium_geography.Add(Medium[i]);
                        }

                        //Choosing randomly from Medium-Geography list
                        int r = rand.Next(medium_geography.Count);
                        Generated_struct.word = medium_geography[r].word;
                        Generated_struct.defenition = medium_geography[r].defenition;
                        Generated_struct.hint = medium_geography[r].hint;
                        Generated_struct.category_st = medium_geography[r].category_st;
                    }
                    else if (category == "Science")
                    {
                        //Creating a list of Medium-Science only
                        List<DATA> medium_science = new List<DATA>();
                        for (int i = 0; i < Medium.Count; i++)
                        {
                            if (Medium[i].category_st.Trim() == "Science")
                                medium_science.Add(Medium[i]);
                        }

                        //Choosing randomly from Medium-Science list
                        int r = rand.Next(medium_science.Count);
                        Generated_struct.word = medium_science[r].word;
                        Generated_struct.defenition = medium_science[r].defenition;
                        Generated_struct.hint = medium_science[r].hint;
                        Generated_struct.category_st = medium_science[r].category_st;
                    }
                }
            }

            else if (game_mode == "Hard")
            {
                if (words_mode == "Random")
                {
                    int r = rand.Next(Hard.Count);
                    Generated_struct.word = Hard[r].word;
                    Generated_struct.defenition = Hard[r].defenition;
                    Generated_struct.hint = Hard[r].hint;
                    Generated_struct.category_st = Hard[r].category_st;
                }
                else if (words_mode == "ByCategory")
                {
                    if (category == "History")
                    {
                        //Creating a list of Hard-History only
                        List<DATA> hard_history = new List<DATA>();
                        for (int i = 0; i < Hard.Count; i++)
                        {
                            if (Hard[i].category_st.Trim() == "History")
                                hard_history.Add(Hard[i]);
                        }

                        //Choosing randomly from Hard-History list
                        int r = rand.Next(hard_history.Count);
                        Generated_struct.word = hard_history[r].word;
                        Generated_struct.defenition = hard_history[r].defenition;
                        Generated_struct.hint = hard_history[r].hint;
                        Generated_struct.category_st = hard_history[r].category_st;
                    }
                    else if (category == "Animals")
                    {
                        //Creating a list of Hard-Animals only
                        List<DATA> hard_animals = new List<DATA>();
                        for (int i = 0; i < Hard.Count; i++)
                        {
                            if (Hard[i].category_st.Trim() == "Animals")
                                hard_animals.Add(Hard[i]);
                        }

                        //Choosing randomly from Hard-Animals list
                        int r = rand.Next(hard_animals.Count);
                        Generated_struct.word = hard_animals[r].word;
                        Generated_struct.defenition = hard_animals[r].defenition;
                        Generated_struct.hint = hard_animals[r].hint;
                        Generated_struct.category_st = hard_animals[r].category_st;
                    }
                    else if (category == "Sports")
                    {
                        //Creating a list of Hard-Sports only
                        List<DATA> hard_sports = new List<DATA>();
                        for (int i = 0; i < Hard.Count; i++)
                        {
                            if (Hard[i].category_st.Trim() == "Sports")
                                hard_sports.Add(Hard[i]);
                        }

                        //Choosing randomly from Hard-Sports list
                        int r = rand.Next(hard_sports.Count);
                        Generated_struct.word = hard_sports[r].word;
                        Generated_struct.defenition = hard_sports[r].defenition;
                        Generated_struct.hint = hard_sports[r].hint;
                        Generated_struct.category_st = hard_sports[r].category_st;
                    }
                    else if (category == "Movies")
                    {
                        //Creating a list of Hard-Movies only
                        List<DATA> hard_movies = new List<DATA>();
                        for (int i = 0; i < Hard.Count; i++)
                        {
                            if (Hard[i].category_st.Trim() == "Movies")
                                hard_movies.Add(Hard[i]);
                        }

                        //Choosing randomly from Hard-Movies list
                        int r = rand.Next(hard_movies.Count);
                        Generated_struct.word = hard_movies[r].word;
                        Generated_struct.defenition = hard_movies[r].defenition;
                        Generated_struct.hint = hard_movies[r].hint;
                        Generated_struct.category_st = hard_movies[r].category_st;
                    }
                    else if (category == "Geography")
                    {
                        //Creating a list of Hard-Geography only
                        List<DATA> hard_geography = new List<DATA>();
                        for (int i = 0; i < Hard.Count; i++)
                        {
                            if (Hard[i].category_st.Trim() == "Geography")
                                hard_geography.Add(Hard[i]);
                        }

                        //Choosing randomly from Hard-Geography list
                        int r = rand.Next(hard_geography.Count);
                        Generated_struct.word = hard_geography[r].word;
                        Generated_struct.defenition = hard_geography[r].defenition;
                        Generated_struct.hint = hard_geography[r].hint;
                        Generated_struct.category_st = hard_geography[r].category_st;
                    }
                    else if (category == "Science")
                    {
                        //Creating a list of Hard-Science only
                        List<DATA> hard_science = new List<DATA>();
                        for (int i = 0; i < Hard.Count; i++)
                        {
                            if (Hard[i].category_st.Trim() == "Science")
                                hard_science.Add(Hard[i]);
                        }

                        //Choosing randomly from Hard-Science list
                        int r = rand.Next(hard_science.Count);
                        Generated_struct.word = hard_science[r].word;
                        Generated_struct.defenition = hard_science[r].defenition;
                        Generated_struct.hint = hard_science[r].hint;
                        Generated_struct.category_st = hard_science[r].category_st;
                    }
                }
            }

            return Generated_struct;
        }

        //This function recieves the generated word and generates dashes with the same length
        public string CreatDashes(string w)
        {
            string guessing_word = w;
            for (int i = 0; i < w.Length; i++)
            {
                if (w[i] == ' ')
                    guessing_word = guessing_word.Replace(w[i], ' ');
                else
                    guessing_word = guessing_word.Replace(w[i], '-'); //Replacing letters with dashes in the string
            }
            dashes_word = guessing_word;
            return dashes_word;
        }

        //This function checks if the letter existed in the word
        public bool check_find(char ca, char sm)
        {
            bool check = false;
            for (int i = 0; i < Generated_struct.word.Length; i++)
            {
                if (Generated_struct.word[i] == ca)
                {
                    check = true;
                }
                else if (Generated_struct.word[i] == sm)
                {
                    check = true;
                }
            }
            if (check == true)
                return true;
            else
                return false;

        }

        //This function evaluates the entered letters
        public string evaluate(char ca, char sm)
        {
            StringBuilder st = new StringBuilder(dashes_word);
            for (int i = 0; i < Generated_struct.word.Length; i++)
            {
                if (Generated_struct.word[i] == ca)
                {
                    st[i] = ca;
                }
                else if (Generated_struct.word[i] == sm)
                {
                    st[i] = sm;
                }
            }
            dashes_word = st.ToString();
            return dashes_word;
        }

        //This functions checks if the user won the current game or not
        public bool Win_or_not()
        {
            if (dashes_word == Generated_struct.word)
            {
                score++;
                return true;
            }
            else
                return false;
        }
    }
}






