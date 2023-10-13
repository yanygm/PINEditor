
using System.Xml.Linq;

namespace PINEditor
{
	partial class PINEditor
	{
		/// <summary>
		/// 필수 디자이너 변수입니다.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 사용 중인 모든 리소스를 정리합니다.
		/// </summary>
		/// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 디자이너에서 생성한 코드

		/// <summary>
		/// 디자이너 지원에 필요한 메서드입니다. 
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
		/// </summary>
		private void InitializeComponent()
		{
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.portBox = new System.Windows.Forms.TextBox();
			this.label14 = new System.Windows.Forms.Label();
			this.ipv4Box = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.aesKeyBox = new System.Windows.Forms.TextBox();
			this.patchUrlBox = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.loginTypeBox = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.urlBox = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.unk5Box = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.unk4Box = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.minorVersionBox = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.unk3Box = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.localeTypeBox = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.unk2Box = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.localeIDBox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.unk1Box = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.Add1 = new System.Windows.Forms.Button();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.Del = new System.Windows.Forms.Button();
			this.label16 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.Apply = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label15 = new System.Windows.Forms.Label();
			this.listView1 = new System.Windows.Forms.ListView();
			this.Type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.Form = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.Value = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.treeView1 = new System.Windows.Forms.TreeView();
			this.menuStrip1.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.fileToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
			this.menuStrip1.Size = new System.Drawing.Size(686, 25);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.openToolStripMenuItem,
			this.saveToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
			this.fileToolStripMenuItem.Text = "文件";
			// 
			// openToolStripMenuItem
			// 
			this.openToolStripMenuItem.Name = "openToolStripMenuItem";
			this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
			this.openToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
			this.openToolStripMenuItem.Text = "打开";
			this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
			// 
			// saveToolStripMenuItem
			// 
			this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
			this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
			this.saveToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
			this.saveToolStripMenuItem.Text = "保存";
			this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Location = new System.Drawing.Point(0, 27);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(686, 411);
			this.tabControl1.TabIndex = 1;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.portBox);
			this.tabPage1.Controls.Add(this.label14);
			this.tabPage1.Controls.Add(this.ipv4Box);
			this.tabPage1.Controls.Add(this.label13);
			this.tabPage1.Controls.Add(this.aesKeyBox);
			this.tabPage1.Controls.Add(this.patchUrlBox);
			this.tabPage1.Controls.Add(this.label12);
			this.tabPage1.Controls.Add(this.label9);
			this.tabPage1.Controls.Add(this.loginTypeBox);
			this.tabPage1.Controls.Add(this.label11);
			this.tabPage1.Controls.Add(this.urlBox);
			this.tabPage1.Controls.Add(this.label10);
			this.tabPage1.Controls.Add(this.unk5Box);
			this.tabPage1.Controls.Add(this.label5);
			this.tabPage1.Controls.Add(this.unk4Box);
			this.tabPage1.Controls.Add(this.label6);
			this.tabPage1.Controls.Add(this.minorVersionBox);
			this.tabPage1.Controls.Add(this.label7);
			this.tabPage1.Controls.Add(this.unk3Box);
			this.tabPage1.Controls.Add(this.label8);
			this.tabPage1.Controls.Add(this.localeTypeBox);
			this.tabPage1.Controls.Add(this.label4);
			this.tabPage1.Controls.Add(this.unk2Box);
			this.tabPage1.Controls.Add(this.label3);
			this.tabPage1.Controls.Add(this.localeIDBox);
			this.tabPage1.Controls.Add(this.label2);
			this.tabPage1.Controls.Add(this.unk1Box);
			this.tabPage1.Controls.Add(this.label1);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(678, 385);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Primary Data";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// portBox
			// 
			this.portBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.portBox.Location = new System.Drawing.Point(278, 305);
			this.portBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.portBox.Name = "portBox";
			this.portBox.Size = new System.Drawing.Size(87, 21);
			this.portBox.TabIndex = 23;
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label14.Location = new System.Drawing.Point(246, 310);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(29, 12);
			this.label14.TabIndex = 22;
			this.label14.Text = "端口";
			this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// ipv4Box
			// 
			this.ipv4Box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ipv4Box.Location = new System.Drawing.Point(93, 305);
			this.ipv4Box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.ipv4Box.Name = "ipv4Box";
			this.ipv4Box.Size = new System.Drawing.Size(133, 21);
			this.ipv4Box.TabIndex = 21;
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.Location = new System.Drawing.Point(61, 310);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(29, 12);
			this.label13.TabIndex = 20;
			this.label13.Text = "地址";
			this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// aesKeyBox
			// 
			this.aesKeyBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.aesKeyBox.Location = new System.Drawing.Point(93, 230);
			this.aesKeyBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.aesKeyBox.Name = "aesKeyBox";
			this.aesKeyBox.Size = new System.Drawing.Size(272, 21);
			this.aesKeyBox.TabIndex = 19;
			// 
			// patchUrlBox
			// 
			this.patchUrlBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.patchUrlBox.Location = new System.Drawing.Point(93, 280);
			this.patchUrlBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.patchUrlBox.Name = "patchUrlBox";
			this.patchUrlBox.Size = new System.Drawing.Size(272, 21);
			this.patchUrlBox.TabIndex = 19;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("宋体", 9F);
			this.label12.Location = new System.Drawing.Point(49, 235);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(41, 12);
			this.label12.TabIndex = 18;
			this.label12.Text = "AESKey";
			this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("宋体", 9F);
			this.label9.Location = new System.Drawing.Point(37, 285);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(53, 12);
			this.label9.TabIndex = 18;
			this.label9.Text = "PatchURL";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// loginTypeBox
			// 
			this.loginTypeBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.loginTypeBox.Location = new System.Drawing.Point(93, 205);
			this.loginTypeBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.loginTypeBox.Name = "loginTypeBox";
			this.loginTypeBox.Size = new System.Drawing.Size(272, 21);
			this.loginTypeBox.TabIndex = 17;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("宋体", 9F);
			this.label11.Location = new System.Drawing.Point(31, 210);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(59, 12);
			this.label11.TabIndex = 16;
			this.label11.Text = "LoginType";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// urlBox
			// 
			this.urlBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.urlBox.Location = new System.Drawing.Point(93, 255);
			this.urlBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.urlBox.Name = "urlBox";
			this.urlBox.Size = new System.Drawing.Size(272, 21);
			this.urlBox.TabIndex = 17;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("宋体", 9F);
			this.label10.Location = new System.Drawing.Point(67, 260);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(23, 12);
			this.label10.TabIndex = 16;
			this.label10.Text = "URL";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// unk5Box
			// 
			this.unk5Box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.unk5Box.Location = new System.Drawing.Point(93, 180);
			this.unk5Box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.unk5Box.Name = "unk5Box";
			this.unk5Box.Size = new System.Drawing.Size(272, 21);
			this.unk5Box.TabIndex = 15;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("宋体", 9F);
			this.label5.Location = new System.Drawing.Point(61, 185);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(29, 12);
			this.label5.TabIndex = 14;
			this.label5.Text = "Unk5";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// unk4Box
			// 
			this.unk4Box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.unk4Box.Location = new System.Drawing.Point(93, 155);
			this.unk4Box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.unk4Box.Name = "unk4Box";
			this.unk4Box.Size = new System.Drawing.Size(272, 21);
			this.unk4Box.TabIndex = 13;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("宋体", 9F);
			this.label6.Location = new System.Drawing.Point(61, 160);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(29, 12);
			this.label6.TabIndex = 12;
			this.label6.Text = "Unk4";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// minorVersionBox
			// 
			this.minorVersionBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.minorVersionBox.Location = new System.Drawing.Point(93, 130);
			this.minorVersionBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.minorVersionBox.Name = "minorVersionBox";
			this.minorVersionBox.Size = new System.Drawing.Size(272, 21);
			this.minorVersionBox.TabIndex = 11;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("宋体", 9F);
			this.label7.Location = new System.Drawing.Point(13, 135);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(77, 12);
			this.label7.TabIndex = 10;
			this.label7.Text = "MinorVersion";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// unk3Box
			// 
			this.unk3Box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.unk3Box.Location = new System.Drawing.Point(93, 105);
			this.unk3Box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.unk3Box.Name = "unk3Box";
			this.unk3Box.Size = new System.Drawing.Size(272, 21);
			this.unk3Box.TabIndex = 9;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("宋体", 9F);
			this.label8.Location = new System.Drawing.Point(61, 110);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(29, 12);
			this.label8.TabIndex = 8;
			this.label8.Text = "Unk3";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// localeTypeBox
			// 
			this.localeTypeBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.localeTypeBox.Location = new System.Drawing.Point(93, 80);
			this.localeTypeBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.localeTypeBox.Name = "localeTypeBox";
			this.localeTypeBox.Size = new System.Drawing.Size(272, 21);
			this.localeTypeBox.TabIndex = 7;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("宋体", 9F);
			this.label4.Location = new System.Drawing.Point(25, 85);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(65, 12);
			this.label4.TabIndex = 6;
			this.label4.Text = "LocaleType";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// unk2Box
			// 
			this.unk2Box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.unk2Box.Location = new System.Drawing.Point(93, 55);
			this.unk2Box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.unk2Box.Name = "unk2Box";
			this.unk2Box.Size = new System.Drawing.Size(272, 21);
			this.unk2Box.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("宋体", 9F);
			this.label3.Location = new System.Drawing.Point(61, 60);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(29, 12);
			this.label3.TabIndex = 4;
			this.label3.Text = "Unk2";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// localeIDBox
			// 
			this.localeIDBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.localeIDBox.Location = new System.Drawing.Point(93, 30);
			this.localeIDBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.localeIDBox.Name = "localeIDBox";
			this.localeIDBox.Size = new System.Drawing.Size(272, 21);
			this.localeIDBox.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("宋体", 9F);
			this.label2.Location = new System.Drawing.Point(37, 35);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(53, 12);
			this.label2.TabIndex = 2;
			this.label2.Text = "LocaleID";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// unk1Box
			// 
			this.unk1Box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.unk1Box.Location = new System.Drawing.Point(93, 5);
			this.unk1Box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.unk1Box.Name = "unk1Box";
			this.unk1Box.Size = new System.Drawing.Size(272, 21);
			this.unk1Box.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("宋体", 9F);
			this.label1.Location = new System.Drawing.Point(61, 10);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(29, 12);
			this.label1.TabIndex = 0;
			this.label1.Text = "Unk1";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.Add1);
			this.tabPage2.Controls.Add(this.textBox3);
			this.tabPage2.Controls.Add(this.Del);
			this.tabPage2.Controls.Add(this.label16);
			this.tabPage2.Controls.Add(this.textBox2);
			this.tabPage2.Controls.Add(this.Apply);
			this.tabPage2.Controls.Add(this.textBox1);
			this.tabPage2.Controls.Add(this.label15);
			this.tabPage2.Controls.Add(this.listView1);
			this.tabPage2.Controls.Add(this.treeView1);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(678, 385);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Bml Info";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// Add1
			// 
			this.Add1.Location = new System.Drawing.Point(122, 345);
			this.Add1.Name = "Add1";
			this.Add1.Size = new System.Drawing.Size(64, 23);
			this.Add1.TabIndex = 9;
			this.Add1.Text = "增加";
			this.Add1.UseVisualStyleBackColor = true;
			this.Add1.Click += new System.EventHandler(this.Add1_Click);
			// 
			// textBox3
			// 
			this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox3.Location = new System.Drawing.Point(8, 345);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(108, 21);
			this.textBox3.TabIndex = 8;
			// 
			// Del
			// 
			this.Del.Location = new System.Drawing.Point(122, 310);
			this.Del.Name = "Del";
			this.Del.Size = new System.Drawing.Size(64, 23);
			this.Del.TabIndex = 7;
			this.Del.Text = "删除";
			this.Del.UseVisualStyleBackColor = true;
			this.Del.Click += new System.EventHandler(this.Del_Click);
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label16.Location = new System.Drawing.Point(207, 315);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(29, 12);
			this.label16.TabIndex = 6;
			this.label16.Text = "View";
			// 
			// textBox2
			// 
			this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.textBox2.Location = new System.Drawing.Point(245, 310);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(358, 21);
			this.textBox2.TabIndex = 5;
			// 
			// Apply
			// 
			this.Apply.Location = new System.Drawing.Point(606, 345);
			this.Apply.Name = "Apply";
			this.Apply.Size = new System.Drawing.Size(64, 23);
			this.Apply.TabIndex = 4;
			this.Apply.Text = "修改";
			this.Apply.UseVisualStyleBackColor = true;
			this.Apply.Click += new System.EventHandler(this.Apply_Click);
			// 
			// textBox1
			// 
			this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox1.Location = new System.Drawing.Point(245, 345);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(358, 21);
			this.textBox1.TabIndex = 3;
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label15.Location = new System.Drawing.Point(207, 350);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(35, 12);
			this.label15.TabIndex = 2;
			this.label15.Text = "Value";
			// 
			// listView1
			// 
			this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
			this.Type,
			this.Form,
			this.Value});
			this.listView1.HideSelection = false;
			this.listView1.Location = new System.Drawing.Point(191, 6);
			this.listView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(481, 289);
			this.listView1.TabIndex = 1;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = System.Windows.Forms.View.Details;
			this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
			// 
			// Type
			// 
			this.Type.Text = "Type";
			this.Type.Width = 120;
			// 
			// Form
			// 
			this.Form.Text = "Form";
			this.Form.Width = 109;
			// 
			// Value
			// 
			this.Value.Text = "Value";
			this.Value.Width = 251;
			// 
			// treeView1
			// 
			this.treeView1.Location = new System.Drawing.Point(4, 6);
			this.treeView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.treeView1.Name = "treeView1";
			this.treeView1.Size = new System.Drawing.Size(182, 289);
			this.treeView1.TabIndex = 0;
			this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
			this.treeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.nodeMouseClick);
			// 
			// PINEditor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(686, 437);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "PINEditor";
			this.Text = "PINEditor";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.TextBox unk1Box;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox localeTypeBox;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox unk2Box;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox localeIDBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox aesKeyBox;
		private System.Windows.Forms.TextBox patchUrlBox;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox loginTypeBox;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox urlBox;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox unk5Box;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox unk4Box;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox minorVersionBox;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox unk3Box;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.ColumnHeader Type;
		private System.Windows.Forms.ColumnHeader Form;
		private System.Windows.Forms.ColumnHeader Value;
		private System.Windows.Forms.TreeView treeView1;
		private System.Windows.Forms.TextBox ipv4Box;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.TextBox portBox;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Button Apply;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Button Del;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Button Add1;
	}
}

