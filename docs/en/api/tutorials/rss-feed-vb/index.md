---
uid: tutorial-rss-feed-vb
title: Tutorial - generate RSS feed in VB.Net
description: In this tutorial, you will create a feed that displays all activities created by other users on the current user's contact. A feed displays information. Each item in the feed includes metadata about that item.
keywords: rss, diary
date: 03.21.2022
version: 10
content_type: tutorial
language: en
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

[!code-vb[VB](includes/rss-generate-link.vb)]

## Step 3: Get the activity information

Let us take a look at how the activity is generated and passed to the feed.

[!include[Content: get activity info](includes/steps/get-activity-info.md)]

## Step 4: Generate the RSS feed

[!include[Content: generate RSS feed](includes/steps/generate-feed.md)]

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

[!include[Content: Configuration](includes/steps/config.md)]

## Step 7: Summary

[!include[Content: RSS results](includes/steps/rss-results.md)]

<a href="~/../assets/downloads/api/rssfeedfinalvb.zip" download>Click to download source code (zip)</a>

<!-- Referenced links -->
[1]: http://www.w3.org/TR/REC-xml
