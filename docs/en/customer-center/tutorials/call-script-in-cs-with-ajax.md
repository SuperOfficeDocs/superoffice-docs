---
title: Using Ajax to call scripts
uid: call_script_in_cs_with_ajax
description: Using Ajax to call scripts in Customer Service
author: Simen Mostuen Iversen
date: 03.31.2014
keywords: Customer Center
content_type: tutorial
index: true
redirect_from: /en/customer-center/tutorials/index
---

# Using Ajax to call scripts in Customer Service

There are often scenarios where you need to get new information while on a page in Customer Centre and don’t want to load all objects at once or do any nasty post-backs.

Ajax is a neat tool where you can do calls dynamically and receive all the data you need, but be aware that too many calls at the same time will cause your solution to be slower.

In this example, I will create a list of companies that will vary depending on which group you’ve selected.

The first thing we’ve got to do is to create an extra table with the name `Group` and an extra field `Name`.

![Extra table -screenshot][img1]

Then create an extra table relation in the `company` table, to your newly created extra table.

![Extra table relation -screenshot][img2]

Create some entries in your `Groups` table, mine were IT, Economy, and Sales.

Remember to also connect the businesses you want to the groups you've made. If no one is connected to the extra table you created, then no companies will show in your new solution.

![Table entries -screenshot][img3]

 Now you’ve got to create your script in Customer Service, and write down the **Include name** and **Key** for later use.

```crmscript
String groupId = getCgiVariable("groupId");

SearchEngine se;
se.addField("contact.contact_id");
se.addField("contact.name");
se.addCriteria("contact.x_group", "Equals", groupId);

String output = "<option value='-1'>Choose</option>";

for(se.select(); !se.eof(); se.next())
  output += "<option value='" + se.getField(0) + "'>" + se.getField(1) + "</option>";

print(output);
```

> [!NOTE]
> Because this is going to be used in an HTML site we need to include `%EJSCRIPT_START%` and `%EJSCRIPT_END%`, or else we’ll receive the entire code as output when calling the script.

That's all we had to do in Customer Service, now we just need to create the page we want to view in the Customer Centre.

Go to where you've installed your Customer Service, go into the *Customer Service folder\templates\your language\customer*

Now, if you haven't done this already, create a folder called *specialForm* and inside create an empty HTML document.

![specialForm -screenshot][img4]

Then, into your file, add this:

[!code-html[HTML](includes/call-script-in-cs.html)]

This is a very simple document, and I'll explain the little details here:

The first part

[!code-html[HTML](includes/call-script-in-cs.html?range=1-15)]

Lists out all your created groups in a drop-down menu. It loads at the start of the page load and fills it out.

Then you've got an empty drop-down menu:

[!code-html[HTML](includes/call-script-in-cs.html?range=18-19)]

This is where we want to populate our new options. This is done from our script.

Now the more advanced part comes into play:

[!code-html[HTML](includes/call-script-in-cs.html?range=20-25)]

Are just two variables. It's important to check if the URL contains the correct `includeId` and `key`.

[!code-html[HTML](includes/call-script-in-cs.html?range=27-41)]

This function starts the event listener. It makes sure that when the script has been called, it will listen and output whatever it receives.

[!code-html[HTML](includes/call-script-in-cs.html?range=43-51)]

This is the jQuery part, which executes when there's been a change in the groups drop-down. Here it will use the URL we set earlier, and insert the group ID we got from the drop-down and send to our script. If you want more attributes to send, just insert them like this `M$name=Ola`:

```html
xmlhttp.send("groupId=" + $('#groups').val() + "&name=Ola");
```

This is one of the most basic ones out there, although you can still create a simpler one this is a very powerful way to create more dynamic pages for everybody to enjoy.

<!-- Referenced images -->
[img1]: media/6238-10462.jpg
[img2]: media/6239-10460.jpg
[img3]: media/6241-10456.jpg
[img4]: media/6244-10466.jpg
