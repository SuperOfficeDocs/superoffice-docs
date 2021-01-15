---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: add_msg_to_ticket_with_github_webhook       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: Using GitHub webhooks to add message to ticket # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: Frode Lillerud
so.date: 02.07.2019
keywords:
so.topic: howto                # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
# so.envir:                     # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# Using GitHub webhooks to add message to ticket

Two of our primary tools for maintaining control when developing customizations for our customers are GitHub and SuperOffice Service, and in this blog post I'll briefly describe how we've used CRMScript to create a light integration between the two systems.

The jist of it is that whenever we commit code to GitHub, we can optionally include a Ticket ID in the commit message, and this will create a message in our SuperOffice.

So a commit like this:

![x][img1]

Generates this on the correct ticket:

![x][img2]

I'll keep the blog post short - those interested in this topic will probably be able to figure out how it works by just reading through the source code below.

First step is to create a web service in SuperOffice with script similar to this:

```crmcsript
#setLanguageLevel 3;
#include "lib-http";
#include "lib-ticket";

/* 
 * Webservice which listens for webhooks from GitHub.
 * If the commit contains 'GEAS-ID: 12345', then a message is added on that ticket.
 * Frode, 7.des 2018
 */

//Configuration start
Integer replyTemplateId = 82;
Integer personId = 92618; //Person "GitHub Commit" on company "GitHub".
//Configuration end

struct GitHubUser {
  String name;
  String email;
  String username;
};

struct GitHubCommit {
  String url;
  String message;
  GitHubUser author;
  GitHubUser committer;
};

struct GitHubInfo {
  GitHubCommit[] commits;
  
  String toJson() {
    JSONBuilder jb;
    this.toJson(jb);
    return jb.getString();
  }
  
  Void fromJson(String json) {
    this.fromXMLNode(parseJSON(json));
  }
};

//Load the incoming JSON data into a struct.
String data = getCgiContent();
GitHubInfo info;
info.fromJson(data);

//Find our static GitHub person.
NSPersonAgent personAgent;
NSPerson person = personAgent.GetPerson(personId);

//Does the commit contain a ticket ID?
for (Integer i = 0; i < info.commits.length(); i++) {
  //String contains 'GEAS', then maybe a dash, then 'ID', then maybe ':', then maybe a whitespace, then a number which is 5 or 6 chars long.
  String pattern = "GEAS-?ID:?\\s?([0-9]{5,6})"; 
  String[] matches = info.commits[i].message.regexp(pattern);
  if (matches.length() >= 2) {
    //Found a ticket ID.
    Integer ticketId = matches[1].toInteger();
    
    ReplyTemplate r;
    r.load(replyTemplateId);
    
    Parser p;
    p.setVariable("committer", info.commits[i].committer.name);
    p.setVariable("message", info.commits[i].message);
    p.setVariable("url", info.commits[i].url);
    p.setVariable("data", data);
    
    String body = p.parseString(r.getHtmlBody(-1));
    
    Message m = CreateDefaultMessage(ticketId);
    //m.setValue("createdBy", users.get(info.commits[i].author.username));
    //m.setValue("customer_id", personId.toString());
    m.setValue("customerId", personId.toString());
    m.setValue("bodyHtml", body);
    m.setValue("slevel", "1"); //internal
    m.setValue("author", person.GetFullName()); // info.commits[i].author.name);
    m.save();
  }
}

return Ok();
```

> [!TIP]
> Remember to wrap the script in the appropriate EJSCRIPT start and end tags

The two includes can be found in the [SuperOffice CRMScript repo][1].

The next step, is to tell GitHub to post JSON to SuperOffice whenever a commit happens.

We've set the setting on the GitHub organization level by going to Settings and the WebHooks settings. Create a webhook there which points to the script.

![x][img3]

The URL looks like this:

`https://crm.example.com/scripts/customer.fcgi?action=safeParse&includeId=github-webhooks-all&key=sec­ret`

And from then on all commits which contains the magical ID reference will end up as messages in SuperOffice.

Hope this is useful for someone!

<!-- Referenced links -->
[1]: https://github.com/SuperOffice/CRMScripts

<!-- Referenced images -->
[img1]: media/gh-commit.png
[img2]: media/ticket.png
[img3]: media/webhook-gh-settings.png
