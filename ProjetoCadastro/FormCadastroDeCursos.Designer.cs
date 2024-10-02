namespace ProjetoCadastro
{
    partial class FormCadastroDeCursos
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastroDeCursos));
            tabControlCadastroCursos = new ReaLTaiizor.Controls.MaterialTabControl();
            tabPage1 = new TabPage();
            BotaoSalvarCurso = new ReaLTaiizor.Controls.MaterialButton();
            BotaoCancelarCurso = new ReaLTaiizor.Controls.MaterialButton();
            CampoDeAreaDoCurso = new ReaLTaiizor.Controls.MaterialComboBox();
            CampoDePeriodoDoCurso = new ReaLTaiizor.Controls.MaterialComboBox();
            CampoDeDuracaoDoCurso = new ReaLTaiizor.Controls.MaterialComboBox();
            CampoDeNivelDoCurso = new ReaLTaiizor.Controls.MaterialComboBox();
            CampoNomeCurso = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            CampoCodigoCurso = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            tabPage2 = new TabPage();
            imageList1 = new ImageList(components);
            tabControlCadastroCursos.SuspendLayout();
            tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlCadastroCursos
            // 
            tabControlCadastroCursos.Controls.Add(tabPage1);
            tabControlCadastroCursos.Controls.Add(tabPage2);
            tabControlCadastroCursos.Depth = 0;
            tabControlCadastroCursos.ImageList = imageList1;
            tabControlCadastroCursos.Location = new Point(5, 50);
            tabControlCadastroCursos.Margin = new Padding(3, 2, 3, 2);
            tabControlCadastroCursos.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            tabControlCadastroCursos.Multiline = true;
            tabControlCadastroCursos.Name = "tabControlCadastroCursos";
            tabControlCadastroCursos.SelectedIndex = 0;
            tabControlCadastroCursos.Size = new Size(780, 417);
            tabControlCadastroCursos.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(BotaoSalvarCurso);
            tabPage1.Controls.Add(BotaoCancelarCurso);
            tabPage1.Controls.Add(CampoDeAreaDoCurso);
            tabPage1.Controls.Add(CampoDePeriodoDoCurso);
            tabPage1.Controls.Add(CampoDeDuracaoDoCurso);
            tabPage1.Controls.Add(CampoDeNivelDoCurso);
            tabPage1.Controls.Add(CampoNomeCurso);
            tabPage1.Controls.Add(CampoCodigoCurso);
            tabPage1.ImageKey = "ImagemConsulta.png";
            tabPage1.Location = new Point(4, 31);
            tabPage1.Margin = new Padding(3, 2, 3, 2);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3, 2, 3, 2);
            tabPage1.Size = new Size(772, 382);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Cadastro";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += tabPage1_Click;
            // 
            // BotaoSalvarCurso
            // 
            BotaoSalvarCurso.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BotaoSalvarCurso.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            BotaoSalvarCurso.Depth = 0;
            BotaoSalvarCurso.HighEmphasis = true;
            BotaoSalvarCurso.Icon = null;
            BotaoSalvarCurso.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            BotaoSalvarCurso.Location = new Point(660, 350);
            BotaoSalvarCurso.Margin = new Padding(4, 4, 4, 4);
            BotaoSalvarCurso.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            BotaoSalvarCurso.Name = "BotaoSalvarCurso";
            BotaoSalvarCurso.NoAccentTextColor = Color.Empty;
            BotaoSalvarCurso.Size = new Size(76, 36);
            BotaoSalvarCurso.TabIndex = 7;
            BotaoSalvarCurso.Text = "Salvar";
            BotaoSalvarCurso.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            BotaoSalvarCurso.UseAccentColor = false;
            BotaoSalvarCurso.UseVisualStyleBackColor = true;
            BotaoSalvarCurso.Click += BotaoSalvarCurso_Click;
            // 
            // BotaoCancelarCurso
            // 
            BotaoCancelarCurso.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BotaoCancelarCurso.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            BotaoCancelarCurso.Depth = 0;
            BotaoCancelarCurso.HighEmphasis = true;
            BotaoCancelarCurso.Icon = null;
            BotaoCancelarCurso.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            BotaoCancelarCurso.Location = new Point(523, 350);
            BotaoCancelarCurso.Margin = new Padding(4, 4, 4, 4);
            BotaoCancelarCurso.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            BotaoCancelarCurso.Name = "BotaoCancelarCurso";
            BotaoCancelarCurso.NoAccentTextColor = Color.Empty;
            BotaoCancelarCurso.Size = new Size(96, 36);
            BotaoCancelarCurso.TabIndex = 6;
            BotaoCancelarCurso.Text = "Cancelar";
            BotaoCancelarCurso.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            BotaoCancelarCurso.UseAccentColor = false;
            BotaoCancelarCurso.UseVisualStyleBackColor = true;
            // 
            // CampoDeAreaDoCurso
            // 
            CampoDeAreaDoCurso.AutoResize = false;
            CampoDeAreaDoCurso.BackColor = Color.FromArgb(255, 255, 255);
            CampoDeAreaDoCurso.Depth = 0;
            CampoDeAreaDoCurso.DrawMode = DrawMode.OwnerDrawVariable;
            CampoDeAreaDoCurso.DropDownHeight = 174;
            CampoDeAreaDoCurso.DropDownStyle = ComboBoxStyle.DropDownList;
            CampoDeAreaDoCurso.DropDownWidth = 121;
            CampoDeAreaDoCurso.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            CampoDeAreaDoCurso.ForeColor = Color.FromArgb(222, 0, 0, 0);
            CampoDeAreaDoCurso.FormattingEnabled = true;
            CampoDeAreaDoCurso.Hint = "Área";
            CampoDeAreaDoCurso.IntegralHeight = false;
            CampoDeAreaDoCurso.ItemHeight = 43;
            CampoDeAreaDoCurso.Location = new Point(85, 318);
            CampoDeAreaDoCurso.Margin = new Padding(3, 2, 3, 2);
            CampoDeAreaDoCurso.MaxDropDownItems = 4;
            CampoDeAreaDoCurso.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            CampoDeAreaDoCurso.Name = "CampoDeAreaDoCurso";
            CampoDeAreaDoCurso.Size = new Size(270, 49);
            CampoDeAreaDoCurso.StartIndex = 0;
            CampoDeAreaDoCurso.TabIndex = 5;
            // 
            // CampoDePeriodoDoCurso
            // 
            CampoDePeriodoDoCurso.AutoResize = false;
            CampoDePeriodoDoCurso.BackColor = Color.FromArgb(255, 255, 255);
            CampoDePeriodoDoCurso.Depth = 0;
            CampoDePeriodoDoCurso.DrawMode = DrawMode.OwnerDrawVariable;
            CampoDePeriodoDoCurso.DropDownHeight = 174;
            CampoDePeriodoDoCurso.DropDownStyle = ComboBoxStyle.DropDownList;
            CampoDePeriodoDoCurso.DropDownWidth = 121;
            CampoDePeriodoDoCurso.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            CampoDePeriodoDoCurso.ForeColor = Color.FromArgb(222, 0, 0, 0);
            CampoDePeriodoDoCurso.FormattingEnabled = true;
            CampoDePeriodoDoCurso.Hint = "Período";
            CampoDePeriodoDoCurso.IntegralHeight = false;
            CampoDePeriodoDoCurso.ItemHeight = 43;
            CampoDePeriodoDoCurso.Location = new Point(85, 193);
            CampoDePeriodoDoCurso.Margin = new Padding(3, 2, 3, 2);
            CampoDePeriodoDoCurso.MaxDropDownItems = 4;
            CampoDePeriodoDoCurso.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            CampoDePeriodoDoCurso.Name = "CampoDePeriodoDoCurso";
            CampoDePeriodoDoCurso.Size = new Size(270, 49);
            CampoDePeriodoDoCurso.StartIndex = 0;
            CampoDePeriodoDoCurso.TabIndex = 4;
            // 
            // CampoDeDuracaoDoCurso
            // 
            CampoDeDuracaoDoCurso.AutoResize = false;
            CampoDeDuracaoDoCurso.BackColor = Color.FromArgb(255, 255, 255);
            CampoDeDuracaoDoCurso.Depth = 0;
            CampoDeDuracaoDoCurso.DrawMode = DrawMode.OwnerDrawVariable;
            CampoDeDuracaoDoCurso.DropDownHeight = 174;
            CampoDeDuracaoDoCurso.DropDownStyle = ComboBoxStyle.DropDownList;
            CampoDeDuracaoDoCurso.DropDownWidth = 121;
            CampoDeDuracaoDoCurso.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            CampoDeDuracaoDoCurso.ForeColor = Color.FromArgb(222, 0, 0, 0);
            CampoDeDuracaoDoCurso.FormattingEnabled = true;
            CampoDeDuracaoDoCurso.Hint = "Duração do Semestre";
            CampoDeDuracaoDoCurso.IntegralHeight = false;
            CampoDeDuracaoDoCurso.ItemHeight = 43;
            CampoDeDuracaoDoCurso.Location = new Point(85, 255);
            CampoDeDuracaoDoCurso.Margin = new Padding(3, 2, 3, 2);
            CampoDeDuracaoDoCurso.MaxDropDownItems = 4;
            CampoDeDuracaoDoCurso.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            CampoDeDuracaoDoCurso.Name = "CampoDeDuracaoDoCurso";
            CampoDeDuracaoDoCurso.Size = new Size(270, 49);
            CampoDeDuracaoDoCurso.StartIndex = 0;
            CampoDeDuracaoDoCurso.TabIndex = 3;
            // 
            // CampoDeNivelDoCurso
            // 
            CampoDeNivelDoCurso.AutoResize = false;
            CampoDeNivelDoCurso.BackColor = Color.FromArgb(255, 255, 255);
            CampoDeNivelDoCurso.Depth = 0;
            CampoDeNivelDoCurso.DrawMode = DrawMode.OwnerDrawVariable;
            CampoDeNivelDoCurso.DropDownHeight = 174;
            CampoDeNivelDoCurso.DropDownStyle = ComboBoxStyle.DropDownList;
            CampoDeNivelDoCurso.DropDownWidth = 121;
            CampoDeNivelDoCurso.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            CampoDeNivelDoCurso.ForeColor = Color.FromArgb(222, 0, 0, 0);
            CampoDeNivelDoCurso.FormattingEnabled = true;
            CampoDeNivelDoCurso.Hint = "Nível";
            CampoDeNivelDoCurso.IntegralHeight = false;
            CampoDeNivelDoCurso.ItemHeight = 43;
            CampoDeNivelDoCurso.Location = new Point(85, 130);
            CampoDeNivelDoCurso.Margin = new Padding(3, 2, 3, 2);
            CampoDeNivelDoCurso.MaxDropDownItems = 4;
            CampoDeNivelDoCurso.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            CampoDeNivelDoCurso.Name = "CampoDeNivelDoCurso";
            CampoDeNivelDoCurso.Size = new Size(270, 49);
            CampoDeNivelDoCurso.StartIndex = 0;
            CampoDeNivelDoCurso.TabIndex = 2;
            // 
            // CampoNomeCurso
            // 
            CampoNomeCurso.AnimateReadOnly = false;
            CampoNomeCurso.AutoCompleteMode = AutoCompleteMode.None;
            CampoNomeCurso.AutoCompleteSource = AutoCompleteSource.None;
            CampoNomeCurso.BackgroundImageLayout = ImageLayout.None;
            CampoNomeCurso.CharacterCasing = CharacterCasing.Normal;
            CampoNomeCurso.Depth = 0;
            CampoNomeCurso.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            CampoNomeCurso.HideSelection = true;
            CampoNomeCurso.Hint = "Nome";
            CampoNomeCurso.LeadingIcon = null;
            CampoNomeCurso.Location = new Point(85, 74);
            CampoNomeCurso.Margin = new Padding(3, 2, 3, 2);
            CampoNomeCurso.MaxLength = 32767;
            CampoNomeCurso.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            CampoNomeCurso.Name = "CampoNomeCurso";
            CampoNomeCurso.PasswordChar = '\0';
            CampoNomeCurso.PrefixSuffixText = null;
            CampoNomeCurso.ReadOnly = false;
            CampoNomeCurso.RightToLeft = RightToLeft.No;
            CampoNomeCurso.SelectedText = "";
            CampoNomeCurso.SelectionLength = 0;
            CampoNomeCurso.SelectionStart = 0;
            CampoNomeCurso.ShortcutsEnabled = true;
            CampoNomeCurso.Size = new Size(522, 48);
            CampoNomeCurso.TabIndex = 1;
            CampoNomeCurso.TabStop = false;
            CampoNomeCurso.TextAlign = HorizontalAlignment.Left;
            CampoNomeCurso.TrailingIcon = null;
            CampoNomeCurso.UseSystemPasswordChar = false;
            // 
            // CampoCodigoCurso
            // 
            CampoCodigoCurso.AnimateReadOnly = false;
            CampoCodigoCurso.AutoCompleteMode = AutoCompleteMode.None;
            CampoCodigoCurso.AutoCompleteSource = AutoCompleteSource.None;
            CampoCodigoCurso.BackgroundImageLayout = ImageLayout.None;
            CampoCodigoCurso.CharacterCasing = CharacterCasing.Normal;
            CampoCodigoCurso.Depth = 0;
            CampoCodigoCurso.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            CampoCodigoCurso.HideSelection = true;
            CampoCodigoCurso.Hint = "Código do Curso";
            CampoCodigoCurso.LeadingIcon = null;
            CampoCodigoCurso.Location = new Point(85, 23);
            CampoCodigoCurso.Margin = new Padding(3, 2, 3, 2);
            CampoCodigoCurso.MaxLength = 32767;
            CampoCodigoCurso.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            CampoCodigoCurso.Name = "CampoCodigoCurso";
            CampoCodigoCurso.PasswordChar = '\0';
            CampoCodigoCurso.PrefixSuffixText = null;
            CampoCodigoCurso.ReadOnly = false;
            CampoCodigoCurso.RightToLeft = RightToLeft.No;
            CampoCodigoCurso.SelectedText = "";
            CampoCodigoCurso.SelectionLength = 0;
            CampoCodigoCurso.SelectionStart = 0;
            CampoCodigoCurso.ShortcutsEnabled = true;
            CampoCodigoCurso.Size = new Size(522, 48);
            CampoCodigoCurso.TabIndex = 0;
            CampoCodigoCurso.TabStop = false;
            CampoCodigoCurso.TextAlign = HorizontalAlignment.Left;
            CampoCodigoCurso.TrailingIcon = null;
            CampoCodigoCurso.UseSystemPasswordChar = false;
            // 
            // tabPage2
            // 
            tabPage2.ImageKey = "ImagemLupa.png";
            tabPage2.Location = new Point(4, 31);
            tabPage2.Margin = new Padding(3, 2, 3, 2);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3, 2, 3, 2);
            tabPage2.Size = new Size(772, 382);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Consulta";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "ImagemConsulta.png");
            imageList1.Images.SetKeyName(1, "ImagemLupa.png");
            // 
            // FormCadastroDeCursos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(791, 472);
            Controls.Add(tabControlCadastroCursos);
            DrawerShowIconsWhenHidden = true;
            DrawerTabControl = tabControlCadastroCursos;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormCadastroDeCursos";
            Padding = new Padding(3, 48, 3, 2);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Cursos";
            Load += FormCadastroDeCursos_Load;
            tabControlCadastroCursos.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTabControl tabControlCadastroCursos;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit CampoNomeCurso;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit CampoCodigoCurso;
        private ReaLTaiizor.Controls.MaterialComboBox CampoDeAreaDoCurso;
        private ReaLTaiizor.Controls.MaterialComboBox CampoDePeriodoDoCurso;
        private ReaLTaiizor.Controls.MaterialComboBox CampoDeDuracaoDoCurso;
        private ReaLTaiizor.Controls.MaterialComboBox CampoDeNivelDoCurso;
        private ReaLTaiizor.Controls.MaterialButton BotaoSalvarCurso;
        private ReaLTaiizor.Controls.MaterialButton BotaoCancelarCurso;
        private ImageList imageList1;
    }
}