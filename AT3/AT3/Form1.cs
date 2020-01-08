using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

/*
  Samuel Low
  30008716 23/10/2019
  This program adds games, their platform, and their genre to three arrays and displays them in a listbox. The entries can be modified or deleted.
  They are sorted in alphabetical order with a bubble sort and can be searched using linear or binary searches.
  The game entires will be saved to a .dat file that can be opened again later.
 */


namespace AT3
{
    public partial class Form1 : Form
    {
        //The MAX global variable sets the max number of game entries.
        static int MAX = 20;

        //These arrays store the strings for the entries, each being a seperate component. The last array is the array that stores all the seperate arrays in one for the .dat file.
        string[] nameArray = new string[MAX];
        string[] platformArray = new string[MAX];
        string[] genreArray = new string[MAX];
        string[] allArray = new string[MAX * 3];

        //The filename variable determines the filename of the save file and, optionally, the location of the save file too.
        string filename = "mygames.dat";

        //The count variable keeps track of the number of game entries currently in the arrays.
        int count;

        public Form1()
        {
            InitializeComponent();
        }

        //When the form first loads in, it will check if a save file exists. If it does, it loads it. If not, it resets all the variables to 0/"empty".
        private void Form1_Load(object sender, EventArgs e)
        {

            if (File.Exists(filename)) 
            {
                loadList();
            }
            else
            {
                count = 0;
                for (int i = 0; i < MAX; i++)
                {
                    nameArray[i] = "empty";
                    platformArray[i] = "empty";
                    genreArray[i] = "empty";
                }

            }
            refreshListBox();
        }

        //This public method that refreshes the listbox when the game list changes. It clears the listbox, calls the sortGames() method, and populates the listbox entries. 
        //Finally, it updates the count textbox.
        public void refreshListBox()
        {
            gamesList.Items.Clear();

            sortGames();

            for(int i = 0; i < MAX; i++)
            {
                if (!nameArray[i].Contains("empty"))
                {
                    gamesList.Items.Add(nameArray[i] + "  | Platform: " + platformArray[i] + "  | Genre: " + genreArray[i]);
                }
            }

            countTxt.Text = count.ToString();
        }

        //This is a public method that sorts the games alpahbetically by name. It uses a bubble sort.
        public void sortGames()
        {
            string nameTemp;
            string platformTemp;
            string genreTemp;

            for(int i = 0; i < MAX; i++)
            {
                for (int p = 0; p < (MAX - 1); p++)
                {
                    if (nameArray[p].Equals("empty"))
                    {
                        nameTemp = nameArray[p + 1];
                        nameArray[p + 1] = nameArray[p];
                        nameArray[p] = nameTemp;

                        platformTemp = platformArray[p + 1];
                        platformArray[p + 1] = platformArray[p];
                        platformArray[p] = platformTemp;

                        genreTemp = genreArray[p + 1];
                        genreArray[p + 1] = genreArray[p];
                        genreArray[p] = genreTemp;
                    }
                    else if (0 < nameArray[p].CompareTo(nameArray[p + 1]) && !nameArray[p + 1].Equals("empty"))
                    {
                        nameTemp = nameArray[p + 1];
                        nameArray[p + 1] = nameArray[p];
                        nameArray[p] = nameTemp;

                        platformTemp = platformArray[p + 1];
                        platformArray[p + 1] = platformArray[p];
                        platformArray[p] = platformTemp;

                        genreTemp = genreArray[p + 1];
                        genreArray[p + 1] = genreArray[p];
                        genreArray[p] = genreTemp;
                    }
                }
            }
        }


        //This public method copies the three small arrays to a bigger array, which is then saved as a .dat file.
        public void saveList()
        {
            Array.Copy(nameArray, 0, allArray, 0, MAX);
            Array.Copy(platformArray, 0, allArray, MAX, MAX);
            Array.Copy(genreArray, 0, allArray, MAX * 2, MAX);
            File.WriteAllLines(filename, allArray);
        }


        //This public method loads a .dat file. The big array from that is copied into the three smaller arrays.
        public void loadList()
        {
            string[] allArray = File.ReadAllLines(filename);
            Array.Copy(allArray, 0, nameArray, 0, MAX);
            Array.Copy(allArray, MAX, platformArray, 0, MAX);
            Array.Copy(allArray, MAX * 2, genreArray, 0, MAX);

            for (int i = 0; i < MAX; i++)
            {
                if (nameArray[i] == "empty")
                {
                    count = i;
                    break;
                }
                else
                {
                    count = 20;
                }
            }
        }

        //This is code is for the add button click event. It checks if there is the maximum number of games, then if any text boxes are empty. 
        //If neither are true, then it adds the text box information to thier respective arrays and increments the count.
        private void addBtn_Click(object sender, EventArgs e)
        {
            if(count < MAX)
            {
                if (String.IsNullOrEmpty(nameTxt.Text) || String.IsNullOrEmpty(platformTxt.Text) || String.IsNullOrEmpty(genreTxt.Text))
                {
                    MessageBox.Show("Data is incomplete.");
                }
                else
                {
                    nameArray[count] = nameTxt.Text;
                    platformArray[count] = platformTxt.Text;
                    genreArray[count] = genreTxt.Text;
                    count++;

                    nameTxt.Clear();
                    platformTxt.Clear();
                    genreTxt.Clear();
                    refreshListBox();
                }
            }
            else
            {
                MessageBox.Show("You have too many games. Please delete one.");
            }

        }

        //This code is executed when the Clear button is clicked. It clears the text boxes of text and clears the games list of selection.
        private void clearBtn_Click(object sender, EventArgs e)
        {
            nameTxt.Clear();
            platformTxt.Clear();
            genreTxt.Clear();
            gamesList.ClearSelected();
        }

        //This code is for the Delete button. It first checks if a game is selected in the games list box. If there isn't, a message box appears asking to select a game.
        //If a game already is selected, it sets that array entry to "empty" on all arrays, clears the text boxes of text and decrements the count by one.
        //Finally it calls the refreshListrBox method.
        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (gamesList.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a game first.");
            }
            else
            {
                nameArray[gamesList.SelectedIndex] = "empty";
                platformArray[gamesList.SelectedIndex] = "empty";
                genreArray[gamesList.SelectedIndex] = "empty";

                nameTxt.Clear();
                platformTxt.Clear();
                genreTxt.Clear();
                count--;
            }
            refreshListBox();
        }

        //Code by Samuel Low

        //This code is for the Update button. It first checks if all text boxes have text. If it doesn't, a message box pops up saying the data is incomplete.
        //If all have text, it changes the array entry to what is currently in the text boxes. Then it calls the refreshListBox method.
        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(nameTxt.Text) || String.IsNullOrEmpty(platformTxt.Text) || String.IsNullOrEmpty(genreTxt.Text))
            {
                MessageBox.Show("Data is incomplete.");
            }
            else
            {
                nameArray[gamesList.SelectedIndex] = nameTxt.Text;
                platformArray[gamesList.SelectedIndex] = platformTxt.Text;
                genreArray[gamesList.SelectedIndex] = genreTxt.Text;

                refreshListBox();
            } 
        }


        //This code is for when an entry in the list box is clicked. It clears the text boxes and puts the array entries corresponding to the selected entry into the text boxes.
        private void gamesList_Click(object sender, EventArgs e)
        {
            nameTxt.Clear();
            platformTxt.Clear();
            genreTxt.Clear();

            nameTxt.AppendText(nameArray[gamesList.SelectedIndex]);
            platformTxt.AppendText(platformArray[gamesList.SelectedIndex]);
            genreTxt.AppendText(genreArray[gamesList.SelectedIndex]);
        }

        
        //This code is exzecuted when the Reset button is clicked. It opens a dialog box that confirms you want to delete everything.
        //If OK is selected, it pleaces all array entires with "empty" and calls teh refreshListBox method. If Cancel is selected, nothing happens.
        private void resetBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to delete all entries?", "Confirm", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                for (int i = 0; i < MAX; i++)
                {
                    nameArray[i] = "empty";
                    platformArray[i] = "empty";
                    genreArray[i] = "empty";
                }

                refreshListBox();
            }
            
        }
        

        //This is the code for when the linear search button is clicked. It goes through each array entry and check if the Name entry in the array matches the text in the Name text box.
        //If it matches, it puts the Platform and Genre entries into thier respective text boxes and selects the game in the list box.
        //If it doesn't match, it displays a message box stating no game was foiund and clears all text fields.
        private void linSearchBtn_Click(object sender, EventArgs e)
        {
            string linSearch = nameTxt.Text;
            bool linFound = false;

            platformTxt.Clear();
            genreTxt.Clear();

            for (int i = 0; i < count; i++)
            {
                if (nameArray[i].Equals(linSearch))
                {
                    platformTxt.AppendText(platformArray[i]);
                    genreTxt.AppendText(genreArray[i]);
                    gamesList.SelectedIndex = i;
                    linFound = true;
                }


            }
            if (!linFound)
            {
                MessageBox.Show("That game was not found.");
                nameTxt.Clear();
                platformTxt.Clear();
                genreTxt.Clear();
            }
        }

        //This is the code for when the binary search button is clicked. It uses a binary search method to find the Name array entry that matches the Name text. 
        //If it finds a match, it puts the Platform and Genre entries into thier respective text boxes and selects the game in the list box.
        //If it doesn't, it displays a message box stating no game was foiund and clears all text fields.
        private void binSearchBtn_Click(object sender, EventArgs e)
        {
            int minNum = 0;
            int maxNum = count;
            int mid;
            bool binSearch = false;

            platformTxt.Clear();
            genreTxt.Clear();

            while(minNum <= maxNum)
            {
                mid = (minNum + maxNum) / 2;
                if(0 == nameArray[mid].CompareTo(nameTxt.Text))
                {
                    platformTxt.AppendText(platformArray[mid]);
                    genreTxt.AppendText(genreArray[mid]);
                    gamesList.SelectedIndex = mid;
                    binSearch = true;
                    break;
                }
                else if(0 < nameArray[mid].CompareTo(nameTxt.Text))
                {
                    maxNum = mid - 1;
                }
                else
                {
                    minNum = mid + 1;
                }
            }
            
            if(!binSearch)
            {
                MessageBox.Show("That game was not found.");
                nameTxt.Clear();
                platformTxt.Clear();
                genreTxt.Clear();
            }
        }


        //The Save button will call the saveList method when clicked.
        private void saveBtn_Click(object sender, EventArgs e)
        {
            saveList();
        }

        //The Load button will call the loadList method when clicked.
        private void openBtn_Click(object sender, EventArgs e)
        {
            loadList();

            refreshListBox();
        }


        //When the window is closed, a dialog box is opened which asks if you want to save the list or not.
        //If Yes, then the saveList method will be called and then closed. If No, then it will just close.
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Do you want to save changes to your game list?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                saveList();
            }
        }
    }
}
