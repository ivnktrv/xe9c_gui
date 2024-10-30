using System.Windows.Forms;

namespace xe9c_gui;

partial class FormMain
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
        inputBox = new TextBox();
        outTextBox = new RichTextBox();
        buttonSend = new Button();
        buttonDisconnect = new Button();
        notifyIconNewMsg = new NotifyIcon(components);
        buttonHide = new Button();
        richTextBoxGatewayInfo = new RichTextBox();
        labelAbout = new Label();
        labelGithub = new Label();
        SuspendLayout();
        // 
        // inputBox
        // 
        inputBox.BorderStyle = BorderStyle.None;
        inputBox.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
        inputBox.Location = new Point(12, 394);
        inputBox.Multiline = true;
        inputBox.Name = "inputBox";
        inputBox.Size = new Size(413, 47);
        inputBox.TabIndex = 0;
        inputBox.TextChanged += inputBox_TextChanged;
        // 
        // outTextBox
        // 
        outTextBox.BorderStyle = BorderStyle.FixedSingle;
        outTextBox.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        outTextBox.Location = new Point(12, 9);
        outTextBox.Name = "outTextBox";
        outTextBox.ReadOnly = true;
        outTextBox.Size = new Size(510, 379);
        outTextBox.TabIndex = 1;
        outTextBox.Text = "";
        outTextBox.TextChanged += outTextBox_TextChanged;
        // 
        // buttonSend
        // 
        buttonSend.Location = new Point(431, 394);
        buttonSend.Name = "buttonSend";
        buttonSend.Size = new Size(91, 47);
        buttonSend.TabIndex = 2;
        buttonSend.Text = "ОТПРАВИТЬ";
        buttonSend.UseVisualStyleBackColor = true;
        buttonSend.Click += buttonSend_Click;
        // 
        // buttonDisconnect
        // 
        buttonDisconnect.Location = new Point(538, 394);
        buttonDisconnect.Name = "buttonDisconnect";
        buttonDisconnect.Size = new Size(181, 47);
        buttonDisconnect.TabIndex = 3;
        buttonDisconnect.Text = "ОТКЛЮЧИТЬСЯ";
        buttonDisconnect.UseVisualStyleBackColor = true;
        buttonDisconnect.Click += buttonDisconnect_Click;
        // 
        // notifyIconNewMsg
        // 
        notifyIconNewMsg.BalloonTipTitle = "Новое сообщение...";
        notifyIconNewMsg.Icon = (Icon)resources.GetObject("notifyIconNewMsg.Icon");
        notifyIconNewMsg.Visible = true;
        notifyIconNewMsg.BalloonTipClicked += FormMain_Show;
        notifyIconNewMsg.MouseClick += FormMain_Show;
        // 
        // buttonHide
        // 
        buttonHide.Location = new Point(538, 344);
        buttonHide.Name = "buttonHide";
        buttonHide.Size = new Size(181, 44);
        buttonHide.TabIndex = 4;
        buttonHide.Text = "СВЕРНУТЬ В ТРЕЙ";
        buttonHide.UseVisualStyleBackColor = true;
        buttonHide.Click += buttonHide_Click;
        // 
        // richTextBoxGatewayInfo
        // 
        richTextBoxGatewayInfo.BorderStyle = BorderStyle.None;
        richTextBoxGatewayInfo.Font = new Font("Cascadia Mono", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
        richTextBoxGatewayInfo.Location = new Point(538, 12);
        richTextBoxGatewayInfo.Name = "richTextBoxGatewayInfo";
        richTextBoxGatewayInfo.ReadOnly = true;
        richTextBoxGatewayInfo.ScrollBars = RichTextBoxScrollBars.None;
        richTextBoxGatewayInfo.Size = new Size(191, 123);
        richTextBoxGatewayInfo.TabIndex = 5;
        richTextBoxGatewayInfo.Text = "";
        // 
        // labelAbout
        // 
        labelAbout.AutoSize = true;
        labelAbout.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
        labelAbout.Location = new Point(560, 274);
        labelAbout.Name = "labelAbout";
        labelAbout.Size = new Size(139, 20);
        labelAbout.TabIndex = 6;
        labelAbout.Text = "Xenine Chat (v3.1)";
        // 
        // labelGithub
        // 
        labelGithub.AutoSize = true;
        labelGithub.Cursor = Cursors.Hand;
        labelGithub.Location = new Point(528, 303);
        labelGithub.Name = "labelGithub";
        labelGithub.Size = new Size(201, 15);
        labelGithub.TabIndex = 7;
        labelGithub.Text = "https://github.com/ivnktrv/xe9c_gui";
        labelGithub.Click += labelGithub_Click;
        // 
        // FormMain
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(734, 451);
        Controls.Add(labelGithub);
        Controls.Add(labelAbout);
        Controls.Add(richTextBoxGatewayInfo);
        Controls.Add(buttonHide);
        Controls.Add(buttonDisconnect);
        Controls.Add(buttonSend);
        Controls.Add(outTextBox);
        Controls.Add(inputBox);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        Icon = (Icon)resources.GetObject("$this.Icon");
        Name = "FormMain";
        Text = "xe9c";
        FormClosing += FormMain_FormClosing;
        Load += FormMain_Load;
        VisibleChanged += FormMain_Resize;
        Resize += FormMain_Resize;
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private TextBox inputBox;
    private RichTextBox outTextBox;
    private Button buttonSend;
    private Button buttonDisconnect;
    private NotifyIcon notifyIconNewMsg;
    private Button buttonHide;
    private RichTextBox richTextBoxGatewayInfo;
    private Label labelAbout;
    private Label labelGithub;
}
