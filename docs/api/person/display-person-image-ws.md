---
# Mandatory fields.
title: display_person_image # (Required) Very important for SEO.
description: Display person image # (Required) Important for SEO.
author: {github-id}             # Your GitHub alias.
so.date: 06.24.2016
keywords: services
so.topic: howto            # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
# so.envir:                     # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# Display person image

Displaying a person's picture involves using the `ImageUtility` to load the image via the web service, and then rendering the output in some way.

Here is an example of a web page that renders a person's image to PNG.

```csharp
int personId = 123;
int minWidth = 100;
int minHeight = 100;
int maxWidth = 1000;
int maxHeight = 1000;

ImageSize imageSize = new ImageSize( minWidth, minHeight, maxWidth, maxHeight);
FallbackStrategy fallbackStrategy = FallbackStrategy.SrNoPhoto;
bool border = true;
Color borderColor = Color.CadetBlue;

Image image = ImageUtility.GetPersonImage(_personId, imageSize, fallbackStrategy, border, borderColor);
if (image != null)
{
  Response.ContentType = "image/png";
  Encoder Enc = Encoder.RenderMethod;
  EncoderParameters EncParms = new EncoderParameters(1);
  EncoderParameter EncParm = new EncoderParameter(Enc, (byte)EncoderValue.RenderNonProgressive);
  EncParms.Param[0] = EncParm;

  MemoryStream ms = new MemoryStream();
  _image.Save(ms, ImageUtility.GetEncoderInfo("image/png"), EncParms);
  int bufferSize = SuperOffice.Configuration.ConfigFile.Documents.BufferSize * 1024;
  byte[] buffer = new byte[bufferSize];
  ms.Position = 0;
  int readBytes = 0;
  do
  {
    readBytes = ms.Read(buffer, 0, bufferSize);
    Response.OutputStream.Write(buffer, 0, readBytes);
    Response.OutputStream.Flush();
  }
  while (readBytes == bufferSize);
}
```
