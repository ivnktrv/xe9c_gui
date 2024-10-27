namespace xe9c_gui
{
    partial class FormConnectToGateway
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
            buttonConnect = new Button();
            textBoxInputClientName = new TextBox();
            textBoxInputIP = new TextBox();
            labelClientName = new Label();
            labelIP = new Label();
            labelPort = new Label();
            textBoxInputPort = new TextBox();
            SuspendLayout();
            // 
            // buttonConnect
            // 
            buttonConnect.Location = new Point(190, 12);
            buttonConnect.Name = "buttonConnect";
            buttonConnect.Size = new Size(132, 84);
            buttonConnect.TabIndex = 0;
            buttonConnect.Text = "ПОДКЛЮЧИТЬСЯ";
            buttonConnect.UseVisualStyleBackColor = true;
            buttonConnect.Click += buttonConnect_Click;
            // 
            // textBoxInputClientName
            // 
            textBoxInputClientName.Location = new Point(84, 12);
            textBoxInputClientName.Name = "textBoxInputClientName";
            textBoxInputClientName.Size = new Size(100, 23);
            textBoxInputClientName.TabIndex = 1;
            textBoxInputClientName.TextChanged += textBoxInputClientName_TextChanged;
            // 
            // textBoxInputIP
            // 
            textBoxInputIP.Location = new Point(84, 42);
            textBoxInputIP.Name = "textBoxInputIP";
            textBoxInputIP.Size = new Size(100, 23);
            textBoxInputIP.TabIndex = 2;
            textBoxInputIP.TextChanged += textBoxInputIP_TextChanged;
            // 
            // labelClientName
            // 
            labelClientName.AutoSize = true;
            labelClientName.Location = new Point(16, 15);
            labelClientName.Name = "labelClientName";
            labelClientName.Size = new Size(62, 15);
            labelClientName.TabIndex = 3;
            labelClientName.Text = "Ваше имя";
            // 
            // labelIP
            // 
            labelIP.AutoSize = true;
            labelIP.Location = new Point(19, 45);
            labelIP.Name = "labelIP";
            labelIP.Size = new Size(59, 15);
            labelIP.TabIndex = 4;
            labelIP.Text = "IP шлюза";
            // 
            // labelPort
            // 
            labelPort.AutoSize = true;
            labelPort.Location = new Point(43, 76);
            labelPort.Name = "labelPort";
            labelPort.Size = new Size(35, 15);
            labelPort.TabIndex = 5;
            labelPort.Text = "Порт";
            // 
            // textBoxInputPort
            // 
            textBoxInputPort.Location = new Point(84, 73);
            textBoxInputPort.Name = "textBoxInputPort";
            textBoxInputPort.Size = new Size(100, 23);
            textBoxInputPort.TabIndex = 6;
            textBoxInputPort.TextChanged += textBoxInputPort_TextChanged;
            // 
            // FormConnectToGateway
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(330, 103);
            Controls.Add(textBoxInputPort);
            Controls.Add(labelPort);
            Controls.Add(labelIP);
            Controls.Add(labelClientName);
            Controls.Add(textBoxInputIP);
            Controls.Add(textBoxInputClientName);
            Controls.Add(buttonConnect);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FormConnectToGateway";
            ShowIcon = false;
            Text = "xe9c | Connect to gateway";
            Load += FormLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonConnect;
        private TextBox textBoxInputClientName;
        private TextBox textBoxInputIP;
        private Label labelClientName;
        private Label labelIP;
        private Label labelPort;
        private TextBox textBoxInputPort;
    }
}