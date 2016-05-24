using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace OfficersForm
{
    public partial class ViewOfficersDB : Form
    {
        public ViewOfficersDB()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "officersDS.S_udal". При необходимости она может быть перемещена или удалена.
            this.s_udalTableAdapter.Fill(this.officersDS.S_udal);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "officersDS.Officers". При необходимости она может быть перемещена или удалена.
            this.OfficersTableAdapter.Fill(this.officersDS.Officers);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "officersDS.Officers". При необходимости она может быть перемещена или удалена.
            this.officersTA.Fill(this.officersDS.Officers);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "officersDS1.Officers". При необходимости она может быть перемещена или удалена.
            // this.officersTableAdapter.Fill(this.officersDS.Officers);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "officersDS.S_zvan". При необходимости она может быть перемещена или удалена.
            //  this.officersTableAdapter.Fill(this.officersDS.Officers);


            this.reportViewer1.RefreshReport();
        }

        private void NvbCB_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (NvbCB.SelectedIndex >= 0 && NvbCB.SelectedIndex < OfficersDGV.RowCount)
            {
                int index = NvbCB.SelectedIndex;
                NvbTB.Text = NvbCB.Text;
                FioTB.Text = OfficersDGV.Rows[index].Cells[1].Value.ToString();
                BithTB.Text = OfficersDGV.Rows[index].Cells[2].Value.ToString();
                ZvanTB.Text = OfficersDGV.Rows[index].Cells[3].Value.ToString();
                DolgnTB.Text = OfficersDGV.Rows[index].Cells[4].Value.ToString();
                StagTB.Text = officersTA.F_stagGetStag(NvbCB.Text).ToString();
                SZvanTB.Text = s_zvanTA.S_zvanGetZvan(ZvanTB.Text).ToString();
                UdalTB.Text = f_udalTA.F_udalGetUdal(NvbCB.Text).ToString();
                VrednTB.Text = f_vrednTA.F_vrednGetVredn(NvbCB.Text).ToString();
                SDolgnTB.Text =s_dolgnTA.S_dolgnGetDolgn(DolgnTB.Text).ToString();
                DovolstvieTB.Text = officersTA.Dovolstvie(NvbCB.Text).ToString();
            }
        }

        private TextBox StagTB;
        private Label NvbL;
        private Label FioL;
        private Label BithdL;
        private Label DolgnL;
        private Label StagL;
        private Label ZvanL;
        private BindingSource bindingS;
        private IContainer components;
        private OfficersDS officersDS;
        private DataGridView OfficersDGV;
        private DataGridViewTextBoxColumn nvbDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fIODataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn birthDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn zvanDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dolgnDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn stagDataGridViewTextBoxColumn;
        private OfficersDSTableAdapters.OfficersTableAdapter officersTA;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.OfficersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.officersDS = new OfficersForm.OfficersDS();
            this.S_udalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sudalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.StagTB = new System.Windows.Forms.TextBox();
            this.NvbL = new System.Windows.Forms.Label();
            this.FioL = new System.Windows.Forms.Label();
            this.BithdL = new System.Windows.Forms.Label();
            this.DolgnL = new System.Windows.Forms.Label();
            this.StagL = new System.Windows.Forms.Label();
            this.ZvanL = new System.Windows.Forms.Label();
            this.bindingS = new System.Windows.Forms.BindingSource(this.components);
            this.OfficersDGV = new System.Windows.Forms.DataGridView();
            this.nvbDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zvanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dolgnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stagDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.officersTA = new OfficersForm.OfficersDSTableAdapters.OfficersTableAdapter();
            this.s_zvanTA = new OfficersForm.OfficersDSTableAdapters.S_zvanTableAdapter();
            this.s_dolgnTA = new OfficersForm.OfficersDSTableAdapters.S_dolgnTableAdapter();
            this.UdalL = new System.Windows.Forms.Label();
            this.VrednL = new System.Windows.Forms.Label();
            this.DovolstvieTB = new System.Windows.Forms.TextBox();
            this.UdalTB = new System.Windows.Forms.TextBox();
            this.f_udalTA = new OfficersForm.OfficersDSTableAdapters.F_udalTableAdapter();
            this.f_vrednTA = new OfficersForm.OfficersDSTableAdapters.F_vrednTableAdapter();
            this.DovolstvieL = new System.Windows.Forms.Label();
            this.VrednTB = new System.Windows.Forms.TextBox();
            this.OtchetListButton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.SearchModCB = new System.Windows.Forms.ComboBox();
            this.DolgnTB = new System.Windows.Forms.TextBox();
            this.ZvanTB = new System.Windows.Forms.TextBox();
            this.BithTB = new System.Windows.Forms.TextBox();
            this.FioTB = new System.Windows.Forms.TextBox();
            this.NvbCB = new System.Windows.Forms.ComboBox();
            this.SZvanTB = new System.Windows.Forms.TextBox();
            this.SDolgnTB = new System.Windows.Forms.TextBox();
            this.NvbTB = new System.Windows.Forms.TextBox();
            this.ErrorBox = new System.Windows.Forms.TextBox();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.ModeChLB = new System.Windows.Forms.CheckedListBox();
            this.ReportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.officersFKBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.OfficersTableAdapter = new OfficersForm.OfficersDSTableAdapters.OfficersTableAdapter();
            this.s_udalTableAdapter = new OfficersForm.OfficersDSTableAdapters.S_udalTableAdapter();
            this.CreateReport = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.OfficersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.officersDS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.S_udalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sudalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OfficersDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.officersFKBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // OfficersBindingSource
            // 
            this.OfficersBindingSource.DataMember = "Officers";
            this.OfficersBindingSource.DataSource = this.officersDS;
            // 
            // officersDS
            // 
            this.officersDS.DataSetName = "OfficersDS";
            this.officersDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // S_udalBindingSource
            // 
            this.S_udalBindingSource.DataMember = "S_udal";
            this.S_udalBindingSource.DataSource = this.officersDS;
            // 
            // sudalBindingSource
            // 
            this.sudalBindingSource.DataMember = "S_udal";
            this.sudalBindingSource.DataSource = this.officersDS;
            // 
            // StagTB
            // 
            this.StagTB.Location = new System.Drawing.Point(158, 160);
            this.StagTB.Name = "StagTB";
            this.StagTB.Size = new System.Drawing.Size(122, 22);
            this.StagTB.TabIndex = 1;
            // 
            // NvbL
            // 
            this.NvbL.AutoSize = true;
            this.NvbL.Location = new System.Drawing.Point(24, 25);
            this.NvbL.Name = "NvbL";
            this.NvbL.Size = new System.Drawing.Size(128, 17);
            this.NvbL.TabIndex = 6;
            this.NvbL.Text = "Военный билет №";
            // 
            // FioL
            // 
            this.FioL.AutoSize = true;
            this.FioL.Location = new System.Drawing.Point(24, 53);
            this.FioL.Name = "FioL";
            this.FioL.Size = new System.Drawing.Size(70, 17);
            this.FioL.TabIndex = 7;
            this.FioL.Text = "Фамилия";
            // 
            // BithdL
            // 
            this.BithdL.AutoSize = true;
            this.BithdL.Location = new System.Drawing.Point(24, 81);
            this.BithdL.Name = "BithdL";
            this.BithdL.Size = new System.Drawing.Size(111, 17);
            this.BithdL.TabIndex = 8;
            this.BithdL.Text = "Дата рождения";
            // 
            // DolgnL
            // 
            this.DolgnL.AutoSize = true;
            this.DolgnL.Location = new System.Drawing.Point(24, 137);
            this.DolgnL.Name = "DolgnL";
            this.DolgnL.Size = new System.Drawing.Size(81, 17);
            this.DolgnL.TabIndex = 9;
            this.DolgnL.Text = "Должность";
            // 
            // StagL
            // 
            this.StagL.AutoSize = true;
            this.StagL.Location = new System.Drawing.Point(24, 165);
            this.StagL.Name = "StagL";
            this.StagL.Size = new System.Drawing.Size(41, 17);
            this.StagL.TabIndex = 10;
            this.StagL.Text = "Стаж";
            // 
            // ZvanL
            // 
            this.ZvanL.AutoSize = true;
            this.ZvanL.Location = new System.Drawing.Point(24, 109);
            this.ZvanL.Name = "ZvanL";
            this.ZvanL.Size = new System.Drawing.Size(56, 17);
            this.ZvanL.TabIndex = 11;
            this.ZvanL.Text = "Звание";
            // 
            // bindingS
            // 
            this.bindingS.DataMember = "Officers";
            this.bindingS.DataSource = this.officersDS;
            // 
            // OfficersDGV
            // 
            this.OfficersDGV.AutoGenerateColumns = false;
            this.OfficersDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OfficersDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nvbDataGridViewTextBoxColumn,
            this.fIODataGridViewTextBoxColumn,
            this.birthDDataGridViewTextBoxColumn,
            this.zvanDataGridViewTextBoxColumn,
            this.dolgnDataGridViewTextBoxColumn,
            this.stagDataGridViewTextBoxColumn});
            this.OfficersDGV.DataSource = this.bindingS;
            this.OfficersDGV.Location = new System.Drawing.Point(158, 324);
            this.OfficersDGV.Name = "OfficersDGV";
            this.OfficersDGV.RowTemplate.Height = 24;
            this.OfficersDGV.Size = new System.Drawing.Size(168, 70);
            this.OfficersDGV.TabIndex = 29;
            this.OfficersDGV.Visible = false;
            // 
            // nvbDataGridViewTextBoxColumn
            // 
            this.nvbDataGridViewTextBoxColumn.DataPropertyName = "Nvb";
            this.nvbDataGridViewTextBoxColumn.HeaderText = "Nvb";
            this.nvbDataGridViewTextBoxColumn.Name = "nvbDataGridViewTextBoxColumn";
            // 
            // fIODataGridViewTextBoxColumn
            // 
            this.fIODataGridViewTextBoxColumn.DataPropertyName = "FIO";
            this.fIODataGridViewTextBoxColumn.HeaderText = "FIO";
            this.fIODataGridViewTextBoxColumn.Name = "fIODataGridViewTextBoxColumn";
            // 
            // birthDDataGridViewTextBoxColumn
            // 
            this.birthDDataGridViewTextBoxColumn.DataPropertyName = "Birth_D";
            this.birthDDataGridViewTextBoxColumn.HeaderText = "Birth_D";
            this.birthDDataGridViewTextBoxColumn.Name = "birthDDataGridViewTextBoxColumn";
            // 
            // zvanDataGridViewTextBoxColumn
            // 
            this.zvanDataGridViewTextBoxColumn.DataPropertyName = "Zvan";
            this.zvanDataGridViewTextBoxColumn.HeaderText = "Zvan";
            this.zvanDataGridViewTextBoxColumn.Name = "zvanDataGridViewTextBoxColumn";
            // 
            // dolgnDataGridViewTextBoxColumn
            // 
            this.dolgnDataGridViewTextBoxColumn.DataPropertyName = "Dolgn";
            this.dolgnDataGridViewTextBoxColumn.HeaderText = "Dolgn";
            this.dolgnDataGridViewTextBoxColumn.Name = "dolgnDataGridViewTextBoxColumn";
            // 
            // stagDataGridViewTextBoxColumn
            // 
            this.stagDataGridViewTextBoxColumn.DataPropertyName = "Stag";
            this.stagDataGridViewTextBoxColumn.HeaderText = "Stag";
            this.stagDataGridViewTextBoxColumn.Name = "stagDataGridViewTextBoxColumn";
            // 
            // officersTA
            // 
            this.officersTA.ClearBeforeFill = true;
            // 
            // s_zvanTA
            // 
            this.s_zvanTA.ClearBeforeFill = true;
            // 
            // s_dolgnTA
            // 
            this.s_dolgnTA.ClearBeforeFill = true;
            // 
            // UdalL
            // 
            this.UdalL.AutoSize = true;
            this.UdalL.Location = new System.Drawing.Point(24, 193);
            this.UdalL.Name = "UdalL";
            this.UdalL.Size = new System.Drawing.Size(94, 17);
            this.UdalL.TabIndex = 31;
            this.UdalL.Text = "Удаленность";
            // 
            // VrednL
            // 
            this.VrednL.AutoSize = true;
            this.VrednL.Location = new System.Drawing.Point(24, 221);
            this.VrednL.Name = "VrednL";
            this.VrednL.Size = new System.Drawing.Size(78, 17);
            this.VrednL.TabIndex = 32;
            this.VrednL.Text = "Вредность";
            // 
            // DovolstvieTB
            // 
            this.DovolstvieTB.Location = new System.Drawing.Point(158, 244);
            this.DovolstvieTB.Name = "DovolstvieTB";
            this.DovolstvieTB.Size = new System.Drawing.Size(122, 22);
            this.DovolstvieTB.TabIndex = 33;
            // 
            // UdalTB
            // 
            this.UdalTB.Location = new System.Drawing.Point(158, 188);
            this.UdalTB.Name = "UdalTB";
            this.UdalTB.Size = new System.Drawing.Size(122, 22);
            this.UdalTB.TabIndex = 34;
            // 
            // f_udalTA
            // 
            this.f_udalTA.ClearBeforeFill = true;
            // 
            // f_vrednTA
            // 
            this.f_vrednTA.ClearBeforeFill = true;
            // 
            // DovolstvieL
            // 
            this.DovolstvieL.AutoSize = true;
            this.DovolstvieL.Location = new System.Drawing.Point(24, 252);
            this.DovolstvieL.Name = "DovolstvieL";
            this.DovolstvieL.Size = new System.Drawing.Size(94, 17);
            this.DovolstvieL.TabIndex = 35;
            this.DovolstvieL.Text = "Довольствие";
            // 
            // VrednTB
            // 
            this.VrednTB.Location = new System.Drawing.Point(158, 216);
            this.VrednTB.Name = "VrednTB";
            this.VrednTB.Size = new System.Drawing.Size(122, 22);
            this.VrednTB.TabIndex = 36;
            // 
            // OtchetListButton
            // 
            this.OtchetListButton.Location = new System.Drawing.Point(27, 322);
            this.OtchetListButton.Name = "OtchetListButton";
            this.OtchetListButton.Size = new System.Drawing.Size(125, 33);
            this.OtchetListButton.TabIndex = 37;
            this.OtchetListButton.Text = "Расчетный Лист";
            this.OtchetListButton.UseVisualStyleBackColor = true;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(27, 283);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(125, 33);
            this.SearchButton.TabIndex = 39;
            this.SearchButton.Text = "Найти";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // SearchModCB
            // 
            this.SearchModCB.FormattingEnabled = true;
            this.SearchModCB.Items.AddRange(new object[] {
            "Фамилия",
            "Военный Билет №",
            "Звание",
            "Должность",
            "Стаж",
            "Удаленность",
            "Вредность"});
            this.SearchModCB.Location = new System.Drawing.Point(158, 288);
            this.SearchModCB.Name = "SearchModCB";
            this.SearchModCB.Size = new System.Drawing.Size(121, 24);
            this.SearchModCB.TabIndex = 40;
            // 
            // DolgnTB
            // 
            this.DolgnTB.Location = new System.Drawing.Point(158, 132);
            this.DolgnTB.Name = "DolgnTB";
            this.DolgnTB.Size = new System.Drawing.Size(122, 22);
            this.DolgnTB.TabIndex = 2;
            // 
            // ZvanTB
            // 
            this.ZvanTB.Location = new System.Drawing.Point(158, 104);
            this.ZvanTB.Name = "ZvanTB";
            this.ZvanTB.Size = new System.Drawing.Size(122, 22);
            this.ZvanTB.TabIndex = 3;
            // 
            // BithTB
            // 
            this.BithTB.Location = new System.Drawing.Point(158, 76);
            this.BithTB.Name = "BithTB";
            this.BithTB.Size = new System.Drawing.Size(122, 22);
            this.BithTB.TabIndex = 4;
            // 
            // FioTB
            // 
            this.FioTB.Location = new System.Drawing.Point(158, 48);
            this.FioTB.Name = "FioTB";
            this.FioTB.Size = new System.Drawing.Size(122, 22);
            this.FioTB.TabIndex = 5;
            // 
            // NvbCB
            // 
            this.NvbCB.DataSource = this.bindingS;
            this.NvbCB.DisplayMember = "Nvb";
            this.NvbCB.FormattingEnabled = true;
            this.NvbCB.Location = new System.Drawing.Point(287, 20);
            this.NvbCB.Name = "NvbCB";
            this.NvbCB.Size = new System.Drawing.Size(121, 24);
            this.NvbCB.TabIndex = 13;
            this.NvbCB.SelectedIndexChanged += new System.EventHandler(this.NvbCB_SelectedIndexChanged);
            // 
            // SZvanTB
            // 
            this.SZvanTB.Location = new System.Drawing.Point(286, 104);
            this.SZvanTB.Name = "SZvanTB";
            this.SZvanTB.Size = new System.Drawing.Size(122, 22);
            this.SZvanTB.TabIndex = 28;
            // 
            // SDolgnTB
            // 
            this.SDolgnTB.Location = new System.Drawing.Point(286, 132);
            this.SDolgnTB.Name = "SDolgnTB";
            this.SDolgnTB.Size = new System.Drawing.Size(122, 22);
            this.SDolgnTB.TabIndex = 30;
            // 
            // NvbTB
            // 
            this.NvbTB.Location = new System.Drawing.Point(158, 20);
            this.NvbTB.Name = "NvbTB";
            this.NvbTB.Size = new System.Drawing.Size(122, 22);
            this.NvbTB.TabIndex = 42;
            // 
            // ErrorBox
            // 
            this.ErrorBox.Location = new System.Drawing.Point(27, 400);
            this.ErrorBox.Multiline = true;
            this.ErrorBox.Name = "ErrorBox";
            this.ErrorBox.ReadOnly = true;
            this.ErrorBox.Size = new System.Drawing.Size(553, 22);
            this.ErrorBox.TabIndex = 41;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(27, 361);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(125, 33);
            this.DeleteButton.TabIndex = 43;
            this.DeleteButton.Text = "Удалить";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // ModeChLB
            // 
            this.ModeChLB.FormattingEnabled = true;
            this.ModeChLB.Items.AddRange(new object[] {
            "Просмотр",
            "Удаление"});
            this.ModeChLB.Location = new System.Drawing.Point(414, 20);
            this.ModeChLB.Name = "ModeChLB";
            this.ModeChLB.Size = new System.Drawing.Size(138, 157);
            this.ModeChLB.TabIndex = 44;
            this.ModeChLB.Visible = false;
            this.ModeChLB.SelectedIndexChanged += new System.EventHandler(this.ModeChLB_SelectedIndexChanged);
            // 
            // ReportViewer
            // 
            this.ReportViewer.AutoSize = true;
            reportDataSource1.Name = "Officers";
            reportDataSource1.Value = this.OfficersBindingSource;
            reportDataSource2.Name = "S_udal";
            reportDataSource2.Value = this.S_udalBindingSource;
            this.ReportViewer.LocalReport.DataSources.Add(reportDataSource1);
            this.ReportViewer.LocalReport.DataSources.Add(reportDataSource2);
            this.ReportViewer.LocalReport.ReportEmbeddedResource = "OfficersForm.ReportList.rdlc";
            this.ReportViewer.Location = new System.Drawing.Point(558, 20);
            this.ReportViewer.Name = "ReportViewer";
            this.ReportViewer.Size = new System.Drawing.Size(498, 358);
            this.ReportViewer.TabIndex = 45;
            this.ReportViewer.Visible = false;
            // 
            // officersFKBindingSource
            // 
            this.officersFKBindingSource.DataMember = "OfficersFK";
            this.officersFKBindingSource.DataSource = this.bindingS;
            // 
            // OfficersTableAdapter
            // 
            this.OfficersTableAdapter.ClearBeforeFill = true;
            // 
            // s_udalTableAdapter
            // 
            this.s_udalTableAdapter.ClearBeforeFill = true;
            // 
            // CreateReport
            // 
            this.CreateReport.Location = new System.Drawing.Point(312, 283);
            this.CreateReport.Name = "CreateReport";
            this.CreateReport.Size = new System.Drawing.Size(147, 23);
            this.CreateReport.TabIndex = 46;
            this.CreateReport.Text = "Создать отчет";
            this.CreateReport.UseVisualStyleBackColor = true;
            this.CreateReport.Click += new System.EventHandler(this.CreateReport_Click);
            // 
            // reportViewer1
            // 
            reportDataSource3.Name = "officers";
            reportDataSource3.Value = this.OfficersBindingSource;
            reportDataSource4.Name = "Udal";
            reportDataSource4.Value = this.S_udalBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "OfficersForm.Report.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(558, 20);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(498, 358);
            this.reportViewer1.TabIndex = 47;
            // 
            // ViewOfficersDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1195, 443);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.CreateReport);
            this.Controls.Add(this.ReportViewer);
            this.Controls.Add(this.ModeChLB);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.NvbTB);
            this.Controls.Add(this.ErrorBox);
            this.Controls.Add(this.SearchModCB);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.OtchetListButton);
            this.Controls.Add(this.VrednTB);
            this.Controls.Add(this.DovolstvieL);
            this.Controls.Add(this.UdalTB);
            this.Controls.Add(this.DovolstvieTB);
            this.Controls.Add(this.VrednL);
            this.Controls.Add(this.UdalL);
            this.Controls.Add(this.SDolgnTB);
            this.Controls.Add(this.OfficersDGV);
            this.Controls.Add(this.SZvanTB);
            this.Controls.Add(this.NvbCB);
            this.Controls.Add(this.ZvanL);
            this.Controls.Add(this.StagL);
            this.Controls.Add(this.DolgnL);
            this.Controls.Add(this.BithdL);
            this.Controls.Add(this.FioL);
            this.Controls.Add(this.NvbL);
            this.Controls.Add(this.FioTB);
            this.Controls.Add(this.BithTB);
            this.Controls.Add(this.ZvanTB);
            this.Controls.Add(this.DolgnTB);
            this.Controls.Add(this.StagTB);
            this.Name = "ViewOfficersDB";
            this.Text = "Офицеры";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OfficersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.officersDS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.S_udalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sudalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OfficersDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.officersFKBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private OfficersDSTableAdapters.S_zvanTableAdapter s_zvanTA;
        private OfficersDSTableAdapters.S_dolgnTableAdapter s_dolgnTA;
        private Label UdalL;
        private Label VrednL;
        private TextBox DovolstvieTB;
        private TextBox UdalTB;
        private OfficersDSTableAdapters.F_udalTableAdapter f_udalTA;
        private OfficersDSTableAdapters.F_vrednTableAdapter f_vrednTA;
        private Label DovolstvieL;
        private TextBox VrednTB;
        private Button OtchetListButton;

        private Button SearchButton;
        private ComboBox SearchModCB;

        private void SearchButton_Click(object sender, EventArgs e)
        {
            switch (SearchModCB.SelectedIndex)
            {
                case 0:
                        if (FioTB.Text.Length != 0)
                        {
                            officersTA.SearchFillByFio(officersDS.Officers, FioTB.Text);
                            ErrorBox.Text = "Ок";
                        }
                        else
                            ErrorBox.Text = "Ошибка поиска по фамилии";
                    break;
                case 1:
                    if (NvbTB.Text.Length != 0)
                    {
                        officersTA.SearchFillByNvb(officersDS.Officers, NvbTB.Text);
                        ErrorBox.Text = "Ок";
                    }
                    else
                        ErrorBox.Text = "Ошибка поиска по номеру военного билета";
                    break;
                case 2:
                    if (ZvanTB.Text.Length != 0)
                    {
                        officersTA.SerachFillByZvan(officersDS.Officers, ZvanTB.Text);
                        ErrorBox.Text = "Ок";
                    }
                    else
                        ErrorBox.Text = "Ошибка поиска по званию";
                    break;
                case 3:
                    if (DolgnTB.Text.Length != 0)
                    {
                        officersTA.SearchFillByDolgn(officersDS.Officers, DolgnTB.Text);
                        ErrorBox.Text = "Ок";
                    }
                    else
                        ErrorBox.Text = "Ошибка поиска по должности";
                    break;
                case 4:
                    if (StagTB.Text.Length != 0)
                    {
                        //                        officersTA.SearchFillByStag(officersDS.Officers, );
                        ErrorBox.Text = "Ок";
                    }
                    else
                        ErrorBox.Text = "Ошибка поиска По удаленности";
                    break;
                case 5:
                    if (UdalTB.Text.Length != 0)
                    {
                        officersTA.SearchFillByDolgn(officersDS.Officers, UdalTB.Text);
                        ErrorBox.Text = "Ок";
                    }
                    else
                        ErrorBox.Text = "Ошибка поиска По удаленности";
                    break;
            }
        }

        private TextBox DolgnTB;
        private TextBox ZvanTB;
        private TextBox BithTB;
        private TextBox FioTB;
        private ComboBox NvbCB;
        private TextBox SZvanTB;
        private TextBox SDolgnTB;
        private TextBox NvbTB;
        private TextBox ErrorBox;
        private Button DeleteButton;
        private CheckedListBox ModeChLB;

        private void ModeChLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (ModeChLB.SelectedIndex)
            {
                case 0:
                    DeleteButton.Visible = false;
                    break;

            }
        }
        
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            
            DialogResult result;
            result = MessageBox.Show("Подтвердить Удаление записи с № военного билета " + NvbTB.Text.ToString() + "?", " Подтверждение удаления записи", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                f_udalTA.DeleteQuery(NvbTB.Text.ToString());
                f_vrednTA.DeleteQuery(NvbTB.Text.ToString());
                officersTA.DeleteQueryOfficers(NvbTB.Text.ToString());
                OfficersDGV.Refresh();
            }
            else if (result != DialogResult.No)
                ErrorBox.Text = "Ошибка удаления";
            
        }

        private Microsoft.Reporting.WinForms.ReportViewer ReportViewer;
        private BindingSource officersFKBindingSource;
        private BindingSource OfficersBindingSource;
        private OfficersDSTableAdapters.OfficersTableAdapter OfficersTableAdapter;
        private BindingSource sudalBindingSource;
        private OfficersDSTableAdapters.S_udalTableAdapter s_udalTableAdapter;



        private Button CreateReport;

        private void CreateReport_Click(object sender, EventArgs e)
        {
            ReportParameter[] Param = new ReportParameter[13];
            Param[0] = new ReportParameter("FIO", FioTB.Text.ToString());
            Param[1] = new ReportParameter("Nvb", NvbTB.Text.ToString());
            Param[2] = new ReportParameter("Zvan", ZvanTB.Text.ToString());
            Param[3] = new ReportParameter("SZvan", SZvanTB.Text.ToString());
            Param[4] = new ReportParameter("Dolgn", DolgnTB.Text.ToString());
            Param[5] = new ReportParameter("SDolgn", SDolgnTB.Text.ToString());
            Param[6] = new ReportParameter("Stag", StagTB.Text.ToString());
            Param[7] = new ReportParameter("SStag", (Double.Parse(SDolgnTB.Text.ToString())*Double.Parse(StagTB.Text.ToString()) / 100).ToString());
            Param[8] = new ReportParameter("Udal", UdalTB.Text.ToString());
            Param[9] = new ReportParameter("SUdal", f_udalTA.GetF_Udal(NvbTB.Text.ToString()).ToString() );
            Param[10] = new ReportParameter("Vredn", VrednTB.Text.ToString());
            Param[11] = new ReportParameter("SVredn", f_vrednTA.GetVredn(NvbTB.Text.ToString()).ToString());
            Param[12] = new ReportParameter("Dovolstvie", DovolstvieTB.Text.ToString());
            ReportViewer.LocalReport.SetParameters( Param );

            this.ReportViewer.RefreshReport();
            ReportViewer.Visible = true;
        }
        private BindingSource S_udalBindingSource;
        private ReportViewer reportViewer1;
    }
}
