Imports System.Data.SqlClient
Public Class Mainform
    Dim cmd As SqlCommand
    Dim cn As SqlConnection
    Dim dr1, dr2 As SqlDataReader
    Public Sub connect()
        cn = New SqlConnection("Server=LAPTOP-PKKTTSU2\SQLEXPRESS;Database=Webbuilder;Trusted_Connection=True;")
        cn.Open()
    End Sub


    Private Sub Mainform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Visible = False
        WebBrowser1.Visible = False
        MenuStrip1.Width = 2000
        'GunaAdvenceTileButton2.Visible = False
        'GunaAdvenceTileButton1.Visible = False
        'RichTextBox2.Height = 1000
        'RichTextBox2.Width = 300
        'RichTextBox2.Location = New Point(RichTextBox1.Location.X + 500, RichTextBox1.Location.Y + 10)
        RichTextBox1.Height = 740
        RichTextBox1.Width = 620
        RichTextBox1.Location = New Point(RichTextBox1.Location.X + 180, RichTextBox1.Location.Y + 6)
        RichTextBox1.Text = "<html>
      <body></body>
</html>"
        RichTextBox1.Font = New Font("Arial", 12)

    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged
        WebBrowser1.DocumentText = RichTextBox1.Text
    End Sub

    Private Sub TreeView1_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TreeView1.AfterSelect
        Dim str As String
        str = TreeView1.SelectedNode.Text
        RichTextBox1.SelectedText = str.Substring(str.IndexOf(":") + 1)
        If e.Node.Text = "Head tag : <head>statements...</head>" Then
            TextBox1.Text = "Heading Tag : The <head> tag is used to define the head portion of document.
Eg: <h1>WEB BUILDER</h1>"
            TextBox1.Font = New Font("Arial Rounded MT", 12, FontStyle.Bold)
        ElseIf e.Node.Text = "Body tag : <body>statements...</body>" Then
            TextBox1.Text = "Body Tag: The <body> tag defines the document's body.It contains all the contents of HTML documents, such as text,hyperlinks,images,tables,lists,etc.Eg:<body>The content of your document... </body>"
            TextBox1.Font = New Font("Arial Rounded MT", 12, FontStyle.Bold)
        ElseIf e.Node.Text = "Title tag : <title>statements...</title>" Then
            TextBox1.Text = "Title Tag: The <title> tag is used for declaring the title,or name,of the HTML document.
Eg: <title>WEB BUILDER!</title>"
            TextBox1.Font = New Font("Arial Rounded MT", 12, FontStyle.Bold)
        ElseIf e.Node.Text = "Paragraph tag : <p>statements...</p>" Then
            TextBox1.Text = "Paragraph Tag: The <p> tag defines a paragraph.
Eg: <p>This is some text in a paragraph.</p>"
            TextBox1.Font = New Font("Arial Rounded MT", 12, FontStyle.Bold)
        ElseIf e.Node.Text = "Bold tag : <b>statements...</b>" Then
            TextBox1.Text = "Bold Tag: The <b> tag is used to create 'b' element, which represents bold text in an HTML document.
Eg: <b>This is bold text.</b>"
            TextBox1.Font = New Font("Arial Rounded MT", 12, FontStyle.Bold)
        ElseIf e.Node.Text = "Italic tag : <i>statements...</i>" Then
            TextBox1.Text = "Italic Tag: The <i> tag is used to make text italic.
Eg: <i>WELCOME TO MY HTML PAGE.</i>"
            TextBox1.Font = New Font("Arial Rounded MT", 12, FontStyle.Bold)
        ElseIf e.Node.Text = "Underline tag : <u>statements...</u>" Then
            TextBox1.Text = "Underline Tag: The <u> tag is used to underline a text in HTML.
Eg: <u>WELCOME TO MY HTML PAGE.</u>"
            TextBox1.Font = New Font("Arial Rounded MT", 12, FontStyle.Bold)
            '        ElseIf e.Node.Text = "Anchor tag : <a href="...">statements...</a>" Then
            '            GunaTextBox1.Text = "Anchor Tag: It is used to define the beginning and end of a hyertext link.
            'Eg: <a href = "www.google.com" > Visit Google.com!.</a>"
            '            GunaTextBox1.Font = New Font("Arial Rounded MT", 12, FontStyle.Bold)
        ElseIf e.Node.Text = "Comment tag : <!--statements...-->" Then
            TextBox1.Text = "Comment Tag: The comment tag is used to insert comments in the source code. Comments are not displayed in the browsers.
Eg:<!--This is a comment. Comments are not displayed in the browser-->"
            TextBox1.Font = New Font("Arial Rounded MT", 12, FontStyle.Bold)
            '        ElseIf e.Node.Text = "Marquee tag :<!--statements...-->" Then
            '            GunaTextBox1.Text = "Marquee Tag: The HTML <marquee> tag defines a scrolling text area in the HTML document that moves across the page in a horizontal or vertical direction.
            'Eg:<marquee bgcolor="cyan" behavior="scroll" width=60% direction="down" height="100px" loop="" scrollamount="10" scrolldelay="10">This is scrolling text.</marquee>"
            '            GunaTextBox1.Font = New Font("Arial Rounded MT", 12, FontStyle.Bold)
        ElseIf e.Node.Text = "Center tag : <center>statements...</center>" Then
            TextBox1.Text = "Center Tag: The center tag is used to set the align of text into the center.
Eg:<center>WELCOME!!!</center>"
            TextBox1.Font = New Font("Arial Rounded MT", 12, FontStyle.Bold)
        ElseIf e.Node.Text = "Line Break tag : <br></br>" Then
            TextBox1.Text = "Line Break Tag: A line break ends the line you are currently on and resumes on the nextline.
Eg: This text contains<br> a line break."
            TextBox1.Font = New Font("Arial Rounded MT", 12, FontStyle.Bold)
        ElseIf e.Node.Text = "Meta tag :<meta></meta>" Then
            TextBox1.Text = "Meta Tag: The <meta> tag provides metadata about HTML document. Metadata will be displayed on page, but will be machine parsable.
            Eg:<meta name=''keywords'' content=''HTML, CSS, XML, XHTML, JavaScript''>"
            TextBox1.Font = New Font("Arial Rounded MT", 12, FontStyle.Bold)
        ElseIf e.Node.Text = "Form tag : <form>statements...</form>" Then
            TextBox1.Text = "Form Tag: The <form> tag is used to create a HTML form for user input."
            TextBox1.Font = New Font("Arial Rounded MT", 12, FontStyle.Bold)
        ElseIf e.Node.Text = "Content separator tag : <hr></hr>" Then
            TextBox1.Text = "Content Separator Tag: The <hr> element is used to separate content(or define a change) in an HTML page.
Eg: <p>HTML is language for describing web pages.</p>
<hr>
<p>CSS defines how to display HTML elements.</p>"
            TextBox1.Font = New Font("Arial Rounded MT", 12, FontStyle.Bold)
        ElseIf e.Node.Text = "Preformatted text block : <pre></pre>" Then
            TextBox1.Text = "Preformatted text block: The <pre> tag is used to define the block of preformatted text.
Eg:<pre>Text in pre element is displayed in fixed-width font, and it preserves both spaces and line breaks.</pre>"
            TextBox1.Font = New Font("Arial Rounded MT", 12, FontStyle.Bold)
        End If
    End Sub
    Private Sub SaveAsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveAsToolStripMenuItem.Click
        If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            RichTextBox1.SaveFile(SaveFileDialog1.FileName, RichTextBoxStreamType.PlainText)
        End If
    End Sub

    Private Sub PrintToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintToolStripMenuItem.Click
        WebBrowser1.ShowPrintDialog()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        If MsgBox("Do you really want to exit?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Exit") = MsgBoxResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        'Dim od As New OpenFileDialog
        'od.ShowDialog()
        ''MsgBox(od.FileName & "l")
        'WebBrowser1.Navigate(od.FileName & "l")
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            RichTextBox1.LoadFile(OpenFileDialog1.FileName, RichTextBoxStreamType.PlainText)
        End If
    End Sub

    Private Sub HTMLPageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HTMLPageToolStripMenuItem.Click
        RichTextBox1.Visible = True
        If RichTextBox1.Visible = True Then
            RichTextBox1.Text = "<html>
      <body></body>
</html>"
            RichTextBox1.Font = New Font("Arial", 12)
        End If
        'If RichTextBox1.TextLength <> 0 Then
        '    If MsgBox("Do you want to save file?", MsgBoxStyle.Information + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
        '        If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
        '            RichTextBox1.SaveFile(SaveFileDialog1.FileName, RichTextBoxStreamType.PlainText)
        '        End If
        '    Else
        '        RichTextBox1.Clear()
        '    End If
        'End If
    End Sub

    Private Sub CutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CutToolStripMenuItem.Click
        RichTextBox1.Cut()
    End Sub

    Private Sub UndoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UndoToolStripMenuItem.Click
        RichTextBox1.Undo()
    End Sub

    Private Sub PasteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PasteToolStripMenuItem.Click
        RichTextBox1.Paste()
    End Sub

    Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyToolStripMenuItem.Click
        RichTextBox1.Copy()
    End Sub

    Private Sub RedoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RedoToolStripMenuItem.Click
        RichTextBox1.Redo()
    End Sub

    Private Sub SelectAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectAllToolStripMenuItem.Click
        RichTextBox1.Select()
    End Sub

    Private Sub SelectAllToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SelectAllToolStripMenuItem1.Click
        RichTextBox1.SelectAll()
    End Sub

    Private Sub BorderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BorderToolStripMenuItem.Click
        bgimage.Show()
    End Sub

    Private Sub OutputToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OutputToolStripMenuItem.Click
        WebBrowser1.Visible = True
        WebBrowser1.Height = 740
        WebBrowser1.Width = 580
        WebBrowser1.Location = New Point(WebBrowser1.Location.X + 570, WebBrowser1.Location.Y + 8)
    End Sub

    Private Sub BorderToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles BorderToolStripMenuItem1.Click
        border.Show()
    End Sub

    Private Sub BoxToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BoxToolStripMenuItem.Click
        box.Show()
    End Sub

    Private Sub ColorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ColorToolStripMenuItem.Click
        bgcolor.Show()
    End Sub

    Private Sub ImageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImageToolStripMenuItem.Click
        bgimage.Show()
    End Sub

    Private Sub PreviewToolStripMenuItem_Click(sender As Object, e As EventArgs)
        preview.Show()
    End Sub

    Private Sub HelpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HelpToolStripMenuItem.Click
        preview.Show()
    End Sub

    Private Sub IMPORTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IMPORTToolStripMenuItem.Click
        RichTextBox1.SelectedText = "style='@import url(text.css)';"
    End Sub

    Private Sub ResizeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResizeToolStripMenuItem.Click
        RichTextBox1.SelectedText = "style='resize:none|both|horizontal|vertical|initial|inherit;'"
    End Sub

    Private Sub SpeakToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SpeakToolStripMenuItem.Click
        RichTextBox1.SelectedText = "style='speak:none|spell-out|normal|inherit;'"
    End Sub

    Private Sub WordSpacingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WordSpacingToolStripMenuItem.Click
        RichTextBox1.SelectedText = "style='word-spacing:5px;'"
    End Sub

    Private Sub WordWrapToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WordWrapToolStripMenuItem.Click
        RichTextBox1.SelectedText = "style='word-wrap:normal|break-word|initial|inherit; width:155px'"
    End Sub

    Private Sub ColumnToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ColumnToolStripMenuItem.Click
        Column.Show()
    End Sub

    Private Sub MarginToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MarginToolStripMenuItem.Click
        showmargin.Show()
    End Sub
    Private Sub BackgroundColorToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles BackgroundColorToolStripMenuItem1.Click
        Dim od1 As New ColorDialog
        od1.ShowDialog()
        RichTextBox1.BackColor = od1.Color
    End Sub

    Private Sub FOODToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FOODToolStripMenuItem.Click
        RichTextBox1.LoadFile("C:\Users\HIMANI SONEWANE\Documents\web2020.txt", RichTextBoxStreamType.PlainText)
    End Sub

    Private Sub GMAILFORMToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GMAILFORMToolStripMenuItem.Click
        RichTextBox1.LoadFile("C:\Users\HIMANI SONEWANE\Documents\formnew", RichTextBoxStreamType.PlainText)
    End Sub



    Private Sub TagsToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles TagsToolStripMenuItem1.Click
        Try
            Dim sql As String
            connect()
            sql = "select * from tag_name"
            cmd = New SqlCommand(sql, cn)
            dr1 = cmd.ExecuteReader
            While dr1.Read
                TreeView1.Nodes.Add(dr1.Item(0))
                'TreeView1.Nodes.Add(dr.Item(1))
                'TreeView1.Nodes(0).Nodes.Add("h1")
            End While
            dr1.Close()
            sql = "select * from properties_table"
            cmd = New SqlCommand(sql, cn)
            dr2 = cmd.ExecuteReader
            While dr2.Read
                TreeView1.Nodes(0).Nodes.Add(dr2.Item(0))
                TreeView1.Nodes(10).Nodes.Add(dr2.Item(2))
                TreeView1.Nodes(12).Nodes.Add(dr2.Item(3))
                'TreeView1.Nodes(18).Nodes.Add(dr2.Item(9))
                TreeView1.Nodes(1).Nodes.Add(dr2.Item(7))
                TreeView1.Nodes(13).Nodes.Add(dr2.Item(4))
                TreeView1.Nodes(16).Nodes.Add(dr2.Item(6))
                TreeView1.Nodes(17).Nodes.Add(dr2.Item(9))
                TreeView1.Nodes(7).Nodes.Add(dr2.Item(8))
            End While
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        TextBox1.Location = New Point(TextBox1.Location.X, TextBox1.Location.Y + 380)
        TextBox1.Width = 300
        TextBox1.Height = 140
        TextBox1.Text = "!!!WELCOME TO WEB BUILDER!!!"
        TextBox1.Font = New Font("Arial Rounded MT", 12, FontStyle.Bold)
        'GunaAdvenceTileButton1.Visible = True
        'GunaAdvenceTileButton2.Visible = True
        'GunaAdvenceTileButton1.Width = 250
        'GunaAdvenceTileButton2.Location = New Point(GunaAdvenceTileButton2.Location.X + 163, GunaAdvenceTileButton2.Location.Y)
        TreeView1.Visible = True
        'TreeView1.Sort()
        TreeView1.Location = New Point(TreeView1.Location.X, TreeView1.Location.Y + 10)
        TreeView1.Height = 570
        TreeView1.Width = 300
        TextBox1.Visible = True
    End Sub
End Class