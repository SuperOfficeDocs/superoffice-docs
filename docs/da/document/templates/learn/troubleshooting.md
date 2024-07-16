---
uid: help-da-document-template-troubleshooting
title: Fejlfinding
description: Sådan opdager og løser du problemer, når du bruger SuperOffice skabelonvariabler i Microsoft 365 dokumenter.
keywords: dokumentskabelon, skabelonvariabel, dokument
author: Bergfrid Dias
date: 07.16.2024
topic: howto
language: da
---

# Fejlfinding

## Brug af skabelonvariabler i Microsoft 365 dokumenter

Når vi opretter et dokument i SuperOffice, udtrækker vi alt indhold af dokumentet som almindelig tekst, som vores skabelon erstatningssystem bruger til at identificere og erstatte skabelonvariabler.

Vi søger efter en starttag ( `{` eller `<`) og derefter en sluttag (`}` eller `>`). Teksten mellem taggene kontrolleres derefter for at se, om det er en skabelonvariabel. For eksempel {**atit**} vil blive genkendt som skabelonvariablen **atit,** mens **{thisisnotatag}** ikke genkendes som et gyldigt tag og vil ikke blive erstattet.

Hvis en skabelonvariabel genkendes, vil den blive erstattet med sin respektive værdi, selv når den er tom. Hvis en skabelonvariabel stadig er synlig i det færdige oprettede dokument, betyder det, at vores system ikke har genkendt det som en gyldig skabelonvariabel.

For rene tekstfiler har vi sjældent uforklarlige fejl med skabelonvariabler, da hvad du ser, er hvad du får.

For nye Microsoft-formater er dette dog ikke tilfældet. Filer af typen docx, pptx, xlsx er faktisk .zip-filer med flere xml-filer indeni. Ud over den faktiske tekst i dokumentet indeholder disse .xml-filer en masse andre oplysninger. Nogle gange forstyrrer xml-tags vores skabelonvariabler og gør dem ugenkendelige for vores erstatningsmotor.

### Eksempel

En ny PowerPoint-fil (.pptx), som indeholder en tekstboks med teksten `{onam}`.

Sådan ser det ud i PowerPoint:

![SuperOffice skabelonvariabler i Microsoft PowerPoint -screenshot][img1]

Dette er indholdet af xml-filen til slide 1: (Bemærk, at `{onam}` skal genkendes af os)

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

Men af en eller anden grund kan xml omkring vores skabelonvariabler ende med at se sådan ud:

```xml
{</a:t><a:rPr lang="en-US" dirty="0" smtClean="0"/><a:t>onam</a:t></a:r><a:r><a:rPr lang="en-US" smtClean="0"/><a:t>}
```

Som du kan se, er start "{" og slut "}" taggene placeret langt fra skabelonvariabelidentifikatoren "onam", så vores system vil ikke genkende dette som en gyldig skabelonvariabel. Slutresultatet er, at dokumentet efter oprettelse stadig vil vise teksten {onam}.

## Hvad kan jeg gøre, når dette sker?

Det første, du skal prøve, er at fjerne skabelonvariablerne fra dokumentet og indtaste dem manuelt igen (ingen kopi/indsæt, da dette kan indeholde formatering eller andet skjult materiale).

* For PowerPoint: Tekstboksene, der indeholder skabelonvariablerne, skal ellers være tomme (billeder, anden tekst og lignende skal tilføjes i egne bokse).

* Det samme gælder for Excel: Cellerne, der indeholder skabelonvariabler, skal ellers være tomme.

* For Word-dokumenter: Tænd for Vis/Skjul skjulte tegn for at se, om Word har placeret noget inde i skabelonvariablen:

![Tænd for Vis/Skjul skjulte tegn -screenshot][img2]

* Er skabelonvariablen stavet korrekt, og er den faktisk understøttet? Se [listen over alle vores understøttede skabelonvariabler][1].

Bemærk, at både Web- og Win-versioner bruger den samme motor til skabelonudskiftning, så resultatet skal være det samme, uanset hvor du opretter dokumentet.

## Det virker stadig ikke, kan det være en fejl?

Det er ekstremt sjældent, at en skabelonvariabel skulle virke i dokumenter af en type, men mislykkes i andre typer. Det er også sjældent, at et dokument indeholder nogle skabelonvariabler, der fungerer, og nogle der ikke gør.

Hvis dette sker, er det sandsynligvis et andet tilfælde af genereret xml, der forstyrrer taggene.

* For at verificere filer af typen .pptx, .docx eller .xlsx, kan du simpelthen omdøbe filtypen til .zip (sørg for at tage en sikkerhedskopi af filen først).

* Efter udpakning kan du åbne den relevante xml-fil for at verificere. Brug Notepad eller lignende, da du vil have, at hele filen vises i sin helhed uden nogen parsning af xml-tags.

* Søg efter den pågældende skabelonvariabel og se, om den har sine start- og slut tags intakte.

* Hvis du stadig kan se den ikke-fungerende skabelonvariabel med sine tags intakte, kan det være en fejl på vores side.

## Interne strukturer

Sådan ser en PowerPoint .pptx ud efter udpakning (den slide1.xml er den faktiske slide 1):

![PowerPoint -screenshot][img4]

Word .docx (document.xml er det faktiske dokument, når det vises for brugeren):

![Word -screenshot][img5]

Excel .xlsx (sheet1.xml er det faktiske ark 1):

![Excel -screenshot][img6]

<!-- Referenced links -->
[1]: ../variables/index.md

<!-- Referenced images -->
[img1]: ../../../../media/loc/en/document/troubleshoot-tempvar.png
[img2]: ../../../../media/loc/en/document/troubleshoot-tempvar-1.png
[img4]: ../../../../media/loc/en/document/troubleshoot-tempvar-2.png
[img5]: ../../../../media/loc/en/document/troubleshoot-tempvar-3.png
[img6]: ../../../../media/loc/en/document/troubleshoot-tempvar-4.png
