namespace ProyectoChat
{
    partial class ChatForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChatForm));
            this.labUsername = new System.Windows.Forms.Label();
            this.gbUsername = new System.Windows.Forms.GroupBox();
            this.rbRegistro = new System.Windows.Forms.RadioButton();
            this.rbLogin = new System.Windows.Forms.RadioButton();
            this.tbPassw = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.labPassw = new System.Windows.Forms.Label();
            this.labName = new System.Windows.Forms.Label();
            this.panelChat = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.tbMensaje = new System.Windows.Forms.TextBox();
            this.dgvChat = new System.Windows.Forms.DataGridView();
            this.btnLogout = new System.Windows.Forms.Button();
            this.labHL = new System.Windows.Forms.Label();
            this.pbChat = new System.Windows.Forms.PictureBox();
            this.pbWelcome = new System.Windows.Forms.PictureBox();
            this.gbUsername.SuspendLayout();
            this.panelChat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbChat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWelcome)).BeginInit();
            this.SuspendLayout();
            // 
            // labUsername
            // 
            this.labUsername.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(142)))), ((int)(((byte)(128)))));
            this.labUsername.Location = new System.Drawing.Point(146, 9);
            this.labUsername.Name = "labUsername";
            this.labUsername.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labUsername.Size = new System.Drawing.Size(256, 40);
            this.labUsername.TabIndex = 0;
            this.labUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbUsername
            // 
            this.gbUsername.Controls.Add(this.rbRegistro);
            this.gbUsername.Controls.Add(this.rbLogin);
            this.gbUsername.Controls.Add(this.tbPassw);
            this.gbUsername.Controls.Add(this.tbName);
            this.gbUsername.Controls.Add(this.labPassw);
            this.gbUsername.Controls.Add(this.labName);
            this.gbUsername.Location = new System.Drawing.Point(13, 9);
            this.gbUsername.Name = "gbUsername";
            this.gbUsername.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gbUsername.Size = new System.Drawing.Size(470, 73);
            this.gbUsername.TabIndex = 6;
            this.gbUsername.TabStop = false;
            // 
            // rbRegistro
            // 
            this.rbRegistro.AutoSize = true;
            this.rbRegistro.Location = new System.Drawing.Point(62, 0);
            this.rbRegistro.Name = "rbRegistro";
            this.rbRegistro.Padding = new System.Windows.Forms.Padding(10, 0, 5, 0);
            this.rbRegistro.Size = new System.Drawing.Size(79, 17);
            this.rbRegistro.TabIndex = 4;
            this.rbRegistro.Text = "Registro";
            this.rbRegistro.UseVisualStyleBackColor = true;
            this.rbRegistro.CheckedChanged += new System.EventHandler(this.rbRegistro_CheckedChanged);
            // 
            // rbLogin
            // 
            this.rbLogin.AutoSize = true;
            this.rbLogin.Checked = true;
            this.rbLogin.Location = new System.Drawing.Point(1, 0);
            this.rbLogin.Name = "rbLogin";
            this.rbLogin.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.rbLogin.Size = new System.Drawing.Size(61, 17);
            this.rbLogin.TabIndex = 3;
            this.rbLogin.TabStop = true;
            this.rbLogin.Text = "Login";
            this.rbLogin.UseVisualStyleBackColor = true;
            this.rbLogin.Click += new System.EventHandler(this.rbLogin_Click);
            // 
            // tbPassw
            // 
            this.tbPassw.Location = new System.Drawing.Point(314, 40);
            this.tbPassw.Name = "tbPassw";
            this.tbPassw.Size = new System.Drawing.Size(150, 20);
            this.tbPassw.TabIndex = 2;
            this.tbPassw.UseSystemPasswordChar = true;
            this.tbPassw.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbPassw_KeyDown);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(56, 40);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(150, 20);
            this.tbName.TabIndex = 1;
            // 
            // labPassw
            // 
            this.labPassw.AutoSize = true;
            this.labPassw.Location = new System.Drawing.Point(247, 43);
            this.labPassw.Name = "labPassw";
            this.labPassw.Size = new System.Drawing.Size(61, 13);
            this.labPassw.TabIndex = 1;
            this.labPassw.Text = "Contraseña";
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.Location = new System.Drawing.Point(6, 43);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(44, 13);
            this.labName.TabIndex = 0;
            this.labName.Text = "Nombre";
            // 
            // panelChat
            // 
            this.panelChat.Controls.Add(this.btnRefresh);
            this.panelChat.Controls.Add(this.btnSend);
            this.panelChat.Controls.Add(this.tbMensaje);
            this.panelChat.Controls.Add(this.dgvChat);
            this.panelChat.Location = new System.Drawing.Point(13, 92);
            this.panelChat.Name = "panelChat";
            this.panelChat.Size = new System.Drawing.Size(470, 305);
            this.panelChat.TabIndex = 6;
            this.panelChat.Visible = false;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(198, 279);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "Refrescar";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(3, 6);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 22);
            this.btnSend.TabIndex = 1;
            this.btnSend.Text = "Enviar";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // tbMensaje
            // 
            this.tbMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMensaje.Location = new System.Drawing.Point(89, 7);
            this.tbMensaje.Name = "tbMensaje";
            this.tbMensaje.Size = new System.Drawing.Size(377, 20);
            this.tbMensaje.TabIndex = 5;
            this.tbMensaje.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbMensaje_KeyDown);
            // 
            // dgvChat
            // 
            this.dgvChat.AllowUserToAddRows = false;
            this.dgvChat.AllowUserToDeleteRows = false;
            this.dgvChat.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvChat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChat.Location = new System.Drawing.Point(5, 44);
            this.dgvChat.Name = "dgvChat";
            this.dgvChat.Size = new System.Drawing.Size(461, 224);
            this.dgvChat.TabIndex = 3;
            // 
            // btnLogout
            // 
            this.btnLogout.CausesValidation = false;
            this.btnLogout.Location = new System.Drawing.Point(402, 18);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 9;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // labHL
            // 
            this.labHL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(142)))), ((int)(((byte)(128)))));
            this.labHL.Location = new System.Drawing.Point(166, 60);
            this.labHL.Name = "labHL";
            this.labHL.Size = new System.Drawing.Size(310, 2);
            this.labHL.TabIndex = 10;
            this.labHL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labHL.Paint += new System.Windows.Forms.PaintEventHandler(this.labHL_Paint);
            // 
            // pbChat
            // 
            this.pbChat.Image = global::ProyectoChat.Properties.Resources.chat_logo;
            this.pbChat.Location = new System.Drawing.Point(14, 24);
            this.pbChat.Name = "pbChat";
            this.pbChat.Size = new System.Drawing.Size(150, 50);
            this.pbChat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbChat.TabIndex = 7;
            this.pbChat.TabStop = false;
            // 
            // pbWelcome
            // 
            this.pbWelcome.Image = global::ProyectoChat.Properties.Resources.welcome;
            this.pbWelcome.Location = new System.Drawing.Point(14, 121);
            this.pbWelcome.Name = "pbWelcome";
            this.pbWelcome.Size = new System.Drawing.Size(468, 227);
            this.pbWelcome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbWelcome.TabIndex = 8;
            this.pbWelcome.TabStop = false;
            // 
            // ChatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 406);
            this.Controls.Add(this.panelChat);
            this.Controls.Add(this.gbUsername);
            this.Controls.Add(this.labUsername);
            this.Controls.Add(this.pbChat);
            this.Controls.Add(this.pbWelcome);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.labHL);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ChatForm";
            this.Text = "Chat";
            this.Load += new System.EventHandler(this.ChatForm_Load);
            this.gbUsername.ResumeLayout(false);
            this.gbUsername.PerformLayout();
            this.panelChat.ResumeLayout(false);
            this.panelChat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbChat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWelcome)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labUsername;
        private System.Windows.Forms.GroupBox gbUsername;
        private System.Windows.Forms.TextBox tbPassw;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label labPassw;
        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.RadioButton rbRegistro;
        private System.Windows.Forms.Panel panelChat;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox tbMensaje;
        private System.Windows.Forms.DataGridView dgvChat;
        private System.Windows.Forms.RadioButton rbLogin;
        private System.Windows.Forms.PictureBox pbChat;
        private System.Windows.Forms.PictureBox pbWelcome;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label labHL;
    }
}

