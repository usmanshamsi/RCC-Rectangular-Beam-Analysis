Public Class mainForm

    Private Sub save_values(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        FormSerialisation.FormSerialisor.Serialise(Me, Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) & "\usmanshamsi__rcc-rectangular-beam-analysis.xml")
    End Sub

    Private Sub load_values(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        FormSerialisation.FormSerialisor.Deserialise(Me, Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) & "\usmanshamsi__rcc-rectangular-beam-analysis.xml")

    End Sub

    Private Sub buttonCalculate_Click(sender As System.Object, e As System.EventArgs) Handles buttonCalculate.Click
        Dim b, h, cc, d, fc, fy, _as As Double
        Try
            b = Convert.ToDouble(inputWidthofBeam.Text)
            h = Convert.ToDouble(inputDepthofBeam.Text)
            cc = Convert.ToDouble(inputCover.Text)
            d = h - cc
            fc = Convert.ToDouble(inputFc.Text)
            fy = Convert.ToDouble(inputFy.Text)
            _as = Convert.ToDouble(inputAs.Text)
        Catch ex As Exception
            MsgBox(ex.Message, vbOKOnly, "Error in inputs")
        End Try

        Dim beta1 As Double = CalculateBeta1(fc)

        Dim rho As Double = _as / (b * d)
        outputRhoProvided.Text = (100 * rho).ToString("0.00")
        outputAsProvided.Text = (b * d * rho).ToString("0.00")

        Dim rhoMinimum As Double = Math.Max(3 * Math.Sqrt(fc) / fy, 200.0 / fy)
        outputRhoMinimum.Text = (100 * rhoMinimum).ToString("0.00")
        outputAsMinimum.Text = (b * d * rhoMinimum).ToString("0.00")

        Dim rhoBalanced As Double = 0.85 * beta1 * (fc / fy) * (87000 / (87000 + fy))
        outputRhoBalanced.Text = (100 * rhoBalanced).ToString("0.00")
        outputAsBalanced.Text = (b * d * rhoBalanced).ToString("0.00")

        Const modulus_of_Steel As Double = 29000000.0

        Dim rhoMaximum As Double = ((0.003 + fy / modulus_of_Steel) / 0.008) * rhoBalanced
        outputRhoMaximum.Text = (100 * rhoMaximum).ToString("0.00")
        outputAsMaximum.Text = (b * d * rhoMaximum).ToString("0.00")

        '    CHECK RHO AGAINST RHO MAX AND RHO MIN
        outputRhoMsg.Text = ""

        If (rho > rhoMaximum) Then
            If (rho <= rhoBalanced) Then
                outputRhoMsg.Text = "Provided reinforcement is more than the maximum reinforcement limit."
            Else
                outputRhoMsg.Text = "Provided reinforcement is more than the balanced reinforcement limit. Further calculations skipped."

                outputWhitneyBlockDepth.Text = ""
                outputNeutralAxisDepth.Text = ""
                outputTensileStrain.Text = ""
                outputPhi.Text = ""
                outputMu_lbinch.Text = ""
                outputMu_kipft.Text = ""

                Exit Sub

            End If
        End If

        If (rho < rhoMinimum) Then
            outputRhoMsg.Text = "Provided reinforcment is less than the minimum reinforcement limit."
        End If


        '    calculate compression block

        Dim a As Double = (_as * fy) / (0.85 * fc * b)
        outputWhitneyBlockDepth.Text = a.ToString("0.00")

        Dim c As Double = a / beta1
        outputNeutralAxisDepth.Text = c.ToString("0.00")


        '    calculate strain, phi and moment capacity
        Dim epsilon_t As Double = ((d - c) / c) * 0.003
        outputTensileStrain.Text = epsilon_t.ToString("0.0#########")

        Dim phi As Double = Phi_flexure(epsilon_t)
        outputPhi.Text = phi.ToString("0.0#####")

        Dim moment_capacity As Double = phi * _as * fy * (d - a / 2)
        outputMu_lbinch.Text = moment_capacity.ToString("0.00")
        outputMu_kipft.Text = (moment_capacity / 12000.0).ToString("0.000")

    End Sub

    Function CalculateBeta1(ByVal fc As Double) As Double

        ' fc in psi

        If (fc <= 4000) Then

            Return 0.85

        ElseIf (fc >= 8000) Then

            Return 0.65

        Else

            Return 0.85 - (fc - 4000) / 1000 * 0.05

        End If
    End Function

    Function Phi_flexure(ByVal epsilon_t As Double) As Double

        ' epsilon_t is the strain in tension fibre

        If (epsilon_t >= 0.005) Then

            Return 0.9

        Else
            Return 0.65 + (epsilon_t - 0.002) * (250.0 / 3.0)

        End If
    End Function

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        AboutForm.ShowDialog()
    End Sub
End Class
