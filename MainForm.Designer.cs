namespace GooglePhotosOrganizer
{
    partial class MainForm
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
            selectButton = new Button();
            selectLabel = new Label();
            selectedPath = new Label();
            formatList = new CheckedListBox();
            formatLabel = new Label();
            copyCounterLabel = new Label();
            fileCounterLabel = new Label();
            fileCounter = new Label();
            copyPathLabel = new Label();
            copyButton = new Button();
            videoSeparateLabel = new Label();
            videoSeparateCombo = new ComboBox();
            copyCounter = new Label();
            organizeButton = new Button();
            progressBar = new ProgressBar();
            progressActionLabel = new Label();
            copyPath = new Label();
            SuspendLayout();
            // 
            // selectButton
            // 
            selectButton.Location = new Point(12, 27);
            selectButton.Name = "selectButton";
            selectButton.Size = new Size(75, 23);
            selectButton.TabIndex = 1;
            selectButton.Text = "Selecciona";
            selectButton.UseVisualStyleBackColor = true;
            selectButton.Click += selectButton_Click;
            // 
            // selectLabel
            // 
            selectLabel.AutoSize = true;
            selectLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            selectLabel.Location = new Point(12, 9);
            selectLabel.Name = "selectLabel";
            selectLabel.Size = new Size(175, 15);
            selectLabel.TabIndex = 3;
            selectLabel.Text = "Selecciona carpeta a organizar";
            // 
            // selectedPath
            // 
            selectedPath.AutoEllipsis = true;
            selectedPath.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            selectedPath.Location = new Point(12, 53);
            selectedPath.Name = "selectedPath";
            selectedPath.Size = new Size(593, 26);
            selectedPath.TabIndex = 4;
            selectedPath.Text = "...";
            // 
            // formatList
            // 
            formatList.FormattingEnabled = true;
            formatList.Location = new Point(12, 107);
            formatList.Name = "formatList";
            formatList.Size = new Size(175, 202);
            formatList.TabIndex = 5;
            formatList.SelectedValueChanged += formatList_SelectedValueChanged;
            // 
            // formatLabel
            // 
            formatLabel.AutoSize = true;
            formatLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            formatLabel.Location = new Point(12, 89);
            formatLabel.Name = "formatLabel";
            formatLabel.Size = new Size(176, 15);
            formatLabel.TabIndex = 6;
            formatLabel.Text = "Seleccione formatos a guardar";
            // 
            // copyCounterLabel
            // 
            copyCounterLabel.AutoSize = true;
            copyCounterLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            copyCounterLabel.Location = new Point(624, 89);
            copyCounterLabel.Name = "copyCounterLabel";
            copyCounterLabel.Size = new Size(164, 15);
            copyCounterLabel.TabIndex = 7;
            copyCounterLabel.Text = "Número de ficheros a copiar";
            // 
            // fileCounterLabel
            // 
            fileCounterLabel.AutoSize = true;
            fileCounterLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            fileCounterLabel.Location = new Point(624, 9);
            fileCounterLabel.Name = "fileCounterLabel";
            fileCounterLabel.Size = new Size(118, 15);
            fileCounterLabel.TabIndex = 8;
            fileCounterLabel.Text = "Número de ficheros";
            // 
            // fileCounter
            // 
            fileCounter.AutoSize = true;
            fileCounter.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            fileCounter.Location = new Point(624, 31);
            fileCounter.Name = "fileCounter";
            fileCounter.Size = new Size(13, 15);
            fileCounter.TabIndex = 9;
            fileCounter.Text = "0";
            // 
            // copyPathLabel
            // 
            copyPathLabel.AutoSize = true;
            copyPathLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            copyPathLabel.Location = new Point(215, 158);
            copyPathLabel.Name = "copyPathLabel";
            copyPathLabel.Size = new Size(196, 15);
            copyPathLabel.TabIndex = 10;
            copyPathLabel.Text = "Seleccione carpeta donde guardar";
            // 
            // copyButton
            // 
            copyButton.Location = new Point(215, 176);
            copyButton.Name = "copyButton";
            copyButton.Size = new Size(75, 23);
            copyButton.TabIndex = 11;
            copyButton.Text = "Guardar en";
            copyButton.UseVisualStyleBackColor = true;
            copyButton.Click += copyButton_Click;
            // 
            // videoSeparateLabel
            // 
            videoSeparateLabel.AutoSize = true;
            videoSeparateLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            videoSeparateLabel.Location = new Point(215, 89);
            videoSeparateLabel.Name = "videoSeparateLabel";
            videoSeparateLabel.Size = new Size(89, 15);
            videoSeparateLabel.TabIndex = 13;
            videoSeparateLabel.Text = "Separar vídeos";
            // 
            // videoSeparateCombo
            // 
            videoSeparateCombo.FormattingEnabled = true;
            videoSeparateCombo.Items.AddRange(new object[] { "SI", "NO" });
            videoSeparateCombo.Location = new Point(215, 111);
            videoSeparateCombo.Name = "videoSeparateCombo";
            videoSeparateCombo.Size = new Size(121, 23);
            videoSeparateCombo.TabIndex = 14;
            // 
            // copyCounter
            // 
            copyCounter.AutoSize = true;
            copyCounter.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            copyCounter.Location = new Point(624, 111);
            copyCounter.Name = "copyCounter";
            copyCounter.Size = new Size(13, 15);
            copyCounter.TabIndex = 15;
            copyCounter.Text = "0";
            // 
            // organizeButton
            // 
            organizeButton.Location = new Point(713, 374);
            organizeButton.Name = "organizeButton";
            organizeButton.Size = new Size(75, 23);
            organizeButton.TabIndex = 16;
            organizeButton.Text = "Organiza!";
            organizeButton.UseVisualStyleBackColor = true;
            organizeButton.Click += organizeButton_Click;
            // 
            // progressBar
            // 
            progressBar.Location = new Point(12, 345);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(776, 23);
            progressBar.TabIndex = 17;
            // 
            // progressActionLabel
            // 
            progressActionLabel.AutoSize = true;
            progressActionLabel.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            progressActionLabel.Location = new Point(12, 327);
            progressActionLabel.Name = "progressActionLabel";
            progressActionLabel.Size = new Size(16, 15);
            progressActionLabel.TabIndex = 18;
            progressActionLabel.Text = "...";
            // 
            // copyPath
            // 
            copyPath.AutoEllipsis = true;
            copyPath.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            copyPath.Location = new Point(215, 202);
            copyPath.Name = "copyPath";
            copyPath.Size = new Size(573, 24);
            copyPath.TabIndex = 19;
            copyPath.Text = "...";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 412);
            Controls.Add(copyPath);
            Controls.Add(progressActionLabel);
            Controls.Add(progressBar);
            Controls.Add(organizeButton);
            Controls.Add(copyCounter);
            Controls.Add(videoSeparateCombo);
            Controls.Add(videoSeparateLabel);
            Controls.Add(copyButton);
            Controls.Add(copyPathLabel);
            Controls.Add(fileCounter);
            Controls.Add(fileCounterLabel);
            Controls.Add(copyCounterLabel);
            Controls.Add(formatLabel);
            Controls.Add(formatList);
            Controls.Add(selectedPath);
            Controls.Add(selectLabel);
            Controls.Add(selectButton);
            Name = "MainForm";
            Text = "Organizador de Google Fotos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button selectButton;
        private Label selectLabel;
        private Label selectedPath;
        private CheckedListBox formatList;
        private Label formatLabel;
        private Label copyCounterLabel;
        private Label fileCounterLabel;
        private Label fileCounter;
        private Label copyPathLabel;
        private Button copyButton;
        private Label videoSeparateLabel;
        private ComboBox videoSeparateCombo;
        private Label copyCounter;
        private Button organizeButton;
        private ProgressBar progressBar;
        private Label progressActionLabel;
        private Label copyPath;
    }
}
