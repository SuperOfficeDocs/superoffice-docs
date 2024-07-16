---
uid: help-no-document-template-troubleshooting
title: Feilsøking
description: Hvordan finne og fikse problemer når du bruker SuperOffice malvariabler i Microsoft 365-dokumenter.
keywords: dokumentmal, malvariabel, dokument
author: Bergfrid Dias
date: 07.16.2024
topic: howto
language: no
---

# Feilsøking

## Bruk av malvariabler i Microsoft 365-dokumenter

Når vi oppretter et dokument i SuperOffice, trekker vi ut alt innholdet i dokumentet som ren tekst, som vårt malutskiftingssystem bruker for å identifisere og erstatte malvariabler.

Vi søker etter en starttagg ( `{` eller `<`) og deretter en slutttagg (`}` eller `>`). Teksten mellom taggene sjekkes deretter for å se om det er en malvariabel. For eksempel vil {**atit**} bli gjenkjent som malvariabelen **atit,** mens **{thisisnotatag}** ikke gjenkjennes som en gyldig tagg og vil ikke bli erstattet.

Hvis en malvariabel gjenkjennes, vil den bli erstattet med sin respektive verdi, selv når den er tom. Hvis en malvariabel fortsatt er synlig i det ferdige opprettede dokumentet, betyr det at systemet vårt ikke har gjenkjent det som en gyldig malvariabel.

For rene tekstfiler har vi sjelden uforklarlige feil med malvariabler, da det du ser, er det du får.

For nye Microsoft-formater er dette imidlertid ikke tilfelle. Filer av typen docx, pptx, xlsx er faktisk .zip-filer med flere xml-filer inni. I tillegg til den faktiske teksten i dokumentet, inneholder disse .xml-filene mye annen informasjon. Noen ganger forstyrrer xml-taggene malvariablene våre, noe som gjør dem ugjenkjennelige for erstatningsmotoren vår.

### Eksempel

En ny PowerPoint-fil (.pptx) som inneholder en tekstboks med teksten `{onam}`.

Slik ser det ut i PowerPoint:

![SuperOffice malvariabler i Microsoft PowerPoint -screenshot][img1]

Dette er innholdet i xml-filen for slide 1: (Merk at `{onam}` skal gjenkjennes av oss)

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

Men av en eller annen grunn kan xml rundt våre malvariabler ende opp med å se slik ut:

```xml
{</a:t><a:rPr lang="en-US" dirty="0" smtClean="0"/><a:t>onam</a:t></a:r><a:r><a:rPr lang="en-US" smtClean="0"/><a:t>}
```

Som du kan se, er start- "{" og slutt- "}" taggene plassert langt fra malvariabelidentifikatoren "onam", så systemet vårt vil ikke gjenkjenne dette som en gyldig malvariabel. Sluttresultatet er at dokumentet etter opprettelse fortsatt vil vise teksten {onam}.

## Hva kan jeg gjøre når dette skjer?

Det første du bør prøve, er å fjerne malvariablene fra dokumentet og skrive dem inn manuelt igjen (ikke kopier/lim inn, da dette kan inneholde formatering eller andre skjulte elementer).

* For PowerPoint: Tekstboksene som inneholder malvariablene, skal ellers være tomme (bilder, annen tekst og lignende skal legges til i egne bokser).

* Det samme gjelder for Excel: Cellene som inneholder malvariabler, skal ellers være tomme.

* For Word-dokumenter: Slå på Vis/Skjul skjulte tegn for å se om Word har plassert noe inne i malvariabelen:

![Slå på Vis/Skjul skjulte tegn -screenshot][img2]

* Er malvariabelen stavet riktig, og er den faktisk støttet? Se [listen over alle våre støttede malvariabler][1].

Merk at både Web- og Win-versjonene bruker samme motor for malutskifting, så resultatet skal være det samme uansett hvor du oppretter dokumentet.

## Det fungerer fortsatt ikke, kan dette være en feil?

Det er ekstremt sjeldent at en malvariabel skal fungere i dokumenter av én type, men mislykkes i andre typer. Det er også sjeldent at et dokument inneholder noen malvariabler som fungerer, og noen som ikke gjør det.

Hvis dette skjer, er det mest sannsynlig et annet tilfelle av generert xml som roter til taggene.

For å verifisere filer av typen .pptx, .docx eller .xlsx, kan du enkelt endre filtypen til .zip (pass på å ta en sikkerhetskopi av filen først).

Etter utpakking kan du åpne den relevante xml-filen for å verifisere. Bruk Notisblokk eller lignende, da du vil at hele filen skal vises i sin helhet uten parsing av xml-tagene.

Søk etter den aktuelle malvariabelen og observer om den har sine start- og slutt tagger intakte.

Hvis du fortsatt kan se den ikke-fungerende malvariabelen med sine tagger intakte, kan det være en feil på vår side.

## Interne strukturer

Slik ser en PowerPoint .pptx ut etter utpakking (den slide1.xml er den faktiske lysbilde 1):

![PowerPoint -screenshot][img4]

Word .docx (document.xml er det faktiske dokumentet når det vises for brukeren):

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
