---
uid: help-en-document-template-troubleshooting
title: Troubleshooting
description: How to spot and fix problems when using SuperOffice template variables in Microsoft 365 documents.
keywords: document template, template variable, document
author: Bergfrid Dias
date: 07.11.2024
topic: howto
language: en
---

# Troubleshooting

## Use of template variables in Microsoft 365 documents

When we create a document in SuperOffice we extract all the content of the document as a plain text which our template substitution system uses to identify and replace template variables.

We search for a start tag ( `{` or `<`) then for an end tag (`}` or `>`). The text in between the tags is then checked to see if it is a template variable. For example {**atit**} will be recognized as the template variable **atit,** while **{thisisnotatag}** is not recognized as a valid tag, and will not be replaced.

If a template variable is recognized, it will be replaced with its respective value, even when blank. If a template variable is still visible in the finished created document, it means that our system has not recognized it as a valid template variable.

For pure text files we rarely have unexplained errors with the template variables as what you see is what you get.

For new Microsoft formats, however, this is not the case. Files of type docx, pptx, xlsx are actually .zip files with several xml files inside. In addition to the actual text in the document, these .xml files contain a lot of other information. Sometimes the xml-tags interfere with our template variables making them unrecognizable by our substitution engine.

### Example

A new PowerPoint file (.pptx) which contains one text box with the text `{onam}`.

This is how it looks in PowerPoint:

![SuperOffice template variables in Microsoft PowerPoint -screenshot][img1]

This is the content of the xml file for slide 1: (Observe that `{onam}` should be recognized by us)

```xml
<p:sld xmlns:a="http://schemas.openxmlformats.org/drawingml/2006/main"
       xmlns:r="http://schemas.openxmlformats.org/officeDocument/2006/relationships"
       xmlns:p="http://schemas.openxmlformats.org/presentationml/2006/main">
<p:cSld>
  <p:spTree>
    <p:nvGrpSpPr>
      <p:cNvPr id="1" name=""/>
      <p:cNvGrpSpPr/>
      <p:nvPr/>
    </p:nvGrpSpPr>
    <p:grpSpPr>
      <a:xfrm>
        <a:off x="0" y="0"/>
        <a:ext cx="0" cy="0"/>
        <a:chOff x="0" y="0"/>
        <a:chExt cx="0" cy="0"/>
      </a:xfrm>
    </p:grpSpPr>
    <p:sp>
      <p:nvSpPr>
        <p:cNvPr id="3" name="Subtitle 2"/>
        <p:cNvSpPr><a:spLocks noGrp="1"/>
      </p:cNvSpPr>
      <p:nvPr>
        <p:ph type="subTitle" idx="1"/>
      </p:nvPr>
      </p:nvSpPr>
      <p:spPr/>
      <p:txBody>
        <a:bodyPr/>
        <a:lstStyle/>
        <a:p>
          <a:r>
            <a:rPr lang="nb-NO" smtClean="0"/>
            <a:t>{onam}</a:t>
          </a:r>
          <a:endParaRPr lang="nb-NO"/>
        </a:p>
      </p:txBody>
    </p:sp>
  </p:spTree>
  <p:extLst>
    <p:ext uri="{BB962C8B-B14F-4D97-AF65-F5344CB8AC3E}">
      <p14:creationId xmlns:p14="http://schemas.microsoft.com/office/powerpoint/2010/main" val="3005012355"/>
    </p:ext>
  </p:extLst>
</p:cSld>
<p:clrMapOvr>
  <a:masterClrMapping/>
</p:clrMapOvr>
</p:sld>
```

But for some reason the xml around our template variables can end up looking something like this:

```xml
{</a:t><a:rPr lang="en-US" dirty="0" smtClean="0"/><a:t>onam</a:t></a:r><a:r><a:rPr lang="en-US" smtClean="0"/><a:t>}
```

As you can see, the start "**{**" and the end "**}**" tags are placed far apart from the template variable identifier "**onam**" so our system will not recognize this as a valid template variable. The end result is that the document after creation will still show the text **{onam}**.

## What can I do when this happens?

The first thing to try is to remove the template variables from the document and re-enter them manually (no copy/paste as this can contain formatting or other hidden stuff).

* For PowerPoint: The text boxes containing the template variables should be otherwise empty (pictures, other text and similar should be added in own boxes).

* Same goes for Excel: The cells containing template variables should otherwise be empty.

* For Word documents: Turn ON **Show/Hide hidden characters** too see if Word has put something inside the template variable:

![Turn hon Show/Hide hidden characters -screenshot][img2]

* Is the template variable spelled correctly and is it actually supported? See the [list of all of our supported template variables][1].

Note that both Web and Win versions use the same engine for template substitution so the result should be the same no matter where you create the document.

## It still doesn't work, could this be a bug?

It is extremely rare that a template variable should work in documents of one type but fail in other types. It is also rare that a document contains some template variables that work and some that don't.

If this happens, it is most probably another case of generated xml that messes up the tags.

* To verify the files of type .**pptx**, .**docx** or .**xlsx**, you can simply rename the extension of the file to .**zip** (make sure to take a backup of the file first).

* After unzipping you can open the relevant xml file to verify. Use Notepad or similar as you do want the whole file to be shown in its entirety without any parsing of the xml tags.

* Search for the template variable in question and observe if it has its start and end tags intact.

* If you can still see the non-working template variable with its tags intact, it could be a bug in our side.

## Internal structures

This is how a PowerPoint **.pptx** looks after unzipping (the **slide1.xml** is the actual slide 1):

![PowerPoint -screenshot][img4]

Word **.docx** (**document.xml** is the actual document when shown to the user):

![Word -screenshot][img5]

Excel **.xlsx** (**sheet1.xml** is the actual Sheet 1):

![Excel -screenshot][img6]

<!-- Referenced links -->
[1]: ../variables/index.md

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/document/troubleshoot-tempvar.png
[img2]: ../../../../media/loc/en/document/troubleshoot-tempvar-1.png
[img4]: ../../../../media/loc/en/document/troubleshoot-tempvar-2.png
[img5]: ../../../../media/loc/en/document/troubleshoot-tempvar-3.png
[img6]: ../../../../media/loc/en/document/troubleshoot-tempvar-4.png
