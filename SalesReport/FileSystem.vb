Imports System
Imports System.Collections.Generic
Imports System.Text
Imports System.IO

Class FileSystem
    Private _bufferSize As Integer = 3 * 1024 * 1024
    Public Property BufferSize() As Integer
        Get
            Return _bufferSize
        End Get
        Set(ByVal value As Integer)
            _bufferSize = value
        End Set
    End Property

#Region "'CopyProgress' event definition code"

    ''' <summary>
    '''     EventArgs derived type which holds the custom event fields
    ''' </summary>
    Public Class CopyProgressEventArgs
        Inherits System.EventArgs
        ''' <summary>
        '''     Use this constructor to initialize the event arguments
        '''     object with the custom event fields
        ''' </summary>
        Public Sub New(ByVal percentage As Decimal, ByVal copiedBytes As Long, ByVal totalBytes As Long, ByVal eta As Double, ByVal elapsedTime As Double)
            Me.percentage = percentage
            Me.copiedBytes = copiedBytes
            Me.totalBytes = totalBytes
            Me.eta = eta

            Me.elapsedTime = elapsedTime
        End Sub

        ''' <summary>
        '''     Percentage of copied bytes
        ''' </summary>
        Public ReadOnly percentage As Decimal

        ''' <summary>
        '''     Number of copied bytes
        ''' </summary>
        Public ReadOnly copiedBytes As Long

        ''' <summary>
        '''     Total bytes to be copied
        ''' </summary>
        Public ReadOnly totalBytes As Long

        ''' <summary>
        '''     Estimated time left in seconds
        ''' </summary>
        Public ReadOnly eta As Double

        ''' <summary>
        '''     Time Elapsed
        ''' </summary>
        Public ReadOnly elapsedTime As Double

        Private m_cancel As Boolean = False
        Public Property Cancel() As Boolean
            Get
                Return m_cancel
            End Get
            Set(ByVal value As Boolean)
                m_cancel = value
            End Set
        End Property

    End Class

    ' Private delegate linked list (explicitly defined)
    Private CopyProgressEventHandlerDelegate As EventHandler(Of CopyProgressEventArgs)

    ''' <summary>
    '''     Provide feedback for file processing progress
    ''' </summary>
    Public Event CopyProgress As EventHandler(Of CopyProgressEventArgs)




#End Region

#Region "'FileCopyCompleted' event definition code"

    ''' <summary>
    '''     EventArgs derived type which holds the custom event fields
    ''' </summary>
    Public Class FileCopyCompletedEventArgs
        Inherits System.EventArgs
        ''' <summary>
        '''     Use this constructor to initialize the event arguments
        '''     object with the custom event fields
        ''' </summary>
        Public Sub New(ByVal Successful As Boolean)
            Me.Successful = Successful
        End Sub

        ''' <summary>
        '''     TODO: Describe the purpose of this event argument here
        ''' </summary>
        Public ReadOnly Successful As Boolean

    End Class

    ''' <summary>
    '''     This represents the delegate method prototype that
    '''     event receivers must implement
    ''' </summary>
    Public Delegate Sub FileCopyCompletedEventHandler(ByVal sender As Object, ByVal args As FileCopyCompletedEventArgs)

    ''' <summary>
    '''     TODO: Describe the purpose of this event here
    ''' </summary>
    Public Event FileCopyCompleted As FileCopyCompletedEventHandler

    ''' <summary>
    '''     This is the method that is responsible for notifying
    '''     receivers that the event occurred
    ''' </summary>
    Protected Overridable Sub OnFileCopyCompleted(ByVal e As FileCopyCompletedEventArgs)
        RaiseEvent FileCopyCompleted(Me, e)
    End Sub

#End Region

    ''' <summary>
    '''     Copies the sourceFile to the outFile
    ''' </summary>
    ''' <param name="sourceFile" type="string">
    '''     <para>
    '''         Source file to be copied
    '''     </para>
    ''' </param>
    ''' <param name="outFile" type="string">
    '''     <para>
    '''         File copy destination
    '''     </para>
    ''' </param>
    ''' <returns>
    '''     A bool value that indicate a successful copy finished.
    ''' </returns>
    Public Function CopyFile(ByVal sourceFile As String, ByVal outFile As String) As Boolean
        Dim fi As New FileInfo(sourceFile)
        Dim totalBytes As Long = fi.Length
        Dim success As Boolean = True

        If totalBytes = 0 Then
            'no file data
            File.Create(outFile).Close()
        Else
            Dim readStream = New FileStream(sourceFile, FileMode.Open, FileAccess.Read)
            Dim writeStream = New FileStream(outFile, FileMode.Create)
            Dim readBytes As Integer = 1
            Dim startTime As DateTime = DateTime.Now
            Dim totalCopiedBytes As Long = 0
            Dim buffer As Byte() = New Byte(_bufferSize - 1) {}

            While readBytes > 0
                readBytes = readStream.Read(buffer, 0, _bufferSize)
                totalCopiedBytes += readBytes
                writeStream.Write(buffer, 0, readBytes)

                Dim m = DateTime.Now.Subtract(startTime).TotalMilliseconds
                Dim speed = totalCopiedBytes / m
                Dim eta = (totalBytes - totalCopiedBytes) / speed

                Dim evt = New CopyProgressEventArgs(CDec(totalCopiedBytes) / totalBytes, totalCopiedBytes, totalBytes, eta, m)
                RaiseEvent CopyProgress(Me, evt)

                If evt.Cancel Then
                    success = False
                    Exit While

                End If
            End While

            writeStream.Close()
            readStream.Close()
        End If
        'If everthing is ok copy file attributes to the newly created file.
        If success Then
            File.SetCreationTime(outFile, File.GetCreationTime(sourceFile))
            File.SetLastWriteTime(outFile, File.GetLastWriteTime(sourceFile))
            File.SetAttributes(outFile, File.GetAttributes(sourceFile))
        Else
            If File.Exists(outFile) Then
                File.Delete(outFile)
            End If
        End If

        OnFileCopyCompleted(New FileCopyCompletedEventArgs(success))
        Return success
    End Function

End Class
