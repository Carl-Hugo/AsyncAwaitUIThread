namespace AsyncAwaitUIThread;

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
        btn_start1 = new Button();
        btn_start2 = new Button();
        btn_stop1 = new Button();
        btn_stop2 = new Button();
        label1 = new Label();
        label2 = new Label();
        btn_stop3 = new Button();
        btn_start3 = new Button();
        label3 = new Label();
        SuspendLayout();
        // 
        // btn_start1
        // 
        btn_start1.Location = new Point(24, 30);
        btn_start1.Name = "btn_start1";
        btn_start1.Size = new Size(75, 23);
        btn_start1.TabIndex = 0;
        btn_start1.Text = "Start";
        btn_start1.UseVisualStyleBackColor = true;
        btn_start1.Click += btn_start1_Click;
        // 
        // btn_start2
        // 
        btn_start2.Location = new Point(24, 59);
        btn_start2.Name = "btn_start2";
        btn_start2.Size = new Size(75, 23);
        btn_start2.TabIndex = 2;
        btn_start2.Text = "Start";
        btn_start2.UseVisualStyleBackColor = true;
        btn_start2.Click += btn_start2_Click;
        // 
        // btn_stop1
        // 
        btn_stop1.Location = new Point(105, 30);
        btn_stop1.Name = "btn_stop1";
        btn_stop1.Size = new Size(75, 23);
        btn_stop1.TabIndex = 4;
        btn_stop1.Text = "Stop";
        btn_stop1.UseVisualStyleBackColor = true;
        btn_stop1.Click += btn_stop1_Click;
        // 
        // btn_stop2
        // 
        btn_stop2.Location = new Point(105, 59);
        btn_stop2.Name = "btn_stop2";
        btn_stop2.Size = new Size(75, 23);
        btn_stop2.TabIndex = 5;
        btn_stop2.Text = "Stop";
        btn_stop2.UseVisualStyleBackColor = true;
        btn_stop2.Click += btn_stop2_Click;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(186, 34);
        label1.Name = "label1";
        label1.Size = new Size(38, 15);
        label1.TabIndex = 6;
        label1.Text = "label1";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(186, 63);
        label2.Name = "label2";
        label2.Size = new Size(38, 15);
        label2.TabIndex = 7;
        label2.Text = "label2";
        // 
        // btn_stop3
        // 
        btn_stop3.Location = new Point(105, 88);
        btn_stop3.Name = "btn_stop3";
        btn_stop3.Size = new Size(75, 23);
        btn_stop3.TabIndex = 9;
        btn_stop3.Text = "Stop";
        btn_stop3.UseVisualStyleBackColor = true;
        btn_stop3.Click += btn_stop3_Click;
        // 
        // btn_start3
        // 
        btn_start3.Location = new Point(24, 88);
        btn_start3.Name = "btn_start3";
        btn_start3.Size = new Size(75, 23);
        btn_start3.TabIndex = 8;
        btn_start3.Text = "Start";
        btn_start3.UseVisualStyleBackColor = true;
        btn_start3.Click += btn_start3_Click;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(186, 92);
        label3.Name = "label3";
        label3.Size = new Size(38, 15);
        label3.TabIndex = 10;
        label3.Text = "label3";
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(371, 134);
        Controls.Add(label3);
        Controls.Add(btn_stop3);
        Controls.Add(btn_start3);
        Controls.Add(label2);
        Controls.Add(label1);
        Controls.Add(btn_stop2);
        Controls.Add(btn_stop1);
        Controls.Add(btn_start2);
        Controls.Add(btn_start1);
        Name = "Form1";
        Text = "Async Await UI Thread Counter Experiment";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button btn_start1;
    private Button btn_start2;
    private Button btn_stop1;
    private Button btn_stop2;
    private Label label1;
    private Label label2;
    private Button btn_stop3;
    private Button btn_start3;
    private Label label3;
}
