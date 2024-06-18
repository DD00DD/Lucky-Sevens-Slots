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
        Me.lblCount = New System.Windows.Forms.Label()
        Me.lblWin = New System.Windows.Forms.Label()
        Me.btnPlay = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.picThree = New System.Windows.Forms.PictureBox()
        Me.picTwo = New System.Windows.Forms.PictureBox()
        Me.picOne = New System.Windows.Forms.PictureBox()
        Me.picSlot = New System.Windows.Forms.PictureBox()
        CType(Me.picThree, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picTwo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picOne, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSlot, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblCount
        '
        Me.lblCount.BackColor = System.Drawing.Color.White
        Me.lblCount.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCount.Location = New System.Drawing.Point(12, 383)
        Me.lblCount.Name = "lblCount"
        Me.lblCount.Size = New System.Drawing.Size(625, 66)
        Me.lblCount.TabIndex = 1
        Me.lblCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblWin
        '
        Me.lblWin.BackColor = System.Drawing.Color.White
        Me.lblWin.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWin.Location = New System.Drawing.Point(12, 462)
        Me.lblWin.Name = "lblWin"
        Me.lblWin.Size = New System.Drawing.Size(625, 66)
        Me.lblWin.TabIndex = 2
        Me.lblWin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnPlay
        '
        Me.btnPlay.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlay.Location = New System.Drawing.Point(17, 543)
        Me.btnPlay.Name = "btnPlay"
        Me.btnPlay.Size = New System.Drawing.Size(167, 50)
        Me.btnPlay.TabIndex = 3
        Me.btnPlay.Text = "Play"
        Me.btnPlay.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(470, 543)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(167, 50)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'picThree
        '
        Me.picThree.BackColor = System.Drawing.Color.White
        Me.picThree.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picThree.Location = New System.Drawing.Point(407, 136)
        Me.picThree.Name = "picThree"
        Me.picThree.Size = New System.Drawing.Size(113, 121)
        Me.picThree.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picThree.TabIndex = 7
        Me.picThree.TabStop = False
        '
        'picTwo
        '
        Me.picTwo.BackColor = System.Drawing.Color.White
        Me.picTwo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picTwo.Location = New System.Drawing.Point(267, 136)
        Me.picTwo.Name = "picTwo"
        Me.picTwo.Size = New System.Drawing.Size(113, 121)
        Me.picTwo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picTwo.TabIndex = 6
        Me.picTwo.TabStop = False
        '
        'picOne
        '
        Me.picOne.BackColor = System.Drawing.Color.White
        Me.picOne.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picOne.Location = New System.Drawing.Point(125, 136)
        Me.picOne.Name = "picOne"
        Me.picOne.Size = New System.Drawing.Size(113, 121)
        Me.picOne.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picOne.TabIndex = 5
        Me.picOne.TabStop = False
        '
        'picSlot
        '
        Me.picSlot.BackgroundImage = Global.DaoD_LuckySevens.My.Resources.Resources.SlotMachine
        Me.picSlot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picSlot.Location = New System.Drawing.Point(12, 12)
        Me.picSlot.Name = "picSlot"
        Me.picSlot.Size = New System.Drawing.Size(625, 368)
        Me.picSlot.TabIndex = 0
        Me.picSlot.TabStop = False
        '
        'Form1
        '
        Me.AcceptButton = Me.btnPlay
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Maroon
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(649, 605)
        Me.Controls.Add(Me.picThree)
        Me.Controls.Add(Me.picTwo)
        Me.Controls.Add(Me.picOne)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnPlay)
        Me.Controls.Add(Me.lblWin)
        Me.Controls.Add(Me.lblCount)
        Me.Controls.Add(Me.picSlot)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Lucky Sevens"
        CType(Me.picThree, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picTwo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picOne, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSlot, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents picSlot As PictureBox
    Friend WithEvents lblCount As Label
    Friend WithEvents lblWin As Label
    Friend WithEvents btnPlay As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents picOne As PictureBox
    Friend WithEvents picTwo As PictureBox
    Friend WithEvents picThree As PictureBox
End Class
