﻿namespace TwcasChatter
{
    partial class MainFrm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrm));
            this.TopPanel = new System.Windows.Forms.Panel();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.btnWeb = new System.Windows.Forms.Button();
            this.txtBoxChannelName = new System.Windows.Forms.TextBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.TopPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.Black;
            this.TopPanel.Controls.Add(this.SettingsButton);
            this.TopPanel.Controls.Add(this.btnWeb);
            this.TopPanel.Controls.Add(this.txtBoxChannelName);
            this.TopPanel.Controls.Add(this.btnOpen);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(468, 55);
            this.TopPanel.TabIndex = 0;
            // 
            // SettingsButton
            // 
            this.SettingsButton.Location = new System.Drawing.Point(417, 10);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(48, 31);
            this.SettingsButton.TabIndex = 4;
            this.SettingsButton.Text = "設定";
            this.SettingsButton.UseVisualStyleBackColor = true;
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // btnWeb
            // 
            this.btnWeb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWeb.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnWeb.Image = global::TwcasChatter.Properties.Resources.twitcasting;
            this.btnWeb.Location = new System.Drawing.Point(12, 8);
            this.btnWeb.Name = "btnWeb";
            this.btnWeb.Size = new System.Drawing.Size(35, 35);
            this.btnWeb.TabIndex = 2;
            this.btnWeb.UseVisualStyleBackColor = true;
            this.btnWeb.Click += new System.EventHandler(this.btnWeb_Click);
            // 
            // txtBoxChannelName
            // 
            this.txtBoxChannelName.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtBoxChannelName.Location = new System.Drawing.Point(103, 16);
            this.txtBoxChannelName.Name = "txtBoxChannelName";
            this.txtBoxChannelName.Size = new System.Drawing.Size(258, 23);
            this.txtBoxChannelName.TabIndex = 1;
            this.txtBoxChannelName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBoxChannelName_KeyDown);
            this.txtBoxChannelName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBoxChannelName_KeyUp);
            // 
            // btnOpen
            // 
            this.btnOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpen.Image = global::TwcasChatter.Properties.Resources.更新2;
            this.btnOpen.Location = new System.Drawing.Point(53, 8);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(35, 35);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 55);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(468, 232);
            this.MainPanel.TabIndex = 1;
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(468, 287);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.TopPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainFrm";
            this.Text = "TwcasChatter";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFrm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainFrm_FormClosed);
            this.Load += new System.EventHandler(this.MainFrm_Load);
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.TextBox txtBoxChannelName;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Button btnWeb;
        private System.Windows.Forms.Button SettingsButton;
    }
}
