---
title: Archive email message
uid: mailarchivehelper_find_contact
description: Find contact from email
author: Tony Yates
so.date: 06.24.2016
keywords: vb
so.topic: howto
so.client: web,win
so.envir: onsite
---

# Archive email message

```vb
Public Function GetMailArchiveHelper() As MailArchiveHelper
  Dim helper As New MailArchiveHelper()
  helper.Initialize("SO5OUTL", "MSG", "SO5OUTL.CHM")
  Return helper
End Function

' returns true if not already archived, or if already archived, 
' but user wants to archive a duplicate
Private Function ContinueIfDuplicate(ByVal i_MailId As String, _ByVal i_Subject As String) As Boolean
  Using archiveHelper As MailArchiveHelper = GetMailArchiveHelper()
    Dim text As String = archiveHelper.GetArchivedTooltip( _i_Subject, i_MailId, RecordType.Document)
      If Len(text) > 0 Then
        text = text & vbCr & GetResource(Resource.cContinueDuplicate)
        Return MsgBox(text, MsgBoxStyle.YesNo, _GetResource(Resource.cDialogTitle)) = MsgBoxResult.Yes
      End If
    Return True  ' Not archived from before
  End Using
End Function

' SafeItem is an Outlook MailItem COM object
Public Function ArchiveAsDoc(ByVal safeItem As Object) As Boolean
  Dim checkForDuplicate As Boolean = True
 
  Dim archiveInfo As ArchiveInfo = New ArchiveInfo()
  archiveInfo.ShowDialog = GetRegValueBool(kAlwaysShowDialog, True)
  archiveInfo.Address = safeItem.FromAddress.Email
  archiveInfo.Name = safeItem.FromAddress.Name
  Dim archiveitem As Boolean = True
  If checkForDuplicate = True Then
    archiveitem = ContinueIfDuplicate(safeItem.Fields(UNIQUEMAILID), _safeItem.Subject)
  End If
  If archiveitem Then
    Dim fileName As String = GetNiceTempPath() & GetTempFilename() & ".msg"
    On Error Resume Next
    safeItem.SaveAs(fileName, OlSaveAsType.olMSG)
    On Error GoTo 0
    Dim docInfo As DocumentInfo = New DocumentInfo()
    docInfo.Date = safeItem.SendDate
    docInfo.Filename = fileName
    docInfo.Direction = DocDirection.kIncoming
    docInfo.ForeignKey = safeItem.Fields(UNIQUEMAILID)
    docInfo.Completed = True
    docInfo.Title = safeItem.Subject
    Using archiveHelper As Object = GetMailArchiveHelper()
      archiveHelper.ArchiveDocument(archiveInfo, docInfo)
    End Using
  End If
End Function
```

The `ArchiveAsDoc` function checks the SMTP unique message ID to see if the message has already been archived. If it has, it prompts the user with a dialog.

If the message is not archived, or the user wants to duplicate the message, then the message is saved to a temp file, and the temp file is imported into SuperOffice using the mail archive helper.

<!-- See the ArchiveDocument reference. -->
