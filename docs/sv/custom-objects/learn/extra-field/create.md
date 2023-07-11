---
uid: help-sv-extra-fields-create
title:  Definiera extrafält
description: Definiera extrafält
author: Hanne Gunnarsson
so.date: 03.29.2023
keywords: extrafält, anpassa fält
so.topic: howto
so.audience: settings
so.audience.tooltip: Settings and maintenance
language: sv
---

# Lägg till extrafält

När du har skapat en [extratabell][1] måste du skapa fält i tabellen så att du senare kan lägga in data (poster) i tabellen. Du kan även skapa extrafält i standardtabellerna.

> [!TIP]
> Extra fält kan till exempel användas som sökkriterier och kolumner i försäljningar i SuperOffice CRM.

**Steg:**

1. Klicka på knappen **Systemdesign** ![ikon][img1] i navigatorn. Välj fliken **Tabeller**.
1. Bläddra till önskad tabell, peka på tabellnamnet och klicka på ![ikon][img2]-knappen.
1. Välj en fälttyp i listrutan **Typ** i fönstret **Nytt extrafält**.
1. Klicka på **OK**. Skärmen **Egenskaper för fält** visas.
1. På skärmen **Egenskaper för fält** kan du ange information om det nya fältet. Vilka egenskaper som finns tillgängliga beror på typen av extrafält (anges i steg 3).
1. Klicka på **OK** för att spara och klicka sedan på knappen **Starta om NetServer** längst upp till höger.

## Egenskaper för fält

| Fält | Beskrivning |
|---|---|
| Får inte vara tomt | Om du markerar det här alternativet blir fältet obligatoriskt. |
| Välj i listrutan | Om fältet är kopplat till en extratabell kan du välja detta alternativ för att visa en lista över tabellvärden. |
| Välj värden i lista | Om du markerar det här alternativet blir fältet en listruta. Alternativen i listan blir de textsträngar som anges i textrutan. Det är en rad per alternativ. |
| Skapa index | Ange om fältet ska indexeras eller inte. Det går snabbare att söka efter data i indexerade fält. |
| Databasfält | Det namn som kolumnen ska ha i databasen. Detta namn måste vara unikt i denna tabell. Dessutom måste kolumnnamnet vara ett enda ord och börja med "x_" och det får endast innehålla understreck, bokstäver från a till z och siffror. Kan bara anges när fältet skapas. Det kan inte ändras senare. |
| Antal decimaler | Det antal decimaler som är tillåtna i ett tal. |
| Standardvärde | Standardvärdet används för det här fältet. |
| Beskrivning | Standardbeskrivningen. |
| Visa värde | Ange om värdet ska visas eller inte. |
| Externt | Om det här alternativet har markerats är fältet tillgängligt från ett kundcenter. Detta är bara relevant för standardtabeller eftersom extratabeller alltid visas i kundcentra. |
| Sidhuvud för lista | Detta fält används för att specificera en rubrik för dessa poster när de visas som "underposter" i en lista. I vårt exempel betyder detta namnet på den nya fliken på skärmen **Visa kontakt** och vi skriver därför "Datorer" här. |
| Dölj funktionsknappar | (relationer) Välj detta alternativ om du inte vill visa funktionen för tillägg av nya poster i relationstabeller. |
| Dölj fältet | Ange om fältet ska visas eller inte. |
| Behåll HTML-taggar | (text) Välj detta alternativ om du vill inkludera HTML-koden i texten. |
| Namn | Namnet på fältet. I vårt exempel är detta namnen i listan i introduktionen till det här kapitlet. |
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
| Uppdatera nollvärden nu | Markera det här alternativet om du vill ersätta alla nollvärden (tomma fält) i databasen med standardvärdet. Lägg märke till att denna åtgärd kan ta lite tid. |
| URL | Ange URL:en i den dynamiska länken här. |
| Använd aktiv användare som standardvärde | Om det här alternativet är markerat används den aktuella användaren som fältets standardvärde. I vårt exempel skulle detta kunna vara relevant för fältet "Registrerat av". |
| Använd aktuellt datum/klockslag som standardvärde | Om det här alternativet är markerat används aktuellt datum/klockslag som fältets standardvärde. I vårt exempel skulle detta kunna vara relevant för fältet "Registreringsdatum". |
| Använd dagar/Använd timmar/Använd minuter | Välj de tidsenheter som du vill använda i tidsperiodfältet. |
| Använd standardvärde | Om det här alternativet är markerat får fältet ett standardvärde om inget annat anges. |
| Visa i relationsväljaren | Om den aktuella tabellen har en relation med en annan tabell (extratabellrelation) markerar du detta alternativ för att göra detta fält tillgängligt som sökfält. Exempel: Du har skapat en extra tabell med namnet "Produkter" med en extratabellrelation till tabellen **Ärenden**. På så sätt kan du söka efter och lägga till produkter på fliken **Extrafält** när du skapar nya ärenden. Genom att välja **Visa i relationsväljaren** för specifika fält i tabellen "Produkter" blir dessa fält tillgängliga som sökfält på fliken **Extrafält**. |

<!-- Referenced links -->
[1]: ../extra-table/create.md

<!-- Referenced images -->
[img1]: ../../../../../common/icons/nav-admin-systemdesign-active.png
[img2]: ../../../../media/icons/service/new-field.png
