Public Class CUnitTests

   Dim robot As CRobot = New CRobot()

   Public Function unitTest1() As String
      robot.createFloorMatrix(5, 5)
      robot.setPosition(1, 2, "N")
      Dim chars As Char() = "RGRGGRGRG".ToCharArray()
      For Each ch In chars
         robot.steerRobot(ch)
      Next
      Return robot.steerRobot("")
   End Function

   Public Function unitTest2() As String
      robot.createFloorMatrix(5, 5)
      robot.setPosition(0, 0, "E")
      Dim chars As Char() = "RGLGGLRG".ToCharArray()
      For Each ch In chars
         robot.steerRobot(ch)
      Next
      Return robot.steerRobot("")
   End Function

End Class
