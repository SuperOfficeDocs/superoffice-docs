---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: build-custom-rest-api-methods       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: Building custom REST API methods using CRMScript # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: Frode Lillerud
so.date: 10.17.2017
keywords:
so.topic: howto           # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
so.envir:                 # cloud or onsite
so.client:                # online, web, win, pocket, or mobile
---

# Building custom REST API methods using CRMScript

When doing programming for SuperOffice you'll encounter a plethora of APIs that you can use. There is the old COM-based API that only works with the Windows client, you've got the NetServer web services which are extensively used by the product itself, but is somewhat .NET focused, there is the SOAP based API that Ejournal had for working with Requests, and there is the new REST API which is recently released.

And then there’s the custom approach described in this blog post.

Sometimes you just need to be able to supply a simple, highly specified, REST API endpoint for doing a specific task. This is typically going to be used by someone outside of the SuperOffice bubble that we live in. Perhaps the webguy responsible for the customer's corporate website just needs an endpoint that he can POST to when someone fills out a form on his webpage. Or maybe the phone system needs to be able to retrieve a list of persons and their mobile numbers.

Using CRMScript it is fairly trivial to write a script that can be called from the external system, and will let them get data from SuperOffice, or supply data to SuperOffice.

Here is an absolutely minimal example which defines a web service endpoint for changing the name of a company.

```crmscript
Integer contactId = getCgiVariable("contactId").toInteger();
String name = getCgiVariable("name");

NSContactAgent contactAgent;
NSContactEntity contact = contactAgent.GetContactEntity(contactId);
contact.SetName(name);
contact = contactAgent.SaveContactEntity(contact);
```

This endpoint can be called by doing a GET to this URL (either directly in your browser, or by using a tool like Postman:

`http://service.example.com/scripts/customer.exe?action=safeParse&includeId=something&key=abc&contact­Id=123&name=NewName`

Now, obviously, this simple script has some room for improvement, but as a start, I just wanted to show the minimum needed to do something.

Ok, let's improve the script by only allowing POST, validate the data passed in, and return some sort of status indicator back to the caller.

```crmscript
Integer contactId = getCgiVariable("contactId").toInteger();
String name = getCgiVariable("name");

//Require POST
if (!cgiWasPost())
  return; 

//Validate input
if (contactId <= 0 || name.isEmpty())
  return;

NSContactAgent contactAgent;
NSContactEntity contact = contactAgent.GetContactEntity(contactId);
contact.SetName(name);
contact = contactAgent.SaveContactEntity(contact);

printLine("Ok, contactId " + contactId.toString() + " now has the name " + contact.GetName());
```

A couple of things you need to be aware of here. The `cgiWasPost()` is somewhat sensitive as to the Content-Type, so it has to be set to "x-www-form-urlencoded".

![x][img1]

Also, at the end of the script we’re just printing out the response. Since we haven’t said otherwise this will be returned as Content-type "text/HTML" and with HTTP status code "200 OK".

Let’s change the example a bit so that it can be used to retrieve data from SuperOffice as JSON, and show how we also can control the HTTP Status Code returned.

```crmscript
#setLanguageLevel 3;

//https://sod.superoffice.com/Custxxxxx/CS/scripts/customer.fcgi?action=safeParse&includeId=simple&k­ey=abcde

//Set HTTP headers
Map _headers;
_headers.insert("Content-Type", "application/json;charset=utf-8");
_headers.insert("X-Custom-Header", "abc");

//Grab incoming CGI parameters
Map result;
Integer personId = getCgiVariable("personId").toInteger();
if (personId == 0)
  _headers.insert("Status", "406 Bad Request - No personId found");
else {
  //Lookup data in SuperOffice
  NSPersonAgent personAgent;
  NSPerson person = personAgent.GetPerson(personId);
  if (person.GetPersonId() != personId)
  {
    _headers.insert("Status", "404 Person not found");
  }
  else {
    result.insert("firstname", person.GetFirstname());
    result.insert("lastname", person.GetLastname());
    _headers.insert("Status", "200 OK");
  }
}

//Return headers and data
String h;
for (_headers.first(); !_headers.eof(); _headers.next())
  h += _headers.getKey() + ": " + _headers.getVal() + "\n";

setParserVariable("ej.headers", h);
printLine(result.toJson());
```

Here there is more stuff going on. We’re setting the HTTP headers manually, so we have total control of all the bits returned to the caller. We’ve got full access to setting things like Content-Types, HTTP status codes and custom X-headers.

Hopefully, you get the sense that this is extremely powerful, and the possibilities here are endless. Typically these kinds of custom endpoints are used for providing a way to create new tickets, update existing companies or extract a list project or sales.

The examples above are fairly trivial, and a real-world script can end up being quite a bit longer than the examples. A pro-tip is to split up the scripts, so that the entry-script, which has the `%EJSCRIPT_START%` tags will include other scripts. Those other scripts do not need `%EJSCRIPT%` tags. By splitting it up you’ll get a better developer experience since the syntax checking performed when saving a script doesn’t work for `%EJSCRIPT%` type scripts.

## With great power comes great responsibility

Execution of these types of endpoints are done as a system user, so you could end up getting data which is private. The URL to a script, if shared inappropriately, could give someone access to data they shouldn’t have access to. I recommend also putting some work into building an authentication mechanism for these scripts, like some sort of token or username/password-based criteria, which could be revoked. Also, logging incoming requests and responses can be beneficial.

These scripts work both for Online and Onsite environments, but in Online there are a few extra considerations. A script is not allowed to run for more than 60 seconds, and it cannot consume more than 8MB of RAM. If the script breaks any of those two rules it’ll be killed. Furthermore, you must make sure you do not call your script too frequently. If your script is executed too often or creates too much load, it will be throttled.

So, there you have it. If the standard APIs supplied by SuperOffice doesn’t cut it for you, you’ve now got one more option you can use.

<!-- Referenced images -->
[img1]: media/13215-28728.jpg
