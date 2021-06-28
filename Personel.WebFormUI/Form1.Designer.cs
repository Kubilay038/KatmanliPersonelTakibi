namespace Personel.WebFormUI
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbxSearch = new System.Windows.Forms.GroupBox();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.gbxUpdate = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblUpdateNumber = new System.Windows.Forms.Label();
            this.lblUpdateName = new System.Windows.Forms.Label();
            this.tbxUpdateName = new System.Windows.Forms.TextBox();
            this.lblUpdateAge = new System.Windows.Forms.Label();
            this.tbxUpdateNumber = new System.Windows.Forms.TextBox();
            this.tbxUpdateSurName = new System.Windows.Forms.TextBox();
            this.lblUpdateSurname = new System.Windows.Forms.Label();
            this.tbxUpdateAge = new System.Windows.Forms.TextBox();
            this.gbxAdd = new System.Windows.Forms.GroupBox();
            this.lblNumber = new System.Windows.Forms.Label();
            this.tbxNumber = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.tbxAge = new System.Windows.Forms.TextBox();
            this.lblSurname = new System.Windows.Forms.Label();
            this.tbxSurName = new System.Windows.Forms.TextBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.dgwPersonel = new System.Windows.Forms.DataGridView();
            this.gbxSearch.SuspendLayout();
            this.gbxUpdate.SuspendLayout();
            this.gbxAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwPersonel)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxSearch
            // 
            this.gbxSearch.Controls.Add(this.tbxSearch);
            this.gbxSearch.Controls.Add(this.lblSearch);
            this.gbxSearch.Location = new System.Drawing.Point(543, 272);
            this.gbxSearch.Name = "gbxSearch";
            this.gbxSearch.Size = new System.Drawing.Size(245, 69);
            this.gbxSearch.TabIndex = 35;
            this.gbxSearch.TabStop = false;
            this.gbxSearch.Text = "Ürün İsmine Göre Ara";
            // 
            // tbxSearch
            // 
            this.tbxSearch.Location = new System.Drawing.Point(56, 23);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(120, 20);
            this.tbxSearch.TabIndex = 1;
            this.tbxSearch.TextChanged += new System.EventHandler(this.tbxSearch_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(18, 23);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(23, 13);
            this.lblSearch.TabIndex = 0;
            this.lblSearch.Text = "Ara";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(626, 12);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 24);
            this.btnDelete.TabIndex = 34;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // gbxUpdate
            // 
            this.gbxUpdate.Controls.Add(this.btnUpdate);
            this.gbxUpdate.Controls.Add(this.lblUpdateNumber);
            this.gbxUpdate.Controls.Add(this.lblUpdateName);
            this.gbxUpdate.Controls.Add(this.tbxUpdateName);
            this.gbxUpdate.Controls.Add(this.lblUpdateAge);
            this.gbxUpdate.Controls.Add(this.tbxUpdateNumber);
            this.gbxUpdate.Controls.Add(this.tbxUpdateSurName);
            this.gbxUpdate.Controls.Add(this.lblUpdateSurname);
            this.gbxUpdate.Controls.Add(this.tbxUpdateAge);
            this.gbxUpdate.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbxUpdate.Location = new System.Drawing.Point(292, 255);
            this.gbxUpdate.Name = "gbxUpdate";
            this.gbxUpdate.Size = new System.Drawing.Size(240, 240);
            this.gbxUpdate.TabIndex = 33;
            this.gbxUpdate.TabStop = false;
            this.gbxUpdate.Text = "Personel Güncelle";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(125, 187);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblUpdateNumber
            // 
            this.lblUpdateNumber.AutoSize = true;
            this.lblUpdateNumber.Location = new System.Drawing.Point(4, 153);
            this.lblUpdateNumber.Name = "lblUpdateNumber";
            this.lblUpdateNumber.Size = new System.Drawing.Size(90, 13);
            this.lblUpdateNumber.TabIndex = 24;
            this.lblUpdateNumber.Text = "Telefon Numarası";
            // 
            // lblUpdateName
            // 
            this.lblUpdateName.AutoSize = true;
            this.lblUpdateName.Location = new System.Drawing.Point(20, 33);
            this.lblUpdateName.Name = "lblUpdateName";
            this.lblUpdateName.Size = new System.Drawing.Size(26, 13);
            this.lblUpdateName.TabIndex = 14;
            this.lblUpdateName.Text = "İsim";
            // 
            // tbxUpdateName
            // 
            this.tbxUpdateName.Location = new System.Drawing.Point(100, 33);
            this.tbxUpdateName.Name = "tbxUpdateName";
            this.tbxUpdateName.Size = new System.Drawing.Size(100, 21);
            this.tbxUpdateName.TabIndex = 17;
            // 
            // lblUpdateAge
            // 
            this.lblUpdateAge.AutoSize = true;
            this.lblUpdateAge.Location = new System.Drawing.Point(20, 112);
            this.lblUpdateAge.Name = "lblUpdateAge";
            this.lblUpdateAge.Size = new System.Drawing.Size(24, 13);
            this.lblUpdateAge.TabIndex = 16;
            this.lblUpdateAge.Text = "Yaş";
            // 
            // tbxUpdateNumber
            // 
            this.tbxUpdateNumber.Location = new System.Drawing.Point(100, 150);
            this.tbxUpdateNumber.Name = "tbxUpdateNumber";
            this.tbxUpdateNumber.Size = new System.Drawing.Size(100, 21);
            this.tbxUpdateNumber.TabIndex = 21;
            // 
            // tbxUpdateSurName
            // 
            this.tbxUpdateSurName.Location = new System.Drawing.Point(100, 73);
            this.tbxUpdateSurName.Name = "tbxUpdateSurName";
            this.tbxUpdateSurName.Size = new System.Drawing.Size(100, 21);
            this.tbxUpdateSurName.TabIndex = 18;
            // 
            // lblUpdateSurname
            // 
            this.lblUpdateSurname.AutoSize = true;
            this.lblUpdateSurname.Location = new System.Drawing.Point(20, 73);
            this.lblUpdateSurname.Name = "lblUpdateSurname";
            this.lblUpdateSurname.Size = new System.Drawing.Size(44, 13);
            this.lblUpdateSurname.TabIndex = 15;
            this.lblUpdateSurname.Text = "Soyİsim";
            // 
            // tbxUpdateAge
            // 
            this.tbxUpdateAge.Location = new System.Drawing.Point(100, 109);
            this.tbxUpdateAge.Name = "tbxUpdateAge";
            this.tbxUpdateAge.Size = new System.Drawing.Size(100, 21);
            this.tbxUpdateAge.TabIndex = 19;
            // 
            // gbxAdd
            // 
            this.gbxAdd.Controls.Add(this.lblNumber);
            this.gbxAdd.Controls.Add(this.tbxNumber);
            this.gbxAdd.Controls.Add(this.btnAdd);
            this.gbxAdd.Controls.Add(this.lblName);
            this.gbxAdd.Controls.Add(this.tbxAge);
            this.gbxAdd.Controls.Add(this.lblSurname);
            this.gbxAdd.Controls.Add(this.tbxSurName);
            this.gbxAdd.Controls.Add(this.lblAge);
            this.gbxAdd.Controls.Add(this.tbxName);
            this.gbxAdd.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbxAdd.Location = new System.Drawing.Point(18, 255);
            this.gbxAdd.Name = "gbxAdd";
            this.gbxAdd.Size = new System.Drawing.Size(240, 240);
            this.gbxAdd.TabIndex = 32;
            this.gbxAdd.TabStop = false;
            this.gbxAdd.Text = "Personel Ekle";
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(3, 158);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(90, 13);
            this.lblNumber.TabIndex = 12;
            this.lblNumber.Text = "Telefon Numarası";
            // 
            // tbxNumber
            // 
            this.tbxNumber.Location = new System.Drawing.Point(99, 150);
            this.tbxNumber.Name = "tbxNumber";
            this.tbxNumber.Size = new System.Drawing.Size(100, 21);
            this.tbxNumber.TabIndex = 9;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(124, 187);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(19, 42);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(26, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "İsim";
            // 
            // tbxAge
            // 
            this.tbxAge.Location = new System.Drawing.Point(99, 118);
            this.tbxAge.Name = "tbxAge";
            this.tbxAge.Size = new System.Drawing.Size(100, 21);
            this.tbxAge.TabIndex = 6;
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(19, 82);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(44, 13);
            this.lblSurname.TabIndex = 2;
            this.lblSurname.Text = "Soyİsim";
            // 
            // tbxSurName
            // 
            this.tbxSurName.Location = new System.Drawing.Point(99, 82);
            this.tbxSurName.Name = "tbxSurName";
            this.tbxSurName.Size = new System.Drawing.Size(100, 21);
            this.tbxSurName.TabIndex = 5;
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(19, 121);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(24, 13);
            this.lblAge.TabIndex = 3;
            this.lblAge.Text = "Yaş";
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(99, 42);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(100, 21);
            this.tbxName.TabIndex = 4;
            // 
            // dgwPersonel
            // 
            this.dgwPersonel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwPersonel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwPersonel.Location = new System.Drawing.Point(21, 42);
            this.dgwPersonel.Name = "dgwPersonel";
            this.dgwPersonel.Size = new System.Drawing.Size(770, 207);
            this.dgwPersonel.TabIndex = 31;
            this.dgwPersonel.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwPersonel_CellClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 513);
            this.Controls.Add(this.gbxSearch);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.gbxUpdate);
            this.Controls.Add(this.gbxAdd);
            this.Controls.Add(this.dgwPersonel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbxSearch.ResumeLayout(false);
            this.gbxSearch.PerformLayout();
            this.gbxUpdate.ResumeLayout(false);
            this.gbxUpdate.PerformLayout();
            this.gbxAdd.ResumeLayout(false);
            this.gbxAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwPersonel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxSearch;
        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox gbxUpdate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblUpdateNumber;
        private System.Windows.Forms.Label lblUpdateName;
        private System.Windows.Forms.TextBox tbxUpdateName;
        private System.Windows.Forms.Label lblUpdateAge;
        private System.Windows.Forms.TextBox tbxUpdateNumber;
        private System.Windows.Forms.TextBox tbxUpdateSurName;
        private System.Windows.Forms.Label lblUpdateSurname;
        private System.Windows.Forms.TextBox tbxUpdateAge;
        private System.Windows.Forms.GroupBox gbxAdd;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.TextBox tbxNumber;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox tbxAge;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.TextBox tbxSurName;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.DataGridView dgwPersonel;
    }
}

