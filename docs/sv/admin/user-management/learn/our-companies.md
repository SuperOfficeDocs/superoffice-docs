---
uid: help-sv-our-companies-manage
title: "Hantera 'Våra företag'"
description: Så lägger du till och tar bort företag på fliken Våra företag
author: Bergfrid
date: 03.15.2023
keywords: user, våra företag
content_type: howto
audience: settings
audience_tooltip: Settings and maintenance
language: sv
client: web
---

# Hantera "Våra företag"

## Krav

Innan du kan lägga till ett företag på fliken **Våra företag** måste det registreras som ett företag i SuperOffice.

Innan du kan ta bort företag från fliken **Våra företag** måste följande kriterier vara uppfyllda:

* Det får inte finnas några medarbetare registrerade på företaget. Antal medarbetare visas i kolumnen **Medarbetare** i företagslistan. Om du vill ta bort ett företag måste du först [ta bort de registrerade medarbetarna][2].

* Företaget kan inte vara en aktiv satellit. Kontrollera om företaget finns med i kolumnen **Aktiv satellit** i företagslistan.

## Lägg till företag på fliken Våra företag

1. Öppna fönstret Användare.

2. Välj fliken **Våra företag**.

3. Klicka på knappen **Lägg till** under företagslistan.

4. Fönstret Sök öppnas. Om sökkriterier redan har valts, men inte de sökkriterier du vill använda, tar du bort dem genom att klicka på knappen **Inaktivera alla** eller avmarkera kryssrutorna för de aktuella kriterierna.

5. Sök efter ett företag. Läs mer nedan.

6. När du har valt önskat företag och klickat på **OK** visas företaget i listan.

## Ta bort företag på fliken Våra företag

1. Kontrollera att kriterierna ovan är uppfyllda.

1. Öppna fönstret Användare.

1. Välj fliken **Våra företag**.

1. Markera önskat företag i listan.

1. Klicka på **Ta bort**-knappen under företagslistan. Företaget tas bort från listan.

> [!NOTE]
> Du kan inte ta bort ett företag som är registrerat som databasägare. Om du väljer en databasägare är knappen **Ta bort** inaktiverad.

## Hur söker jag efter ett företag?

1. I listrutan till höger om det fält du vill söka på väljer du om du vill söka efter ett företag som **Börjar med**, **Innehåller** eller **Är lika med** de sökkriterier du har angett.

2. Du kan ange flera [olika sökkriterier](#criteria), till exempel namn, kod, telefonnummer eller e-postadress. Om du anger flera sökkriterier görs en sökning efter företag som uppfyller samtliga kriterier.

3. När du har valt sökkriterier klickar du på knappen **Sök**.

4. Sökningen kan ge något av följande resultat:

    * **En träff**: företaget som matchar sökkriterierna visas i listan.

    * **Två eller flera träffar**: En träfflista visas i sökfönstret. Här kan du välja önskat företag i listan och klicka på **OK** för att gå till detta företag.

    * **Inga träffar**: Ett meddelande visas om att ingen post överensstämmer med sökkriterierna. Klicka på **OK** och gör en ny sökning med andra kriterier.

### <a id="criteria"></a>Sökkriterierna

Fälten nedan motsvarar fälten på företagskortet.

* Namn: Ange hela eller början på företagsnamnet.
* Nummer: Ange hela eller början på företagsnamnet.
* Kod: Ange hela eller början på koden.
* Org.nr: Ange hela eller början på organisationsnumret.
* Förnamn: Ange hela eller en del av förnamnet på en kontakt på företaget.
* Efternamn: Ange hela eller en del av efternamnet på en kontakt på företaget.
* Telefon: Ange hela eller en del av telefonnumret till företaget.
* E-post: Ange hela eller en del av e-postadressen till företaget.
* Uppfyll även: Här kan du ange ytterligare [sökkriterier][1].

<!-- Referenced links -->
[1]: ../../../search-options/learn/search-criteria.md
[2]: delete-user.md

<!-- Referenced images -->
