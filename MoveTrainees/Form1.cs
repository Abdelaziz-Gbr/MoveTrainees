using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MoveTrainees
{
    public partial class Form1 : Form
    {
        private List<Trainee> trainees;
        private int[] labs;
        private int currentLab = 1;
        public Form1()
        {
            trainees = new List<Trainee>();
            InitializeComponent();
            labs = new int[] { 1, 2};
            FillCheckedListBoxWithTrainees();
            InitComboLab();
        }

        private void InitComboLab()
        {
            foreach(int i in labs)
                comboBox_lab.Items.Add("lab " + i);
            comboBox_lab.SelectedIndex = 0;
        }

        private void btn_MoveTrainee_Click(object sender, EventArgs e)
        {
            foreach (int index in chkedListBox_Trainees.CheckedIndices)
            {
                trainees[index].lab = currentLab;
            }
            //update checked list box - lab trainee
            AssignTrainees();
        }

        private void FillCheckedListBoxWithTrainees()
        {
            InitTraineeList();
            //assign each trainee to their lab.
            AssignTrainees();
        }

        private void AssignTrainees()
        {
            //clear the checked list boxes.
            ClearAllBoxes();
            foreach(Trainee t in trainees)
            {
                if (t.lab == 0)
                {
                    chkedListBox_Trainees.Items.Add(t);
                }
                else if (t.lab == currentLab) 
                {
                    //change to else if and assign each trainee to its lab
                    chkedListBox_LabTrainees.Items.Add(t);
                }
            }
        }

        private void ClearAllBoxes()
        {
            chkedListBox_Trainees.Items.Clear();
            chkedListBox_LabTrainees.Items.Clear();
        }

        private void InitTraineeList()
        {
            trainees.Add(new Trainee("Ahmed"));
            trainees.Add(new Trainee("Ali"));
            trainees.Add(new Trainee("Mohamed"));
            trainees.Add(new Trainee("Abdelaziz"));
            trainees.Add(new Trainee("Haitham"));
            trainees.Add(new Trainee("Manar"));
        }

        private void btn_MoveAllTrainees_Click(object sender, EventArgs e)
        {
            foreach (Trainee t in trainees)
                if(t.lab == 0)
                    t.lab = currentLab;
            AssignTrainees();
        }

        private void btn_MoceLabTrainee_Click(object sender, EventArgs e)
        {
            foreach(int index in chkedListBox_LabTrainees.CheckedIndices)
                trainees[index].lab = 0;
            AssignTrainees();
        }

        private void btn_MoveAllLabTrainees_Click(object sender, EventArgs e)
        {
            foreach(Trainee t in trainees)
                if(t.lab == currentLab)
                    t.lab = 0;
            AssignTrainees();
        }

        private void comboBox_lab_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentLab = labs[comboBox_lab.SelectedIndex];
            AssignTrainees();
        }
    }
}
