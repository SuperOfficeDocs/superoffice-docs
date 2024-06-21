---
uid: crmscript-random-requests-tutorial
title: Creating lots of random requests
description: Creating lots of random requests in CRMScript
author: kronicz
date: 10.03.2022
keywords: CRMScript
topic: tutorial
---

# Creating lots of random requests

Sometimes when you experiment with Service, it is convenient to have a lot of dummy requests in the database. Here is a small script that will create a given number of requests with a variable number of messages containing Lorem Ipsum content. The script will initially load all categories and customers so that the data will be randomly related to these entities.

![random request -screenshot][img1]

Here is the code for this script. The top section has some variables which can be configured to tune the behavior.

```crmscript
#setLanguageLevel 2;

// Configuration section
Integer numTickets = 10;
Integer minAge = 10; // In hours
Integer maxAge = 1000;
Integer minNumMessages = 2;
Integer maxNumMessages = 5;

String source = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Donec odio. Quisque volutpat mattis eros. Nullam malesuada erat ut turpis.";

String[] words = source.split(" ");

Integer[] customerIds;
Integer[] categoryIds;

SearchEngine customerQuery;
customerQuery.addField("person.id");
for (customerQuery.execute(); !customerQuery.eof(); customerQuery.next())
    customerIds.pushBack(customerQuery.getField(0).toInteger());

SearchEngine categoryQuery;
categoryQuery.addField("ej_category.id");
for (categoryQuery.execute(); !categoryQuery.eof(); categoryQuery.next())
    categoryIds.pushBack(categoryQuery.getField(0).toInteger());

String createRandomString(Integer p_length)
{
    String result;
    while (p_length-- > 0)
        result += words[rand(0, words.length() - 1)] + " ";
    return result.subString(0, 1).toUpper() + result.subString(1, result.getLength() - 1).stripTrailing(" ") + ".";
}

for (Integer i = 0; i < numTickets; i++)
{
    Customer myCustomer;
    myCustomer.load(customerIds[rand(0, customerIds.length() - 1)]);

    DateTime created;
    DateTime closed;
    created.addHour(-1 * rand(minAge, maxAge));
    closed = created;
    closed.addHour(rand(10, 100));

    Ticket newTicket;
    newTicket.setValue("title", createRandomString(rand(10, 20)));
    newTicket.setValue("status", rand(1, 3).toString());
    newTicket.setValue("category", categoryIds[rand(0, categoryIds.length() - 1)].toString());
    newTicket.setValue("custId", myCustomer.getValue("id"));
    newTicket.setValue("priority", rand(1, 3).toString());
    newTicket.setValue("slevel", rand(1, 2).toString());
    Integer ticketId = newTicket.save();

    newTicket.setValue("created_at", created.toString());
    newTicket.setValue("closed_at", closed.toString());
    newTicket.save();

    print("Created request: created at: " + newTicket.getValue("created_at") + ", closed at: " + newTicket.getValue("closed_at") + "\r\n");

    Integer numMessages = rand(minNumMessages, maxNumMessages);
    for (Integer m = 0; m < numMessages; m++)
    {
        String body;
        Integer numParagraphs = rand(1, 5);
        for (Integer j = 0; j < numParagraphs; j++)
        body += createRandomString(rand(20, 100)) + "\r\n\r\n";

        Message newMessage;
        newMessage.setValue("body", body);
        newMessage.setValue("author", myCustomer.getValue("name"));
        created.addHour(rand(10, 100));
        newMessage.setValue("ticketId", ticketId.toString());
        newMessage.save();
        newMessage.setValue("createdAt", created.toString());
        newMessage.save();
    }
}
```

[img1]: media/random-requests.png
