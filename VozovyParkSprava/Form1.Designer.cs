partial class Form1
{
    private System.ComponentModel.IContainer components = null;

    // Ovládací prvky formuláře
    private System.Windows.Forms.DataGridView dataGridView1;
    private System.Windows.Forms.Button btnAdd;
    private System.Windows.Forms.Button btnEdit;
    private System.Windows.Forms.Button btnDelete;
    private System.Windows.Forms.Button btnSearch;
    private System.Windows.Forms.TextBox txtSPZ;
    private System.Windows.Forms.TextBox txtModel;
    private System.Windows.Forms.TextBox txtVyrobce;
    private System.Windows.Forms.TextBox txtRok;
    private System.Windows.Forms.TextBox txtStav;
    private System.Windows.Forms.TextBox txtSearch;
    private System.Windows.Forms.Label lblSPZ;
    private System.Windows.Forms.Label lblModel;
    private System.Windows.Forms.Label lblVyrobce;
    private System.Windows.Forms.Label lblRok;
    private System.Windows.Forms.Label lblStav;
    private System.Windows.Forms.GroupBox groupBoxDetails;

    // Vytvoření ovládacích prvků
    private void InitializeComponent()
    {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSPZ = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtVyrobce = new System.Windows.Forms.TextBox();
            this.txtRok = new System.Windows.Forms.TextBox();
            this.txtStav = new System.Windows.Forms.TextBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSPZ = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblVyrobce = new System.Windows.Forms.Label();
            this.lblRok = new System.Windows.Forms.Label();
            this.lblStav = new System.Windows.Forms.Label();
            this.groupBoxDetails = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBoxDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 221);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(760, 200);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(214, 62);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Přidat";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(214, 38);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Upravit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(214, 12);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Smazat";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(195, 190);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Hledat";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSPZ
            // 
            this.txtSPZ.Location = new System.Drawing.Point(93, 26);
            this.txtSPZ.Name = "txtSPZ";
            this.txtSPZ.Size = new System.Drawing.Size(100, 20);
            this.txtSPZ.TabIndex = 5;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(93, 52);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(100, 20);
            this.txtModel.TabIndex = 6;
            // 
            // txtVyrobce
            // 
            this.txtVyrobce.Location = new System.Drawing.Point(93, 78);
            this.txtVyrobce.Name = "txtVyrobce";
            this.txtVyrobce.Size = new System.Drawing.Size(100, 20);
            this.txtVyrobce.TabIndex = 7;
            // 
            // txtRok
            // 
            this.txtRok.Location = new System.Drawing.Point(93, 104);
            this.txtRok.Name = "txtRok";
            this.txtRok.Size = new System.Drawing.Size(100, 20);
            this.txtRok.TabIndex = 8;
            // 
            // txtStav
            // 
            this.txtStav.Location = new System.Drawing.Point(93, 130);
            this.txtStav.Name = "txtStav";
            this.txtStav.Size = new System.Drawing.Size(100, 20);
            this.txtStav.TabIndex = 9;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(89, 192);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(100, 20);
            this.txtSearch.TabIndex = 10;
            // 
            // lblSPZ
            // 
            this.lblSPZ.Location = new System.Drawing.Point(6, 29);
            this.lblSPZ.Name = "lblSPZ";
            this.lblSPZ.Size = new System.Drawing.Size(80, 13);
            this.lblSPZ.TabIndex = 0;
            this.lblSPZ.Text = "SPZ:";
            // 
            // lblModel
            // 
            this.lblModel.Location = new System.Drawing.Point(6, 55);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(80, 13);
            this.lblModel.TabIndex = 6;
            this.lblModel.Text = "Model:";
            // 
            // lblVyrobce
            // 
            this.lblVyrobce.Location = new System.Drawing.Point(6, 81);
            this.lblVyrobce.Name = "lblVyrobce";
            this.lblVyrobce.Size = new System.Drawing.Size(80, 13);
            this.lblVyrobce.TabIndex = 7;
            this.lblVyrobce.Text = "Výrobce:";
            // 
            // lblRok
            // 
            this.lblRok.Location = new System.Drawing.Point(6, 107);
            this.lblRok.Name = "lblRok";
            this.lblRok.Size = new System.Drawing.Size(80, 13);
            this.lblRok.TabIndex = 8;
            this.lblRok.Text = "Rok:";
            // 
            // lblStav
            // 
            this.lblStav.Location = new System.Drawing.Point(6, 133);
            this.lblStav.Name = "lblStav";
            this.lblStav.Size = new System.Drawing.Size(80, 13);
            this.lblStav.TabIndex = 9;
            this.lblStav.Text = "Stav:";
            // 
            // groupBoxDetails
            // 
            this.groupBoxDetails.Controls.Add(this.lblSPZ);
            this.groupBoxDetails.Controls.Add(this.txtSPZ);
            this.groupBoxDetails.Controls.Add(this.lblModel);
            this.groupBoxDetails.Controls.Add(this.txtModel);
            this.groupBoxDetails.Controls.Add(this.lblVyrobce);
            this.groupBoxDetails.Controls.Add(this.txtVyrobce);
            this.groupBoxDetails.Controls.Add(this.lblRok);
            this.groupBoxDetails.Controls.Add(this.txtRok);
            this.groupBoxDetails.Controls.Add(this.lblStav);
            this.groupBoxDetails.Controls.Add(this.txtStav);
            this.groupBoxDetails.Location = new System.Drawing.Point(8, 12);
            this.groupBoxDetails.Name = "groupBoxDetails";
            this.groupBoxDetails.Size = new System.Drawing.Size(200, 170);
            this.groupBoxDetails.TabIndex = 11;
            this.groupBoxDetails.TabStop = false;
            this.groupBoxDetails.Text = "Detaily vozidla";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(5, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Hledat dle SPZ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(784, 429);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBoxDetails);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Správa Vozového Parku";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBoxDetails.ResumeLayout(false);
            this.groupBoxDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    private System.Windows.Forms.Label label1;
}
