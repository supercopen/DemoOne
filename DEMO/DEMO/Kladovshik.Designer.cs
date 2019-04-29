namespace DEMO
{
    partial class Kladovshik
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
            this.components = new System.ComponentModel.Container();
            this.demo_exDataSet = new DEMO.Demo_exDataSet();
            this.пользовательBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.пользовательTableAdapter = new DEMO.Demo_exDataSetTableAdapters.ПользовательTableAdapter();
            this.tableAdapterManager = new DEMO.Demo_exDataSetTableAdapters.TableAdapterManager();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.спискиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.тканиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.фурнитураToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.demo_exDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.пользовательBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // demo_exDataSet
            // 
            this.demo_exDataSet.DataSetName = "Demo_exDataSet";
            this.demo_exDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // пользовательBindingSource
            // 
            this.пользовательBindingSource.DataMember = "Пользователь";
            this.пользовательBindingSource.DataSource = this.demo_exDataSet;
            // 
            // пользовательTableAdapter
            // 
            this.пользовательTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = DEMO.Demo_exDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ЗаказTableAdapter = null;
            this.tableAdapterManager.Заказанные_изделияTableAdapter = null;
            this.tableAdapterManager.ИзделиеTableAdapter = null;
            this.tableAdapterManager.ПользовательTableAdapter = this.пользовательTableAdapter;
            this.tableAdapterManager.Склад_тканиTableAdapter = null;
            this.tableAdapterManager.Склад_фурнитурыTableAdapter = null;
            this.tableAdapterManager.Ткани_изделияTableAdapter = null;
            this.tableAdapterManager.ТканьTableAdapter = null;
            this.tableAdapterManager.Фурнитура_изделияTableAdapter = null;
            this.tableAdapterManager.ФурнитураTableAdapter = null;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.спискиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(658, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // спискиToolStripMenuItem
            // 
            this.спискиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.тканиToolStripMenuItem,
            this.фурнитураToolStripMenuItem});
            this.спискиToolStripMenuItem.Name = "спискиToolStripMenuItem";
            this.спискиToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.спискиToolStripMenuItem.Text = "Списки";
            // 
            // тканиToolStripMenuItem
            // 
            this.тканиToolStripMenuItem.Name = "тканиToolStripMenuItem";
            this.тканиToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.тканиToolStripMenuItem.Text = "Ткани";
            this.тканиToolStripMenuItem.Click += new System.EventHandler(this.тканиToolStripMenuItem_Click);
            // 
            // фурнитураToolStripMenuItem
            // 
            this.фурнитураToolStripMenuItem.Name = "фурнитураToolStripMenuItem";
            this.фурнитураToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.фурнитураToolStripMenuItem.Text = "Фурнитура";
            this.фурнитураToolStripMenuItem.Click += new System.EventHandler(this.фурнитураToolStripMenuItem_Click);
            // 
            // Kladovshik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 449);
            this.ControlBox = false;
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Kladovshik";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "                                                                  Экран \"Кладовщи" +
    "ка\"";
            this.Load += new System.EventHandler(this.Kladovshik_Load);
            ((System.ComponentModel.ISupportInitialize)(this.demo_exDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.пользовательBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Demo_exDataSet demo_exDataSet;
        private System.Windows.Forms.BindingSource пользовательBindingSource;
        private Demo_exDataSetTableAdapters.ПользовательTableAdapter пользовательTableAdapter;
        private Demo_exDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem спискиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem тканиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem фурнитураToolStripMenuItem;
    }
}