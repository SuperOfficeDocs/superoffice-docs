---
title: Custom form - Signature
uid: custom_form_signature
description: Custom form in Customer Centre with Signature
author: {github-id}
so.date: 01.20.2012
keywords:
so.topic: tutorial
---

# Custom form with signature

A typical business scenario for this could be an order form, perhaps shown on an Ipad or similar tablet, where the customer would sign to confirm the order.

![x][img1]

## Custom Form

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

### The Signature Area
 
The idea of the signature area is based on some new HTML5 functionality: the canvas tag. This tag allows us to create an area which we can draw in with javascript, and which can be exported to an image and represented as a base64-encoded string. The string can be stored in a hidden text element. The components we need for this to work are:

* A canvas element.
* Some javascript to handle drawing in the canvas. Needs to work with both mouse and touch events.
* A hidden form field to contain the image data.
* A javascript which executes when we click the Submit-button, which gets the contents of the canvas and converts it to a base64 string and stores it in the hidden field.
* CRMScript code which manages the post. Creates a new request, with a new message, and with an attachment with the posted image data.

### The HTML Code
The HTML-code in this example is very simple, but some small modifications have been done so that this will look good on an iphone/ipad:

* `<meta name = "viewport" content = "initial-scale = 1.0">`: This will cause the page not to be zoomed initially.
* `event.preventDefault()`: This will cause the page not to be pushed up/down when you touch inside the signature area. Makes it a lot simpler to sign.

### The Javascript for Drawing in the Canvas
There are numerous examples of how to draw in a canvas on the net. The idea is basically:

1. Register `onmousedown`-event, and then register the mouse/touch coordinates and begin drawing.
2. For each `onmousemove`-event, as long as the mouse button is still down, get the new coordinates and draw a line from the old ones to the new ones.
3. When we get the `onmouseup`-event, we stop drawing.

Getting the correct coordinates inside the drawing area is in fact a bit tricky in javascript, but is solved with the function `getPositionInElement()`.

### Getting the Signature Drawing and Posting It
There is no standard way in HTML to post an image to the server. So, in order to make the signature a part of the post, we will get the image as a text string (base64 encoding of the image as a png image file), and store this in a `input type=”hidden”` tag. This needs to be done just before we post, and is managed by the function `copyCanvasToHidden()`

### Processing the Post
The section where the post is processed on the server is inside the `if (getCgiVariable(“ok”) != “”)`-section. Here we make sure that supplied form data (retrieved by getCgiVariable) are valid. Then we save a new request, save a new message, and save a new attachment. The method `saveBase64()` on the attachment-class takes care of saving the image.

### Complete Code
Here is the complete code. Just create this as a CRMScript under System design > Scripts, set the include id to “order-form” and the key to “answer-is-42”, and it should work out of the box.

```html
<html>
  <head>
  <meta name = "viewport" content = "initial-scale = 1.0">
      <script src="https://code.jquery.com/jquery-3.6.0.min.js" integrity="sha256-/xUj+3OJU5yExlq6GSYGSHk7tPXikynS7ogEvDej/m4=" crossorigin="anonymous"></script>
  <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.min.js" integrity="sha384-QJHtvGhmr9XOIpI6YVutG+2QOK9T+ZnN4kzFN1RtK3zEFEIsxhlmWl5/YESvpZ13" crossorigin="anonymous"></script>
      <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" integrity="sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3" crossorigin="anonymous">
  
  %EJSCRIPT_START%
  <script>
NSMa
  var pos = null;
var context = null;

function getPositionInElement(p_event, p_isTouch)
{
  var x = (p_isTouch ? p_event.touches[0].pageX : p_event.clientX);
  var y = (p_isTouch ? p_event.touches[0].pageY : p_event.clientY);
  p_event.preventDefault();
  var element = p_event.srcElement;
  do
  {
    x -= element.offsetLeft;
    y -= element.offsetTop;
    element = element.offsetParent;
  }
  while (element != null)
    return {'x': x, 'y': y};
}

function canvas_onmousedown(p_event, p_isTouch)
{
  pos = getPositionInElement(p_event, p_isTouch);
  var canvas = document.getElementById("canvas");
  context = canvas.getContext("2d");
  context.beginPath();
  context.moveTo(pos.x, pos.y);
}

function canvas_onmouseup(p_event, p_isTouch)
{
  pos = null;
}

function canvas_onmousemove(p_event, p_isTouch)
{
  if (pos != null)
  {
    pos = getPositionInElement(p_event, p_isTouch);
    context.lineTo(pos.x, pos.y);
    context.stroke();
  }
}

function copyCanvasToHidden()
{
  var canvas = document.getElementById("canvas");
  var signature = document.getElementById("signature");
  signature.value = canvas.toDataURL();
}

function clearCanvas()
{
  var canvas = document.getElementById("canvas");
  context = canvas.getContext("2d");
  context.clearRect(0, 0, canvas.width, canvas.height);
}
function resize_canvas(){
    canvas = document.getElementById("canvas");
    if (canvas.width  < window.innerWidth)
    {
        canvas.width  = window.innerWidth;
    }
}

</script>
  </head>
  <body onresize='resize_canvas()'>
  <div class='container'>
  <%
  #setLanguageLevel 3;

String name = getCgiVariable("name");
String units = getCgiVariable("units");
String signature = getCgiVariable("signature");
String ticketId = getCgiVariable("ticketId");
Bool printForm = true;

if (getCgiVariable("ok") != "") // Got posted
{
  if (name == "" || units == "" || signature == "") // One of the fields are empty
  {
    print("<em>You must fill out all fields!</em>");
  }
  else if (signature.beginsWith("data:image/png;base64,") == false)
  {
    print("<em>Signature format invalid</em>");
  }
  else
  {
    signature = signature.after("data:image/png;base64,");
    Ticket myTicket;
    myTicket.setValue("title", "Order");
    myTicket.setValue("category", "1");
    myTicket.setValue("priority", "1");
    Integer ticketId = myTicket.save();

    Attachment attachment;
    attachment.setValue("contentType", "image/png");
    attachment.save(); // Must save first to get ID
    attachment.saveBase64(signature);

    Message myMessage;
    myMessage.setValue("ticketId", ticketId.toString());
    myMessage.setValue("body", "Name: " + name + "\r\nUnits: " + units + "\r\n");
    myMessage.save();

    Vector attachmentIds;
    attachmentIds.pushBack(attachment.getValue("id"));
    myMessage.setAttachments(attachmentIds);
    print("<i>Ticket saved with id " + ticketId.toString() + "</i><p>");
    printForm = false;
  }
}

if (printForm)
{
  
  %>
    <form method="post" action='<%print(getParserVariable("AuthProgram"));%>&action=safeParse&includeId=sig_form&key=TLJM31BqZA1iiStQ'>
    <div class="mb-3">
    <label for="name" class='form-label'>Name:</label><input type='text' class='form-control' name='name' value='<% print(name); %>'></div>

      <div class="mb-3">
    <label for="units" class='form-label'>Ordered units:</label><input class='form-control' type='text' name='units' value='<% print(units); %>'></div>

        <div class="mb-3">
    <label for="signature" class='form-label'>Signature:
          <canvas
          onmousedown='canvas_onmousedown(event, false);'
          onmousemove='canvas_onmousemove(event, false);'
          onmouseup='canvas_onmouseup(event, false);'

          ontouchstart='canvas_onmousedown(event, true);'
          ontouchmove='canvas_onmousemove(event, true);'
          ontouchend='canvas_onmouseup(event, true);'


          id='canvas' class='form-control'  style='border: black solid 1px;width:100%'>Sorry, your browser does not support canvas</canvas>
            <input id='signature' type='hidden' name='signature'></div>

            
            <input  type='submit' class="btn btn-primary" onclick='copyCanvasToHidden();' name='ok' value='Ok'>
            <input type='button' class='btn btn-light' onclick='javascript:window.history.back();' name='cancel' value='Cancel'>
            <input  type='button' class="btn" onclick='clearCanvas();' value='Clear signature'>
           
            </form>
            <%
}
%>
  %EJSCRIPT_END%
  </div>
  </body>
  </html>
  </html>
```

<!-- Referenced image -->
[img1]: media/image011.png
