namespace Esoft_project
{
    partial class FormDeal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDeal));
            this.labelCustomerCompanyDeductions = new System.Windows.Forms.Label();
            this.labelAgentSellerDeductions = new System.Windows.Forms.Label();
            this.labelSellerCompanyDeductions = new System.Windows.Forms.Label();
            this.labelDemand = new System.Windows.Forms.Label();
            this.labelSupply = new System.Windows.Forms.Label();
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.listViewDealSet = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.comboBoxDemand = new System.Windows.Forms.ComboBox();
            this.comboBoxSupply = new System.Windows.Forms.ComboBox();
            this.textBoxAgentCustomerDeductions = new System.Windows.Forms.TextBox();
            this.textCustomerCompanyDeductions = new System.Windows.Forms.TextBox();
            this.textBoxAgentSellerDeductions = new System.Windows.Forms.TextBox();
            this.textBoxSellerCompanyDeductions = new System.Windows.Forms.TextBox();
            this.labelAgentCustomerDeductions = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCustomerCompanyDeductions
            // 
            this.labelCustomerCompanyDeductions.AutoSize = true;
            this.labelCustomerCompanyDeductions.Location = new System.Drawing.Point(15, 340);
            this.labelCustomerCompanyDeductions.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCustomerCompanyDeductions.Name = "labelCustomerCompanyDeductions";
            this.labelCustomerCompanyDeductions.Size = new System.Drawing.Size(278, 17);
            this.labelCustomerCompanyDeductions.TabIndex = 74;
            this.labelCustomerCompanyDeductions.Text = "Cтоимость услуги для клиента-продавца";
            // 
            // labelAgentSellerDeductions
            // 
            this.labelAgentSellerDeductions.AutoSize = true;
            this.labelAgentSellerDeductions.Location = new System.Drawing.Point(15, 292);
            this.labelAgentSellerDeductions.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAgentSellerDeductions.Name = "labelAgentSellerDeductions";
            this.labelAgentSellerDeductions.Size = new System.Drawing.Size(281, 17);
            this.labelAgentSellerDeductions.TabIndex = 73;
            this.labelAgentSellerDeductions.Text = "Отчисление риелтору клинета-продавца";
            // 
            // labelSellerCompanyDeductions
            // 
            this.labelSellerCompanyDeductions.AutoSize = true;
            this.labelSellerCompanyDeductions.Location = new System.Drawing.Point(15, 244);
            this.labelSellerCompanyDeductions.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSellerCompanyDeductions.Name = "labelSellerCompanyDeductions";
            this.labelSellerCompanyDeductions.Size = new System.Drawing.Size(278, 17);
            this.labelSellerCompanyDeductions.TabIndex = 72;
            this.labelSellerCompanyDeductions.Text = "Стоимость услуги для клиента-продавца";
            // 
            // labelDemand
            // 
            this.labelDemand.AutoSize = true;
            this.labelDemand.Location = new System.Drawing.Point(11, 97);
            this.labelDemand.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDemand.Name = "labelDemand";
            this.labelDemand.Size = new System.Drawing.Size(94, 17);
            this.labelDemand.TabIndex = 71;
            this.labelDemand.Text = "Потребность";
            // 
            // labelSupply
            // 
            this.labelSupply.AutoSize = true;
            this.labelSupply.Location = new System.Drawing.Point(10, 164);
            this.labelSupply.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSupply.Name = "labelSupply";
            this.labelSupply.Size = new System.Drawing.Size(99, 17);
            this.labelSupply.TabIndex = 70;
            this.labelSupply.Text = "Предложение";
            // 
            // buttonDel
            // 
            this.buttonDel.Location = new System.Drawing.Point(1197, 372);
            this.buttonDel.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(267, 59);
            this.buttonDel.TabIndex = 69;
            this.buttonDel.Text = "Удалить";
            this.buttonDel.UseVisualStyleBackColor = true;
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(859, 372);
            this.buttonEdit.Margin = new System.Windows.Forms.Padding(4);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(267, 59);
            this.buttonEdit.TabIndex = 68;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = true;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(535, 372);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(267, 59);
            this.buttonAdd.TabIndex = 67;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            // 
            // listViewDealSet
            // 
            this.listViewDealSet.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listViewDealSet.FullRowSelect = true;
            this.listViewDealSet.GridLines = true;
            this.listViewDealSet.HideSelection = false;
            this.listViewDealSet.Location = new System.Drawing.Point(390, 43);
            this.listViewDealSet.Margin = new System.Windows.Forms.Padding(4);
            this.listViewDealSet.MultiSelect = false;
            this.listViewDealSet.Name = "listViewDealSet";
            this.listViewDealSet.Size = new System.Drawing.Size(1119, 314);
            this.listViewDealSet.TabIndex = 66;
            this.listViewDealSet.UseCompatibleStateImageBehavior = false;
            this.listViewDealSet.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Клиент-продавец";
            this.columnHeader1.Width = 106;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Риелтор клиента-продавца";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Клиент-покупатель";
            this.columnHeader3.Width = 113;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Риелтор клиента-покупателя";
            this.columnHeader4.Width = 159;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Адрес объекта недвижимости";
            this.columnHeader5.Width = 181;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Стоимость ";
            this.columnHeader6.Width = 260;
            // 
            // comboBoxDemand
            // 
            this.comboBoxDemand.FormattingEnabled = true;
            this.comboBoxDemand.Location = new System.Drawing.Point(13, 185);
            this.comboBoxDemand.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxDemand.Name = "comboBoxDemand";
            this.comboBoxDemand.Size = new System.Drawing.Size(304, 24);
            this.comboBoxDemand.TabIndex = 65;
            // 
            // comboBoxSupply
            // 
            this.comboBoxSupply.FormattingEnabled = true;
            this.comboBoxSupply.Location = new System.Drawing.Point(13, 118);
            this.comboBoxSupply.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxSupply.Name = "comboBoxSupply";
            this.comboBoxSupply.Size = new System.Drawing.Size(304, 24);
            this.comboBoxSupply.TabIndex = 64;
            // 
            // textBoxAgentCustomerDeductions
            // 
            this.textBoxAgentCustomerDeductions.Location = new System.Drawing.Point(15, 415);
            this.textBoxAgentCustomerDeductions.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxAgentCustomerDeductions.Name = "textBoxAgentCustomerDeductions";
            this.textBoxAgentCustomerDeductions.Size = new System.Drawing.Size(304, 22);
            this.textBoxAgentCustomerDeductions.TabIndex = 63;
            // 
            // textCustomerCompanyDeductions
            // 
            this.textCustomerCompanyDeductions.Location = new System.Drawing.Point(15, 366);
            this.textCustomerCompanyDeductions.Margin = new System.Windows.Forms.Padding(4);
            this.textCustomerCompanyDeductions.Name = "textCustomerCompanyDeductions";
            this.textCustomerCompanyDeductions.Size = new System.Drawing.Size(304, 22);
            this.textCustomerCompanyDeductions.TabIndex = 62;
            // 
            // textBoxAgentSellerDeductions
            // 
            this.textBoxAgentSellerDeductions.Location = new System.Drawing.Point(15, 312);
            this.textBoxAgentSellerDeductions.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxAgentSellerDeductions.Name = "textBoxAgentSellerDeductions";
            this.textBoxAgentSellerDeductions.Size = new System.Drawing.Size(304, 22);
            this.textBoxAgentSellerDeductions.TabIndex = 61;
            // 
            // textBoxSellerCompanyDeductions
            // 
            this.textBoxSellerCompanyDeductions.Location = new System.Drawing.Point(15, 264);
            this.textBoxSellerCompanyDeductions.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSellerCompanyDeductions.Name = "textBoxSellerCompanyDeductions";
            this.textBoxSellerCompanyDeductions.Size = new System.Drawing.Size(304, 22);
            this.textBoxSellerCompanyDeductions.TabIndex = 60;
            // 
            // labelAgentCustomerDeductions
            // 
            this.labelAgentCustomerDeductions.AutoSize = true;
            this.labelAgentCustomerDeductions.Location = new System.Drawing.Point(15, 394);
            this.labelAgentCustomerDeductions.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAgentCustomerDeductions.Name = "labelAgentCustomerDeductions";
            this.labelAgentCustomerDeductions.Size = new System.Drawing.Size(295, 17);
            this.labelAgentCustomerDeductions.TabIndex = 75;
            this.labelAgentCustomerDeductions.Text = "Отчисление риелтору клиента-покупателя";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(339, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 76;
            this.pictureBox1.TabStop = false;
            // 
            // FormDeal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1582, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelAgentCustomerDeductions);
            this.Controls.Add(this.labelCustomerCompanyDeductions);
            this.Controls.Add(this.labelAgentSellerDeductions);
            this.Controls.Add(this.labelSellerCompanyDeductions);
            this.Controls.Add(this.labelDemand);
            this.Controls.Add(this.labelSupply);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.listViewDealSet);
            this.Controls.Add(this.comboBoxDemand);
            this.Controls.Add(this.comboBoxSupply);
            this.Controls.Add(this.textBoxAgentCustomerDeductions);
            this.Controls.Add(this.textCustomerCompanyDeductions);
            this.Controls.Add(this.textBoxAgentSellerDeductions);
            this.Controls.Add(this.textBoxSellerCompanyDeductions);
            this.Name = "FormDeal";
            this.Text = "Сделки";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCustomerCompanyDeductions;
        private System.Windows.Forms.Label labelAgentSellerDeductions;
        private System.Windows.Forms.Label labelSellerCompanyDeductions;
        private System.Windows.Forms.Label labelDemand;
        private System.Windows.Forms.Label labelSupply;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ListView listViewDealSet;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ComboBox comboBoxDemand;
        private System.Windows.Forms.ComboBox comboBoxSupply;
        private System.Windows.Forms.TextBox textBoxAgentCustomerDeductions;
        private System.Windows.Forms.TextBox textCustomerCompanyDeductions;
        private System.Windows.Forms.TextBox textBoxAgentSellerDeductions;
        private System.Windows.Forms.TextBox textBoxSellerCompanyDeductions;
        private System.Windows.Forms.Label labelAgentCustomerDeductions;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}