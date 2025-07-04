---
title: Embed chat widget
uid: embed_chat_widget_on_external_site
description: Embed chat widget on external site
author: Michel Krohn-Dale
keywords: Customer Center, chat
content_type: tutorial
index: true
---

# Embed chat widget on external site

To offer a more seamless and smooth experience for customers we introduced support for automatic authentication in the chat widget we use in our Customer Centre in SuperOffice version 8.5 R05.

Well great news, but what if you want to embed SuperOffice chat on an external website?

For each chat channel that you configure in your system, we generate a unique script tag that allows you to embed a chat widget on any other site.

```javascript
<script src='https://online.superoffice.com/CustXXXXX/CS/javascript/chat.js'
data-topicId='1' data-title='Standard chatchannel' data-theme='classic' data-color='#0080FF' data-font='verdana' data-delay='1'></script>
```

## Scenario

Let’s expand this a bit with a real-life scenario:

Your customer has an external website that allows their customers to log in and they want to add SuperOffice chat to this page. This website exists outside our ecosystem, so you know that our authentication mechanism will not work, but you would prefer that customers would not have to manually fill out the pre-chat form as they already have authenticated.

## How to solve this?

It is possible to expand the script tag with data-attributes to pass values into the pre-chat form. The following 4 attributes are supported:

<!-- markdownlint-disable-file MD034 -->
* Name: **data-customerName** = "John Rowling"
* Email: **data-customerEmail** = "john@mailinator.com"
* Phone: **data-customerPhone** = "12345678"
* Company: **data-companyName** = "Liberty Inc"

The contextual page might have these values available as either local JavaScript variables, cookie values, or URL parameters. Therefore, it should be possible to use the following syntax:

* `data-customerName="cookie:someValue"?`: Get the value from the cookie named "someValue"
* `data-customerName="url:someParameter"`: Get the value from the URL parameter named "someParameter"
* `data-customerName="variable:someVar"`: Get the value from the JavaScript variable named "someVar" ("window.someVar")

All 4 fields support this syntax.

This would now give you, for example, a newly expanded script tag using information from the cookie.

```javascript
 <script src='https://online.superoffice.com/CustXXXXX/CS/javascript/chat.js' data-topicId='1' data-title='Standard chatchannel' data-theme='classic' data-color='#0080FF'
data-font='verdana' data-delay='1' data-customerName='cookie:custName' data-customerEmail='cookie:custEmail' data-customerPhone='cookie:custPhone'></script>
```

The pre-chat form would automatically populate based on present cookie values:

![how-can-we-help -screenshot][img1]

![cookies -screenshot][img2]

<!-- Referenced images -->
[img1]: media/how-can-we-help.png
[img2]: media/cookies.png
