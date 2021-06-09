namespace MonsterMerger.UserInterface {
    partial class StatCalculator {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StatCalculator));
            this.LabelAthletics = new System.Windows.Forms.Label();
            this.IntPutAthletics = new System.Windows.Forms.NumericUpDown();
            this.LabelAthleticsCalc = new System.Windows.Forms.Label();
            this.IntPutConviction = new System.Windows.Forms.NumericUpDown();
            this.LabelConviction = new System.Windows.Forms.Label();
            this.IntPutBody = new System.Windows.Forms.NumericUpDown();
            this.LabelBody = new System.Windows.Forms.Label();
            this.LabelInput = new System.Windows.Forms.Label();
            this.panelVitality = new System.Windows.Forms.Panel();
            this.DisplayThresholdOverkill = new System.Windows.Forms.Label();
            this.DisplayThresholdDeadly = new System.Windows.Forms.Label();
            this.DisplayMaxDeadly = new System.Windows.Forms.Label();
            this.DisplayThresholdCritical = new System.Windows.Forms.Label();
            this.DisplayMaxCritical = new System.Windows.Forms.Label();
            this.DisplayThresholdMauled = new System.Windows.Forms.Label();
            this.DisplayMaxMauled = new System.Windows.Forms.Label();
            this.DisplayThresholdInjured = new System.Windows.Forms.Label();
            this.DisplayMaxInjured = new System.Windows.Forms.Label();
            this.LabelOverkill = new System.Windows.Forms.Label();
            this.LabelDeadly = new System.Windows.Forms.Label();
            this.LabelCritical = new System.Windows.Forms.Label();
            this.LabelMauled = new System.Windows.Forms.Label();
            this.LabelVitalityThreshold = new System.Windows.Forms.Label();
            this.LabelVitalityMaximum = new System.Windows.Forms.Label();
            this.LabelInjured = new System.Windows.Forms.Label();
            this.LabelVitality = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LabelTotal = new System.Windows.Forms.Label();
            this.DisplayTotalSpeed = new System.Windows.Forms.Label();
            this.IntPutMoveAmount = new System.Windows.Forms.NumericUpDown();
            this.LabelMoveAmount = new System.Windows.Forms.Label();
            this.LabelStep = new System.Windows.Forms.Label();
            this.DisplayLeftOver = new System.Windows.Forms.Label();
            this.DisplayTileAmount = new System.Windows.Forms.Label();
            this.LabelLeftOver = new System.Windows.Forms.Label();
            this.LabelTileAmount = new System.Windows.Forms.Label();
            this.IntPutTileSize = new System.Windows.Forms.NumericUpDown();
            this.LabelTileSize = new System.Windows.Forms.Label();
            this.DisplayStepSpeed = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.IntPutAthletics)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IntPutConviction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IntPutBody)).BeginInit();
            this.panelVitality.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IntPutMoveAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IntPutTileSize)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelAthletics
            // 
            this.LabelAthletics.AutoSize = true;
            this.LabelAthletics.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelAthletics.Location = new System.Drawing.Point(10, 108);
            this.LabelAthletics.Name = "LabelAthletics";
            this.LabelAthletics.Size = new System.Drawing.Size(61, 16);
            this.LabelAthletics.TabIndex = 0;
            this.LabelAthletics.Text = "Athletics:";
            // 
            // IntPutAthletics
            // 
            this.IntPutAthletics.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IntPutAthletics.Location = new System.Drawing.Point(76, 105);
            this.IntPutAthletics.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.IntPutAthletics.Name = "IntPutAthletics";
            this.IntPutAthletics.Size = new System.Drawing.Size(45, 22);
            this.IntPutAthletics.TabIndex = 23;
            this.IntPutAthletics.ValueChanged += new System.EventHandler(this.ValueChanged);
            // 
            // LabelAthleticsCalc
            // 
            this.LabelAthleticsCalc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabelAthleticsCalc.Location = new System.Drawing.Point(127, 105);
            this.LabelAthleticsCalc.Name = "LabelAthleticsCalc";
            this.LabelAthleticsCalc.Size = new System.Drawing.Size(38, 22);
            this.LabelAthleticsCalc.TabIndex = 24;
            this.LabelAthleticsCalc.Text = "2x 6+";
            this.LabelAthleticsCalc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // IntPutConviction
            // 
            this.IntPutConviction.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IntPutConviction.Location = new System.Drawing.Point(120, 65);
            this.IntPutConviction.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.IntPutConviction.Minimum = new decimal(new int[] {
            999,
            0,
            0,
            -2147483648});
            this.IntPutConviction.Name = "IntPutConviction";
            this.IntPutConviction.Size = new System.Drawing.Size(45, 22);
            this.IntPutConviction.TabIndex = 26;
            this.IntPutConviction.ValueChanged += new System.EventHandler(this.ValueChanged);
            // 
            // LabelConviction
            // 
            this.LabelConviction.AutoSize = true;
            this.LabelConviction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelConviction.Location = new System.Drawing.Point(91, 42);
            this.LabelConviction.Name = "LabelConviction";
            this.LabelConviction.Size = new System.Drawing.Size(92, 20);
            this.LabelConviction.TabIndex = 25;
            this.LabelConviction.Text = "Conviction";
            // 
            // IntPutBody
            // 
            this.IntPutBody.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IntPutBody.Location = new System.Drawing.Point(13, 65);
            this.IntPutBody.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.IntPutBody.Minimum = new decimal(new int[] {
            999,
            0,
            0,
            -2147483648});
            this.IntPutBody.Name = "IntPutBody";
            this.IntPutBody.Size = new System.Drawing.Size(45, 22);
            this.IntPutBody.TabIndex = 24;
            this.IntPutBody.ValueChanged += new System.EventHandler(this.ValueChanged);
            // 
            // LabelBody
            // 
            this.LabelBody.AutoSize = true;
            this.LabelBody.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelBody.Location = new System.Drawing.Point(9, 42);
            this.LabelBody.Name = "LabelBody";
            this.LabelBody.Size = new System.Drawing.Size(49, 20);
            this.LabelBody.TabIndex = 23;
            this.LabelBody.Text = "Body";
            // 
            // LabelInput
            // 
            this.LabelInput.AutoSize = true;
            this.LabelInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelInput.Location = new System.Drawing.Point(2, 7);
            this.LabelInput.Name = "LabelInput";
            this.LabelInput.Size = new System.Drawing.Size(64, 25);
            this.LabelInput.TabIndex = 27;
            this.LabelInput.Text = "Input";
            // 
            // panelVitality
            // 
            this.panelVitality.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelVitality.Controls.Add(this.DisplayThresholdOverkill);
            this.panelVitality.Controls.Add(this.DisplayThresholdDeadly);
            this.panelVitality.Controls.Add(this.DisplayMaxDeadly);
            this.panelVitality.Controls.Add(this.DisplayThresholdCritical);
            this.panelVitality.Controls.Add(this.DisplayMaxCritical);
            this.panelVitality.Controls.Add(this.DisplayThresholdMauled);
            this.panelVitality.Controls.Add(this.DisplayMaxMauled);
            this.panelVitality.Controls.Add(this.DisplayThresholdInjured);
            this.panelVitality.Controls.Add(this.DisplayMaxInjured);
            this.panelVitality.Controls.Add(this.LabelOverkill);
            this.panelVitality.Controls.Add(this.LabelDeadly);
            this.panelVitality.Controls.Add(this.LabelCritical);
            this.panelVitality.Controls.Add(this.LabelMauled);
            this.panelVitality.Controls.Add(this.LabelVitalityThreshold);
            this.panelVitality.Controls.Add(this.LabelVitalityMaximum);
            this.panelVitality.Controls.Add(this.LabelInjured);
            this.panelVitality.Controls.Add(this.LabelVitality);
            this.panelVitality.Location = new System.Drawing.Point(-4, 142);
            this.panelVitality.Name = "panelVitality";
            this.panelVitality.Size = new System.Drawing.Size(302, 204);
            this.panelVitality.TabIndex = 78;
            this.panelVitality.Paint += new System.Windows.Forms.PaintEventHandler(this.panelVitality_Paint);
            // 
            // DisplayThresholdOverkill
            // 
            this.DisplayThresholdOverkill.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DisplayThresholdOverkill.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayThresholdOverkill.Location = new System.Drawing.Point(180, 164);
            this.DisplayThresholdOverkill.Name = "DisplayThresholdOverkill";
            this.DisplayThresholdOverkill.Size = new System.Drawing.Size(42, 20);
            this.DisplayThresholdOverkill.TabIndex = 108;
            this.DisplayThresholdOverkill.Text = "1";
            this.DisplayThresholdOverkill.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // DisplayThresholdDeadly
            // 
            this.DisplayThresholdDeadly.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DisplayThresholdDeadly.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayThresholdDeadly.Location = new System.Drawing.Point(180, 138);
            this.DisplayThresholdDeadly.Name = "DisplayThresholdDeadly";
            this.DisplayThresholdDeadly.Size = new System.Drawing.Size(42, 20);
            this.DisplayThresholdDeadly.TabIndex = 106;
            this.DisplayThresholdDeadly.Text = "1";
            this.DisplayThresholdDeadly.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // DisplayMaxDeadly
            // 
            this.DisplayMaxDeadly.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DisplayMaxDeadly.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayMaxDeadly.Location = new System.Drawing.Point(110, 138);
            this.DisplayMaxDeadly.Name = "DisplayMaxDeadly";
            this.DisplayMaxDeadly.Size = new System.Drawing.Size(42, 20);
            this.DisplayMaxDeadly.TabIndex = 105;
            this.DisplayMaxDeadly.Text = "1";
            this.DisplayMaxDeadly.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // DisplayThresholdCritical
            // 
            this.DisplayThresholdCritical.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DisplayThresholdCritical.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayThresholdCritical.Location = new System.Drawing.Point(180, 110);
            this.DisplayThresholdCritical.Name = "DisplayThresholdCritical";
            this.DisplayThresholdCritical.Size = new System.Drawing.Size(42, 20);
            this.DisplayThresholdCritical.TabIndex = 104;
            this.DisplayThresholdCritical.Text = "1";
            this.DisplayThresholdCritical.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // DisplayMaxCritical
            // 
            this.DisplayMaxCritical.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DisplayMaxCritical.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayMaxCritical.Location = new System.Drawing.Point(110, 110);
            this.DisplayMaxCritical.Name = "DisplayMaxCritical";
            this.DisplayMaxCritical.Size = new System.Drawing.Size(42, 20);
            this.DisplayMaxCritical.TabIndex = 103;
            this.DisplayMaxCritical.Text = "0";
            this.DisplayMaxCritical.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // DisplayThresholdMauled
            // 
            this.DisplayThresholdMauled.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DisplayThresholdMauled.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayThresholdMauled.Location = new System.Drawing.Point(180, 82);
            this.DisplayThresholdMauled.Name = "DisplayThresholdMauled";
            this.DisplayThresholdMauled.Size = new System.Drawing.Size(42, 20);
            this.DisplayThresholdMauled.TabIndex = 102;
            this.DisplayThresholdMauled.Text = "1";
            this.DisplayThresholdMauled.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // DisplayMaxMauled
            // 
            this.DisplayMaxMauled.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DisplayMaxMauled.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayMaxMauled.Location = new System.Drawing.Point(110, 82);
            this.DisplayMaxMauled.Name = "DisplayMaxMauled";
            this.DisplayMaxMauled.Size = new System.Drawing.Size(42, 20);
            this.DisplayMaxMauled.TabIndex = 101;
            this.DisplayMaxMauled.Text = "0";
            this.DisplayMaxMauled.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // DisplayThresholdInjured
            // 
            this.DisplayThresholdInjured.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DisplayThresholdInjured.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayThresholdInjured.Location = new System.Drawing.Point(180, 55);
            this.DisplayThresholdInjured.Name = "DisplayThresholdInjured";
            this.DisplayThresholdInjured.Size = new System.Drawing.Size(42, 20);
            this.DisplayThresholdInjured.TabIndex = 100;
            this.DisplayThresholdInjured.Text = "1";
            this.DisplayThresholdInjured.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // DisplayMaxInjured
            // 
            this.DisplayMaxInjured.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DisplayMaxInjured.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayMaxInjured.Location = new System.Drawing.Point(110, 55);
            this.DisplayMaxInjured.Name = "DisplayMaxInjured";
            this.DisplayMaxInjured.Size = new System.Drawing.Size(42, 20);
            this.DisplayMaxInjured.TabIndex = 98;
            this.DisplayMaxInjured.Text = "0";
            this.DisplayMaxInjured.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LabelOverkill
            // 
            this.LabelOverkill.AutoSize = true;
            this.LabelOverkill.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelOverkill.Location = new System.Drawing.Point(38, 165);
            this.LabelOverkill.Name = "LabelOverkill";
            this.LabelOverkill.Size = new System.Drawing.Size(60, 16);
            this.LabelOverkill.TabIndex = 97;
            this.LabelOverkill.Text = "Over Kill:";
            this.LabelOverkill.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // LabelDeadly
            // 
            this.LabelDeadly.AutoSize = true;
            this.LabelDeadly.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDeadly.Location = new System.Drawing.Point(43, 138);
            this.LabelDeadly.Name = "LabelDeadly";
            this.LabelDeadly.Size = new System.Drawing.Size(55, 16);
            this.LabelDeadly.TabIndex = 93;
            this.LabelDeadly.Text = "Deadly:";
            this.LabelDeadly.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // LabelCritical
            // 
            this.LabelCritical.AutoSize = true;
            this.LabelCritical.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCritical.Location = new System.Drawing.Point(48, 110);
            this.LabelCritical.Name = "LabelCritical";
            this.LabelCritical.Size = new System.Drawing.Size(51, 16);
            this.LabelCritical.TabIndex = 89;
            this.LabelCritical.Text = "Critical:";
            this.LabelCritical.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // LabelMauled
            // 
            this.LabelMauled.AutoSize = true;
            this.LabelMauled.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelMauled.Location = new System.Drawing.Point(42, 84);
            this.LabelMauled.Name = "LabelMauled";
            this.LabelMauled.Size = new System.Drawing.Size(56, 16);
            this.LabelMauled.TabIndex = 85;
            this.LabelMauled.Text = "Mauled:";
            this.LabelMauled.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // LabelVitalityThreshold
            // 
            this.LabelVitalityThreshold.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LabelVitalityThreshold.AutoSize = true;
            this.LabelVitalityThreshold.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelVitalityThreshold.Location = new System.Drawing.Point(170, 32);
            this.LabelVitalityThreshold.Name = "LabelVitalityThreshold";
            this.LabelVitalityThreshold.Size = new System.Drawing.Size(62, 15);
            this.LabelVitalityThreshold.TabIndex = 81;
            this.LabelVitalityThreshold.Text = "Threshold";
            // 
            // LabelVitalityMaximum
            // 
            this.LabelVitalityMaximum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LabelVitalityMaximum.AutoSize = true;
            this.LabelVitalityMaximum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelVitalityMaximum.Location = new System.Drawing.Point(101, 32);
            this.LabelVitalityMaximum.Name = "LabelVitalityMaximum";
            this.LabelVitalityMaximum.Size = new System.Drawing.Size(63, 15);
            this.LabelVitalityMaximum.TabIndex = 80;
            this.LabelVitalityMaximum.Text = "Maximum";
            // 
            // LabelInjured
            // 
            this.LabelInjured.AutoSize = true;
            this.LabelInjured.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelInjured.Location = new System.Drawing.Point(49, 57);
            this.LabelInjured.Name = "LabelInjured";
            this.LabelInjured.Size = new System.Drawing.Size(51, 16);
            this.LabelInjured.TabIndex = 78;
            this.LabelInjured.Text = "Injured:";
            this.LabelInjured.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // LabelVitality
            // 
            this.LabelVitality.AutoSize = true;
            this.LabelVitality.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelVitality.Location = new System.Drawing.Point(3, 10);
            this.LabelVitality.Name = "LabelVitality";
            this.LabelVitality.Size = new System.Drawing.Size(62, 18);
            this.LabelVitality.TabIndex = 77;
            this.LabelVitality.Text = "Vitality:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.LabelTotal);
            this.panel1.Controls.Add(this.DisplayTotalSpeed);
            this.panel1.Controls.Add(this.IntPutMoveAmount);
            this.panel1.Controls.Add(this.LabelMoveAmount);
            this.panel1.Controls.Add(this.LabelStep);
            this.panel1.Controls.Add(this.DisplayLeftOver);
            this.panel1.Controls.Add(this.DisplayTileAmount);
            this.panel1.Controls.Add(this.LabelLeftOver);
            this.panel1.Controls.Add(this.LabelTileAmount);
            this.panel1.Controls.Add(this.IntPutTileSize);
            this.panel1.Controls.Add(this.LabelTileSize);
            this.panel1.Controls.Add(this.DisplayStepSpeed);
            this.panel1.Controls.Add(this.label27);
            this.panel1.Location = new System.Drawing.Point(-4, 344);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(302, 162);
            this.panel1.TabIndex = 109;
            // 
            // LabelTotal
            // 
            this.LabelTotal.AutoSize = true;
            this.LabelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTotal.Location = new System.Drawing.Point(88, 91);
            this.LabelTotal.Name = "LabelTotal";
            this.LabelTotal.Size = new System.Drawing.Size(86, 16);
            this.LabelTotal.TabIndex = 118;
            this.LabelTotal.Text = "Total Meters:";
            // 
            // DisplayTotalSpeed
            // 
            this.DisplayTotalSpeed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DisplayTotalSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayTotalSpeed.Location = new System.Drawing.Point(180, 88);
            this.DisplayTotalSpeed.Name = "DisplayTotalSpeed";
            this.DisplayTotalSpeed.Size = new System.Drawing.Size(42, 20);
            this.DisplayTotalSpeed.TabIndex = 117;
            this.DisplayTotalSpeed.Text = "0";
            this.DisplayTotalSpeed.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolTip1.SetToolTip(this.DisplayTotalSpeed, "The total amount you can move using all your Move Actions");
            // 
            // IntPutMoveAmount
            // 
            this.IntPutMoveAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IntPutMoveAmount.Location = new System.Drawing.Point(157, 29);
            this.IntPutMoveAmount.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.IntPutMoveAmount.Name = "IntPutMoveAmount";
            this.IntPutMoveAmount.Size = new System.Drawing.Size(45, 22);
            this.IntPutMoveAmount.TabIndex = 116;
            this.toolTip1.SetToolTip(this.IntPutMoveAmount, "The amount of Move Actions you are allowed to make during one turn");
            this.IntPutMoveAmount.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.IntPutMoveAmount.ValueChanged += new System.EventHandler(this.ValueChanged);
            // 
            // LabelMoveAmount
            // 
            this.LabelMoveAmount.AutoSize = true;
            this.LabelMoveAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelMoveAmount.Location = new System.Drawing.Point(136, 10);
            this.LabelMoveAmount.Name = "LabelMoveAmount";
            this.LabelMoveAmount.Size = new System.Drawing.Size(90, 16);
            this.LabelMoveAmount.TabIndex = 115;
            this.LabelMoveAmount.Text = "Move Amount";
            // 
            // LabelStep
            // 
            this.LabelStep.AutoSize = true;
            this.LabelStep.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelStep.Location = new System.Drawing.Point(68, 68);
            this.LabelStep.Name = "LabelStep";
            this.LabelStep.Size = new System.Drawing.Size(106, 16);
            this.LabelStep.TabIndex = 114;
            this.LabelStep.Text = "Meters per Step:";
            // 
            // DisplayLeftOver
            // 
            this.DisplayLeftOver.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DisplayLeftOver.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayLeftOver.Location = new System.Drawing.Point(180, 134);
            this.DisplayLeftOver.Name = "DisplayLeftOver";
            this.DisplayLeftOver.Size = new System.Drawing.Size(42, 20);
            this.DisplayLeftOver.TabIndex = 113;
            this.DisplayLeftOver.Text = "0";
            this.DisplayLeftOver.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolTip1.SetToolTip(this.DisplayLeftOver, "Left over movenement speed for diagonal calculations");
            // 
            // DisplayTileAmount
            // 
            this.DisplayTileAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DisplayTileAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayTileAmount.Location = new System.Drawing.Point(180, 111);
            this.DisplayTileAmount.Name = "DisplayTileAmount";
            this.DisplayTileAmount.Size = new System.Drawing.Size(42, 20);
            this.DisplayTileAmount.TabIndex = 109;
            this.DisplayTileAmount.Text = "0";
            this.DisplayTileAmount.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolTip1.SetToolTip(this.DisplayTileAmount, "The amount of tiles you can move using all Move Actions");
            // 
            // LabelLeftOver
            // 
            this.LabelLeftOver.AutoSize = true;
            this.LabelLeftOver.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelLeftOver.Location = new System.Drawing.Point(71, 134);
            this.LabelLeftOver.Name = "LabelLeftOver";
            this.LabelLeftOver.Size = new System.Drawing.Size(103, 16);
            this.LabelLeftOver.TabIndex = 112;
            this.LabelLeftOver.Text = "Leftover Speed:";
            // 
            // LabelTileAmount
            // 
            this.LabelTileAmount.AutoSize = true;
            this.LabelTileAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTileAmount.Location = new System.Drawing.Point(77, 111);
            this.LabelTileAmount.Name = "LabelTileAmount";
            this.LabelTileAmount.Size = new System.Drawing.Size(97, 16);
            this.LabelTileAmount.TabIndex = 111;
            this.LabelTileAmount.Text = "Amount of tiles:";
            // 
            // IntPutTileSize
            // 
            this.IntPutTileSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IntPutTileSize.Location = new System.Drawing.Point(74, 29);
            this.IntPutTileSize.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.IntPutTileSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.IntPutTileSize.Name = "IntPutTileSize";
            this.IntPutTileSize.Size = new System.Drawing.Size(45, 22);
            this.IntPutTileSize.TabIndex = 110;
            this.toolTip1.SetToolTip(this.IntPutTileSize, "The size of one map tile/unit");
            this.IntPutTileSize.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.IntPutTileSize.ValueChanged += new System.EventHandler(this.ValueChanged);
            // 
            // LabelTileSize
            // 
            this.LabelTileSize.AutoSize = true;
            this.LabelTileSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTileSize.Location = new System.Drawing.Point(67, 10);
            this.LabelTileSize.Name = "LabelTileSize";
            this.LabelTileSize.Size = new System.Drawing.Size(61, 16);
            this.LabelTileSize.TabIndex = 109;
            this.LabelTileSize.Text = "Tile size:";
            // 
            // DisplayStepSpeed
            // 
            this.DisplayStepSpeed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DisplayStepSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayStepSpeed.Location = new System.Drawing.Point(180, 65);
            this.DisplayStepSpeed.Name = "DisplayStepSpeed";
            this.DisplayStepSpeed.Size = new System.Drawing.Size(42, 20);
            this.DisplayStepSpeed.TabIndex = 108;
            this.DisplayStepSpeed.Text = "0";
            this.DisplayStepSpeed.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolTip1.SetToolTip(this.DisplayStepSpeed, "The amount of movenement you can make with one Move Action");
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(3, 10);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(60, 18);
            this.label27.TabIndex = 77;
            this.label27.Text = "Speed:";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.LabelInput);
            this.panel2.Controls.Add(this.LabelBody);
            this.panel2.Controls.Add(this.IntPutBody);
            this.panel2.Controls.Add(this.LabelConviction);
            this.panel2.Controls.Add(this.LabelAthletics);
            this.panel2.Controls.Add(this.LabelAthleticsCalc);
            this.panel2.Controls.Add(this.IntPutAthletics);
            this.panel2.Controls.Add(this.IntPutConviction);
            this.panel2.Location = new System.Drawing.Point(-4, -5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(302, 151);
            this.panel2.TabIndex = 109;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(9, 535);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 123;
            this.label2.Text = "Made By: Kitty Soldier";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(122, 512);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 50);
            this.pictureBox1.TabIndex = 122;
            this.pictureBox1.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox1, "Mrreow!");
            // 
            // StatCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 571);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelVitality);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "StatCalculator";
            this.Text = "Vitality Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.IntPutAthletics)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IntPutConviction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IntPutBody)).EndInit();
            this.panelVitality.ResumeLayout(false);
            this.panelVitality.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IntPutMoveAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IntPutTileSize)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelAthletics;
        private System.Windows.Forms.NumericUpDown IntPutAthletics;
        private System.Windows.Forms.Label LabelAthleticsCalc;
        private System.Windows.Forms.NumericUpDown IntPutConviction;
        private System.Windows.Forms.Label LabelConviction;
        private System.Windows.Forms.NumericUpDown IntPutBody;
        private System.Windows.Forms.Label LabelBody;
        private System.Windows.Forms.Label LabelInput;
        private System.Windows.Forms.Panel panelVitality;
        private System.Windows.Forms.Label LabelOverkill;
        private System.Windows.Forms.Label LabelDeadly;
        private System.Windows.Forms.Label LabelCritical;
        private System.Windows.Forms.Label LabelMauled;
        private System.Windows.Forms.Label LabelVitalityThreshold;
        private System.Windows.Forms.Label LabelVitalityMaximum;
        private System.Windows.Forms.Label LabelInjured;
        private System.Windows.Forms.Label LabelVitality;
        private System.Windows.Forms.Label DisplayMaxInjured;
        private System.Windows.Forms.Label DisplayThresholdDeadly;
        private System.Windows.Forms.Label DisplayMaxDeadly;
        private System.Windows.Forms.Label DisplayThresholdCritical;
        private System.Windows.Forms.Label DisplayMaxCritical;
        private System.Windows.Forms.Label DisplayThresholdMauled;
        private System.Windows.Forms.Label DisplayMaxMauled;
        private System.Windows.Forms.Label DisplayThresholdInjured;
        private System.Windows.Forms.Label DisplayThresholdOverkill;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LabelTileAmount;
        private System.Windows.Forms.NumericUpDown IntPutTileSize;
        private System.Windows.Forms.Label LabelTileSize;
        private System.Windows.Forms.Label DisplayStepSpeed;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label DisplayLeftOver;
        private System.Windows.Forms.Label DisplayTileAmount;
        private System.Windows.Forms.Label LabelLeftOver;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.NumericUpDown IntPutMoveAmount;
        private System.Windows.Forms.Label LabelMoveAmount;
        private System.Windows.Forms.Label LabelStep;
        private System.Windows.Forms.Label LabelTotal;
        private System.Windows.Forms.Label DisplayTotalSpeed;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}