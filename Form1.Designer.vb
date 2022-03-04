<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class registration_form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(registration_form))
        Me.MediaPlayer_music = New AxWMPLib.AxWindowsMediaPlayer()
        Me.MediaPlayer_H_B = New AxWMPLib.AxWindowsMediaPlayer()
        Me.ALL_DTDataSet = New language_class.ALL_DTDataSet()
        CType(Me.MediaPlayer_music, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MediaPlayer_H_B, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ALL_DTDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MediaPlayer_music
        '
        Me.MediaPlayer_music.Enabled = True
        Me.MediaPlayer_music.Location = New System.Drawing.Point(897, 12)
        Me.MediaPlayer_music.Name = "MediaPlayer_music"
        Me.MediaPlayer_music.OcxState = CType(resources.GetObject("MediaPlayer_music.OcxState"), System.Windows.Forms.AxHost.State)
        Me.MediaPlayer_music.Size = New System.Drawing.Size(75, 23)
        Me.MediaPlayer_music.TabIndex = 8
        Me.MediaPlayer_music.Visible = False
        '
        'MediaPlayer_H_B
        '
        Me.MediaPlayer_H_B.Enabled = True
        Me.MediaPlayer_H_B.Location = New System.Drawing.Point(897, 41)
        Me.MediaPlayer_H_B.Name = "MediaPlayer_H_B"
        Me.MediaPlayer_H_B.OcxState = CType(resources.GetObject("MediaPlayer_H_B.OcxState"), System.Windows.Forms.AxHost.State)
        Me.MediaPlayer_H_B.Size = New System.Drawing.Size(75, 23)
        Me.MediaPlayer_H_B.TabIndex = 10
        Me.MediaPlayer_H_B.Visible = False
        '
        'ALL_DTDataSet
        '
        Me.ALL_DTDataSet.DataSetName = "ALL_DTDataSet"
        Me.ALL_DTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'registration_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(984, 481)
        Me.Controls.Add(Me.MediaPlayer_H_B)
        Me.Controls.Add(Me.MediaPlayer_music)
        Me.MaximizeBox = False
        Me.Name = "registration_form"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.MediaPlayer_music, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MediaPlayer_H_B, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ALL_DTDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MediaPlayer_music As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents ALL_DTDataSet As language_class.ALL_DTDataSet
    Friend WithEvents MediaPlayer_H_B As AxWMPLib.AxWindowsMediaPlayer

End Class