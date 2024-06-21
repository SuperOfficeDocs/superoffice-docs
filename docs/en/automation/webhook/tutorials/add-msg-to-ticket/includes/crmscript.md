<!-- markdownlint-disable-file MD041 -->
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
