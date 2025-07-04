---
uid: custom-form-edit-customer
title: Custom form - edit customer
description: Custom form in Customer Centre to edit a customer
author: kronicz
date: 09.15.2011
keywords: CRMScript, Customer Center, form
content_type: tutorial
index: true
---

# Custom form - edit customer

This tutorial shows you how to create a custom form in the Customer Centre to allow modifying a customer

By default, we have a page in the customer care center allowing the customer to change their name, password, and any extra fields, such as an address or interest flags used for subscriptions to eMarketing messages. In many cases, our standard page will suffice. However, if you need something a bit more customized, here is an example of how to create another page in the customer centre, allowing the customer to modify "something".

Most pages in the customer care center use the simplified parser language. In this scenario, I will rather use a CRMScript created from within SuperOffice. This also allows me to edit the script without having to access the disk on the SuperOffice server.

When you create a CRMScript, there are two fields which allow you to access the script from the Customer Centre: **Include name** and **Key**. They will allow you to identify and authenticate access to the script. The idea is that by knowing these two values, you are allowed to execute the script in the Customer Centre with this URL: `.../scripts/customer.fcgi?action=safeParse&includeId=change-customer-information&key=JJbqoeFSR65ItWS4`

![Custom form - edit customer -screenshot][img1]

As you can see, there are some important parameters to `customer.fcgi`:

| Parameter | Description |
|-----------|-------------|
| `action=safeParse` | Specifies the main method of the Customer Centre, which in this case tells it that we want to execute a custom script. |
| `includeId=change-customer-information` | Specifies that we want to execute the script with Include name "change-customer-address". |
| `key=JJbqoeFSR65ItWS4` | Specifies that the secret key of the script is "JJbqoeFSR65ItWS4". If it does not match the key of the script, an error will be returned. |
| `withFrame=1`| Optional. This will make the page a part of the Customer Centre default visual look by placing the returned contents inside *framework.html*, just like the other Customer Centre pages. |

Additionally, you can include any parameters of your choice in the URL. You can retrieve them inside your CRMScript by calling the `getCgiVariable()` method. This method will also retrieve any fields sent to this script by any form POST methods, which is what we will use for our custom form.

In this example, I have created a new CRMScript with the following values:

* includeId: change-customer-information
* key: JJbqoeFSR65ItWS4
* body:

```html
%EJSCRIPT_START%
<%
Customer theCustomer;
theCustomer.load(getParserVariable("customer.id").toInteger());

if (getCgiVariable("ok") != "")
{
  theCustomer.setValue("firstname", getCgiVariable("firstname"));
  theCustomer.setValue("lastname", getCgiVariable("lastname"));
  theCustomer.setValue("x_address", getCgiVariable("address"));
  theCustomer.save();
  print("Information saved!");
}
else
{
  %>
  <form method='post' action='<%print(getParserVariable("AuthProgram"));%>?action=safeParse&includeId=change-customer-information&key=JJbqoeFSR65ItWS4&withFrame=1'>
  <table>
  <tr><td>First name:</td><td><input type='text' name='firstname' value='<% print(theCustomer.getValue("firstname")); %>'></td></tr>
  <tr><td>Last name:</td><td><input type='text' name='lastname' value='<% print(theCustomer.getValue("lastname")); %>'></td></tr>
  <tr><td>Address:</td><td><textarea name='address' rows='5' cols='50'><% print(theCustomer.getValue("x_address")); %></textarea></td></tr>
  <tr><td align='center' colspan='2'><input style='width: 100px' type='submit' name='ok' value=' Ok '></td></tr>
  </form>
  <%
}

%>
%EJSCRIPT_END%
```

Notice how the body is not in core CRMScript syntax, but rather in our embedded CRMScript format, which resembles PHP, ASP, and so on. As you can see, this is a format that by default is HTML, but that allows you to embed CRMScript between `<%` and `%>`. The first and last lines define the beginning and end of this embedded language section.

You can execute this script from your customer care center with the following URL. Note that for this particular scenario, I have added an extra field, `x_address`, to the `customer` table.

`.../scripts/customer.fcgi?action=safeParse&includeId=change-customer-information&key=JJbqoeFSR65ItWS4&withFrame=1`

## Add to left menu

If you want to, you can add this item to the left menu of the customer care center. To do this, you will have to edit *framework.html* (in Customer centre source files) to add this item. You only want this screen for logged in customers, which means you will add something like this to your *framework.html*:

![menu  -screenshot][img4]

It's just a copy of another menu line with the modified URL. This is how it looks:

![form 1 -screenshot][img2]

![form 2 -screenshot][img3]

<!-- Referenced image -->
[img1]: media/script.png
[img2]: media/form1.png
[img3]: media/form2.png
[img4]: media/menuitem.png
