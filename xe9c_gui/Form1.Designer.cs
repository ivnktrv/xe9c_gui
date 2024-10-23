namespace xe9c_gui;

partial class Form1
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
        SuspendLayout();
        // 
        // inputBox
        // 
        inputBox.Location = new Point(12, 394);
        inputBox.Multiline = true;
        inputBox.Name = "inputBox";
        inputBox.Size = new Size(363, 44);
        inputBox.TabIndex = 0;
        inputBox.TextChanged += textBox1_TextChanged;
        // 
        // outTextBox
        // 
        outTextBox.Location = new Point(12, 12);
        outTextBox.Name = "outTextBox";
        outTextBox.ReadOnly = true;
        outTextBox.Size = new Size(488, 376);
        outTextBox.TabIndex = 1;
        outTextBox.Text = "";
        outTextBox.TextChanged += richTextBox1_TextChanged;
        // 
        // buttonSend
        // 
        buttonSend.Location = new Point(381, 394);
        buttonSend.Name = "buttonSend";
        buttonSend.Size = new Size(119, 44);
        buttonSend.TabIndex = 2;
        buttonSend.Text = "SEND";
        buttonSend.UseVisualStyleBackColor = true;
        buttonSend.Click += buttonSend_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(509, 446);
        Controls.Add(buttonSend);
        Controls.Add(outTextBox);
        Controls.Add(inputBox);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        Name = "Form1";
        ShowIcon = false;
        Text = "xe9c";
        Load += Form1_Load;
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private TextBox inputBox;
    public RichTextBox outTextBox;
    private Button buttonSend;
}
