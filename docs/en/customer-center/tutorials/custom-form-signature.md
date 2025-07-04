---
uid: custom-form-signature
title: Custom form - Signature
description: Custom form in Customer Centre with Signature
author: kronicz
date: 01.20.2012
keywords: CRMScript, Customer Center
content_type: tutorial
index: true
---

# Custom form with signature

A typical business scenario for this could be an order form, perhaps shown on a tablet, where the customer would sign to confirm the order.

![Custom form with signature -screenshot][img1]

## Custom form

Since we want full control of the visual layout of this form, and also want to make this form available for external users, I will create it as a web page produced by an CRMScript.

Our first version of the script looks like this:

```html
%EJSCRIPT_START%
<html>
<body>
<% #setLanguageLevel 3;

String name = getCgiVariable("name");
String units = getCgiVariable("units");
String signature = getCgiVariable("signature");
Bool printForm = true;

if (getCgiVariable("ok") != "") // Got posted
{
}

if (printForm)
{ %>
<form method="post" action='<%print(getParserVariable("AuthProgram"));%>&action=safeParse&includeId=sig_form&key=TLJM31BqZA1iiStQ'>
<table>
 <tr><td>Name:</td></tr>
 <tr><td><input type='text' name='name' value='<% print(name); %>'></td></tr> 
 <tr><td>Ordered units:</td></tr>
 <tr><td><input type='text' name='units' value='<% print(units); %>'></td></tr>
 <tr><td colspan='2'><input type='submit' name='ok' value='Ok'></td></tr>
</form>
</body>
</html>
<%
}
%>
%EJSCRIPT_END%
```

This code has two important areas. The first if-section will get executed if the form was posted. Inside this section, we will process a post. The second if-section will get executed unless `printForm` is set to false, and prints out the form. The idea is that if the user posts the form, but the data is incorrect, we can bail out of the first if (without setting `printForm` to false), and the form will get reprinted with the posted values. For simplicity, no validation or escaping is done in the example code.

### The Signature area

The idea of the signature area is based on some new HTML5 functionality: the canvas tag. This tag allows us to create an area which we can draw in with JavaScript, and which can be exported to an image and represented as a base64-encoded string. The string can be stored in a hidden text element. The components we need for this to work are:

* A canvas element.
* Some JavaScript to handle drawing in the canvas. Needs to work with both mouse and touch events.
* A hidden form field to contain the image data.
* A JavaScript which executes when we click the **Submit** button, which gets the contents of the canvas and converts it to a base64 string and stores it in the hidden field.
* CRMScript code which manages the post. Creates a new request, with a new message, and with an attachment with the posted image data.

### The HTML code

The HTML-code in this example is very simple, but some small modifications have been done so that this will look good on an iPhone or iPad:

* `<meta name = "viewport" content = "initial-scale = 1.0">`: This will cause the page not to be zoomed initially.
* `event.preventDefault()`: This will cause the page not to be pushed up/down when you touch inside the signature area. Makes it a lot simpler to sign.

### The JavaScript for drawing in the canvas

There are numerous examples of how to draw in a canvas on the net. The idea is basically:

1. Register `onmousedown`-event, and then register the mouse/touch coordinates and begin drawing.
2. For each `onmousemove`-event, as long as the mouse button is still down, get the new coordinates and draw a line from the old ones to the new ones.
3. When we get the `onmouseup`-event, we stop drawing.

Getting the correct coordinates inside the drawing area is in fact a bit tricky in JavaScript, but is solved with the function `getPositionInElement()`.

### Getting the signature drawing and posting it

There is no standard way in HTML to post an image to the server. So, in order to make the signature a part of the post, we will get the image as a text string (base64 encoding of the image as a png image file), and store this in a `input type=”hidden”` tag. This needs to be done just before we post, and is managed by the function `copyCanvasToHidden()`

### Processing the Post

The section where the post is processed on the server is inside the `if (getCgiVariable(“ok”) != “”)`-section. Here we make sure that supplied form data (retrieved by getCgiVariable) are valid. Then we save a new request, save a new message, and save a new attachment. The method `saveBase64()` on the attachment-class takes care of saving the image.

### Complete code

Here is the complete code. Just create this as a CRMScript under **System design > Scripts**, set the include ID to "sig_form" and the key to "TLJM31BqZA1iiStQ", and it should work out of the box.

[!code-text[HTML](includes/custom-form.html)]

<!-- Referenced image -->
[img1]: media/image011.png
