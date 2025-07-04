---
uid: help-sv-extra-fields-create
title: Lägg till extrafält
description: Lägg till extrafält
keywords: extrafält, anpassa fält
author: Bergfrid Dias
date: 04.09.2024
version: 10.3.4
content_type: howto
audience: settings
audience_tooltip: Settings and maintenance
language: sv
redirect_from: /sv/custom-objects/learn/extra-field/create
index: true
---

# Lägg till extrafält

När du har skapat en [extratabell][1] måste du skapa fält i tabellen så att du senare kan lägga in data (poster) i tabellen. Du kan även skapa extrafält i standardtabellerna.

## Steg

1. [!include[Gå til tabeller](includes/goto-tables.md)]

1. Bläddra till önskad tabell, peka på tabellnamnet och klicka på **Nytt fält**.

    ![Skapa extra fält -screenshot][img1]

1. Välj en typ för det nya fältet och klicka på **OK**.

1. I **Fält egenskaper** skärmen, ange information om det nya fältet.

    * Ange ett *namn* som ska användas som etiketten.
    * Ange ett *databasfält* som börjar med **x_** för att identifiera det i schemat.
    * Valfritt ställ in andra egenskaper. Typen bestämmer vad som är tillgängligt. Se detaljer om fälten nedan.

    > [!TIP]
    > För att göra ett fält obligatoriskt, välj **Kan inte vara tomt**.

1. Klicka på **OK** för att spara det nya fältet (kör `alter table y_mynewtable add column x_mynewfield ...`).

1. Fortsätt att lägga till fler fält.

1. Klicka på **Starta om NetServer** när du är klar. Om Travel är aktiverat kommer du också att se ett meddelande om att en ny Travel-databas måste skapas.

## Egenskaper för fält

| Fält | Beskrivning |
|---|---|
| Får inte vara tomt | Om du markerar det här alternativet blir fältet obligatoriskt. |
| Välj i listrutan | Om fältet är kopplat till en extratabell kan du välja detta alternativ för att visa en lista över tabellvärden. |
| Välj värden i lista | Om du markerar det här alternativet blir fältet en listruta. Alternativen i listan blir de textsträngar som anges i textrutan. Det är en rad per alternativ. |
| Skapa index | Ange om fältet ska indexeras eller inte. Det går snabbare att söka efter data i indexerade fält. |
| Databasfält | Det namn som kolumnen ska ha i databasen. Detta namn måste vara unikt i denna tabell. Dessutom måste kolumnnamnet vara ett enda ord och börja med "x_" och det får endast innehålla understreck, bokstäver från a till z och siffror. Kan bara anges när fältet skapas. **Kan inte ändras senare.** |
| Antal decimaler | Det antal decimaler som är tillåtna i ett tal. |
| Standardvärde | Standardvärdet används för det här fältet. |
| Beskrivning | Standardbeskrivningen. |
| Visa värde | Ange om värdet ska visas eller inte. |
| Externt | Om det här alternativet har markerats är fältet tillgängligt från ett kundcenter. Detta är bara relevant för standardtabeller eftersom extratabeller alltid visas i kundcentra. |
| Sidhuvud för lista | Detta fält används för att specificera en rubrik för dessa poster när de visas som "underposter" i en lista. |
| Dölj funktionsknappar | (relationer) Välj detta alternativ om du inte vill visa funktionen för tillägg av nya poster i relationstabeller. |
| Dölj fältet | Ange om fältet ska visas eller inte. |
| Behåll HTML-taggar | (text) Välj detta alternativ om du vill inkludera HTML-koden i texten. |
| Namn | Namnet på fältet. |
| Antal enheter | (tidsperiod) Ange maximalt antal enheter för den "största" valda tidsenheten. Exempel: Om du har valt timmar och minuter och skriver "4" kan maximalt 4 timmar väljas medan minuterna går till 60. För dagar och timmar kan på liknande sätt maximalt 4 dagar väljas medan timmarna går till 24. |
| Tillåt bara bladnod i hierarkiska listrutor | (extratabellrelation) Specificera om endast den lägsta noden i en hierarki kan väljas av användaren. |
| Befattning | Anger fältets placering bland de övriga fälten i listor. |
| Sökkriterium | Välj den sökoperator som ska användas för det här fältet. |
| Visa i tabell | Om det här alternativet markeras visas fältet som en kolumn i fönster där flera poster visas i en tabell. |
| Visa en-till-flera-relationer | Om du har valt fälttyperna **Kontaktrelation**, **Företagsrelation** eller **Ärenderelation** och vill att en flik med data från denna tabell ska visas i fönstren Kontakt, Företag eller Ärende kan du markera det här fältet. |
| Tabell | Specificera vilken tabell fältet tillhör. |
| Måltabell | Specificera vilken tabell som ska användas. |
| Textområde/höjd | Välj detta alternativ om du vill specificera textfältets höjd (antalet rader). |
| Typ | Visar vald fälttyp. |
| Uppdatera nollvärden nu | Markera det här alternativet om du vill ersätta alla nollvärden (tomma fält) i databasen med standardvärdet. **Denna åtgärd kan ta lite tid.** |
| URL | Ange URL:en i den dynamiska länken här. |
| Använd aktiv användare som standardvärde | Om det här alternativet är markerat används den aktuella användaren som fältets standardvärde. |
| Använd aktuellt datum/klockslag som standardvärde | Om det här alternativet är markerat används aktuellt datum/klockslag som fältets standardvärde. |
| Använd dagar/Använd timmar/Använd minuter | Välj de tidsenheter som du vill använda i tidsperiodfältet. |
| Använd standardvärde | Om det här alternativet är markerat får fältet ett standardvärde om inget annat anges. |
| Visa i relationsväljaren | Om den aktuella tabellen har en relation med en annan tabell (extratabellrelation) markerar du detta alternativ för att göra detta fält tillgängligt som sökfält. Exempel: Du har skapat en extra tabell med namnet "Produkter" med en extratabellrelation till tabellen **Ärenden**. På så sätt kan du söka efter och lägga till produkter på fliken **Extrafält** när du skapar nya ärenden. Genom att välja **Visa i relationsväljaren** för specifika fält i tabellen "Produkter" blir dessa fält tillgängliga som sökfält på fliken **Extrafält**. |

## Lägg till relation (förnyckel, FK)

1. Klicka på **Nytt fält**.
1. Välj relationstypen för den enhet du vill ansluta till och klicka på **OK**.
1. Ställ in fältegenskaper som beskrivs ovan.

    > [!NOTE]
    > Tillgänglig från version 10.3.4 i pilot: Att välja **Visa en-till-flera-relationer** lägger till ett detaljkort (arkiv) till relaterade standardenheter.

1. Klicka på **OK** för att spara relationen.
1. Klicka på **Starta om NetServer** för att tillämpa ändringarna.

Till exempel, för att ansluta alla inkommande ärende till en specifik försäljning, kan du lägga till ett extra fält av typen säljrelation till Ärende ([ticket tabellen][4]). För att lista anslutna ärende när du tittar på en försäljning i SuperOffice CRM, behöver du bygga en webbpanel.

<!-- Referenced links -->
[1]: create-extra-table.md
[4]: ../../../en/database/tables/ticket.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/custom-objects/create-extra-tables-and-fields.png
