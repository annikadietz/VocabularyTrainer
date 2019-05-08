namespace VocabularyTrainer
{
    partial class VocabularyGUI
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.practiceTab = new System.Windows.Forms.TabPage();
            this.correctAnswer = new System.Windows.Forms.Label();
            this.givenAnswer = new System.Windows.Forms.Label();
            this.correctAnswerLabel = new System.Windows.Forms.Label();
            this.yourAnswerLabel = new System.Windows.Forms.Label();
            this.sendButton = new System.Windows.Forms.Button();
            this.inputLabel = new System.Windows.Forms.Label();
            this.answer = new System.Windows.Forms.TextBox();
            this.dataPane = new System.Windows.Forms.Panel();
            this.vocabulary = new System.Windows.Forms.Label();
            this.nextVocabLabel = new System.Windows.Forms.Label();
            this.statisticsTab = new System.Windows.Forms.TabPage();
            this.settingsTab = new System.Windows.Forms.TabPage();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.progress = new System.Windows.Forms.ProgressBar();
            this.progressLabel = new System.Windows.Forms.Label();
            this.statsHeader = new System.Windows.Forms.Label();
            this.totalCorrectLabel = new System.Windows.Forms.Label();
            this.amountWrongAnswersLabel = new System.Windows.Forms.Label();
            this.ammoutDaysUsedLabel = new System.Windows.Forms.Label();
            this.amountCorrect = new System.Windows.Forms.Label();
            this.amountWrong = new System.Windows.Forms.Label();
            this.amountDays = new System.Windows.Forms.Label();
            this.amountWords = new System.Windows.Forms.Label();
            this.totalAmountWordsLabel = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.practiceTab.SuspendLayout();
            this.dataPane.SuspendLayout();
            this.statisticsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.practiceTab);
            this.tabControl1.Controls.Add(this.statisticsTab);
            this.tabControl1.Controls.Add(this.settingsTab);
            this.tabControl1.Location = new System.Drawing.Point(0, -1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(801, 455);
            this.tabControl1.TabIndex = 1;
            // 
            // practiceTab
            // 
            this.practiceTab.Controls.Add(this.correctAnswer);
            this.practiceTab.Controls.Add(this.givenAnswer);
            this.practiceTab.Controls.Add(this.correctAnswerLabel);
            this.practiceTab.Controls.Add(this.yourAnswerLabel);
            this.practiceTab.Controls.Add(this.sendButton);
            this.practiceTab.Controls.Add(this.inputLabel);
            this.practiceTab.Controls.Add(this.answer);
            this.practiceTab.Controls.Add(this.dataPane);
            this.practiceTab.Location = new System.Drawing.Point(4, 22);
            this.practiceTab.Name = "practiceTab";
            this.practiceTab.Padding = new System.Windows.Forms.Padding(3);
            this.practiceTab.Size = new System.Drawing.Size(793, 429);
            this.practiceTab.TabIndex = 0;
            this.practiceTab.Text = "Practice";
            this.practiceTab.UseVisualStyleBackColor = true;
            // 
            // correctAnswer
            // 
            this.correctAnswer.AutoSize = true;
            this.correctAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.correctAnswer.Location = new System.Drawing.Point(350, 289);
            this.correctAnswer.Name = "correctAnswer";
            this.correctAnswer.Size = new System.Drawing.Size(19, 25);
            this.correctAnswer.TabIndex = 7;
            this.correctAnswer.Text = "-";
            // 
            // givenAnswer
            // 
            this.givenAnswer.AutoSize = true;
            this.givenAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.givenAnswer.Location = new System.Drawing.Point(31, 289);
            this.givenAnswer.Name = "givenAnswer";
            this.givenAnswer.Size = new System.Drawing.Size(19, 25);
            this.givenAnswer.TabIndex = 6;
            this.givenAnswer.Text = "-";
            // 
            // correctAnswerLabel
            // 
            this.correctAnswerLabel.AutoSize = true;
            this.correctAnswerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.correctAnswerLabel.Location = new System.Drawing.Point(345, 231);
            this.correctAnswerLabel.Name = "correctAnswerLabel";
            this.correctAnswerLabel.Size = new System.Drawing.Size(140, 25);
            this.correctAnswerLabel.TabIndex = 5;
            this.correctAnswerLabel.Text = "Correct anwer:";
            // 
            // yourAnswerLabel
            // 
            this.yourAnswerLabel.AutoSize = true;
            this.yourAnswerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yourAnswerLabel.Location = new System.Drawing.Point(26, 231);
            this.yourAnswerLabel.Name = "yourAnswerLabel";
            this.yourAnswerLabel.Size = new System.Drawing.Size(141, 26);
            this.yourAnswerLabel.TabIndex = 4;
            this.yourAnswerLabel.Text = "Your answer:";
            // 
            // sendButton
            // 
            this.sendButton.Location = new System.Drawing.Point(648, 159);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(120, 37);
            this.sendButton.TabIndex = 3;
            this.sendButton.Text = "send";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // inputLabel
            // 
            this.inputLabel.AutoSize = true;
            this.inputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputLabel.Location = new System.Drawing.Point(23, 125);
            this.inputLabel.Name = "inputLabel";
            this.inputLabel.Size = new System.Drawing.Size(113, 31);
            this.inputLabel.TabIndex = 2;
            this.inputLabel.Text = "Answer:";
            // 
            // answer
            // 
            this.answer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answer.Location = new System.Drawing.Point(23, 159);
            this.answer.Name = "answer";
            this.answer.Size = new System.Drawing.Size(569, 38);
            this.answer.TabIndex = 1;
            this.answer.KeyUp += new System.Windows.Forms.KeyEventHandler(this.answer_KeyUp);
            // 
            // dataPane
            // 
            this.dataPane.Controls.Add(this.vocabulary);
            this.dataPane.Controls.Add(this.nextVocabLabel);
            this.dataPane.Location = new System.Drawing.Point(23, 15);
            this.dataPane.Name = "dataPane";
            this.dataPane.Size = new System.Drawing.Size(745, 90);
            this.dataPane.TabIndex = 0;
            // 
            // vocabulary
            // 
            this.vocabulary.AutoSize = true;
            this.vocabulary.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vocabulary.Location = new System.Drawing.Point(319, 30);
            this.vocabulary.Name = "vocabulary";
            this.vocabulary.Size = new System.Drawing.Size(199, 31);
            this.vocabulary.TabIndex = 1;
            this.vocabulary.Text = "vocabularyText";
            // 
            // nextVocabLabel
            // 
            this.nextVocabLabel.AutoSize = true;
            this.nextVocabLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextVocabLabel.Location = new System.Drawing.Point(63, 30);
            this.nextVocabLabel.Name = "nextVocabLabel";
            this.nextVocabLabel.Size = new System.Drawing.Size(221, 31);
            this.nextVocabLabel.TabIndex = 0;
            this.nextVocabLabel.Text = "Next Vocabulary:";
            // 
            // statisticsTab
            // 
            this.statisticsTab.Controls.Add(this.totalAmountWordsLabel);
            this.statisticsTab.Controls.Add(this.amountWords);
            this.statisticsTab.Controls.Add(this.amountDays);
            this.statisticsTab.Controls.Add(this.amountWrong);
            this.statisticsTab.Controls.Add(this.amountCorrect);
            this.statisticsTab.Controls.Add(this.ammoutDaysUsedLabel);
            this.statisticsTab.Controls.Add(this.amountWrongAnswersLabel);
            this.statisticsTab.Controls.Add(this.totalCorrectLabel);
            this.statisticsTab.Controls.Add(this.statsHeader);
            this.statisticsTab.Controls.Add(this.progressLabel);
            this.statisticsTab.Controls.Add(this.progress);
            this.statisticsTab.Controls.Add(this.chart1);
            this.statisticsTab.Location = new System.Drawing.Point(4, 22);
            this.statisticsTab.Name = "statisticsTab";
            this.statisticsTab.Padding = new System.Windows.Forms.Padding(3);
            this.statisticsTab.Size = new System.Drawing.Size(793, 429);
            this.statisticsTab.TabIndex = 1;
            this.statisticsTab.Text = "Statistics";
            this.statisticsTab.UseVisualStyleBackColor = true;
            this.statisticsTab.Enter += new System.EventHandler(this.statisticsTab_Enter);
            // 
            // settingsTab
            // 
            this.settingsTab.Location = new System.Drawing.Point(4, 22);
            this.settingsTab.Name = "settingsTab";
            this.settingsTab.Size = new System.Drawing.Size(793, 429);
            this.settingsTab.TabIndex = 2;
            this.settingsTab.Text = "Settings";
            this.settingsTab.UseVisualStyleBackColor = true;
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.LegendItemOrder = System.Windows.Forms.DataVisualization.Charting.LegendItemOrder.SameAsSeriesOrder;
            legend2.Name = "legend";
            legend2.Title = "Legend";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(388, 63);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
            series2.Legend = "legend";
            series2.Name = "Right answers";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(386, 300);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "Percentages:";
            // 
            // progress
            // 
            this.progress.Location = new System.Drawing.Point(37, 394);
            this.progress.Maximum = 500;
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(693, 23);
            this.progress.TabIndex = 1;
            // 
            // progressLabel
            // 
            this.progressLabel.AutoSize = true;
            this.progressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progressLabel.Location = new System.Drawing.Point(363, 366);
            this.progressLabel.Name = "progressLabel";
            this.progressLabel.Size = new System.Drawing.Size(61, 25);
            this.progressLabel.TabIndex = 3;
            this.progressLabel.Text = "x/500";
            // 
            // statsHeader
            // 
            this.statsHeader.AutoSize = true;
            this.statsHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statsHeader.Location = new System.Drawing.Point(333, 23);
            this.statsHeader.Name = "statsHeader";
            this.statsHeader.Size = new System.Drawing.Size(125, 31);
            this.statsHeader.TabIndex = 4;
            this.statsHeader.Text = "Statistics";
            // 
            // totalCorrectLabel
            // 
            this.totalCorrectLabel.AutoSize = true;
            this.totalCorrectLabel.Location = new System.Drawing.Point(37, 77);
            this.totalCorrectLabel.Name = "totalCorrectLabel";
            this.totalCorrectLabel.Size = new System.Drawing.Size(162, 13);
            this.totalCorrectLabel.TabIndex = 5;
            this.totalCorrectLabel.Text = "Total amount of correct answers:";
            // 
            // amountWrongAnswersLabel
            // 
            this.amountWrongAnswersLabel.AutoSize = true;
            this.amountWrongAnswersLabel.Location = new System.Drawing.Point(37, 108);
            this.amountWrongAnswersLabel.Name = "amountWrongAnswersLabel";
            this.amountWrongAnswersLabel.Size = new System.Drawing.Size(158, 13);
            this.amountWrongAnswersLabel.TabIndex = 6;
            this.amountWrongAnswersLabel.Text = "Total amount of wrong answers:";
            // 
            // ammoutDaysUsedLabel
            // 
            this.ammoutDaysUsedLabel.AutoSize = true;
            this.ammoutDaysUsedLabel.Location = new System.Drawing.Point(37, 143);
            this.ammoutDaysUsedLabel.Name = "ammoutDaysUsedLabel";
            this.ammoutDaysUsedLabel.Size = new System.Drawing.Size(164, 13);
            this.ammoutDaysUsedLabel.TabIndex = 7;
            this.ammoutDaysUsedLabel.Text = "Total amount of days being used:";
            // 
            // amountCorrect
            // 
            this.amountCorrect.AutoSize = true;
            this.amountCorrect.Location = new System.Drawing.Point(241, 77);
            this.amountCorrect.Name = "amountCorrect";
            this.amountCorrect.Size = new System.Drawing.Size(12, 13);
            this.amountCorrect.TabIndex = 8;
            this.amountCorrect.Text = "x";
            // 
            // amountWrong
            // 
            this.amountWrong.AutoSize = true;
            this.amountWrong.Location = new System.Drawing.Point(241, 108);
            this.amountWrong.Name = "amountWrong";
            this.amountWrong.Size = new System.Drawing.Size(12, 13);
            this.amountWrong.TabIndex = 9;
            this.amountWrong.Text = "x";
            // 
            // amountDays
            // 
            this.amountDays.AutoSize = true;
            this.amountDays.Location = new System.Drawing.Point(241, 143);
            this.amountDays.Name = "amountDays";
            this.amountDays.Size = new System.Drawing.Size(12, 13);
            this.amountDays.TabIndex = 10;
            this.amountDays.Text = "x";
            // 
            // amountWords
            // 
            this.amountWords.AutoSize = true;
            this.amountWords.Location = new System.Drawing.Point(241, 172);
            this.amountWords.Name = "amountWords";
            this.amountWords.Size = new System.Drawing.Size(12, 13);
            this.amountWords.TabIndex = 11;
            this.amountWords.Text = "x";
            // 
            // totalAmountWordsLabel
            // 
            this.totalAmountWordsLabel.AutoSize = true;
            this.totalAmountWordsLabel.Location = new System.Drawing.Point(40, 172);
            this.totalAmountWordsLabel.Name = "totalAmountWordsLabel";
            this.totalAmountWordsLabel.Size = new System.Drawing.Size(179, 13);
            this.totalAmountWordsLabel.TabIndex = 12;
            this.totalAmountWordsLabel.Text = "Total amount of words in the system:";
            // 
            // VocabularyGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "VocabularyGUI";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.VocabularyGUI_FormClosing);
            this.Load += new System.EventHandler(this.VocabularyGUI_Load);
            this.tabControl1.ResumeLayout(false);
            this.practiceTab.ResumeLayout(false);
            this.practiceTab.PerformLayout();
            this.dataPane.ResumeLayout(false);
            this.dataPane.PerformLayout();
            this.statisticsTab.ResumeLayout(false);
            this.statisticsTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage practiceTab;
        private System.Windows.Forms.Label correctAnswer;
        private System.Windows.Forms.Label givenAnswer;
        private System.Windows.Forms.Label correctAnswerLabel;
        private System.Windows.Forms.Label yourAnswerLabel;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.Label inputLabel;
        private System.Windows.Forms.TextBox answer;
        private System.Windows.Forms.Panel dataPane;
        private System.Windows.Forms.Label vocabulary;
        private System.Windows.Forms.Label nextVocabLabel;
        private System.Windows.Forms.TabPage statisticsTab;
        private System.Windows.Forms.TabPage settingsTab;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label statsHeader;
        private System.Windows.Forms.Label progressLabel;
        private System.Windows.Forms.ProgressBar progress;
        private System.Windows.Forms.Label amountDays;
        private System.Windows.Forms.Label amountWrong;
        private System.Windows.Forms.Label amountCorrect;
        private System.Windows.Forms.Label ammoutDaysUsedLabel;
        private System.Windows.Forms.Label amountWrongAnswersLabel;
        private System.Windows.Forms.Label totalCorrectLabel;
        private System.Windows.Forms.Label totalAmountWordsLabel;
        private System.Windows.Forms.Label amountWords;
    }
}

