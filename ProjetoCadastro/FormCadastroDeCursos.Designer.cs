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
            mlvCursos = new ListView();
            BotaoDeNovoCurso = new ReaLTaiizor.Controls.MaterialButton();
            BotaoDeEditarCurso = new ReaLTaiizor.Controls.MaterialButton();
            BotaoDeExcluirCurso = new ReaLTaiizor.Controls.MaterialButton();
            imageList1 = new ImageList(components);
            tabControlCadastroCursos.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlCadastroCursos
            // 
            tabControlCadastroCursos.Controls.Add(tabPage1);
            tabControlCadastroCursos.Controls.Add(tabPage2);
            tabControlCadastroCursos.Depth = 0;
            tabControlCadastroCursos.Dock = DockStyle.Fill;
            tabControlCadastroCursos.ImageList = imageList1;
            tabControlCadastroCursos.Location = new Point(3, 64);
            tabControlCadastroCursos.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            tabControlCadastroCursos.Multiline = true;
            tabControlCadastroCursos.Name = "tabControlCadastroCursos";
            tabControlCadastroCursos.SelectedIndex = 0;
            tabControlCadastroCursos.Size = new Size(898, 574);
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
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(890, 539);
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
            BotaoSalvarCurso.Location = new Point(665, 467);
            BotaoSalvarCurso.Margin = new Padding(5);
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
            BotaoCancelarCurso.Location = new Point(521, 467);
            BotaoCancelarCurso.Margin = new Padding(5);
            BotaoCancelarCurso.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            BotaoCancelarCurso.Name = "BotaoCancelarCurso";
            BotaoCancelarCurso.NoAccentTextColor = Color.Empty;
            BotaoCancelarCurso.Size = new Size(96, 36);
            BotaoCancelarCurso.TabIndex = 6;
            BotaoCancelarCurso.Text = "Cancelar";
            BotaoCancelarCurso.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            BotaoCancelarCurso.UseAccentColor = false;
            BotaoCancelarCurso.UseVisualStyleBackColor = true;
            BotaoCancelarCurso.Click += BotaoCancelarCurso_Click;
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
            CampoDeAreaDoCurso.Items.AddRange(new object[] { "Licenciatura", "Informática", "Indústria", "Administração" });
            CampoDeAreaDoCurso.Location = new Point(7, 380);
            CampoDeAreaDoCurso.MaxDropDownItems = 4;
            CampoDeAreaDoCurso.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            CampoDeAreaDoCurso.Name = "CampoDeAreaDoCurso";
            CampoDeAreaDoCurso.Size = new Size(308, 49);
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
            CampoDePeriodoDoCurso.Items.AddRange(new object[] { "Matutino", "Vespertino", "Noturno", "Integral" });
            CampoDePeriodoDoCurso.Location = new Point(7, 239);
            CampoDePeriodoDoCurso.MaxDropDownItems = 4;
            CampoDePeriodoDoCurso.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            CampoDePeriodoDoCurso.Name = "CampoDePeriodoDoCurso";
            CampoDePeriodoDoCurso.Size = new Size(308, 49);
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
            CampoDeDuracaoDoCurso.Items.AddRange(new object[] { "1 Semestre", "2 Semestres", "3 Semestres", "4 Semestres", "5 Semestres", "6 Semestres", "7 Semestres", "8 Semestres", "9 Semestres", "10 Semestres" });
            CampoDeDuracaoDoCurso.Location = new Point(7, 309);
            CampoDeDuracaoDoCurso.MaxDropDownItems = 4;
            CampoDeDuracaoDoCurso.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            CampoDeDuracaoDoCurso.Name = "CampoDeDuracaoDoCurso";
            CampoDeDuracaoDoCurso.Size = new Size(308, 49);
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
            CampoDeNivelDoCurso.Items.AddRange(new object[] { "Técnico", "Superior" });
            CampoDeNivelDoCurso.Location = new Point(7, 168);
            CampoDeNivelDoCurso.MaxDropDownItems = 4;
            CampoDeNivelDoCurso.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            CampoDeNivelDoCurso.Name = "CampoDeNivelDoCurso";
            CampoDeNivelDoCurso.Size = new Size(308, 49);
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
            CampoNomeCurso.Location = new Point(7, 99);
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
            CampoNomeCurso.Size = new Size(597, 48);
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
            CampoCodigoCurso.Location = new Point(7, 29);
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
            CampoCodigoCurso.Size = new Size(597, 48);
            CampoCodigoCurso.TabIndex = 0;
            CampoCodigoCurso.TabStop = false;
            CampoCodigoCurso.TextAlign = HorizontalAlignment.Left;
            CampoCodigoCurso.TrailingIcon = null;
            CampoCodigoCurso.UseSystemPasswordChar = false;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(mlvCursos);
            tabPage2.Controls.Add(BotaoDeNovoCurso);
            tabPage2.Controls.Add(BotaoDeEditarCurso);
            tabPage2.Controls.Add(BotaoDeExcluirCurso);
            tabPage2.ImageKey = "ImagemLupa.png";
            tabPage2.Location = new Point(4, 31);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(890, 539);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Consulta";
            tabPage2.UseVisualStyleBackColor = true;
            tabPage2.Enter += tabPage2_Enter;
            // 
            // mlvCursos
            // 
            mlvCursos.FullRowSelect = true;
            mlvCursos.Location = new Point(-1, 0);
            mlvCursos.Name = "mlvCursos";
            mlvCursos.Size = new Size(891, 451);
            mlvCursos.TabIndex = 4;
            mlvCursos.UseCompatibleStateImageBehavior = false;
            mlvCursos.View = View.Details;
            mlvCursos.MouseDoubleClick += mlvCursos_MouseDoubleClick_1;
            // 
            // BotaoDeNovoCurso
            // 
            BotaoDeNovoCurso.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BotaoDeNovoCurso.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            BotaoDeNovoCurso.Depth = 0;
            BotaoDeNovoCurso.HighEmphasis = true;
            BotaoDeNovoCurso.Icon = null;
            BotaoDeNovoCurso.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            BotaoDeNovoCurso.Location = new Point(463, 453);
            BotaoDeNovoCurso.Margin = new Padding(5, 8, 5, 8);
            BotaoDeNovoCurso.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            BotaoDeNovoCurso.Name = "BotaoDeNovoCurso";
            BotaoDeNovoCurso.NoAccentTextColor = Color.Empty;
            BotaoDeNovoCurso.Size = new Size(64, 36);
            BotaoDeNovoCurso.TabIndex = 3;
            BotaoDeNovoCurso.Text = "Novo";
            BotaoDeNovoCurso.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            BotaoDeNovoCurso.UseAccentColor = false;
            BotaoDeNovoCurso.UseVisualStyleBackColor = true;
            BotaoDeNovoCurso.Click += BotaoDeNovoCurso_Click;
            // 
            // BotaoDeEditarCurso
            // 
            BotaoDeEditarCurso.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BotaoDeEditarCurso.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            BotaoDeEditarCurso.Depth = 0;
            BotaoDeEditarCurso.HighEmphasis = true;
            BotaoDeEditarCurso.Icon = null;
            BotaoDeEditarCurso.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            BotaoDeEditarCurso.Location = new Point(560, 453);
            BotaoDeEditarCurso.Margin = new Padding(5, 8, 5, 8);
            BotaoDeEditarCurso.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            BotaoDeEditarCurso.Name = "BotaoDeEditarCurso";
            BotaoDeEditarCurso.NoAccentTextColor = Color.Empty;
            BotaoDeEditarCurso.Size = new Size(71, 36);
            BotaoDeEditarCurso.TabIndex = 2;
            BotaoDeEditarCurso.Text = "Editar";
            BotaoDeEditarCurso.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            BotaoDeEditarCurso.UseAccentColor = false;
            BotaoDeEditarCurso.UseVisualStyleBackColor = true;
            BotaoDeEditarCurso.Click += BotaoDeEditarCurso_Click;
            // 
            // BotaoDeExcluirCurso
            // 
            BotaoDeExcluirCurso.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BotaoDeExcluirCurso.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            BotaoDeExcluirCurso.Depth = 0;
            BotaoDeExcluirCurso.HighEmphasis = true;
            BotaoDeExcluirCurso.Icon = null;
            BotaoDeExcluirCurso.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            BotaoDeExcluirCurso.Location = new Point(664, 453);
            BotaoDeExcluirCurso.Margin = new Padding(5, 8, 5, 8);
            BotaoDeExcluirCurso.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            BotaoDeExcluirCurso.Name = "BotaoDeExcluirCurso";
            BotaoDeExcluirCurso.NoAccentTextColor = Color.Empty;
            BotaoDeExcluirCurso.Size = new Size(80, 36);
            BotaoDeExcluirCurso.TabIndex = 1;
            BotaoDeExcluirCurso.Text = "Excluir";
            BotaoDeExcluirCurso.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            BotaoDeExcluirCurso.UseAccentColor = false;
            BotaoDeExcluirCurso.UseVisualStyleBackColor = true;
            BotaoDeExcluirCurso.Click += BotaoDeExcluirCurso_Click;
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
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(904, 641);
            Controls.Add(tabControlCadastroCursos);
            DrawerShowIconsWhenHidden = true;
            DrawerTabControl = tabControlCadastroCursos;
            Name = "FormCadastroDeCursos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Cursos";
            Load += FormCadastroDeCursos_Load;
            tabControlCadastroCursos.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
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
        private ReaLTaiizor.Controls.MaterialButton BotaoDeNovoCurso;
        private ReaLTaiizor.Controls.MaterialButton BotaoDeEditarCurso;
        private ReaLTaiizor.Controls.MaterialButton BotaoDeExcluirCurso;
        private ListView mlvCursos;
    }
}