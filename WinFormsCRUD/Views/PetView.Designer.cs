namespace WinFormsCRUD.Views
{
  partial class PetView
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
      tabControl1 = new TabControl();
      tabPage1 = new TabPage();
      dgPetListView = new DataGridView();
      btnDelete = new Button();
      btnEdit = new Button();
      btnAdd = new Button();
      btnSearch = new Button();
      txtSearch = new TextBox();
      label2 = new Label();
      tabPage2 = new TabPage();
      txtPetColor = new TextBox();
      txtPetType = new TextBox();
      txtPetName = new TextBox();
      txtPetId = new TextBox();
      label6 = new Label();
      label5 = new Label();
      label4 = new Label();
      label3 = new Label();
      btnCancel = new Button();
      btnSave = new Button();
      panel1.SuspendLayout();
      tabControl1.SuspendLayout();
      tabPage1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)dgPetListView).BeginInit();
      tabPage2.SuspendLayout();
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
      label1.Location = new Point(24, 20);
      label1.Name = "label1";
      label1.Size = new Size(54, 28);
      label1.TabIndex = 0;
      label1.Text = "PETS";
      // 
      // tabControl1
      // 
      tabControl1.Controls.Add(tabPage1);
      tabControl1.Controls.Add(tabPage2);
      tabControl1.Dock = DockStyle.Fill;
      tabControl1.Location = new Point(0, 100);
      tabControl1.Name = "tabControl1";
      tabControl1.SelectedIndex = 0;
      tabControl1.Size = new Size(800, 350);
      tabControl1.TabIndex = 1;
      // 
      // tabPage1
      // 
      tabPage1.Controls.Add(dgPetListView);
      tabPage1.Controls.Add(btnDelete);
      tabPage1.Controls.Add(btnEdit);
      tabPage1.Controls.Add(btnAdd);
      tabPage1.Controls.Add(btnSearch);
      tabPage1.Controls.Add(txtSearch);
      tabPage1.Controls.Add(label2);
      tabPage1.Location = new Point(4, 24);
      tabPage1.Name = "tabPage1";
      tabPage1.Padding = new Padding(3);
      tabPage1.Size = new Size(792, 322);
      tabPage1.TabIndex = 0;
      tabPage1.Text = "Pets list";
      tabPage1.UseVisualStyleBackColor = true;
      // 
      // dgPetListView
      // 
      dgPetListView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
      dgPetListView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      dgPetListView.Location = new Point(8, 50);
      dgPetListView.Name = "dgPetListView";
      dgPetListView.Size = new Size(580, 245);
      dgPetListView.TabIndex = 6;
      // 
      // btnDelete
      // 
      btnDelete.Location = new Point(685, 144);
      btnDelete.Name = "btnDelete";
      btnDelete.Size = new Size(75, 23);
      btnDelete.TabIndex = 5;
      btnDelete.Text = "Delete";
      btnDelete.UseVisualStyleBackColor = true;
      // 
      // btnEdit
      // 
      btnEdit.Location = new Point(685, 103);
      btnEdit.Name = "btnEdit";
      btnEdit.Size = new Size(75, 23);
      btnEdit.TabIndex = 4;
      btnEdit.Text = "Edit";
      btnEdit.UseVisualStyleBackColor = true;
      // 
      // btnAdd
      // 
      btnAdd.Location = new Point(685, 62);
      btnAdd.Name = "btnAdd";
      btnAdd.Size = new Size(75, 23);
      btnAdd.TabIndex = 3;
      btnAdd.Text = "Add new";
      btnAdd.UseVisualStyleBackColor = true;
      // 
      // btnSearch
      // 
      btnSearch.Location = new Point(594, 21);
      btnSearch.Name = "btnSearch";
      btnSearch.Size = new Size(112, 23);
      btnSearch.TabIndex = 2;
      btnSearch.Text = "Search";
      btnSearch.UseVisualStyleBackColor = true;
      // 
      // txtSearch
      // 
      txtSearch.Location = new Point(8, 21);
      txtSearch.Name = "txtSearch";
      txtSearch.Size = new Size(580, 23);
      txtSearch.TabIndex = 1;
      // 
      // label2
      // 
      label2.AutoSize = true;
      label2.Location = new Point(8, 3);
      label2.Name = "label2";
      label2.Size = new Size(65, 15);
      label2.TabIndex = 0;
      label2.Text = "Search pet:";
      // 
      // tabPage2
      // 
      tabPage2.Controls.Add(txtPetColor);
      tabPage2.Controls.Add(txtPetType);
      tabPage2.Controls.Add(txtPetName);
      tabPage2.Controls.Add(txtPetId);
      tabPage2.Controls.Add(label6);
      tabPage2.Controls.Add(label5);
      tabPage2.Controls.Add(label4);
      tabPage2.Controls.Add(label3);
      tabPage2.Controls.Add(btnCancel);
      tabPage2.Controls.Add(btnSave);
      tabPage2.Location = new Point(4, 24);
      tabPage2.Name = "tabPage2";
      tabPage2.Padding = new Padding(3);
      tabPage2.Size = new Size(792, 322);
      tabPage2.TabIndex = 1;
      tabPage2.Text = "Pet details";
      tabPage2.UseVisualStyleBackColor = true;
      // 
      // txtPetColor
      // 
      txtPetColor.Location = new Point(29, 216);
      txtPetColor.Name = "txtPetColor";
      txtPetColor.Size = new Size(282, 23);
      txtPetColor.TabIndex = 9;
      // 
      // txtPetType
      // 
      txtPetType.Location = new Point(211, 128);
      txtPetType.Name = "txtPetType";
      txtPetType.Size = new Size(100, 23);
      txtPetType.TabIndex = 8;
      // 
      // txtPetName
      // 
      txtPetName.Location = new Point(29, 128);
      txtPetName.Name = "txtPetName";
      txtPetName.Size = new Size(100, 23);
      txtPetName.TabIndex = 7;
      // 
      // txtPetId
      // 
      txtPetId.Location = new Point(29, 35);
      txtPetId.Name = "txtPetId";
      txtPetId.Size = new Size(100, 23);
      txtPetId.TabIndex = 6;
      // 
      // label6
      // 
      label6.AutoSize = true;
      label6.Location = new Point(29, 185);
      label6.Name = "label6";
      label6.Size = new Size(57, 15);
      label6.TabIndex = 5;
      label6.Text = "Pet color:";
      // 
      // label5
      // 
      label5.AutoSize = true;
      label5.Location = new Point(211, 106);
      label5.Name = "label5";
      label5.Size = new Size(53, 15);
      label5.TabIndex = 4;
      label5.Text = "Pet type:";
      // 
      // label4
      // 
      label4.AutoSize = true;
      label4.Location = new Point(29, 106);
      label4.Name = "label4";
      label4.Size = new Size(60, 15);
      label4.TabIndex = 3;
      label4.Text = "Pet name:";
      // 
      // label3
      // 
      label3.AutoSize = true;
      label3.Location = new Point(29, 17);
      label3.Name = "label3";
      label3.Size = new Size(41, 15);
      label3.TabIndex = 2;
      label3.Text = "Pet ID:";
      // 
      // btnCancel
      // 
      btnCancel.Location = new Point(211, 255);
      btnCancel.Name = "btnCancel";
      btnCancel.Size = new Size(100, 30);
      btnCancel.TabIndex = 1;
      btnCancel.Text = "Cancel";
      btnCancel.UseVisualStyleBackColor = true;
      // 
      // btnSave
      // 
      btnSave.Location = new Point(29, 255);
      btnSave.Name = "btnSave";
      btnSave.Size = new Size(100, 30);
      btnSave.TabIndex = 0;
      btnSave.Text = "Save";
      btnSave.UseVisualStyleBackColor = true;
      // 
      // PetView
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(800, 450);
      Controls.Add(tabControl1);
      Controls.Add(panel1);
      Name = "PetView";
      Text = "PetView";
      panel1.ResumeLayout(false);
      panel1.PerformLayout();
      tabControl1.ResumeLayout(false);
      tabPage1.ResumeLayout(false);
      tabPage1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)dgPetListView).EndInit();
      tabPage2.ResumeLayout(false);
      tabPage2.PerformLayout();
      ResumeLayout(false);
    }

    #endregion

    private Panel panel1;
    private Label label1;
    private TabControl tabControl1;
    private TabPage tabPage1;
    private Button btnDelete;
    private Button btnEdit;
    private Button btnAdd;
    private Button btnSearch;
    private TextBox txtSearch;
    private Label label2;
    private TabPage tabPage2;
    private DataGridView dgPetListView;
    private TextBox txtPetColor;
    private TextBox txtPetType;
    private TextBox txtPetName;
    private TextBox txtPetId;
    private Label label6;
    private Label label5;
    private Label label4;
    private Label label3;
    private Button btnCancel;
    private Button btnSave;
  }
}