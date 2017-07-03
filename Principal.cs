using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Calculadora
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Principal : System.Windows.Forms.Form
	{
		private Variavel [] Vars;
		
		private System.Windows.Forms.TextBox txtExpr;
		private System.Windows.Forms.Button btnCalc;
		private System.Windows.Forms.DataGrid dgrVars;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.TextBox txtResult;
		private System.Windows.Forms.DataGridTableStyle dataGridTableStyle1;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn1;
		private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn2;
        private GroupBox groupBox4;
        private TextBox txtPos;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Principal()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();
			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.txtExpr = new System.Windows.Forms.TextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.dgrVars = new System.Windows.Forms.DataGrid();
            this.dataGridTableStyle1 = new System.Windows.Forms.DataGridTableStyle();
            this.dataGridTextBoxColumn1 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn2 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtPos = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgrVars)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtExpr
            // 
            this.txtExpr.Location = new System.Drawing.Point(8, 24);
            this.txtExpr.Name = "txtExpr";
            this.txtExpr.Size = new System.Drawing.Size(184, 27);
            this.txtExpr.TabIndex = 0;
            this.txtExpr.TextChanged += new System.EventHandler(this.txtExpr_TextChanged);
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(200, 24);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(104, 32);
            this.btnCalc.TabIndex = 2;
            this.btnCalc.Text = "&Calcular";
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // dgrVars
            // 
            this.dgrVars.CaptionText = "Variáveis";
            this.dgrVars.CaptionVisible = false;
            this.dgrVars.DataMember = "";
            this.dgrVars.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dgrVars.Location = new System.Drawing.Point(8, 24);
            this.dgrVars.Name = "dgrVars";
            this.dgrVars.Size = new System.Drawing.Size(296, 200);
            this.dgrVars.TabIndex = 3;
            this.dgrVars.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {
            this.dataGridTableStyle1});
            // 
            // dataGridTableStyle1
            // 
            this.dataGridTableStyle1.DataGrid = this.dgrVars;
            this.dataGridTableStyle1.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {
            this.dataGridTextBoxColumn1,
            this.dataGridTextBoxColumn2});
            this.dataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dataGridTableStyle1.MappingName = "Vars";
            // 
            // dataGridTextBoxColumn1
            // 
            this.dataGridTextBoxColumn1.Format = "";
            this.dataGridTextBoxColumn1.FormatInfo = null;
            this.dataGridTextBoxColumn1.MappingName = "Nome";
            this.dataGridTextBoxColumn1.Width = 75;
            // 
            // dataGridTextBoxColumn2
            // 
            this.dataGridTextBoxColumn2.Format = "";
            this.dataGridTextBoxColumn2.FormatInfo = null;
            this.dataGridTextBoxColumn2.MappingName = "Valor";
            this.dataGridTextBoxColumn2.Width = 75;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCalc);
            this.groupBox1.Controls.Add(this.txtExpr);
            this.groupBox1.Location = new System.Drawing.Point(8, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(312, 64);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Expressão:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgrVars);
            this.groupBox2.Location = new System.Drawing.Point(8, 80);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(312, 232);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Variáveis:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtResult);
            this.groupBox3.Location = new System.Drawing.Point(8, 388);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(312, 64);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Resultado:";
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(8, 24);
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(296, 27);
            this.txtResult.TabIndex = 0;
            this.txtResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtPos);
            this.groupBox4.Location = new System.Drawing.Point(8, 318);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(312, 64);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Pós-fixa:";
            // 
            // txtPos
            // 
            this.txtPos.Location = new System.Drawing.Point(8, 24);
            this.txtPos.Name = "txtPos";
            this.txtPos.ReadOnly = true;
            this.txtPos.Size = new System.Drawing.Size(296, 27);
            this.txtPos.TabIndex = 0;
            this.txtPos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Principal
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(10, 20);
            this.ClientSize = new System.Drawing.Size(328, 461);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Principal";
            this.Text = "Calculadora";
            ((System.ComponentModel.ISupportInitialize)(this.dgrVars)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Principal());
		}

        // Encontrando o valor se tiver nas vars
        private double GetValue(string Var)
        {
            if ((Vars == null) || (Var == null)) return 0;
            foreach (Variavel v in Vars)
            {
                if (v.Nome == Var)
                    return v.Valor;
            }
            return 0;
        }
        
        
        // Mudando o texto da caixa de texto analizamos se existem novas variáveis, e adicionamos na tabela
        private void txtExpr_TextChanged(object sender, System.EventArgs e)
		{
            Hashtable temp = new Hashtable();
            int i = 0;
            string t = "";
			foreach (char c in txtExpr.Text)
			{
                if ((c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z'))
                {
                    t += c;
                }
                else
                {
                    if (t != "")
                    {
                        temp[t] = GetValue(t);
                        t = "";
                    }
                }
			}
            if (t != "")
            {
                temp[t] = GetValue(t);
                t = "";
            }
            Vars = new Variavel[temp.Count];
			i = 0;
			foreach (DictionaryEntry de in temp)
			{
                string s = de.Key as string;
                if ((s != "") && (s != null))
                {
                    Vars[i] = new Variavel();
                    Vars[i].Nome = s;
                    Vars[i].Valor = Convert.ToDouble(de.Value);
                    i++;
                }
			}
			dgrVars.DataSource = Vars;
		}

		// Função que chama as rotinas para cálculo da expressão
		private void btnCalc_Click(object sender, System.EventArgs e)
		{
			Calc c = new Calc();
			if (c.Analisar(txtExpr.Text))
			{
				string pos = c.Converter(txtExpr.Text);
                txtPos.Text = pos;
				double res = c.Calcular(pos, Vars);
				txtResult.Text = res.ToString();
			}
			else
			{
                txtPos.Text = "Expressão Inválida!";
                txtResult.Text = "0";
			}
		}
	}
}
