namespace check_station
{
    partial class form_check_station
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
            btnCheckStation = new Button();
            dataGridView1 = new DataGridView();
            Modelo = new DataGridViewTextBoxColumn();
            Versao = new DataGridViewTextBoxColumn();
            Serial = new DataGridViewTextBoxColumn();
            Fabricante = new DataGridViewTextBoxColumn();
            SDKAndroid = new DataGridViewTextBoxColumn();
            Operadora = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnCheckStation
            // 
            btnCheckStation.Font = new Font("Segoe UI", 10F);
            btnCheckStation.Location = new Point(29, 521);
            btnCheckStation.Name = "btnCheckStation";
            btnCheckStation.Size = new Size(414, 105);
            btnCheckStation.TabIndex = 1;
            btnCheckStation.Text = "CHECK STATION";
            btnCheckStation.UseVisualStyleBackColor = true;
            btnCheckStation.Click += btnCheckStation_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Modelo, Versao, Serial, Fabricante, SDKAndroid, Operadora });
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1025, 311);
            dataGridView1.TabIndex = 10;
            // 
            // Modelo
            // 
            Modelo.HeaderText = "Modelo";
            Modelo.MinimumWidth = 8;
            Modelo.Name = "Modelo";
            Modelo.Width = 150;
            // 
            // Versao
            // 
            Versao.HeaderText = "Versao";
            Versao.MinimumWidth = 8;
            Versao.Name = "Versao";
            Versao.Width = 150;
            // 
            // Serial
            // 
            Serial.HeaderText = "Serial";
            Serial.MinimumWidth = 8;
            Serial.Name = "Serial";
            Serial.Width = 150;
            // 
            // Fabricante
            // 
            Fabricante.HeaderText = "Fabricante";
            Fabricante.MinimumWidth = 8;
            Fabricante.Name = "Fabricante";
            Fabricante.Width = 150;
            // 
            // SDKAndroid
            // 
            SDKAndroid.HeaderText = "SDKAndroid";
            SDKAndroid.MinimumWidth = 8;
            SDKAndroid.Name = "SDKAndroid";
            SDKAndroid.Width = 150;
            // 
            // Operadora
            // 
            Operadora.HeaderText = "Operadora";
            Operadora.MinimumWidth = 8;
            Operadora.Name = "Operadora";
            Operadora.Width = 150;
            // 
            // form_check_station
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1049, 675);
            Controls.Add(dataGridView1);
            Controls.Add(btnCheckStation);
            FormBorderStyle = FormBorderStyle.None;
            Name = "form_check_station";
            Text = "form_check_station";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnCheckStation;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Modelo;
        private DataGridViewTextBoxColumn Versao;
        private DataGridViewTextBoxColumn Serial;
        private DataGridViewTextBoxColumn Fabricante;
        private DataGridViewTextBoxColumn SDKAndroid;
        private DataGridViewTextBoxColumn Operadora;
    }
}