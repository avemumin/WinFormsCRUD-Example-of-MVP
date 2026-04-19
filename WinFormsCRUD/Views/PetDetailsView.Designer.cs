namespace WinFormsCRUD.Views
{
  partial class PetDetailsView
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
      panel1 = new Panel();
      label1 = new Label();
      label2 = new Label();
      label3 = new Label();
      label4 = new Label();
      btnSave = new Button();
      btnCancel = new Button();
      label5 = new Label();
      txtPetId = new TextBox();
      txtPetName = new TextBox();
      txtPetType = new TextBox();
      txtPetColor = new TextBox();
      panel1.SuspendLayout();
      SuspendLayout();
      // 
      // panel1
      // 
      panel1.BackColor = Color.White;
      panel1.Controls.Add(label1);
      panel1.Dock = DockStyle.Top;
      panel1.Location = new Point(0, 0);
      panel1.Name = "panel1";
      panel1.Size = new Size(800, 100);
      panel1.TabIndex = 0;
      // 
      // label1
      // 
      label1.AutoSize = true;
      label1.Font = new Font("Segoe UI", 15F);
      label1.Location = new Point(18, 14);
      label1.Name = "label1";
      label1.Size = new Size(105, 28);
      label1.TabIndex = 0;
      label1.Text = "Pet details:";
      // 
      // label2
      // 
      label2.AutoSize = true;
      label2.Location = new Point(18, 128);
      label2.Name = "label2";
      label2.Size = new Size(41, 15);
      label2.TabIndex = 1;
      label2.Text = "Pet ID:";
      // 
      // label3
      // 
      label3.AutoSize = true;
      label3.Location = new Point(18, 211);
      label3.Name = "label3";
      label3.Size = new Size(62, 15);
      label3.TabIndex = 2;
      label3.Text = "Pet Name:";
      // 
      // label4
      // 
      label4.AutoSize = true;
      label4.Location = new Point(227, 211);
      label4.Name = "label4";
      label4.Size = new Size(35, 15);
      label4.TabIndex = 3;
      label4.Text = "Type:";
      // 
      // btnSave
      // 
      btnSave.Location = new Point(18, 349);
      btnSave.Name = "btnSave";
      btnSave.Size = new Size(100, 30);
      btnSave.TabIndex = 4;
      btnSave.Text = "Save";
      btnSave.UseVisualStyleBackColor = true;
      // 
      // btnCancel
      // 
      btnCancel.Location = new Point(204, 349);
      btnCancel.Name = "btnCancel";
      btnCancel.Size = new Size(100, 30);
      btnCancel.TabIndex = 5;
      btnCancel.Text = "Cancel";
      btnCancel.UseVisualStyleBackColor = true;
      // 
      // label5
      // 
      label5.AutoSize = true;
      label5.Location = new Point(18, 275);
      label5.Name = "label5";
      label5.Size = new Size(39, 15);
      label5.TabIndex = 6;
      label5.Text = "Color:";
      // 
      // txtPetId
      // 
      txtPetId.Location = new Point(18, 146);
      txtPetId.Name = "txtPetId";
      txtPetId.Size = new Size(100, 23);
      txtPetId.TabIndex = 7;
      // 
      // txtPetName
      // 
      txtPetName.Location = new Point(18, 230);
      txtPetName.Name = "txtPetName";
      txtPetName.Size = new Size(100, 23);
      txtPetName.TabIndex = 8;
      // 
      // txtPetType
      // 
      txtPetType.Location = new Point(215, 230);
      txtPetType.Name = "txtPetType";
      txtPetType.Size = new Size(100, 23);
      txtPetType.TabIndex = 9;
      // 
      // txtPetColor
      // 
      txtPetColor.Location = new Point(18, 295);
      txtPetColor.Name = "txtPetColor";
      txtPetColor.Size = new Size(286, 23);
      txtPetColor.TabIndex = 10;
      // 
      // PetDetailsView
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(800, 450);
      Controls.Add(txtPetColor);
      Controls.Add(txtPetType);
      Controls.Add(txtPetName);
      Controls.Add(txtPetId);
      Controls.Add(label5);
      Controls.Add(btnCancel);
      Controls.Add(btnSave);
      Controls.Add(label4);
      Controls.Add(label3);
      Controls.Add(label2);
      Controls.Add(panel1);
      Name = "PetDetailsView";
      Text = "PetDetailsView";
      panel1.ResumeLayout(false);
      panel1.PerformLayout();
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private Panel panel1;
    private Label label1;
    private Label label2;
    private Label label3;
    private Label label4;
    private Button btnSave;
    private Button btnCancel;
    private Label label5;
    private TextBox txtPetId;
    private TextBox txtPetName;
    private TextBox txtPetType;
    private TextBox txtPetColor;
  }
}