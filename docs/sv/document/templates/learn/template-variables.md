---
uid: help-sv-template-variables
title: Mallvariabler
description: Med mallvariabler kan du anpassa och automatisera inmatningen av kunddata
keywords: dokument, mall, variabel, mallvariabel
author: Bergfrid Dias
date: 12.10.2024
version: 10.3
content_type: concept
language: sv
redirect_from: /sv/document/learn/template-variables
---

# Mallvariabler

Mallvariabler används för att infoga data från SuperOffice i e-postmeddelanden, offerter, mötesaviseringar, dokumentmallar med mera. Du kan använda mallvariabler för att anpassa och automatisera inmatningen av kunddata (eller data från kontakter, försäljningar och annat) i ditt innehåll och skapa komplexa offerter.

## Exempel: Så anpassar du ett e-postmeddelande med hjälp av mallvariabler

I stället för följande text:

"Bästa kund! Vill du veta mer om hur vår produkt kan hjälpa ditt företag att skaffa nya kunder? Kontakta oss."

kan du skicka denna text:

"Hej Chris! Vill du veta mer om hur vår produkt kan hjälpa Bilbutiken AB att skaffa nya kunder? Vänliga hälsningar, Karin Nordman på SuperShop."

Den text du anger ser ut så här:

"Hej **{atfn}**, Vill du veta mer om hur vår produkt kan hjälpa **{name}** att skaffa nya kunder? Ring **{cont}** på **{onam}**."

## Använda mallvariabler

* Hela variabeln måste vara formaterad med samma typsnitt och teckenstorlek och du får använda endast små bokstäver. Om du har aktiverat inställningen **Tillåt stora bokstäver i mallvariabler** går det däremot bra att formatera mallvariabeln.

* Du kan blanda vanlig text och variabler i malldokumentet: Du kan till exempel lägga till mallvariabler som hämtar ett företags namn och adress, skriva en standardtext till brevets brödtext och lägga till variabeln för vår kontakt som avslutning på brevet.

* Du kan också använda så kallade fyllnadstecken i malldokumentet (se nedan).

* Datum och klockslag i mallvariablerna styrs av systemklockan på datorn.

* I dokument med filtypen .doc i Office 2003 och äldre måste du använda vinkelparenteser – &lt; &gt; – runt variablerna i stället för klammerparenteser – { } –.

### Exempel: mötesprotokoll (rubrik)

Det här är ett exempel på en rubrik i ett mötesprotokoll (dokument eller e-post).

**Mall:**

```text
{head}
Datum/Plats: {sdat}, {city}
Närvarande: {attn} ({name}), {auth} ({onam})
Frånvarande:
Mötessekreterare: {auth} ({auem})
```

**Resultat:**

```text
Sommarkampanj – planering
Daum/Plats: 2019-12-15, London
Närvarande: Sara Miller (Liberty Ltd.), Johan Jonsson (SuperShop)
Frånvarande:
Mötessekreterare: Johan Jonsson (jj@supershop.com)
```

## Smarta variabler från företagskortet

Adressvariabler från företagskortet är så kallade "smarta" mallvariabler. Detta innebär att systemet väljer adressdata i en viss ordning. Variablerna i **fet text** nedan (till exempel **addr** och **city**) är smarta mallvariabler.

När du använder adressvariabler från företagskortet väljer systemet adressdata i följande ordning:

1. Om alternativet **Använd som postadress** är aktivt för en kontakt på företaget används kontaktens adressuppgifter.
2. Om alternativet ovan inte är aktivt används företagets adressuppgifter.
3. Om företagets postadress är tom, kommer företagets gatuadress att användas.

## Variabler i offertmallar

När du använder offerter och produkter i SuperOffice behöver du skapa offertmallar. Mallarna för offertdokument, offertdetaljer och orderbekräftelser skiljer sig från vanliga dokumentmallar eftersom de använder "merge fields" vid sidan om vanliga mallvariabler.

### Exempel: Orderbekräftelse (rubrik)

Mallvariabler för offerter och orderbekräftelser kan användas i en offert.

**Mall:**

```text
Orderdatum: {sdat}
Ordernummer: {qnum}
Leveransvillkor: {qdev}
Betalningsvillkor: {qpev}
Ert ordernummer: {qpon}
Vår kontakt: {cont}
```

**Resultat:**

```text
Orderdatum: 2019-12-15
Ordernummer: 550012
Leveransvillkor: Leverans ingår
Betalningsvillkor: 15 dagar
Ert ordernummer: 70000882
Vår kontakt: Johan Jonsson
```

## Mallvariabler för service och marknadsföring

När du skapar e-postmallar för ärenden och utskick (och meddelandemallar) i Marknadsföring kan du anpassa e-postmeddelandet eller utskicket med mallvariabler. Variablerna skiljer sig något från dem som används i dokument.

## Referens

Referensen är grupperad efter område. [Gå till referens][1]

<!-- Referenced links -->
[1]: ../variables/index.md

<!-- Referenced images -->
