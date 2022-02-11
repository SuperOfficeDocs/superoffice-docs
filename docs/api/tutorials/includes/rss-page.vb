Imports SuperOffice
Imports SuperOffice.CRM.Services
Imports System.Collections.Generic
Imports System.Collections.Specialized
Imports SuperOffice.CRM.ArchiveLists
Imports SuperOffice.CRM.Archives
Imports SuperOffice.CRM.Globalization

' Some code left out for brevity

Public _pubDate As DateTime = DateTime.MinValue
Public _url As String = ""
Public _items As String = ""
Public _description As String = "All activities that other users have recently registered on your contacts in SuperOffice."

Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
    ' validate the session
    Dim session As SoSession = Me.validateSession()

    If session IsNot Nothing Then
        ' set the url value for the feed
        Dim path As String = "http://" + "localhost:50804" + "" + Request.ApplicationPath
        _url = String.Format("{0}/default.aspx", path)

        ' - - - - - - - - - - - - - - - - - - - - - -
        ' SECTION 1 : Retrieve Activity information
        ' - - - - - - - - - - - - - - - - - - - - - -

        ' Setting the Parameters that needs to be passed to Agent method and retrieve activity information

        ' Parameter - providerName - The name of the archive provider to use
        Dim providerName As String = ActivityArchiveProvider.ProviderName

        'Parameter - columns - An array of the names of the columns wanted.
        Dim columns As String() = New String() {"date", "saleId", "appointmentId", "documentId", "sale/description", "appointment/description", _
        "document/description", "project/name", "contact/name", "associateId", "type", "contact/department", _
        "contactId"}

        'Parameter - restriction - Archive restrictions
        Dim associateRestriction As New ArchiveRestrictionInfo("associateId", "associateIsNotOneOf", SoContext.CurrentPrincipal.AssociateId)

        Dim registeredUserRestriction As New ArchiveRestrictionInfo("contact/associateId", "currentAssociate", SoContext.CurrentPrincipal.AssociateId)

        Dim restrictions As ArchiveRestrictionInfo() = New ArchiveRestrictionInfo(1) {}

        restrictions(0) = associateRestriction
        restrictions(1) = registeredUserRestriction

       'Parameter - sortOrder - Sort order for the archive
        Dim archiveSrtOrd As ArchiveOrderByInfo() = New ArchiveOrderByInfo(0) {}

        archiveSrtOrd(0) = New ArchiveOrderByInfo("date", SuperOffice.Util.OrderBySortType.DESC)

        'Parameter - entities – which entities to be included
        Dim entities As String() = New String() {"document", "appointment", "sale"}

        'Parameter - page - Page number, page 0 is the first page
        'Parameter - pageSize - Page size
        Dim page As Integer = 0
        Dim pageSize As Integer = 500

        ' Create an ArchiveAgent object
        Dim newActivity As IArchiveAgent = AgentFactory.GetArchiveAgent()

        ' Call the get ‘GetArchiveListByColumns’ method to retrieve the specified records
        Dim activitytItems As ArchiveListItem() = _
             newActivity.GetArchiveListByColumns(providerName, _
             columns, archiveSrtOrd, restrictions, entities, page, _
             pageSize)

        ' - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -
        ' SECTION 2 : Generate the feed XML with retrieved activity data
        ' - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -

        ' iterate over the activity collection
        For Each listItem As ArchiveListItem In activitytItems
            Dim lstActivityInfo As New ListDictionary()
            Dim id As String = Nothing
            Dim description As String = Nothing
            Dim activityMainType As String = Nothing
            Dim contactId As String = Nothing
            Dim link As String = "http://localhost/SuperOfficeWebUpdatable/default.aspx?superoffice:contact.activityarchive."

            Dim newDate As DateTime = DateTime.MinValue

            ' retrieve the column names and the data values for each ArchiveListItem and store in the ListDictionary

            For Each column As KeyValuePair(Of String, ArchiveColumnData) In listItem.ColumnData
                Dim displayValue As String = "-"

                If (column.Value IsNot Nothing) Then
                    displayValue = column.Value.DisplayValue.ToString()
                End If

                Dim key As String = column.Key

                If (key = "date") AndAlso (displayValue IsNot Nothing) Then
                    Dim tempDate As String = displayValue.Substring(3, 10)
                    newDate = DateTime.Parse(tempDate)
                    displayValue = newDate.ToUniversalTime().ToString("yyyyMMdd-T-HHmmss-Z")
                End If

                lstActivityInfo.Add(key, displayValue)
            Next

            contactId = lstActivityInfo("contactId").ToString()

            ' activity type : Sale
            If listItem.EntityName = "sale" Then
                id = lstActivityInfo("saleId").ToString()
                description = lstActivityInfo("sale/description").ToString()
                activityMainType = "Sale"
                link += "sale?contact_id=" + Me.activityId(contactId) + "&sale_id=" + Me.activityId(id)
            End If

            ' activity type : Appointment
            If listItem.EntityName = "appointment" Then
                id = lstActivityInfo("appointmentId").ToString()
                description = lstActivityInfo("appointment/description").ToString()
                activityMainType = "Appointment"
                link += "appointment?contact_id=" + Me.activityId(contactId) + "&appointment_id=" + Me.activityId(id)
            End If

            ' activity type : Document
            If listItem.EntityName = "document" Then
                id = lstActivityInfo("documentId").ToString()
                description = lstActivityInfo("document/description").ToString()
                activityMainType = "Document"
                link += "document?contact_id=" + Me.activityId(contactId) + "&document_id=" + Me.activityId(id)
            End If

            ' generate the <item> information of the feed XML (values for <title>,<link>,<description>,<pubDate> and <dc:creator> components are set here)

            Dim item As String = ""
            item += "<item>"
            item += "<title>"
            item += Server.mdEncode(activityMainType + ": " + lstActivityInfo("contact/name").ToString())
            item += "</title>"
            item += "<guid isPermaLink='false'>"
            item += "guid.SuperOfficeASA.appointid." + id
            item += "</guid>"
            item += "<link>"
            item += Server.mdEncode(link)
            item += "</link>"
            item += "<description>"

            Dim desc As String = ""
            desc += "<b> Summary : </b> " + lstActivityInfo("associateId").ToString() + " registered an activity of type <b>" + lstActivityInfo("type").ToString() + "</b> on " + lstActivityInfo("contact/name").ToString() + ", " + lstActivityInfo("contact/department").ToString() + "<p>"
            desc += "<b> Project :</b> " + lstActivityInfo("project/name").ToString() + "<br/>"
            desc += "<b> On :</b> " + newDate.ToUniversalTime().ToString("R") + "<br/>"
            desc += "<b> Activity description :</b> " + description + "<br/>"
            desc += "</p>"

            item += Server.mdEncode(desc)
            item += "</description>"
            item += "<pubDate>"
            item += newDate.ToString("f")
            item += "</pubDate>"
            item += "<dc:creator>"
            item += "Creator :" + lstActivityInfo("associateId").ToString()
            item += "</dc:creator>"
            item += "</item>"

            _items += item

            lstActivityInfo.Clear()
        Next
        session.Close()
        session.Dispose()
    Else
        ' validation fails: redirect to login page
        Response.Redirect("~/Default.aspx")
    End If
End Sub

Private Function validateSession() As SoSession
    ' read the query string values
    Dim user As String = Request("user")
    Dim secret As String = Request("pass")
    Dim maxnum As String = Request("size")

    ' get the secret password value secret = Rot13(secret)
    ' read the maximum number of records displayed at a time
    Dim max As Integer = 5
    If maxnum IsNot Nothing Then
        Integer.TryParse(maxnum, max)
    End If

    ' validate the session
    Dim session As SoSession = Nothing

    If session Is Nothing AndAlso user IsNot Nothing AndAlso secret IsNot Nothing Then
        session = SoSession.Authenticate(user, secret)
    End If

    Return session
End Function

''' <summary>
''' format the identity values dat has the format [I:XXX]
''' </summary>
''' <param name="originalId"></param>
''' <returns></returns>
Private Function activityId(ByVal originalId As String) As String
    Dim index As Integer = originalId.IndexOf("]"c)
    Dim temString As String = originalId.Remove(index)
    Return temString.Substring(3).Trim()
End Function