Module Module1

    Sub Main()

      Dim st As CRobot = New CRobot()
      Dim sCurrentPosition As String = ""

      ''''''''Unit tests'''''''''''''
      'Dim ut As CUnitTests = New CUnitTests()
      'Console.WriteLine(ut.unitTest1())
      'Console.ReadLine()
      '''''''''''''''''''''''''''''''
      'Create the floorMatrix
      Console.WriteLine("Input(Enter size of the room, example: 5 5)")
      Dim input = Console.ReadLine()
      Dim values = input.Split(" ")
      st.createFloorMatrix(CInt(values(0)), CInt(values(1)))
      'Set the current position of Robot
      Console.WriteLine("Input(Set RObot's current position, example: 1 2 N)")
      input = Console.ReadLine().ToUpper()
      sCurrentPosition = input
      values = input.Split(" ")
      st.setPosition(CInt(values(0)), CInt(values(1)), values(2))
      'Steer the Robot
      Console.WriteLine("Input (Steer ROBOT, example: RGRGGRGRG)")
      Dim sReadLine = Console.ReadLine().ToUpper()
      Dim chars As Char() = sReadLine.ToCharArray()
      For Each ch In chars
         st.steerRobot(ch)
      Next
      sCurrentPosition = st.steerRobot("")
      'Display the current position of ROBOT
      Console.WriteLine("--------------")
      Console.WriteLine("Report:" + sCurrentPosition)
      Console.ReadLine()
   End Sub
End Module
