---
title: Generate RSS feed in VB.Net
uid: rss_feed_vb
description: Generate RSS feed in VB.Net
author: {github-id}
so.date: 
keywords: rss, diary
so.topic: tutorial
---

# Generate RSS feed in VB.Net

In this tutorial, we will create a feed that displays all activities created by other users on the current user’s contact. A feed displays information. Each item in the feed includes metadata about that item.

The example handles user authentication with forms authentication mode with a custom login page. Based on the user credentials provided, the link to the RSS feed is generated.

The second half explains how to generate the XML contents with the relevant activity information. How the formatting of the feed contents is handled will be addressed next, followed by an explanation of how to configure the feed in Outlook Express 2007 enabling Feed subscription through Outlook Express 2007.

<!-- The following screenshot shows how the link to the feed when valid user credentials are provided.

![ShowImage][img1] -->

## Authentication and how to create the link to the feed

The generated feed link uses the user credentials along with the user preference for the number of items displayed in Feed contents is read and appended to the feed URL.

Then the logged-on user information is validated with the use of Authenticate method of SOSession. The user password has to be encrypted since it’s sent along with the URL in plain text format. The support method Rot13 is used for this data conversion as shown in the following code segment.

[!code-vb[VB](includes/rss-generate-link.vb)]

## Generate XML Contents

**RSS** (Really Simple Syndication) is a web content syndication format. As specified in RSS 2.0 specification, "RSS is a dialect of XML. All RSS files must conform to the XML 1.0 [specification][1], as published on the World Wide Web Consortium (W3C) website."

The format for the RSS Feed is predefined with a set of required and optional elements. The generated feed conforms to this format.

Here is an example of how the base RSS feed template appears.

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

An XML stylesheet, which is referenced on the first line in the example above, formats how the feed is displayed. The stylesheet will be discussed later in the article. Let’s take a look at how the activity is generated and passed to the feed.

The code example uses the **SuperOffice.CRM.ArchiveLists.ActivityArchiveProvider** to retrieve the activities registered by another user on the current user’s contact.

### Section 1

Section 1 shows how the parameters required by `GetArchiveListByColumns` are created (the columns to be included in the selection). It also defines the search restrictions and the entities to be included in the search.

Next, an `IArchiveAgent` object is retrieved using the `AgentFactory`. `GetArchiveListByColumns` method is then invoked to get the activity information.

### Section 2

Section 2 demonstrates how to, using the query results, generate the RSS feed. Here, we have chosen to iterates over the retrieved `ArchiveListItem` collection. It extracts data values for each `ArchiveListItem` and stores those in a `ListDictionary`.

The `ListDictionary` contains details of one activity at a time. Then the following `item` sub-element values are set based on data in the `ListDictionary`:

* title
* link
* description
* pubDate
* dc:creator

As shown in the feed code segment, this is the data referred to by the `<%= _items %>` data-binding expression.

## Formatting RSS in XSLT

Internet Explorer 7+ and Firefox 2+ browsers have the integrated RSS reading capability. Previous versions of these browsers display RSS as plain XML. To address this issue, we use XSLT style sheets to control how the Feed will be rendered in a browser. The XML stylesheet will be ignored depending on whether the RSS is recognized as an XML document or as an RSS feed by a browser.

**XSLT style sheet:**

```html
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

## RSS results

**Feed content shown in a browser before subscribed:**

![32][img2]

Once subscribed to the feed it becomes available in the folder specified by the user.

![33][img3]

By clicking on the link in the feed contents, the appropriate dialog in SuperOffice CRM Web is opened:

![34][img4]

## Configure the feed in Outlook

RSS feeds can be subscribed through Microsoft Office Outlook 2007. The RSS subscriptions are kept in a separate folder along with the mail folders in Outlook 2007. Once subscribed, RSS feeds can be read the same way emails are read. When you click a particular feed all the posts appear in the same format as regular email in the mail reader pane.

To subscribe to RSS in Outlook 2007:

1. Go to Tools, then Account Settings.
2. Click RSS Feeds tab and Click ‘New’ to add a new RSS Feed.
3. Enter the URL of the feed as shown below.

Now you can see a folder under *RSS Feeds* main folder with the name of the feed.

![35][img5]

## General settings

For the application to run, some modifications are required in the web configuration file. The following section illustrates the modifications required in the authentication section and the database section of the configuration file.

[!code-xml[XML](includes/rss-webconfig.xml)]

The authentication mode is set to *Forms*, to enable custom user authentication. Here, the `loginUrl` points to the application's custom login page.

Further, the Database information has to be modified.

## Configuration

To run the sample code, after we have updated the *web.config* file, we have to add the following references:

* SOCore.dll
* SODataBase.dll
* SuperOffice.Legacy.dll
* SuperOffice.Services.dll
* SuperOffice.Services.Impl.dll

<a href="../assets/downloads/rssfeedfinalvb.zip" download>Click to download source code (zip)</a>

<!-- Referenced links -->
[1]: http://www.w3.org/TR/REC-xml

<!-- Referenced images -->
[img1]: media/image031.jpg
[img2]: media/image032.jpg
[img3]: media/image033.jpg
[img4]: media/image034.jpg
[img5]: media/image035.jpg
