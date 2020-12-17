---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: expand_quick_search       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: Expanding quick search functionality # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: Hans Wilhelmsen             # Your GitHub alias.
keywords:
so.topic: howto               # article, howto, reference, concept, guide
so.date: 30 Sep 2013

# Optional fields. Don't forget to remove # if you need a field.
# so.envir:                     # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# Expanding quick search functionality

Customer Service out of the box offers quick searching through the field in the top right corner on most of the fields for contacts and persons in the database.

Occasionally the need to search for something else arises, wether it be some standard field that is not a part of the regular options for quick search functionality or it being an extra column/field on an already existing table or a new table altogether.

You can even have the quick search do a search on some remote website if that's what you want.

![x][img1]

Adding additional search criteria to the quick search is quite possible, and I'll try to explain how you can easily implement it.

1. Through **System Design**, go to **Screen Choosers**.

2. Find and click **Quicksearch**

3. Paste the following code into the textbox:

```crmscript
String s = getCgiVariable("HtmlPage\_quickSearch");
if(s.find("sport:") >= 0) {
  String q = s.after(":");
  setVariable("url",getProgram(1) + "&action=searchTable&ok=1&table=person&field.0=person.x\_sport&value.0=" + q);
}
```

While searching for people who have football as their favorite sport might not be something everyone is craving to have as a new search functionality, I'll quickly explain how to edit a couple of the parts to make it work with something else:

**"**if(s.find("**sport:**") >=0) {"

The bold text defines the search keyword, and can be replaced by anything as long as it doesn't interfere with any of the other search keywords, but alone this doesn't really define what you will be searching for, other than implying it.

"setVariable("url",getProgram(1) + "**&action=searchTable&ok=1&table=person&field.0=person.x\_sport&value.0=**" + q);"

The bold text, together with `getProgram(1)` defines what you will be searching for. The q at the end represents the text after your colon, as in what you were searching for. As long as the search is done within Customer Service, there's no need to remove or change the `getProgram(1)` part.

* `table=` specifies which table the search will be made on

* `field.0=` specifies which column/field on which table the search will be made on

However, should you be interested in searching outside Customer Service you could do the following:

`setVariable("url","http://www.1881.no/?Query=" + q);`

This would result in a search for the parameter provided on the Norwegian Yellow Pages site, 1881.

As long as you know the query string for a website you can use this functionality towards pretty much any page.

<!-- Referenced images -->
[img1]: media/5438-8684.jpg