Public Module Settings

    'The module opens the database and creates a datatable in vb, then any edits that occur during the program then 
    'it updates the database With the datatable
    Public Function runSQL(ByVal query As String) As DataTable
        Dim con As New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=dbPMQuiz.mdb")
        'Establishes a connection to a access file by the name dbPMQuiz
        Dim da As OleDb.OleDbDataAdapter
        'This is the data adapter, this fetches data from the database and then translates between the database and VB
        'But it does not completely exist at this point
        Dim dt As New DataTable
        'Create the data table variable assigned to dt
        con.Open() 'Opens the database connection
        da = New OleDb.OleDbDataAdapter(query, con) 'The data adapter now exists and it runs the following query
        'by the connection
        dt.Clear() 'The table is cleared incase it already had values within it
        dt.Columns.Clear() 'Verification that the table is cleared
        da.Fill(dt) 'The data adapter is now filled with the database
        con.Close() 'Closes the connection to the database
        'It is important to close the connection because only one connection can be made at one time
        Return dt 'The data table filled with the database is now outputted from the function
    End Function
End Module
