Imports System
Imports System.Drawing
Imports System.Windows.Forms

Public Class LivePanel
    Inherits Panel

    Private Const _gripsize As Integer = 20
    Private _dragging_resize As Boolean
    Private _dragging_move As Boolean
    Private _dragpos As Point
    Private _freeze As Boolean

    Public Sub New()
        Me.DoubleBuffered = True
        Me.SetStyle(ControlStyles.ResizeRedraw, True)
        Me.BackColor = Color.White
        _freeze = False
    End Sub

    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
        ControlPaint.DrawSizeGrip(e.Graphics, Me.BackColor, _
                                  New Rectangle(Me.ClientSize.Width - _gripsize, _
                                   Me.ClientSize.Height - _gripsize, _gripsize, _gripsize))

        MyBase.OnPaint(e)
    End Sub

    Private Function IsOnGrip(ByVal pos As Point) As Boolean
        IsOnGrip = pos.X >= Me.ClientSize.Width - _gripsize And _
            pos.Y >= Me.ClientSize.Height - _gripsize
    End Function

    Protected Overrides Sub OnMouseDown(ByVal e As MouseEventArgs)
        _dragging_resize = IsOnGrip(e.Location)
        _dragging_move = Not IsOnGrip(e.Location)
        _dragpos = e.Location
        MyBase.OnMouseDown(e)
    End Sub

    Protected Overrides Sub OnMouseUp(ByVal e As MouseEventArgs)
        _dragging_resize = False
        _dragging_move = False
        MyBase.OnMouseUp(e)
    End Sub

    Protected Overrides Sub OnMouseMove(ByVal e As MouseEventArgs)
        If Not _freeze Then
            If (_dragging_resize) Then
                Me.Size = New Size(Me.Width + e.X - _dragpos.X, Me.Height + e.Y - _dragpos.Y)
                _dragpos = e.Location
            ElseIf (_dragging_move) Then
                Me.Location = New Point(Me.Location.X + e.X - _dragpos.X, _
                                        Me.Location.Y + e.Y - _dragpos.Y)
            ElseIf (IsOnGrip(e.Location)) Then
                Me.Cursor = Cursors.SizeNWSE
            Else
                Me.Cursor = Cursors.Default
            End If
        End If
        MyBase.OnMouseMove(e)
    End Sub

    Protected Overrides Sub OnDoubleClick(ByVal e As System.EventArgs)
        _freeze = True
        MyBase.OnDoubleClick(e)
    End Sub

End Class
