using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using AppCore.Classes;
using AppCore.Extensions;
using AppCore.Properties;

namespace AppCore.Forms
{
    public partial class FormMain : Form
    {
        private readonly Tasks _currentTasks = new();
        private BindingSource _bindingTasks;

        public FormMain()
        {
            InitializeComponent();
        }

        public void Setup()
        {
            Text = "L000MES";
            Icon = Resources.Icon;
            StartPosition = FormStartPosition.CenterScreen;

            _bindingTasks = new BindingSource {DataSource = _currentTasks};
            gridTasks.ApplySetup(_bindingTasks, BackColor);
            gridTasks.ReadOnly = true;
            gridTasks.SelectionMode = DataGridViewSelectionMode.CellSelect;
            gridTasks.SelectionChanged += GridViewExtensions.DataGrid_ClearSelection;

            var colId = gridTasks.Columns.Add(new DataGridViewButtonColumn
            {
                Name = "Launch",
                HeaderText = "",
                Text = "...",
                UseColumnTextForButtonValue = true
            });
            gridTasks.Columns[colId].Width = 25;

            var font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gridTasks.SetFont(font);

            gridTasks.CellClick += gridTasks_CellClick;

            btnNewTask.Click += delegate
            {
                using var formAdd = new FormTask();
                formAdd.Setup();
                formAdd.ShowDialog(this);

                var returnTask = formAdd.Task;
                if (returnTask == null) return;

                _currentTasks.Add(returnTask);
                _currentTasks.Update();
                _bindingTasks.ResetBindings(false);
            };
        }

        private void gridTasks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (sender is not DataGridView grid) return;
            if (grid.CurrentRow?.DataBoundItem is not Task task) return;

            var column = grid.Columns[e.ColumnIndex];
            if (column.Name != "Launch") return;

            using var editForm = new FormTask
            {
                Task = task
            };
            editForm.Setup();
            editForm.ShowDialog(this);

            _currentTasks.Update();
            _bindingTasks.ResetBindings(false);
        }
    }
}
