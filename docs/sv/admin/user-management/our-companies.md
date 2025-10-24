---
uid: help-sv-our-companies-manage
title: Hantera Våra företag
description: Så lägger du till och tar bort företag på fliken Våra företag
keywords: våra företag
author: digitaldiina
date: 10.24.2025
version: 10.4
content_type: howto
audience: settings
audience_tooltip: Settings and maintenance
category: identity management
topic: user
platform: web
index: true
redirect_from: 
  - /sv/admin/user-management/learn/move-user
  - /sv/admin/user-management/learn/our-companies
language: sv
---

# Hantera "Våra företag"

Du kan hantera "Våra företag" och flytta användare mellan dem i vyn Användare under Inställningar och underhåll.

## Lägg till företag på fliken Våra företag

Krav: Innan du kan lägga till ett företag på fliken **Våra företag** måste det registreras som ett företag i SuperOffice.

1. Välj fliken **Våra företag**.

1. Klicka på knappen **Lägg till** under företagslistan.

1. Fönstret Sök öppnas. Om sökkriterier redan har valts, men inte de sökkriterier du vill använda, tar du bort dem genom att klicka på knappen **Inaktivera alla** eller avmarkera kryssrutorna för de aktuella kriterierna.

1. Sök efter ett företag. Läs mer nedan.

1. När du har valt önskat företag och klickat på **OK** visas företaget i listan.

## Ta bort företag på fliken Våra företag

1. Kontrollera att kriterierna är uppfyllda:

    * Det får inte finnas några medarbetare registrerade på företaget. Antal medarbetare visas i kolumnen **Medarbetare** i företagslistan. Om du vill ta bort ett företag måste du först [ta bort de registrerade medarbetarna][2].
    * Företaget kan inte vara en aktiv satellit. Kontrollera om företaget finns med i kolumnen **Aktiv satellit** i företagslistan.

1. Välj fliken **Våra företag**.

1. Markera önskat företag i listan.

1. Klicka på **Ta bort**-knappen under företagslistan. Företaget tas bort från listan.

> [!NOTE]
> Du kan inte ta bort ett företag som är registrerat som databasägare. Om du väljer en databasägare är knappen **Ta bort** inaktiverad.

## <a id="move"></a>Flytta användare från ett företag till ett annat

Du kan flytta en användare från ett företag till ett annat om din organisation består av flera företag som är registrerade under fliken **Våra företag**. Om en användare har skapats under fel företag eller har bytt befattning/tjänst i organisationen kan hen flyttas, inklusive aktiviteter och försäljningar.

1. Välj fliken **Medarbetare** och välj önskad användare i listan.

1. Klicka på **Uppgift** och välj **Flytta användare**.

1. Välj **Flytta till** i dialogrutan och välj det företag du vill flytta kontakten till.

1. Välj något av följande under **Åtgärd för alla befintliga aktiviteter och försäljningar**:

    [!include[Select action](../../learn/includes/select-action-on-activity.md)]

    > [!NOTE]
    > Om du vill se resultaten innan du bekräftar åtgärden klickar du på <i class="ph ph-info" aria-label="Visa resultat"></i>.

1. Klicka på **Flytta**. Användaren flyttas till företaget som du har angett.

## Hur söker jag efter ett företag?

1. I listrutan till höger om det fält du vill söka på väljer du om du vill söka efter ett företag som **Börjar med**, **Innehåller** eller **Är lika med** de sökkriterier du har angett.

2. Du kan ange flera olika sökkriterier, till exempel namn, kod, telefonnummer eller e-postadress. Om du anger flera sökkriterier görs en sökning efter företag som uppfyller samtliga kriterier.

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
[1]: ../../search-options/learn/search-criteria.md
[2]: update-user.md#delete

<!-- Referenced images -->
