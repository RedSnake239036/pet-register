
namespace pet_register
{
    partial class Pet_Register
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.select = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pet_category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sex_pet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pet_birth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pet_tagID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tagID_pet_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pet_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pet_photo = new System.Windows.Forms.DataGridViewImageColumn();
            this.owner_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.select,
            this.ID,
            this.pet_category,
            this.sex_pet,
            this.pet_birth,
            this.pet_tagID,
            this.tagID_pet_number,
            this.pet_name,
            this.pet_photo,
            this.owner_name,
            this.edit,
            this.delete});
            this.dataGridView1.Location = new System.Drawing.Point(12, 45);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(1243, 393);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OpenRecord);
            // 
            // select
            // 
            this.select.HeaderText = "Выбор";
            this.select.Name = "select";
            this.select.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // pet_category
            // 
            this.pet_category.HeaderText = "Категория животного";
            this.pet_category.Name = "pet_category";
            // 
            // sex_pet
            // 
            this.sex_pet.HeaderText = "Пол животного";
            this.sex_pet.Name = "sex_pet";
            // 
            // pet_birth
            // 
            this.pet_birth.HeaderText = "Год рождения питомца";
            this.pet_birth.Name = "pet_birth";
            // 
            // pet_tagID
            // 
            this.pet_tagID.HeaderText = "Идентификационная метка";
            this.pet_tagID.Name = "pet_tagID";
            // 
            // tagID_pet_number
            // 
            this.tagID_pet_number.HeaderText = "Номер электронного чипа";
            this.tagID_pet_number.Name = "tagID_pet_number";
            this.tagID_pet_number.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // pet_name
            // 
            this.pet_name.HeaderText = "Кличка животного";
            this.pet_name.Name = "pet_name";
            // 
            // pet_photo
            // 
            this.pet_photo.HeaderText = "Фото";
            this.pet_photo.Name = "pet_photo";
            // 
            // owner_name
            // 
            this.owner_name.HeaderText = "ФИО владельца";
            this.owner_name.Name = "owner_name";
            // 
            // edit
            // 
            this.edit.HeaderText = "Редактировать";
            this.edit.Name = "edit";
            // 
            // delete
            // 
            this.delete.HeaderText = "Удалить";
            this.delete.Name = "delete";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Параметр 1",
            "Параметр 2",
            "Параметр ...",
            "Параметр N"});
            this.comboBox1.Location = new System.Drawing.Point(1134, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1018, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Группировать по...";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Pet_Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1270, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Pet_Register";
            this.Text = "Реестр учета домашних животных";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn select;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn pet_category;
        private System.Windows.Forms.DataGridViewTextBoxColumn sex_pet;
        private System.Windows.Forms.DataGridViewTextBoxColumn pet_birth;
        private System.Windows.Forms.DataGridViewTextBoxColumn pet_tagID;
        private System.Windows.Forms.DataGridViewTextBoxColumn tagID_pet_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn pet_name;
        private System.Windows.Forms.DataGridViewImageColumn pet_photo;
        private System.Windows.Forms.DataGridViewTextBoxColumn owner_name;
        private System.Windows.Forms.DataGridViewButtonColumn edit;
        private System.Windows.Forms.DataGridViewButtonColumn delete;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}