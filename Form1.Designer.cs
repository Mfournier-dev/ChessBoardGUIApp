namespace ChessBoardGUIApp
{
    partial class Form1
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
            this.lblInstructions = new System.Windows.Forms.Label();
            this.cbPiece = new System.Windows.Forms.ComboBox();
            this.pnlBoard = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lblInstructions
            // 
            this.lblInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstructions.Location = new System.Drawing.Point(25, 9);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(365, 37);
            this.lblInstructions.TabIndex = 0;
            this.lblInstructions.Text = "Select a piece from the drop down menu and lick any square. I will show you all t" +
    "he legal moves";
            this.lblInstructions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbPiece
            // 
            this.cbPiece.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPiece.FormattingEnabled = true;
            this.cbPiece.Items.AddRange(new object[] {
            "Knight",
            "Bishop",
            "Rook",
            "Queen",
            "King"});
            this.cbPiece.Location = new System.Drawing.Point(396, 18);
            this.cbPiece.Name = "cbPiece";
            this.cbPiece.Size = new System.Drawing.Size(130, 21);
            this.cbPiece.TabIndex = 1;
            this.cbPiece.SelectedIndexChanged += new System.EventHandler(this.cbPiece_SelectedIndexChanged);
            // 
            // pnlBoard
            // 
            this.pnlBoard.Location = new System.Drawing.Point(26, 49);
            this.pnlBoard.Name = "pnlBoard";
            this.pnlBoard.Size = new System.Drawing.Size(500, 500);
            this.pnlBoard.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 590);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.pnlBoard);
            this.Controls.Add(this.cbPiece);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.ComboBox cbPiece;
        private System.Windows.Forms.Panel pnlBoard;
    }
}

