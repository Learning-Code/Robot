Public Class CRobot

   Private arrFloor(,) As String
   Private sInitialDirection As String
   Private sFaceDirection As String = ""
   Private iWidth As Integer
   Private iDepth As Integer
   Private sFinalResult As String = ""


   Public Sub createFloorMatrix(ByVal width As Integer, ByVal depth As Integer)
      Dim arr(width, depth) As String
      arrFloor = arr
   End Sub

   Public Sub setPosition(ByVal w As Integer, ByVal d As Integer, ByVal sDirection As String)
      sInitialDirection = sDirection
      iWidth = w
      iDepth = d
   End Sub

   Public Function steerRobot(ByVal sCommand As String) As String
      If sFaceDirection = "" Then
         sFaceDirection = sInitialDirection
      End If
      If sCommand = "L" Then
         If sFaceDirection = "N" Then
            sFaceDirection = "W"
         ElseIf sFaceDirection = "S" Then
            sFaceDirection = "E"
         ElseIf sFaceDirection = "E" Then
            sFaceDirection = "N"
         ElseIf sFaceDirection = "W" Then
            sFaceDirection = "S"
         End If

      ElseIf sCommand = "R" Then
         If sFaceDirection = "N" Then
            sFaceDirection = "E"
         ElseIf sFaceDirection = "S" Then
            sFaceDirection = "W"
         ElseIf sFaceDirection = "E" Then
            sFaceDirection = "S"
         ElseIf sFaceDirection = "W" Then
            sFaceDirection = "N"
         End If

      ElseIf sCommand = "G" Then
         If sFaceDirection = "N" Then
            iWidth = iWidth
            iDepth = iDepth - 1
         ElseIf sFaceDirection = "S" Then
            iWidth = iWidth
            iDepth = iDepth + 1
         ElseIf sFaceDirection = "E" Then
            iWidth = iWidth - 1
            iDepth = iDepth
         ElseIf sFaceDirection = "W" Then
            iWidth = iWidth + 1
            iDepth = iDepth
         End If
         sFinalResult = (CStr(Math.Abs(iWidth)) + " " + CStr(Math.Abs(iDepth)) + " " + sFaceDirection)
      ElseIf sCommand = "" Then
         If sFinalResult = "" Then
            sFinalResult = (CStr(Math.Abs(iWidth)) + " " + CStr(Math.Abs(iDepth)) + " " + sFaceDirection)
         End If
         Return sFinalResult
      End If
      Return ""
   End Function


End Class
