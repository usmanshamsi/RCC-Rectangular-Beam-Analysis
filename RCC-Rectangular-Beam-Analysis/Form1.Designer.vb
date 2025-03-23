<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mainForm
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.inputWidthofBeam = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.inputDepthofBeam = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.inputCover = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.inputFc = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.inputFy = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.inputAs = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.buttonCalculate = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.outputRhoProvided = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.outputRhoMinimum = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.outputRhoMaximum = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.outputRhoBalanced = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.outputRhoMsg = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.outputNeutralAxisDepth = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.outputWhitneyBlockDepth = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.outputTensileStrain = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.outputPhi = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.outputMu_lbinch = New System.Windows.Forms.TextBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.outputMu_kipft = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Width of beam"
        '
        'inputWidthofBeam
        '
        Me.inputWidthofBeam.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inputWidthofBeam.Location = New System.Drawing.Point(254, 11)
        Me.inputWidthofBeam.Name = "inputWidthofBeam"
        Me.inputWidthofBeam.Size = New System.Drawing.Size(95, 22)
        Me.inputWidthofBeam.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(355, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 16)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "inch"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(355, 42)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 16)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "inch"
        '
        'inputDepthofBeam
        '
        Me.inputDepthofBeam.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inputDepthofBeam.Location = New System.Drawing.Point(254, 39)
        Me.inputDepthofBeam.Name = "inputDepthofBeam"
        Me.inputDepthofBeam.Size = New System.Drawing.Size(95, 22)
        Me.inputDepthofBeam.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 42)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(128, 16)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Total depth of beam"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(355, 70)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(32, 16)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "inch"
        '
        'inputCover
        '
        Me.inputCover.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inputCover.Location = New System.Drawing.Point(254, 67)
        Me.inputCover.Name = "inputCover"
        Me.inputCover.Size = New System.Drawing.Size(95, 22)
        Me.inputCover.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 70)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(242, 16)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Cover to center of tension reinforcement"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(757, 14)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(26, 16)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "psi"
        '
        'inputFc
        '
        Me.inputFc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inputFc.Location = New System.Drawing.Point(656, 11)
        Me.inputFc.Name = "inputFc"
        Me.inputFc.Size = New System.Drawing.Size(95, 22)
        Me.inputFc.TabIndex = 7
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(414, 14)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(226, 16)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Compressive strength of concrete, f'c"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(757, 42)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(26, 16)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "psi"
        '
        'inputFy
        '
        Me.inputFy.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inputFy.Location = New System.Drawing.Point(656, 39)
        Me.inputFy.Name = "inputFy"
        Me.inputFy.Size = New System.Drawing.Size(95, 22)
        Me.inputFy.TabIndex = 9
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(414, 42)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(217, 16)
        Me.Label11.TabIndex = 8
        Me.Label11.Text = "Tensile strength of reinforcement, fy"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(757, 70)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(46, 16)
        Me.Label12.TabIndex = 18
        Me.Label12.Text = "inch^2"
        '
        'inputAs
        '
        Me.inputAs.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inputAs.Location = New System.Drawing.Point(656, 67)
        Me.inputAs.Name = "inputAs"
        Me.inputAs.Size = New System.Drawing.Size(95, 22)
        Me.inputAs.TabIndex = 11
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(414, 70)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(236, 16)
        Me.Label13.TabIndex = 10
        Me.Label13.Text = "Total area of tension reinforcement, As"
        '
        'buttonCalculate
        '
        Me.buttonCalculate.Location = New System.Drawing.Point(656, 102)
        Me.buttonCalculate.Name = "buttonCalculate"
        Me.buttonCalculate.Size = New System.Drawing.Size(147, 28)
        Me.buttonCalculate.TabIndex = 12
        Me.buttonCalculate.Text = "Calculate"
        Me.buttonCalculate.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(12, 163)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(199, 16)
        Me.Label14.TabIndex = 20
        Me.Label14.Text = "Reinforcement Percentage, Rho"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(251, 163)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(63, 16)
        Me.Label15.TabIndex = 21
        Me.Label15.Text = "Provided"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(414, 160)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(20, 16)
        Me.Label16.TabIndex = 23
        Me.Label16.Text = "%"
        '
        'outputRhoProvided
        '
        Me.outputRhoProvided.BackColor = System.Drawing.Color.White
        Me.outputRhoProvided.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.outputRhoProvided.ForeColor = System.Drawing.Color.Blue
        Me.outputRhoProvided.Location = New System.Drawing.Point(320, 157)
        Me.outputRhoProvided.Name = "outputRhoProvided"
        Me.outputRhoProvided.ReadOnly = True
        Me.outputRhoProvided.Size = New System.Drawing.Size(88, 22)
        Me.outputRhoProvided.TabIndex = 22
        Me.outputRhoProvided.TabStop = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(603, 157)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(20, 16)
        Me.Label17.TabIndex = 26
        Me.Label17.Text = "%"
        '
        'outputRhoMinimum
        '
        Me.outputRhoMinimum.BackColor = System.Drawing.Color.White
        Me.outputRhoMinimum.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.outputRhoMinimum.ForeColor = System.Drawing.Color.Blue
        Me.outputRhoMinimum.Location = New System.Drawing.Point(509, 154)
        Me.outputRhoMinimum.Name = "outputRhoMinimum"
        Me.outputRhoMinimum.ReadOnly = True
        Me.outputRhoMinimum.Size = New System.Drawing.Size(88, 22)
        Me.outputRhoMinimum.TabIndex = 25
        Me.outputRhoMinimum.TabStop = False
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(440, 160)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(61, 16)
        Me.Label18.TabIndex = 24
        Me.Label18.Text = "Minimum"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(603, 185)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(20, 16)
        Me.Label19.TabIndex = 29
        Me.Label19.Text = "%"
        '
        'outputRhoMaximum
        '
        Me.outputRhoMaximum.BackColor = System.Drawing.Color.White
        Me.outputRhoMaximum.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.outputRhoMaximum.ForeColor = System.Drawing.Color.Blue
        Me.outputRhoMaximum.Location = New System.Drawing.Point(509, 182)
        Me.outputRhoMaximum.Name = "outputRhoMaximum"
        Me.outputRhoMaximum.ReadOnly = True
        Me.outputRhoMaximum.Size = New System.Drawing.Size(88, 22)
        Me.outputRhoMaximum.TabIndex = 28
        Me.outputRhoMaximum.TabStop = False
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(440, 188)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(65, 16)
        Me.Label20.TabIndex = 27
        Me.Label20.Text = "Maximum"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(603, 213)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(20, 16)
        Me.Label21.TabIndex = 32
        Me.Label21.Text = "%"
        '
        'outputRhoBalanced
        '
        Me.outputRhoBalanced.BackColor = System.Drawing.Color.White
        Me.outputRhoBalanced.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.outputRhoBalanced.ForeColor = System.Drawing.Color.Blue
        Me.outputRhoBalanced.Location = New System.Drawing.Point(509, 210)
        Me.outputRhoBalanced.Name = "outputRhoBalanced"
        Me.outputRhoBalanced.ReadOnly = True
        Me.outputRhoBalanced.Size = New System.Drawing.Size(88, 22)
        Me.outputRhoBalanced.TabIndex = 31
        Me.outputRhoBalanced.TabStop = False
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(440, 216)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(66, 16)
        Me.Label22.TabIndex = 30
        Me.Label22.Text = "Balanced"
        '
        'outputRhoMsg
        '
        Me.outputRhoMsg.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.outputRhoMsg.ForeColor = System.Drawing.Color.Red
        Me.outputRhoMsg.Location = New System.Drawing.Point(12, 188)
        Me.outputRhoMsg.Name = "outputRhoMsg"
        Me.outputRhoMsg.Size = New System.Drawing.Size(390, 41)
        Me.outputRhoMsg.TabIndex = 33
        Me.outputRhoMsg.Text = " "
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(333, 288)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(32, 16)
        Me.Label23.TabIndex = 40
        Me.Label23.Text = "inch"
        '
        'outputNeutralAxisDepth
        '
        Me.outputNeutralAxisDepth.BackColor = System.Drawing.Color.White
        Me.outputNeutralAxisDepth.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.outputNeutralAxisDepth.ForeColor = System.Drawing.Color.Blue
        Me.outputNeutralAxisDepth.Location = New System.Drawing.Point(239, 285)
        Me.outputNeutralAxisDepth.Name = "outputNeutralAxisDepth"
        Me.outputNeutralAxisDepth.ReadOnly = True
        Me.outputNeutralAxisDepth.Size = New System.Drawing.Size(88, 22)
        Me.outputNeutralAxisDepth.TabIndex = 39
        Me.outputNeutralAxisDepth.TabStop = False
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(12, 288)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(131, 16)
        Me.Label24.TabIndex = 38
        Me.Label24.Text = "Neutral Axis Depth, c"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(333, 258)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(32, 16)
        Me.Label25.TabIndex = 37
        Me.Label25.Text = "inch"
        '
        'outputWhitneyBlockDepth
        '
        Me.outputWhitneyBlockDepth.BackColor = System.Drawing.Color.White
        Me.outputWhitneyBlockDepth.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.outputWhitneyBlockDepth.ForeColor = System.Drawing.Color.Blue
        Me.outputWhitneyBlockDepth.Location = New System.Drawing.Point(239, 255)
        Me.outputWhitneyBlockDepth.Name = "outputWhitneyBlockDepth"
        Me.outputWhitneyBlockDepth.ReadOnly = True
        Me.outputWhitneyBlockDepth.Size = New System.Drawing.Size(88, 22)
        Me.outputWhitneyBlockDepth.TabIndex = 36
        Me.outputWhitneyBlockDepth.TabStop = False
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(12, 258)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(224, 16)
        Me.Label27.TabIndex = 34
        Me.Label27.Text = "Whitney compression block depth, a"
        '
        'outputTensileStrain
        '
        Me.outputTensileStrain.BackColor = System.Drawing.Color.White
        Me.outputTensileStrain.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.outputTensileStrain.ForeColor = System.Drawing.Color.Blue
        Me.outputTensileStrain.Location = New System.Drawing.Point(562, 255)
        Me.outputTensileStrain.Name = "outputTensileStrain"
        Me.outputTensileStrain.ReadOnly = True
        Me.outputTensileStrain.Size = New System.Drawing.Size(154, 22)
        Me.outputTensileStrain.TabIndex = 42
        Me.outputTensileStrain.TabStop = False
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(440, 258)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(106, 16)
        Me.Label28.TabIndex = 41
        Me.Label28.Text = "Net tensile strain"
        '
        'outputPhi
        '
        Me.outputPhi.BackColor = System.Drawing.Color.White
        Me.outputPhi.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.outputPhi.ForeColor = System.Drawing.Color.Blue
        Me.outputPhi.Location = New System.Drawing.Point(562, 285)
        Me.outputPhi.Name = "outputPhi"
        Me.outputPhi.ReadOnly = True
        Me.outputPhi.Size = New System.Drawing.Size(154, 22)
        Me.outputPhi.TabIndex = 44
        Me.outputPhi.TabStop = False
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(440, 288)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(92, 16)
        Me.Label26.TabIndex = 43
        Me.Label26.Text = "Phi calculated"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(446, 347)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(54, 16)
        Me.Label29.TabIndex = 47
        Me.Label29.Text = "lb-inch"
        '
        'outputMu_lbinch
        '
        Me.outputMu_lbinch.BackColor = System.Drawing.Color.White
        Me.outputMu_lbinch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.outputMu_lbinch.ForeColor = System.Drawing.Color.Blue
        Me.outputMu_lbinch.Location = New System.Drawing.Point(305, 344)
        Me.outputMu_lbinch.Name = "outputMu_lbinch"
        Me.outputMu_lbinch.ReadOnly = True
        Me.outputMu_lbinch.Size = New System.Drawing.Size(135, 22)
        Me.outputMu_lbinch.TabIndex = 46
        Me.outputMu_lbinch.TabStop = False
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(12, 347)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(287, 16)
        Me.Label30.TabIndex = 45
        Me.Label30.Text = "Bending Moment Capacity, Mu = phi * Mn"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(656, 347)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(42, 16)
        Me.Label31.TabIndex = 49
        Me.Label31.Text = "kip-ft"
        '
        'outputMu_kipft
        '
        Me.outputMu_kipft.BackColor = System.Drawing.Color.White
        Me.outputMu_kipft.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.outputMu_kipft.ForeColor = System.Drawing.Color.Blue
        Me.outputMu_kipft.Location = New System.Drawing.Point(515, 344)
        Me.outputMu_kipft.Name = "outputMu_kipft"
        Me.outputMu_kipft.ReadOnly = True
        Me.outputMu_kipft.Size = New System.Drawing.Size(135, 22)
        Me.outputMu_kipft.TabIndex = 48
        Me.outputMu_kipft.TabStop = False
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button1.Location = New System.Drawing.Point(12, 392)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(84, 28)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "About..."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.Location = New System.Drawing.Point(719, 392)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(84, 28)
        Me.Button2.TabIndex = 14
        Me.Button2.Text = "Close"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'mainForm
        '
        Me.AcceptButton = Me.buttonCalculate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(815, 432)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label31)
        Me.Controls.Add(Me.outputMu_kipft)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.outputMu_lbinch)
        Me.Controls.Add(Me.Label30)
        Me.Controls.Add(Me.outputPhi)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.outputTensileStrain)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.outputNeutralAxisDepth)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.outputWhitneyBlockDepth)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.outputRhoMsg)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.outputRhoBalanced)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.outputRhoMaximum)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.outputRhoMinimum)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.outputRhoProvided)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.buttonCalculate)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.inputAs)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.inputFy)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.inputFc)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.inputCover)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.inputDepthofBeam)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.inputWidthofBeam)
        Me.Controls.Add(Me.Label2)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "mainForm"
        Me.Text = "RCC Rectangular Beam Analysis"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents inputWidthofBeam As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents inputDepthofBeam As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents inputCover As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents inputFc As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents inputFy As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents inputAs As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents buttonCalculate As System.Windows.Forms.Button
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents outputRhoProvided As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents outputRhoMinimum As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents outputRhoMaximum As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents outputRhoBalanced As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents outputRhoMsg As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents outputNeutralAxisDepth As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents outputWhitneyBlockDepth As System.Windows.Forms.TextBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents outputTensileStrain As System.Windows.Forms.TextBox
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents outputPhi As System.Windows.Forms.TextBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents outputMu_lbinch As System.Windows.Forms.TextBox
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents outputMu_kipft As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button

End Class
