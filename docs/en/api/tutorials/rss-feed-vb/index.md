---
uid: tutorial-rss-feed-vb
title: Tutorial - generate RSS feed in VB.Net
description: In this tutorial, you will create a feed that displays all activities created by other users on the current user's contact. A feed displays information. Each item in the feed includes metadata about that item.
keywords: rss, diary
date: 03.21.2022
version: 10
content_type: tutorial
language: en
redirect_from: /en/diary/tutorials/rss-feed-vb/index
---

# Tutorial - generate RSS feed in VB.Net

## Step 1: Introduction

The example handles user authentication with forms authentication mode using a custom login page. Based on the provided credentials, a link to the RSS feed is generated.

The second half explains how to generate the XML contents with the relevant activity information. Formatting of the feed content is then addressed, followed by instructions on configuring the feed in Outlook Express 2007.

The code uses the `SuperOffice.CRM.ArchiveLists.ActivityArchiveProvider` to retrieve activities registered by another user on the current user's contact.

**RSS** (Really Simple Syndication) is a web content syndication format. According to the RSS 2.0 specification: "RSS is a dialect of XML. All RSS files must conform to the XML 1.0 [specification][1], as published on the W3C website."

The generated feed conforms to this standard format.

Example RSS base template:

```xml
<?xml-stylesheet type="text/xsl" href="rss.xsl" media="screen"?>
<rss version="2.0" xmlns:dc="http://purl.org/dc/elements/1.1/">
  <channel>
    <title>SuperOffice Feed VB</title>
    <link><%= _url %></link>
    <description><%= _description %></description>
    <language>en-us</language>
    <copyright>Copyright 2006 SuperOffice</copyright>
    <pubDate><%= DateTime.Now.ToUniversalTime().ToString("R") %></pubDate>
    <generator>Late Night SuperOffice Hacker</generator>
    <%= _items %>
  </channel>
</rss>
```

The XML stylesheet on the first line formats how the feed is displayed. This will be explained in a later step.

## Step 2: Authentication and how to create the link to the feed

The generated feed link uses the user credentials along with the user preference for the number of items displayed in Feed contents is read and appended to the feed URL.

Then the logged-on user information is validated with the use of Authenticate method of SOSession. The user password has to be encrypted since it's sent along with the URL in plain text format. The support method Rot13 is used for this data conversion as shown in the following code segment.

```vb
''' <summary>
''' generates the link for the RSS feed
''' </summary>
''' <param name="sender"></param>
''' <param name="e"></param>
Protected Sub btnGenerateLink_Click(ByVal sender As Object, ByVal e As EventArgs)

    Try
        ' read user credentials
        Dim user As String = Server.UrlEncode(Me.txtUName.Text)
        Dim pass As String = Server.UrlEncode(Rot13(Me.txtPwd.Text))

        ' read maximum number of items to be displayed for the feed contents
        Dim num As String = Me.ddlMaxValue.SelectedValue

        ' generate the feed URL
        Dim path As String = "http://" + "localhost:50804" + "" + Request.ApplicationPath
        Dim url As String = String.Format("{0}/Feed.aspx?user={1}&pass={2}&size={3}", path, user, pass, num)

        ' authenticate the user with the credentials provided
        Dim session As SoSession = SoSession.Authenticate(user, Me.txtPwd.Text)

        If session Is Nothing Then
            Me.lnkURL.NavigateUrl = ""
            Me.lnkURL.Text = "Login failed - please try again"
        Else
            ' set the link
            Me.lnkURL.NavigateUrl = url
            Me.lnkURL.Text = url
            _url = url

            ' kill the session
            session.Close()
            session.Dispose()
        End If
    Catch exception As Exception
        Me.lblMessage.Text = exception.Message
    End Try

End Sub

''' <summary>
''' Modify the character code of the character
''' </summary>
''' <param name="text"></param>
''' <returns>the modified text</returns>
Public Shared Function Rot13(ByVal text As String) As String
    Dim res As String = ""
    Dim chars As Char() = text.ToCharArray()
    For i As Integer = 0 To chars.Length - 1
        Dim curChar As Integer = Microsoft.VisualBasic.AscW(chars(i))
        'Modify the character code of the character, - this
        'so that "a" becomes "n", "z" becomes "m", "N" becomes "Y" and so on

        If curChar >= 97 AndAlso curChar <= 109 Then
            curChar = curChar + 13
        ElseIf curChar >= 110 AndAlso curChar <= 122 Then
            curChar = curChar - 13
        ElseIf curChar >= 65 AndAlso curChar <= 77 Then
            curChar = curChar + 13
        ElseIf curChar >= 78 AndAlso curChar <= 90 Then
            curChar = curChar - 13
        End If

        'Add the current character to the string to be returned
        res += Microsoft.VisualBasic.ChrW(curChar)
    Next

    Return res
End Function
```

## Step 3: Get the activity information

Let us take a look at how the activity is generated and passed to the feed.

[!code-vb[VB](includes/rss-page.vb?range=1-69)]

[!code-vb[VB](includes/rss-page.vb?range=176-197)]

Section 1 shows how the parameters required by `GetArchiveListByColumns` are created (the columns to be included in the selection). It also defines the search restrictions and the entities to be included in the search.

Next, an `IArchiveAgent` object is retrieved using the `AgentFactory`. `GetArchiveListByColumns` method is then invoked to get the activity information.

## Step 4: Generate the RSS feed

[!code-vb[VB](includes/rss-page.vb?range=71-174)]

[!code-vb[VB](includes/rss-page.vb?range=199-208)]

Section 2 demonstrates how to, using the query results, generate the RSS feed. Here, we have chosen to iterates over the retrieved `ArchiveListItem` collection. It extracts data values for each `ArchiveListItem` and stores those in a `ListDictionary`.

The `ListDictionary` contains details of one activity at a time. Then the following `item` sub-element values are set based on data in the `ListDictionary`:

* title
* link
* description
* pubDate
* dc:creator

As shown in the feed code segment, this is the data referred to by the `<%= _items %>` data-binding expression.

## Step 5: Formatting RSS in XSLT

Internet Explorer 7+ and Firefox 2+ browsers have the integrated RSS reading capability. Previous versions of these browsers display RSS as plain XML. To address this issue, we use XSLT style sheets to control how the Feed will be rendered in a browser. The XML stylesheet will be ignored depending on whether the RSS is recognized as an XML document or as an RSS feed by a browser.

**XSLT style sheet:**

```xsl
<div id="Content">
  <h1><xsl:value-of select="rss/channel/title"/></h1>
  <ol id="ItemList">
    <xsl:for-each select="rss/channel/item">
    <li class="ItemListItem">
      <h1>
        <a><xsl:attribute name="href"><xsl:value-of select="link"/></a>
      </h1>
      <div class="ItemListItemDetails">
        Published <xsl:value-of select="pubDate"/> by <xsl:value-of select="dc:creator" />
      </div>
    </li>
    </xsl:for-each>
  </ol>
</div>
```

## Step 6: Configure

### Configure the feed in Outlook

RSS feeds can be subscribed through Microsoft Office Outlook 2007. The RSS subscriptions are kept in a separate folder along with the mail folders in Outlook 2007. Once subscribed, RSS feeds can be read the same way emails are read. When you click a particular feed all the posts appear in the same format as regular email in the mail reader pane.

To subscribe to RSS in Outlook 2007:

1. Go to Tools, then Account Settings.
2. Click RSS Feeds tab and Click **New** to add a new RSS Feed.
3. Enter the URL of the feed as shown below.

Now you can see a folder under *RSS Feeds* main folder with the name of the feed.

![RSS feeds folder -screenshot][img1]

### General settings

For the application to run, some modifications are required in the web configuration file. The following section illustrates the modifications required in the authentication section and the database section of the configuration file.

```xml
<authentication mode="Forms">
  <forms name="RSSFeedFinalVB" loginUrl="~/Default.aspx" protection="All" timeout="30" path="/"></forms>
</authentication>

<sessionState mode="InProc"
              stateConnectionString="tcpip=127.0.0.1:42424"
              stateNetworkTimeout="10"
              sqlConnectionString="data source=127.0.0.1;Integrated Security=SSPI"
              cookieless="false"
              timeout="40"/>

<authorization>
  <!-- 
  <deny users="?"/>
  <allow users="[comma separated list of users]"
         roles="[comma separated list of roles]" />
  <deny users="[comma separated list of users]"
        roles="[comma separated list of roles]" />
  -->
</authorization>

<Database>
  <add key="DatabaseMajor" value="MSSQL"/>
  <add key="DatabaseMinor" value="8"/>
  <add key="Server" value="ECCOLVISPHE"/>
  <add key="Database" value="SuperOffice"/>
  <add key="CommandTimeOut" value="300"/>
  <add key="TablePrefix" value="CRM5"/>
  <add key="ConnectionString" value="Server=[@Server];Database=[@Database];User ID=[@User];Password=[@Password]"/>
</Database>
```

The authentication mode is set to *Forms*, to enable custom user authentication. Here, the `loginUrl` points to the application's custom login page.

Further, the Database information has to be modified.

### Add references

To run the sample code, after we have updated the *web.config* file, we have to add the following references:

* SOCore.dll
* SODataBase.dll
* SuperOffice.Legacy.dll
* SuperOffice.Services.dll
* SuperOffice.Services.Impl.dll

## Step 7: Summary

**Feed content shown in a browser before subscribed:**

![RSS feed before subscribing -screenshot][img2]

Once subscribed to the feed it becomes available in the folder specified by the user.

![RSS feed after subscribing -screenshot][img3]

By clicking on the link in the feed contents, the appropriate dialog in SuperOffice CRM Web is opened:

![Dialog opened from RSS feed -screenshot][img4]

<a href="../../../../assets/downloads/api/rssfeedfinalvb.zip" download>Click to download source code (zip)</a>

<!-- Referenced links -->
[1]: http://www.w3.org/TR/REC-xml

<!-- Referenced images -->
[img1]: media/image035.jpg
[img2]: media/image032.jpg
[img3]: media/image033.jpg
[img4]: media/image034.jpg
