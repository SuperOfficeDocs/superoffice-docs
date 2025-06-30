---
uid: help-nl-document-template-troubleshooting
title: Probleemoplossing
description: Hoe u problemen herkent en oplost bij het gebruik van SuperOffice-sjabloonvariabelen in Microsoft 365-documenten.
keywords: documentsjabloon, sjabloonvariabele, document
author: Bergfrid Dias
date: 07.16.2024
content_type: howto
language: nl
---

# Probleemoplossing

## Gebruik van sjabloonvariabelen in Microsoft 365-documenten

Wanneer we een document in SuperOffice maken, halen we alle inhoud van het document als platte tekst op, die ons sjabloonvervangingssysteem gebruikt om sjabloonvariabelen te identificeren en te vervangen.

We zoeken naar een starttag ( `{` of `<`) en vervolgens naar een eindtag (`}` of `>`). De tekst tussen de tags wordt vervolgens gecontroleerd om te zien of het een sjabloonvariabele is. Bijvoorbeeld {**atit**} zal worden herkend als de sjabloonvariabele **atit**, terwijl **{thisisnotatag}** niet wordt herkend als een geldige tag en niet zal worden vervangen.

Als een sjabloonvariabele wordt herkend, wordt deze vervangen door de respectieve waarde, zelfs als deze leeg is. Als een sjabloonvariabele nog steeds zichtbaar is in het voltooide gemaakte document, betekent dit dat ons systeem deze niet als een geldige sjabloonvariabele heeft herkend.

Voor pure tekstbestanden hebben we zelden onverklaarbare fouten met de sjabloonvariabelen, omdat wat je ziet is wat je krijgt.

Voor nieuwe Microsoft-formaten is dit echter niet het geval. Bestanden van het type docx, pptx, xlsx zijn eigenlijk .zip-bestanden met daarin meerdere xml-bestanden. Naast de eigenlijke tekst in het document bevatten deze .xml-bestanden veel andere informatie. Soms interfereren de xml-tags met onze sjabloonvariabelen, waardoor ze onherkenbaar worden voor onze vervangingsengine.

### Voorbeeld

Een nieuw PowerPoint-bestand (.pptx) met één tekstvak met de tekst `{onam}`.

Zo ziet het eruit in PowerPoint:

![SuperOffice sjabloonvariabelen in Microsoft PowerPoint -screenshot][img1]

Dit is de inhoud van het xml-bestand voor dia 1: (Let op dat `{onam}` door ons herkend zou moeten worden)

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

Maar om een of andere reden kan de xml rond onze sjabloonvariabelen er uiteindelijk zo uitzien:

```xml
{</a:t><a:rPr lang="en-US" dirty="0" smtClean="0"/><a:t>onam</a:t></a:r><a:r><a:rPr lang="en-US" smtClean="0"/><a:t>}
```

Zoals je kunt zien, zijn de start- "{" en eind- "}" tags ver van de sjabloonvariabele-identificatie "onam" geplaatst, dus ons systeem zal dit niet als een geldige sjabloonvariabele herkennen. Het eindresultaat is dat het document na het maken nog steeds de tekst {onam} laat zien.

## Wat kan ik doen als dit gebeurt?

Het eerste wat je moet proberen, is de sjabloonvariabelen uit het document verwijderen en handmatig opnieuw invoeren (geen kopiëren/plakken, omdat dit opmaak of andere verborgen zaken kan bevatten).

* Voor PowerPoint: De tekstvakken die de sjabloonvariabelen bevatten, moeten anders leeg zijn (afbeeldingen, andere tekst en dergelijke moeten in eigen vakken worden toegevoegd).

* Hetzelfde geldt voor Excel: De cellen die sjabloonvariabelen bevatten, moeten anders leeg zijn.

* Voor Word-documenten: Zet Verborgen tekens weergeven/verbergen aan om te zien of Word iets in de sjabloonvariabele heeft geplaatst:

![Verborgen tekens weergeven/verbergen inschakelen -screenshot][img2]

* Is de sjabloonvariabele correct gespeld en wordt deze daadwerkelijk ondersteund? Zie de [lijst van al onze ondersteunde sjabloonvariabelen][1].

Merk op dat zowel de Web- als Win-versies dezelfde motor voor sjabloonvervanging gebruiken, dus het resultaat zou hetzelfde moeten zijn, ongeacht waar je het document maakt.

## Het werkt nog steeds niet, kan dit een bug zijn?

Het is uiterst zeldzaam dat een sjabloonvariabele in documenten van het ene type werkt, maar in andere typen faalt. Het is ook zeldzaam dat een document enkele sjabloonvariabelen bevat die werken en enkele die niet werken.

Als dit gebeurt, is het hoogstwaarschijnlijk een ander geval van gegenereerde xml die de tags verstoort.

* Om bestanden van het type .pptx, .docx of .xlsx te verifiëren, kun je eenvoudig de extensie van het bestand wijzigen in .zip (zorg ervoor dat je eerst een back-up van het bestand maakt).

* Na het uitpakken kun je het relevante xml-bestand openen om te verifiëren. Gebruik Kladblok of iets dergelijks, omdat je wilt dat het hele bestand in zijn geheel wordt weergegeven zonder enige parsing van de xml-tags.

* Zoek naar de betreffende sjabloonvariabele en observeer of de start- en eindtags intact zijn.

* Als je de niet-werkende sjabloonvariabele met zijn intacte tags nog steeds kunt zien, kan het een bug aan onze kant zijn.

## Interne structuren

Zo ziet een PowerPoint .pptx eruit na het uitpakken (de slide1.xml is de eigenlijke dia 1):

![PowerPoint -screenshot][img4]

Word .docx (document.xml is het eigenlijke document wanneer het aan de gebruiker wordt getoond):

![Word -screenshot][img5]

Excel .xlsx (sheet1.xml is het eigenlijke blad 1):

![Excel -screenshot][img6]

<!-- Referenced links -->
[1]: ../variables/index.md

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/document/troubleshoot-tempvar.png
[img2]: ../../../../media/loc/en/document/troubleshoot-tempvar-1.png
[img4]: ../../../../media/loc/en/document/troubleshoot-tempvar-2.png
[img5]: ../../../../media/loc/en/document/troubleshoot-tempvar-3.png
[img6]: ../../../../media/loc/en/document/troubleshoot-tempvar-4.png
