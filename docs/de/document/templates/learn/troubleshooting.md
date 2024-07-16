---
uid: help-de-document-template-troubleshooting
title: Fehlerbehebung
description: So erkennen und beheben Sie Probleme bei der Verwendung von SuperOffice-Vorlagenvariablen in Microsoft 365-Dokumenten.
keywords: Dokumentvorlage, Vorlagenvariable, Dokument
author: Bergfrid Dias
date: 07.16.2024
topic: howto
language: de
---

# Fehlerbehebung

## Verwendung von Vorlagenvariablen in Microsoft 365-Dokumenten

Wenn wir ein Dokument in SuperOffice erstellen, extrahieren wir den gesamten Inhalt des Dokuments als Klartext, den unser Vorlagenersatzsystem verwendet, um Vorlagenvariablen zu identifizieren und zu ersetzen.

Wir suchen nach einem Start-Tag ( `{` oder `<`) und dann nach einem End-Tag (`}` oder `>`). Der Text zwischen den Tags wird dann überprüft, ob es sich um eine Vorlagenvariable handelt. Zum Beispiel wird {**atit**} als Vorlagenvariable **atit** erkannt, während **{thisisnotatag}** nicht als gültiges Tag erkannt wird und nicht ersetzt wird.

Wenn eine Vorlagenvariable erkannt wird, wird sie durch ihren jeweiligen Wert ersetzt, auch wenn sie leer ist. Wenn eine Vorlagenvariable im fertig erstellten Dokument noch sichtbar ist, bedeutet dies, dass unser System sie nicht als gültige Vorlagenvariable erkannt hat.

Bei reinen Textdateien haben wir selten unerklärliche Fehler mit den Vorlagenvariablen, da das, was man sieht, auch das ist, was man bekommt.

Bei neuen Microsoft-Formaten ist dies jedoch nicht der Fall. Dateien vom Typ docx, pptx, xlsx sind tatsächlich .zip-Dateien mit mehreren xml-Dateien darin. Zusätzlich zum eigentlichen Text im Dokument enthalten diese .xml-Dateien viele andere Informationen. Manchmal stören die xml-Tags unsere Vorlagenvariablen und machen sie für unsere Ersatzmaschine unkenntlich.

### Beispiel

Eine neue PowerPoint-Datei (.pptx), die ein Textfeld mit dem Text `{onam}` enthält.

So sieht es in PowerPoint aus:

![SuperOffice Vorlagenvariablen in Microsoft PowerPoint -screenshot][img1]

Dies ist der Inhalt der xml-Datei für Folie 1: (Beachten Sie, dass `{onam}` von uns erkannt werden sollte)

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

Aber aus irgendeinem Grund kann das XML um unsere Vorlagenvariablen am Ende so aussehen:

```xml
{</a:t><a:rPr lang="en-US" dirty="0" smtClean="0"/><a:t>onam</a:t></a:r><a:r><a:rPr lang="en-US" smtClean="0"/><a:t>}
```

Wie Sie sehen können, sind die Start- "{" und End- "}" Tags weit entfernt vom Vorlagenvariablen-Identifier "onam" platziert, so dass unser System dies nicht als gültige Vorlagenvariable erkennt. Das Endergebnis ist, dass das Dokument nach der Erstellung immer noch den Text {onam} anzeigt.

## Was kann ich tun, wenn das passiert?

Das Erste, was Sie versuchen sollten, ist, die Vorlagenvariablen aus dem Dokument zu entfernen und sie manuell erneut einzugeben (kein Kopieren/Einfügen, da dies Formatierungen oder andere versteckte Elemente enthalten kann).

* Für PowerPoint: Die Textfelder, die die Vorlagenvariablen enthalten, sollten ansonsten leer sein (Bilder, anderer Text und Ähnliches sollten in eigenen Boxen hinzugefügt werden).

* Das Gleiche gilt für Excel: Die Zellen, die Vorlagenvariablen enthalten, sollten ansonsten leer sein.

* Für Word-Dokumente: Schalten Sie Verborgene Zeichen ein-/ausblenden ein, um zu sehen, ob Word etwas in die Vorlagenvariable eingefügt hat:

![Verborgene Zeichen ein-/ausblenden einschalten -screenshot][img2]

* Ist die Vorlagenvariable korrekt geschrieben und wird sie tatsächlich unterstützt? Siehe die [Liste aller unserer unterstützten Vorlagenvariablen][1].

Beachten Sie, dass sowohl die Web- als auch die Win-Versionen denselben Motor für den Vorlagenersatz verwenden, so dass das Ergebnis dasselbe sein sollte, unabhängig davon, wo Sie das Dokument erstellen.

## Es funktioniert immer noch nicht, könnte das ein Fehler sein?

Es ist äußerst selten, dass eine Vorlagenvariable in Dokumenten eines Typs funktionieren, aber in anderen Typen fehlschlagen sollte. Es ist auch selten, dass ein Dokument einige Vorlagenvariablen enthält, die funktionieren, und einige, die nicht funktionieren.

Wenn dies passiert, handelt es sich höchstwahrscheinlich um einen weiteren Fall von generiertem XML, das die Tags durcheinander bringt.

* Um Dateien vom Typ .pptx, .docx oder .xlsx zu überprüfen, können Sie einfach die Erweiterung der Datei in .zip umbenennen (stellen Sie sicher, dass Sie zuerst eine Sicherungskopie der Datei erstellen).

* Nach dem Entpacken können Sie die relevante XML-Datei öffnen, um sie zu überprüfen. Verwenden Sie Notepad oder ähnliches, da Sie möchten, dass die gesamte Datei in ihrer Gesamtheit ohne Parsen der XML-Tags angezeigt wird.

* Suchen Sie nach der betreffenden Vorlagenvariablen und beobachten Sie, ob ihre Start- und End-Tags intakt sind.

* Wenn Sie die nicht funktionierende Vorlagenvariable mit ihren intakten Tags noch sehen können, könnte es ein Fehler auf unserer Seite sein.

## Interne Strukturen

So sieht eine PowerPoint .pptx nach dem Entpacken aus (die slide1.xml ist die eigentliche Folie 1):

![PowerPoint -screenshot][img4]

Word .docx (document.xml ist das eigentliche Dokument, wenn es dem Benutzer angezeigt wird):

![Word -screenshot][img5]

Excel .xlsx (sheet1.xml ist das eigentliche Blatt 1):

![Excel -screenshot][img6]

<!-- Referenced links -->
[1]: ../variables/index.md

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/document/troubleshoot-tempvar.png
[img2]: ../../../../media/loc/en/document/troubleshoot-tempvar-1.png
[img4]: ../../../../media/loc/en/document/troubleshoot-tempvar-2.png
[img5]: ../../../../media/loc/en/document/troubleshoot-tempvar-3.png
[img6]: ../../../../media/loc/en/document/troubleshoot-tempvar-4.png
