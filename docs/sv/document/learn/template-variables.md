---
uid: help-sv-template-variables
title: Mallvariabler
description: Med mallvariabler kan du anpassa och automatisera inmatningen av kunddata
author: SuperOffice RnD
so.date: 02.23.2023
keywords: dokument, mall, variabel
so.topic: concept
language: sv
---

# Mallvariabler

Mallvariabler används för att infoga data från SuperOffice i e-postmeddelanden, offerter, mötesaviseringar, dokumentmallar med mera. Du kan använda mallvariabler för att anpassa och automatisera inmatningen av kunddata (eller data från kontakter, försäljningar och annat) i ditt innehåll och skapa komplexa offerter

> [!TIP]
> Se alla olika [mallvariabler][2] för **företagskortet**.

## Exempel

Här visar vi några exempel på hur du använder mallvariabler. Många av exemplen använder standardmallarna i SuperOffice.

### Så anpassar du ett e-postmeddelande med hjälp av mallvariabler

I stället för följande text:

"Bästa kund! Vill du veta mer om hur vår produkt kan hjälpa ditt företag att skaffa nya kunder? Kontakta oss."

kan du skicka denna text:

"Hej Chris! Vill du veta mer om hur vår produkt kan hjälpa Bilbutiken AB att skaffa nya kunder? Vänliga hälsningar, Karin Nordman på SuperShop."

Den text du anger ser ut så här:

"Hej **{atfn}**, Vill du veta mer om hur vår produkt kan hjälpa **{name}** att skaffa nya kunder? Ring **{cont}** på **{onam}**."

### Signaturer

Detta är ett exempel på en signatur som kan användas av vem som helst i ditt företag.

```text
Bästa hälsningar,
{auth}
{atit}
{onam}
Adress: {opad}, {ozip} {ocit}
Telefon: {audp}
Mobiltelefon: {aupc}
{auem}
{owww} | Med vänlig hälsning,
Johan Jonsson
Försäljningschef
SuperShop
Adress: Storgatan 12, 123 45 Storstad
Telefon: 22334455
Mobiltelefon: 99887766
jj@supershop.com
supershop.com
```

### Mötesprotokoll (rubrik)

Det här är ett exempel på en rubrik i ett mötesprotokoll (dokument eller e-post).

```text
{head}
Datum/Plats: {sdat}, {city}
Närvarande: {attn} ({name}), {auth} ({onam})
Frånvarande:
Mötessekreterare: {auth} ({auem})
Sommarkampanj – planering
Daum/Plats: 2019-12-15, London
Närvarande: Sara Miller (Liberty Ltd.), Johan Jonsson (SuperShop)
Frånvarande:
Mötessekreterare: Johan Jonsson (jj@supershop.com)
```

### Orderbekräftelse (rubrik)

Mallvariabler för offerter och orderbekräftelser kan användas i en offert.

```text
Orderdatum: {sdat}
Ordernummer: {qnum}
Leveransvillkor: {qdev}
Betalningsvillkor: {qpev}
Ert ordernummer: {qpon}
Vår kontakt: {cont}
Orderdatum: 2019-12-15
Ordernummer: 550012
Leveransvillkor: Leverans ingår
Betalningsvillkor: 15 dagar
Ert ordernummer: 70000882
Vår kontakt: Johan Jonsson
```

## Använda mallvariabler

* I dokument med filtypen .doc i Office 2003 och äldre måste du använda vinkelparenteser – &lt; &gt; – runt variablerna i stället för klammerparenteser – { } –.
* Hela variabeln måste vara formaterad med samma typsnitt och teckenstorlek och du får använda endast små bokstäver. Om du har aktiverat inställningen **Tillåt stora bokstäver i mallvariabler** går det däremot bra att formatera mallvariabeln.
* Du kan blanda vanlig text och variabler i malldokumentet: Du kan till exempel lägga till mallvariabler som hämtar ett företags namn och adress, skriva en standardtext till brevets brödtext och lägga till variabeln för vår kontakt som avslutning på brevet.
* Du kan också använda så kallade fyllnadstecken i malldokumentet (se nedan).
* Datum och klockslag i mallvariablerna styrs av systemklockan på datorn.

> [!TIP]
> När du har skapat ett nytt malldokument måste du lägga till det i fönstret **Listor** under Inställningar och underhåll innan du kan använda det i SuperOffice CRM.

## Fyllnadstecken

Ibland kan du behöva använda fyllnadstecken i mallar för att fältinnehåll eller fältformatering inte ska ändras eller tas bort om innehållet i ett fält blir kortare än vad fältvariabeln anger.

Du använder variabeln padd# för att ange vilket fyllnadstecken som ska användas. Ersätt #-tecknet med ANSI-koden för det tecken du vill använda som fyllnad. En lista över ANSI-koder finns vanligtvis i handboken till det program du skapar mallar i.

SuperOffice CRM har standardvärden för fyllnadstecken i de vanligaste ordbehandlings- och kalkylprogrammen. Vanligtvis används mjuka bindestreck, eftersom dessa inte visas på skärmen eller utskriften. För applikationer där inställningen är okänd används {padd32}, som är ANSI-koden för mellanslag.

> [!TIP]
> I Microsoft Word används {padd31} som fyllnadstecken.

Om du inte vill använda fyllnadstecken använder du mallvariabeln {padd0}.

> [!NOTE]
> Detta fungerar bara för dokumentformat som är sekventiella, till exempel Anteckningar och AmiPro-mallar utan grafik.

När du använder {padd0} kan du skriva alla mallvariabler utan mellanrum mellan namnet på mallvariabeln och det avslutande variabeltecknet (}).

## Variabler från företagskortet

> [!NOTE]
> Adressvariabler från företagskortet är så kallade "smarta" mallvariabler. Detta innebär att systemet väljer adressdata i en viss ordning. Variablerna i **fet text** nedan (till exempel **addr** och **city**) är smarta mallvariabler.

När du använder adressvariabler från företagskortet väljer systemet adressdata i följande ordning:

1. Om alternativet **Använd som postadress** är aktivt för en kontakt på företaget används kontaktens adressuppgifter.
2. Om alternativet ovan inte är aktivt används företagets adressuppgifter.
3. Om företagets postadress är tom, kommer företagets gatuadress att användas.

## Variabler i offertmallar

När du använder offerter och produkter i SuperOffice behöver du skapa offertmallar. Variablerna finns i en pdf-fil som även visar hur du arbetar med offertmallar.

Mallarna för offertdokument, offertdetaljer och orderbekräftelser skiljer sig från vanliga dokumentmallar eftersom de använder "mergefields" vid sidan om vanliga mallvariabler.

## Mallvariabler för service och marknadsföring

När du skapar e-postmallar för ärenden och utskick (och meddelandemallar) i Marknadsföring kan du anpassa e-postmeddelandet eller utskicket med mallvariabler. Variablerna skiljer sig något från dem som används i dokument.

## Referens

Referensen är grupperad efter område. [Gå till referens][1]

<!-- Referenced links -->
[1]:https://docs.superoffice.com/en/document/templates/variables/index.html
[2]:https://docs.superoffice.com/en/document/templates/variables/from-company-card.html

<!-- Referenced images -->
