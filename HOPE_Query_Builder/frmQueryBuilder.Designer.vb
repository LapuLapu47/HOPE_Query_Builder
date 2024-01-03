<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmQueryBuilder
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.btnExecute = New System.Windows.Forms.Button()
        Me.CheckedListBox1 = New System.Windows.Forms.CheckedListBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.tbFilter5 = New System.Windows.Forms.TextBox()
        Me.tbFilter4 = New System.Windows.Forms.TextBox()
        Me.tbFilter3 = New System.Windows.Forms.TextBox()
        Me.tbFilter2 = New System.Windows.Forms.TextBox()
        Me.tbFilter1 = New System.Windows.Forms.TextBox()
        Me.cbColOperator5 = New System.Windows.Forms.ComboBox()
        Me.cbColOperator4 = New System.Windows.Forms.ComboBox()
        Me.cbColOperator3 = New System.Windows.Forms.ComboBox()
        Me.cbColOperator2 = New System.Windows.Forms.ComboBox()
        Me.cbColOperator1 = New System.Windows.Forms.ComboBox()
        Me.cbColFilter5 = New System.Windows.Forms.ComboBox()
        Me.cbColFilter4 = New System.Windows.Forms.ComboBox()
        Me.cbColFilter3 = New System.Windows.Forms.ComboBox()
        Me.cbColFilter2 = New System.Windows.Forms.ComboBox()
        Me.cbColFilter1 = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.Splitter2 = New System.Windows.Forms.Splitter()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Splitter1 = New System.Windows.Forms.Splitter()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.dgvResults = New System.Windows.Forms.DataGridView()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.MoveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SingleTransactionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AllTransactionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dgvResults, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnExecute
        '
        Me.btnExecute.Location = New System.Drawing.Point(821, 135)
        Me.btnExecute.Name = "btnExecute"
        Me.btnExecute.Size = New System.Drawing.Size(75, 23)
        Me.btnExecute.TabIndex = 26
        Me.btnExecute.Text = "Execute"
        Me.btnExecute.UseVisualStyleBackColor = True
        '
        'CheckedListBox1
        '
        Me.CheckedListBox1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CheckedListBox1.FormattingEnabled = True
        Me.CheckedListBox1.Items.AddRange(New Object() {"..."})
        Me.CheckedListBox1.Location = New System.Drawing.Point(176, 37)
        Me.CheckedListBox1.Name = "CheckedListBox1"
        Me.CheckedListBox1.Size = New System.Drawing.Size(208, 94)
        Me.CheckedListBox1.TabIndex = 5
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnClear)
        Me.Panel1.Controls.Add(Me.tbFilter5)
        Me.Panel1.Controls.Add(Me.btnExecute)
        Me.Panel1.Controls.Add(Me.tbFilter4)
        Me.Panel1.Controls.Add(Me.tbFilter3)
        Me.Panel1.Controls.Add(Me.tbFilter2)
        Me.Panel1.Controls.Add(Me.tbFilter1)
        Me.Panel1.Controls.Add(Me.cbColOperator5)
        Me.Panel1.Controls.Add(Me.cbColOperator4)
        Me.Panel1.Controls.Add(Me.cbColOperator3)
        Me.Panel1.Controls.Add(Me.cbColOperator2)
        Me.Panel1.Controls.Add(Me.cbColOperator1)
        Me.Panel1.Controls.Add(Me.cbColFilter5)
        Me.Panel1.Controls.Add(Me.cbColFilter4)
        Me.Panel1.Controls.Add(Me.cbColFilter3)
        Me.Panel1.Controls.Add(Me.cbColFilter2)
        Me.Panel1.Controls.Add(Me.cbColFilter1)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.CheckBox1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.RadioButton4)
        Me.Panel1.Controls.Add(Me.RadioButton3)
        Me.Panel1.Controls.Add(Me.CheckedListBox1)
        Me.Panel1.Controls.Add(Me.RadioButton2)
        Me.Panel1.Controls.Add(Me.RadioButton1)
        Me.Panel1.Controls.Add(Me.Splitter2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Splitter1)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(913, 173)
        Me.Panel1.TabIndex = 2
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(821, 29)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 27
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'tbFilter5
        '
        Me.tbFilter5.Location = New System.Drawing.Point(704, 138)
        Me.tbFilter5.Name = "tbFilter5"
        Me.tbFilter5.Size = New System.Drawing.Size(100, 20)
        Me.tbFilter5.TabIndex = 25
        '
        'tbFilter4
        '
        Me.tbFilter4.Location = New System.Drawing.Point(704, 112)
        Me.tbFilter4.Name = "tbFilter4"
        Me.tbFilter4.Size = New System.Drawing.Size(100, 20)
        Me.tbFilter4.TabIndex = 22
        '
        'tbFilter3
        '
        Me.tbFilter3.Location = New System.Drawing.Point(704, 84)
        Me.tbFilter3.Name = "tbFilter3"
        Me.tbFilter3.Size = New System.Drawing.Size(100, 20)
        Me.tbFilter3.TabIndex = 19
        '
        'tbFilter2
        '
        Me.tbFilter2.Location = New System.Drawing.Point(704, 57)
        Me.tbFilter2.Name = "tbFilter2"
        Me.tbFilter2.Size = New System.Drawing.Size(100, 20)
        Me.tbFilter2.TabIndex = 16
        '
        'tbFilter1
        '
        Me.tbFilter1.Location = New System.Drawing.Point(704, 31)
        Me.tbFilter1.Name = "tbFilter1"
        Me.tbFilter1.Size = New System.Drawing.Size(100, 20)
        Me.tbFilter1.TabIndex = 13
        '
        'cbColOperator5
        '
        Me.cbColOperator5.FormattingEnabled = True
        Me.cbColOperator5.Location = New System.Drawing.Point(576, 138)
        Me.cbColOperator5.Name = "cbColOperator5"
        Me.cbColOperator5.Size = New System.Drawing.Size(121, 21)
        Me.cbColOperator5.TabIndex = 24
        '
        'cbColOperator4
        '
        Me.cbColOperator4.FormattingEnabled = True
        Me.cbColOperator4.Location = New System.Drawing.Point(576, 112)
        Me.cbColOperator4.Name = "cbColOperator4"
        Me.cbColOperator4.Size = New System.Drawing.Size(121, 21)
        Me.cbColOperator4.TabIndex = 21
        '
        'cbColOperator3
        '
        Me.cbColOperator3.FormattingEnabled = True
        Me.cbColOperator3.Location = New System.Drawing.Point(576, 85)
        Me.cbColOperator3.Name = "cbColOperator3"
        Me.cbColOperator3.Size = New System.Drawing.Size(121, 21)
        Me.cbColOperator3.TabIndex = 18
        '
        'cbColOperator2
        '
        Me.cbColOperator2.FormattingEnabled = True
        Me.cbColOperator2.Location = New System.Drawing.Point(576, 57)
        Me.cbColOperator2.Name = "cbColOperator2"
        Me.cbColOperator2.Size = New System.Drawing.Size(121, 21)
        Me.cbColOperator2.TabIndex = 15
        '
        'cbColOperator1
        '
        Me.cbColOperator1.FormattingEnabled = True
        Me.cbColOperator1.Location = New System.Drawing.Point(576, 31)
        Me.cbColOperator1.Name = "cbColOperator1"
        Me.cbColOperator1.Size = New System.Drawing.Size(121, 21)
        Me.cbColOperator1.TabIndex = 12
        '
        'cbColFilter5
        '
        Me.cbColFilter5.FormattingEnabled = True
        Me.cbColFilter5.Location = New System.Drawing.Point(436, 139)
        Me.cbColFilter5.Name = "cbColFilter5"
        Me.cbColFilter5.Size = New System.Drawing.Size(121, 21)
        Me.cbColFilter5.TabIndex = 23
        '
        'cbColFilter4
        '
        Me.cbColFilter4.FormattingEnabled = True
        Me.cbColFilter4.Location = New System.Drawing.Point(436, 112)
        Me.cbColFilter4.Name = "cbColFilter4"
        Me.cbColFilter4.Size = New System.Drawing.Size(121, 21)
        Me.cbColFilter4.TabIndex = 20
        '
        'cbColFilter3
        '
        Me.cbColFilter3.FormattingEnabled = True
        Me.cbColFilter3.Location = New System.Drawing.Point(436, 84)
        Me.cbColFilter3.Name = "cbColFilter3"
        Me.cbColFilter3.Size = New System.Drawing.Size(121, 21)
        Me.cbColFilter3.TabIndex = 17
        '
        'cbColFilter2
        '
        Me.cbColFilter2.FormattingEnabled = True
        Me.cbColFilter2.Location = New System.Drawing.Point(436, 57)
        Me.cbColFilter2.Name = "cbColFilter2"
        Me.cbColFilter2.Size = New System.Drawing.Size(121, 21)
        Me.cbColFilter2.TabIndex = 14
        '
        'cbColFilter1
        '
        Me.cbColFilter1.FormattingEnabled = True
        Me.cbColFilter1.Location = New System.Drawing.Point(436, 31)
        Me.cbColFilter1.Name = "cbColFilter1"
        Me.cbColFilter1.Size = New System.Drawing.Size(121, 21)
        Me.cbColFilter1.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(433, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Filters:"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Enabled = False
        Me.CheckBox1.Location = New System.Drawing.Point(313, 141)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(71, 17)
        Me.CheckBox1.TabIndex = 6
        Me.CheckBox1.Text = "Check All"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(173, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Select Display Fields:"
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Location = New System.Drawing.Point(26, 107)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(81, 17)
        Me.RadioButton4.TabIndex = 4
        Me.RadioButton4.TabStop = True
        Me.RadioButton4.Text = "Transaction"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(26, 84)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(69, 17)
        Me.RadioButton3.TabIndex = 3
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "No Credit"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(26, 61)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(106, 17)
        Me.RadioButton2.TabIndex = 2
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Manager Review"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(26, 38)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(110, 17)
        Me.RadioButton1.TabIndex = 1
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "CPT Transactions"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'Splitter2
        '
        Me.Splitter2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Splitter2.Location = New System.Drawing.Point(155, 0)
        Me.Splitter2.Name = "Splitter2"
        Me.Splitter2.Size = New System.Drawing.Size(258, 173)
        Me.Splitter2.TabIndex = 4
        Me.Splitter2.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Select Table:"
        '
        'Splitter1
        '
        Me.Splitter1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Splitter1.Location = New System.Drawing.Point(0, 0)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(155, 173)
        Me.Splitter1.TabIndex = 3
        Me.Splitter1.TabStop = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(12, 191)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(913, 255)
        Me.TabControl1.TabIndex = 3
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.dgvResults)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(905, 229)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Results"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'dgvResults
        '
        Me.dgvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvResults.ContextMenuStrip = Me.ContextMenuStrip1
        Me.dgvResults.Location = New System.Drawing.Point(3, 3)
        Me.dgvResults.Name = "dgvResults"
        Me.dgvResults.ReadOnly = True
        Me.dgvResults.Size = New System.Drawing.Size(896, 220)
        Me.dgvResults.TabIndex = 0
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MoveToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(105, 26)
        '
        'MoveToolStripMenuItem
        '
        Me.MoveToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SingleTransactionToolStripMenuItem, Me.AllTransactionsToolStripMenuItem})
        Me.MoveToolStripMenuItem.Name = "MoveToolStripMenuItem"
        Me.MoveToolStripMenuItem.Size = New System.Drawing.Size(104, 22)
        Me.MoveToolStripMenuItem.Text = "Move"
        '
        'SingleTransactionToolStripMenuItem
        '
        Me.SingleTransactionToolStripMenuItem.Name = "SingleTransactionToolStripMenuItem"
        Me.SingleTransactionToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.SingleTransactionToolStripMenuItem.Text = "Single Transaction"
        '
        'AllTransactionsToolStripMenuItem
        '
        Me.AllTransactionsToolStripMenuItem.Name = "AllTransactionsToolStripMenuItem"
        Me.AllTransactionsToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.AllTransactionsToolStripMenuItem.Text = "All Transactions"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.TextBox1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(905, 229)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Query"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(6, 6)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(893, 20)
        Me.TextBox1.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(937, 458)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form1"
        Me.Text = "Hope Query Builder"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.dgvResults, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnExecute As Button
    Friend WithEvents CheckedListBox1 As CheckedListBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Splitter1 As Splitter
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents Splitter2 As Splitter
    Friend WithEvents Label2 As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Label3 As Label
    Friend WithEvents tbFilter5 As TextBox
    Friend WithEvents tbFilter4 As TextBox
    Friend WithEvents tbFilter3 As TextBox
    Friend WithEvents tbFilter2 As TextBox
    Friend WithEvents tbFilter1 As TextBox
    Friend WithEvents cbColOperator5 As ComboBox
    Friend WithEvents cbColOperator4 As ComboBox
    Friend WithEvents cbColOperator3 As ComboBox
    Friend WithEvents cbColOperator2 As ComboBox
    Friend WithEvents cbColOperator1 As ComboBox
    Friend WithEvents cbColFilter5 As ComboBox
    Friend WithEvents cbColFilter4 As ComboBox
    Friend WithEvents cbColFilter3 As ComboBox
    Friend WithEvents cbColFilter2 As ComboBox
    Friend WithEvents cbColFilter1 As ComboBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents dgvResults As DataGridView
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btnClear As Button
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents MoveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SingleTransactionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AllTransactionsToolStripMenuItem As ToolStripMenuItem
End Class
