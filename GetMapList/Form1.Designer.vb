<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.txtBrowse = New System.Windows.Forms.TextBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.txtPopulate = New System.Windows.Forms.TextBox()
        Me.btnExport = New System.Windows.Forms.Button()
        Me.save = New System.Windows.Forms.SaveFileDialog()
        Me.lbTypes = New System.Windows.Forms.ListBox()
        Me.btnCustomAdd = New System.Windows.Forms.Button()
        Me.fbdSaveLoc = New System.Windows.Forms.FolderBrowserDialog()
        Me.txtSave = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnBrowse
        '
        Me.btnBrowse.Location = New System.Drawing.Point(267, 237)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(75, 23)
        Me.btnBrowse.TabIndex = 0
        Me.btnBrowse.Text = "Browse"
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'txtBrowse
        '
        Me.txtBrowse.Location = New System.Drawing.Point(11, 237)
        Me.txtBrowse.Name = "txtBrowse"
        Me.txtBrowse.Size = New System.Drawing.Size(233, 20)
        Me.txtBrowse.TabIndex = 1
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(12, 12)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(46, 30)
        Me.ListBox1.TabIndex = 2
        Me.ListBox1.Visible = False
        '
        'txtPopulate
        '
        Me.txtPopulate.Location = New System.Drawing.Point(12, 12)
        Me.txtPopulate.Multiline = True
        Me.txtPopulate.Name = "txtPopulate"
        Me.txtPopulate.Size = New System.Drawing.Size(232, 148)
        Me.txtPopulate.TabIndex = 4
        '
        'btnExport
        '
        Me.btnExport.Location = New System.Drawing.Point(267, 210)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(75, 23)
        Me.btnExport.TabIndex = 5
        Me.btnExport.Text = "Export"
        Me.btnExport.UseVisualStyleBackColor = True
        '
        'lbTypes
        '
        Me.lbTypes.FormattingEnabled = True
        Me.lbTypes.Items.AddRange(New Object() {"mapcycle.txt", "maplist.txt", "arena_mapcycle.txt"})
        Me.lbTypes.Location = New System.Drawing.Point(250, 12)
        Me.lbTypes.Name = "lbTypes"
        Me.lbTypes.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.lbTypes.Size = New System.Drawing.Size(116, 160)
        Me.lbTypes.TabIndex = 6
        '
        'btnCustomAdd
        '
        Me.btnCustomAdd.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnCustomAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCustomAdd.Location = New System.Drawing.Point(305, 178)
        Me.btnCustomAdd.Name = "btnCustomAdd"
        Me.btnCustomAdd.Size = New System.Drawing.Size(61, 20)
        Me.btnCustomAdd.TabIndex = 7
        Me.btnCustomAdd.Text = "Custom..."
        Me.btnCustomAdd.UseVisualStyleBackColor = False
        '
        'txtSave
        '
        Me.txtSave.Location = New System.Drawing.Point(12, 210)
        Me.txtSave.Name = "txtSave"
        Me.txtSave.Size = New System.Drawing.Size(232, 20)
        Me.txtSave.TabIndex = 9
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(12, 166)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(232, 38)
        Me.TextBox1.TabIndex = 10
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(369, 262)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.txtSave)
        Me.Controls.Add(Me.btnCustomAdd)
        Me.Controls.Add(Me.lbTypes)
        Me.Controls.Add(Me.btnExport)
        Me.Controls.Add(Me.txtPopulate)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.txtBrowse)
        Me.Controls.Add(Me.btnBrowse)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(385, 301)
        Me.MinimumSize = New System.Drawing.Size(385, 301)
        Me.Name = "Form1"
        Me.Text = "GetMapList"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnBrowse As System.Windows.Forms.Button
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents txtBrowse As System.Windows.Forms.TextBox
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents txtPopulate As System.Windows.Forms.TextBox
    Friend WithEvents btnExport As System.Windows.Forms.Button
    Friend WithEvents save As System.Windows.Forms.SaveFileDialog
    Friend WithEvents lbTypes As System.Windows.Forms.ListBox
    Friend WithEvents btnCustomAdd As System.Windows.Forms.Button
    Friend WithEvents fbdSaveLoc As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents txtSave As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox

End Class
