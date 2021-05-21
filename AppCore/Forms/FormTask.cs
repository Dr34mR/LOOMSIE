using System;
using System.Drawing;
using System.Windows.Forms;
using AppCore.Classes;
using AppCore.Properties;

namespace AppCore.Forms
{
    public partial class FormTask : Form
    {
        public FormTask()
        {
            InitializeComponent();
        }

        public Task Task { get; set; }

        public void Setup()
        {
            CancelButton = btnSave;
            AcceptButton = btnSave;
            Icon = Resources.Icon;
            StartPosition = FormStartPosition.CenterParent;
            btnSave.Click += delegate { Save(); };

            if (Task == null)
            {
                lblId.Text = "New Task";
                lblId.ForeColor = Color.Green;
                AcceptButton = btnSave;
                dteDue.Value = DateTime.Today;
            }
            else
            {
                lblId.Text = $"Task #{Task.TaskId:N0}";
                btnSave.Text = "Complete";

                txtTaskName.Text = Task.TaskName;
                txtNumber.Text = Task.Number;
                txtOffence.Text = Task.Offence;
                dteReported.Value = Task.DateReported;
                dteDue.Value = Task.DateDue;
                txtNotes.Text = Task.Notes;
            }
        }

        public void Save()
        {
            Task ??= new Task();

            Task.TaskName = txtTaskName.Text.Trim();
            Task.Number = txtNumber.Text.ToUpper().Trim();
            Task.Offence = txtOffence.Text.Trim();
            Task.DateReported = dteReported.Value.Date;
            Task.DateDue = dteDue.Value.Date;
            Task.DriveLink = string.Empty;
            Task.Notes = txtNotes.Text.Trim();

            Hide();
        }
    }
}
