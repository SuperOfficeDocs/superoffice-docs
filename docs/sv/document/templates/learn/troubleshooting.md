---
uid: help-sv-document-template-troubleshooting
title: Felsökning
description: Hur du upptäcker och åtgärdar problem när du använder SuperOffice mallvariabler i Microsoft 365-dokument.
keywords: dokumentmall, mallvariabel, dokument
author: Bergfrid Dias
date: 07.16.2024
content_type: howto
language: sv
---

# Felsökning

## Användning av mallvariabler i Microsoft 365-dokument

När vi skapar ett dokument i SuperOffice extraherar vi allt innehåll i dokumentet som vanlig text som vårt mallutbytesystem använder för att identifiera och ersätta mallvariabler.

Vi söker efter en starttagg ( `{` eller `<`) och sedan efter en sluttagg (`}` eller `>`). Texten mellan taggarna kontrolleras sedan för att se om det är en mallvariabel. Till exempel kommer {**atit**} att erkännas som mallvariabeln **atit**, medan **{thisisnotatag}** inte erkänns som en giltig tagg och kommer inte att ersättas.

Om en mallvariabel känns igen kommer den att ersättas med sitt respektive värde, även när den är tom. Om en mallvariabel fortfarande är synlig i det färdiga skapade dokumentet betyder det att vårt system inte har känt igen det som en giltig mallvariabel.

För rena textfiler har vi sällan oförklarliga fel med mallvariabler eftersom vad du ser är vad du får.

För nya Microsoft-format är detta dock inte fallet. Filer av typen docx, pptx, xlsx är faktiskt .zip-filer med flera xml-filer inuti. Förutom den faktiska texten i dokumentet innehåller dessa .xml-filer mycket annan information. Ibland stör xml-taggarna våra mallvariabler och gör dem oigenkännliga för vår ersättningsmotor.

### Exempel

En ny PowerPoint-fil (.pptx) som innehåller en textruta med texten `{onam}`.

Så här ser det ut i PowerPoint:

![SuperOffice mallvariabler i Microsoft PowerPoint -screenshot][img1]

Detta är innehållet i xml-filen för bild 1: (Observera att `{onam}` bör kännas igen av oss)

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

Men av någon anledning kan xml runt våra mallvariabler sluta se ut så här:

```xml
{</a:t><a:rPr lang="en-US" dirty="0" smtClean="0"/><a:t>onam</a:t></a:r><a:r><a:rPr lang="en-US" smtClean="0"/><a:t>}
```

Som du kan se är start- "{" och slut- "}" taggarna placerade långt från mallvariabelidentifieraren "onam", så vårt system kommer inte att känna igen detta som en giltig mallvariabel. Slutresultatet är att dokumentet efter skapandet fortfarande visar texten {onam}.

## Vad kan jag göra när detta händer?

Det första du ska försöka är att ta bort mallvariablerna från dokumentet och ange dem manuellt igen (ingen kopiering/klistring eftersom detta kan innehålla formatering eller andra dolda saker).

* För PowerPoint: Textlådorna som innehåller mallvariablerna ska annars vara tomma (bilder, annan text och liknande ska läggas till i egna lådor).

* Samma gäller för Excel: Cellerna som innehåller mallvariablerna ska annars vara tomma.

* För Word-dokument: Slå på Visa/dölj dolda tecken för att se om Word har placerat något inuti mallvariabeln:

![Slå på Visa/dölj dolda tecken -screenshot][img2]

* Är mallvariabeln stavad korrekt och stöds den verkligen? Se [listan över alla våra stödda mallvariabler][1].

Observera att både webb- och Win-versionerna använder samma motor för mallutbyte, så resultatet ska vara detsamma oavsett var du skapar dokumentet.

## Det fungerar fortfarande inte, kan det vara ett fel?

Det är extremt sällsynt att en mallvariabel skulle fungera i dokument av en typ men misslyckas i andra typer. Det är också sällsynt att ett dokument innehåller några mallvariabler som fungerar och några som inte gör det.

Om detta händer är det högst troligt ett annat fall av genererad xml som stör taggarna.

* För att verifiera filer av typen .pptx, .docx eller .xlsx, kan du helt enkelt byta namn på filens tillägg till .zip (se till att ta en säkerhetskopia av filen först).

* Efter att ha packat upp kan du öppna den relevanta xml-filen för att verifiera. Använd Anteckningar eller liknande eftersom du vill att hela filen ska visas i sin helhet utan någon parsning av xml-taggarna.

* Sök efter den aktuella mallvariabeln och observera om dess start- och sluttaggar är intakta.

* Om du fortfarande kan se den icke-fungerande mallvariabeln med dess taggar intakta, kan det vara ett fel på vår sida.

## Interna strukturer

Så här ser en PowerPoint .pptx ut efter uppackning (den slide1.xml är den faktiska bilden 1):

![PowerPoint -screenshot][img4]

Word .docx (document.xml är det faktiska dokumentet när det visas för användaren):

![Word -screenshot][img5]

Excel .xlsx (sheet1.xml är det faktiska blad 1):

![Excel -screenshot][img6]

<!-- Referenced links -->
[1]: ../variables/index.md

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/document/troubleshoot-tempvar.png
[img2]: ../../../../media/loc/en/document/troubleshoot-tempvar-1.png
[img4]: ../../../../media/loc/en/document/troubleshoot-tempvar-2.png
[img5]: ../../../../media/loc/en/document/troubleshoot-tempvar-3.png
[img6]: ../../../../media/loc/en/document/troubleshoot-tempvar-4.png
