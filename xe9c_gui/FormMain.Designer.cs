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
        inputBox = new TextBox();
        outTextBox = new RichTextBox();
        buttonSend = new Button();
        buttonDisconnect = new Button();
        SuspendLayout();
        // 
        // inputBox
        // 
        inputBox.BorderStyle = BorderStyle.FixedSingle;
        inputBox.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
        inputBox.Location = new Point(12, 394);
        inputBox.Multiline = true;
        inputBox.Name = "inputBox";
        inputBox.Size = new Size(333, 44);
        inputBox.TabIndex = 0;
        inputBox.TextChanged += inputBox_TextChanged;
        // 
        // outTextBox
        // 
        outTextBox.BorderStyle = BorderStyle.None;
        outTextBox.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        outTextBox.Location = new Point(12, 12);
        outTextBox.Name = "outTextBox";
        outTextBox.ReadOnly = true;
        outTextBox.Size = new Size(510, 376);
        outTextBox.TabIndex = 1;
        outTextBox.Text = "";
        outTextBox.TextChanged += outTextBox_TextChanged;
        // 
        // buttonSend
        // 
        buttonSend.Location = new Point(351, 394);
        buttonSend.Name = "buttonSend";
        buttonSend.Size = new Size(92, 44);
        buttonSend.TabIndex = 2;
        buttonSend.Text = "ОТПРАВИТЬ";
        buttonSend.UseVisualStyleBackColor = true;
        buttonSend.Click += buttonSend_Click;
        // 
        // buttonDisconnect
        // 
        buttonDisconnect.Location = new Point(449, 394);
        buttonDisconnect.Name = "buttonDisconnect";
        buttonDisconnect.Size = new Size(73, 44);
        buttonDisconnect.TabIndex = 3;
        buttonDisconnect.Text = "ОТКЛЮЧИТЬСЯ";
        buttonDisconnect.UseVisualStyleBackColor = true;
        buttonDisconnect.Click += buttonDisconnect_Click;
        // 
        // FormMain
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(534, 446);
        Controls.Add(buttonDisconnect);
        Controls.Add(buttonSend);
        Controls.Add(outTextBox);
        Controls.Add(inputBox);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        Name = "FormMain";
        ShowIcon = false;
        Text = "xe9c";
        ControlBox = false;
        Load += FormMain_Load;
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private TextBox inputBox;
    private RichTextBox outTextBox;
    private Button buttonSend;
    private Button buttonDisconnect;
}
