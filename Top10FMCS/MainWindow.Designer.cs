namespace Top10FMCS
{
    partial class MainWindow
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.listSongs = new System.Windows.Forms.ListBox();
            this.textSong = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonGolos = new System.Windows.Forms.Button();
            this.listGolos = new System.Windows.Forms.ListBox();
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonItog = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listSongs
            // 
            this.listSongs.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listSongs.FormattingEnabled = true;
            this.listSongs.ItemHeight = 29;
            this.listSongs.Location = new System.Drawing.Point(50, 53);
            this.listSongs.Name = "listSongs";
            this.listSongs.Size = new System.Drawing.Size(267, 236);
            this.listSongs.TabIndex = 0;
            // 
            // textSong
            // 
            this.textSong.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textSong.Location = new System.Drawing.Point(49, 304);
            this.textSong.Name = "textSong";
            this.textSong.Size = new System.Drawing.Size(267, 35);
            this.textSong.TabIndex = 1;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.Location = new System.Drawing.Point(39, 356);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(300, 48);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "Добавить исполнителя";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonGolos
            // 
            this.buttonGolos.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonGolos.Location = new System.Drawing.Point(467, 41);
            this.buttonGolos.Name = "buttonGolos";
            this.buttonGolos.Size = new System.Drawing.Size(264, 43);
            this.buttonGolos.TabIndex = 3;
            this.buttonGolos.Text = "голосую";
            this.buttonGolos.UseVisualStyleBackColor = true;
            this.buttonGolos.Click += new System.EventHandler(this.buttonGolos_Click);
            // 
            // listGolos
            // 
            this.listGolos.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listGolos.FormattingEnabled = true;
            this.listGolos.ItemHeight = 29;
            this.listGolos.Location = new System.Drawing.Point(467, 90);
            this.listGolos.Name = "listGolos";
            this.listGolos.Size = new System.Drawing.Size(264, 149);
            this.listGolos.TabIndex = 4;
            // 
            // buttonDel
            // 
            this.buttonDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDel.Location = new System.Drawing.Point(467, 256);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(264, 42);
            this.buttonDel.TabIndex = 5;
            this.buttonDel.Text = "удалить";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // buttonOk
            // 
            this.buttonOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOk.Location = new System.Drawing.Point(467, 304);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(264, 42);
            this.buttonOk.TabIndex = 6;
            this.buttonOk.Text = "готово";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonItog
            // 
            this.buttonItog.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonItog.Location = new System.Drawing.Point(455, 363);
            this.buttonItog.Name = "buttonItog";
            this.buttonItog.Size = new System.Drawing.Size(299, 41);
            this.buttonItog.TabIndex = 7;
            this.buttonItog.Text = "ИТОГИ ГОЛОСОВАНИЯ";
            this.buttonItog.UseVisualStyleBackColor = true;
            this.buttonItog.Click += new System.EventHandler(this.buttonItog_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Список исполнителей";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonItog);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.listGolos);
            this.Controls.Add(this.buttonGolos);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textSong);
            this.Controls.Add(this.listSongs);
            this.Name = "MainWindow";
            this.Text = "ТОР10 факультета математики и компьютерных наук";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listSongs;
        private System.Windows.Forms.TextBox textSong;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonGolos;
        private System.Windows.Forms.ListBox listGolos;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonItog;
        private System.Windows.Forms.Label label1;
    }
}

