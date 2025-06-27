---
title: Expanding quick search
uid: expand-quick-search
description: Expanding quick search functionality
author: Hans Wilhelmsen
keywords: Service, quicksearch, screen chooser
content_type: howto
date: 09.30.2013
---

# Expanding quick search functionality

Customer Service out of the box offers quick searching through the field in the top right corner on most of the fields for contacts and persons in the database.

Occasionally the need to search for something else arises, whether it be some standard field that is not a part of the regular options for quick search functionality or it being an extra column/field on an already existing table or a new table altogether.

You can even have the quick-search search some remote website if that's what you want.

![x -screenshot][img1]

Adding additional search criteria to the quick search is quite possible, and I'll try to explain how you can easily implement it.

1. Through **System Design**, go to **Screen Choosers**.

2. Find and click **Quicksearch**

3. Paste the following code into the textbox:

```crmscript
String s = getCgiVariable("HtmlPage_quickSearch");
if(s.find("sport:") >= 0) {
  String q = s.after(":");
  setVariable("url",getProgram(1) + "&action=searchTable&ok=1&table=person&field.0=person.x_sport&value.0=" + q);
}
```

While searching for people who have football as their favorite sport might not be something everyone is craving to have as a new search functionality, I'll quickly explain how to edit a couple of the parts to make it work with something else:

**"**if(s.find("**sport:**") >=0) {"

The bold text defines the search keyword and can be replaced by anything as long as it doesn't interfere with any of the other search keywords, but alone this doesn't define what you will be searching for, other than implying it.

"setVariable("url",getProgram(1) + "**&action=searchTable&ok=1&table=person&field.0=person.x_sport&value.0=**" + q);"

The bold text, together with `getProgram(1)` defines what you will be searching for. The q at the end represents the text after your colon, as in what you were searching for. As long as the search is done within Customer Service, there's no need to remove or change the `getProgram(1)` part.

* `table=` specifies which table the search will be made on

* `field.0=` specifies which column/field on which table the search will be made on

However, should you be interested in searching outside Customer Service you could do the following:

`setVariable("url","http://www.1881.no/?Query=" + q);`

This would result in a search for the parameter provided on the Norwegian Yellow Pages site, 1881.

As long as you know the query string for a website you can use this functionality towards pretty much any page.

<!-- Referenced images -->
[img1]: media/5438-8684.jpg
