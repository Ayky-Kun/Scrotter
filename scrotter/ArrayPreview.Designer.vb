﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ArrayPreview
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Preview = New System.Windows.Forms.PictureBox()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.BackgroundType = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BackgroundLoadBtn = New System.Windows.Forms.Button()
        Me.ColorDialog = New System.Windows.Forms.ColorDialog()
        Me.ColorPickBtn = New System.Windows.Forms.Button()
        Me.ColorPreview = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ImagePatternPicker = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.InnerBox = New System.Windows.Forms.NumericUpDown()
        Me.OuterBox = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.Preview, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ColorPreview, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InnerBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OuterBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Preview
        '
        Me.Preview.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Preview.InitialImage = Nothing
        Me.Preview.Location = New System.Drawing.Point(0, 0)
        Me.Preview.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Preview.Name = "Preview"
        Me.Preview.Size = New System.Drawing.Size(719, 354)
        Me.Preview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Preview.TabIndex = 7
        Me.Preview.TabStop = False
        '
        'SaveButton
        '
        Me.SaveButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.SaveButton.Location = New System.Drawing.Point(593, 382)
        Me.SaveButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(114, 23)
        Me.SaveButton.TabIndex = 6
        Me.SaveButton.Text = "Save..."
        Me.SaveButton.UseVisualStyleBackColor = True
        '
        'BackgroundType
        '
        Me.BackgroundType.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BackgroundType.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BackgroundType.FormattingEnabled = True
        Me.BackgroundType.Items.AddRange(New Object() {"Transparent", "Solid Color", "Load Image"})
        Me.BackgroundType.Location = New System.Drawing.Point(112, 383)
        Me.BackgroundType.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BackgroundType.Name = "BackgroundType"
        Me.BackgroundType.Size = New System.Drawing.Size(91, 21)
        Me.BackgroundType.TabIndex = 2
        Me.BackgroundType.Text = "Transparent"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 384)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Background Type:"
        '
        'BackgroundLoadBtn
        '
        Me.BackgroundLoadBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BackgroundLoadBtn.Enabled = False
        Me.BackgroundLoadBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BackgroundLoadBtn.Location = New System.Drawing.Point(313, 382)
        Me.BackgroundLoadBtn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BackgroundLoadBtn.Name = "BackgroundLoadBtn"
        Me.BackgroundLoadBtn.Size = New System.Drawing.Size(117, 23)
        Me.BackgroundLoadBtn.TabIndex = 4
        Me.BackgroundLoadBtn.Text = "Load Background..."
        Me.BackgroundLoadBtn.UseVisualStyleBackColor = True
        '
        'ColorPickBtn
        '
        Me.ColorPickBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ColorPickBtn.Enabled = False
        Me.ColorPickBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ColorPickBtn.Location = New System.Drawing.Point(209, 382)
        Me.ColorPickBtn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ColorPickBtn.Name = "ColorPickBtn"
        Me.ColorPickBtn.Size = New System.Drawing.Size(75, 23)
        Me.ColorPickBtn.TabIndex = 3
        Me.ColorPickBtn.Text = "Pick Color..."
        Me.ColorPickBtn.UseVisualStyleBackColor = True
        '
        'ColorPreview
        '
        Me.ColorPreview.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ColorPreview.BackColor = System.Drawing.Color.Transparent
        Me.ColorPreview.Location = New System.Drawing.Point(284, 382)
        Me.ColorPreview.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ColorPreview.Name = "ColorPreview"
        Me.ColorPreview.Size = New System.Drawing.Size(23, 23)
        Me.ColorPreview.TabIndex = 13
        Me.ColorPreview.TabStop = False
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Enabled = False
        Me.Label2.Location = New System.Drawing.Point(436, 386)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Image Pattern:"
        '
        'ImagePatternPicker
        '
        Me.ImagePatternPicker.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ImagePatternPicker.Enabled = False
        Me.ImagePatternPicker.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ImagePatternPicker.FormattingEnabled = True
        Me.ImagePatternPicker.Items.AddRange(New Object() {"Single", "Stretch", "Tile"})
        Me.ImagePatternPicker.Location = New System.Drawing.Point(525, 383)
        Me.ImagePatternPicker.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ImagePatternPicker.Name = "ImagePatternPicker"
        Me.ImagePatternPicker.Size = New System.Drawing.Size(62, 21)
        Me.ImagePatternPicker.TabIndex = 5
        Me.ImagePatternPicker.Text = "Single"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(33, 363)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Inner Margin:"
        '
        'InnerBox
        '
        Me.InnerBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.InnerBox.Location = New System.Drawing.Point(112, 362)
        Me.InnerBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.InnerBox.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.InnerBox.Name = "InnerBox"
        Me.InnerBox.Size = New System.Drawing.Size(49, 20)
        Me.InnerBox.TabIndex = 0
        '
        'OuterBox
        '
        Me.OuterBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.OuterBox.Location = New System.Drawing.Point(290, 362)
        Me.OuterBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.OuterBox.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.OuterBox.Name = "OuterBox"
        Me.OuterBox.Size = New System.Drawing.Size(45, 20)
        Me.OuterBox.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(206, 363)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 13)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Outer Margin:"
        '
        'ArrayPreview
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(719, 410)
        Me.Controls.Add(Me.OuterBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.InnerBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ImagePatternPicker)
        Me.Controls.Add(Me.ColorPreview)
        Me.Controls.Add(Me.ColorPickBtn)
        Me.Controls.Add(Me.BackgroundLoadBtn)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BackgroundType)
        Me.Controls.Add(Me.SaveButton)
        Me.Controls.Add(Me.Preview)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MinimumSize = New System.Drawing.Size(729, 212)
        Me.Name = "ArrayPreview"
        Me.Text = "Multi-Screen Editor"
        CType(Me.Preview, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ColorPreview, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InnerBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OuterBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Preview As System.Windows.Forms.PictureBox
    Friend WithEvents SaveButton As System.Windows.Forms.Button
    Friend WithEvents BackgroundType As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BackgroundLoadBtn As System.Windows.Forms.Button
    Friend WithEvents ColorDialog As System.Windows.Forms.ColorDialog
    Friend WithEvents ColorPickBtn As System.Windows.Forms.Button
    Friend WithEvents ColorPreview As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ImagePatternPicker As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents InnerBox As System.Windows.Forms.NumericUpDown
    Friend WithEvents OuterBox As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
