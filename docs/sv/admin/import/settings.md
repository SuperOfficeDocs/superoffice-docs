---
uid: help-sv-import-settings
title: Importinställningar
description: Importinställningar
keywords: importinställningar
author: SuperOffice Product and Engineering
date: 02.22.2023
version: 10.5
content_type: howto
category: Settings and maintenance
topic: Import
audience: settings
audience_tooltip: Settings and maintenance
index: true
redirect_from: /sv/admin/import/learn/configure-import-settings
language: sv
---

# Konfigurera importinställningar

Genom att anpassa importinställningarna sparar du tid och det blir lättare att importera data på rätt sätt.

[!include[Back up database before import](includes/caution-backup-before-import.md)]

I dialogrutan **Importinställningar** kan du anpassa importen så att den omfattar precis det du vill. För att importdatan ska hålla så hög kvalitet som möjligt är det viktigt att ange rätt importinställningar.

Detta gäller bland annat följande:

* Dubbletter: Välj önskad metod för att hantera information som finns både i importfilen och databasen.
* Kontakter som inte är kopplade till företag.
* Rättslig grund och källa till samtycke för kontakter.
* Listor: Välj önskad metod för att hantera poster i importen. Exempel: nya kategorier, företagstyper och telefonnummer, nya produktkategorier, produktserier och produkttyper.

## Att tänka på innan du importerar kontakt- eller produktinformation

* Du kan definiera vad systemet ska göra om du importerar kontakter som redan finns i SuperOffice CRM. Systemet kan skriva över dem eller hoppa över uppdatering – du väljer själv.

* Du kan välja att låta systemet skapa nya kategorier automatiskt om du använder en kategori som inte finns i SuperOffice CRM i din importfil.

## Typiska scenarier

* Jag vill importera information som inte finns i SuperOffice-datan, men jag vill inte skriva över befintlig information.
    Välj alternativet **Slå ihop – uppdatera tomma fält**. Då uppdateras endast tomma fält i SuperOffice med den importerade informationen.

* De uppgifter jag vill importera är kvalitetssäkrade och jag vill uppdatera SuperOffice-databasen.
    Välj alternativet **Ersätt - skriv över befintlig**. Data från importen skriver då över befintliga fält i SuperOffice.

* Jag vill bara importera nya företag och kontakter till SuperOffice.
    Välj alternativet **Hoppa över - importera inte**. Företag och kontakter som redan finns i SuperOffice uppdateras inte.

* Jag vill bara importera nya produkter till den valda prislistan.
    Välj alternativet **Hoppa över - importera inte**. Produkter som redan finns med i den valda prislistan uppdateras inte.

* Jag vill importera alla företag och kontakter till SuperOffice och hantera eventuella dubbletter manuellt.
    Välj alternativet **Lägg alltid till**.

* Jag vill importera alla produkter till den valda prislistan och hantera eventuella dubbletter manuellt.
    Välj alternativet **Lägg alltid till**.

### Exempel

**Befintliga data:**

| | Företag | Adress | Momsreg.nr | Kod |
|---|---|---|---|---|
| **Import Excel/Outlook/Gmail** | ACME Inc. | Broadway 123 | 11223344 | - |
| **SuperOffice** | ACME Inc. | Main street 456 | - | ACME1 |

**Åtgärd:**

| Åtgärd | Företag | Adress | Momsreg.nr | Kod |
|---|---|---|---|---|
| **Slå ihop** | ACME Inc. | Broadway 123 | 11223344 | ACME1 |
| **Ersätt** | ACME Inc. | Main street 456 | 11223344 | - |
| **Hoppa över** | ACME Inc. | Broadway 123 | - | ACME1 |

## Hantera dubbletter (företag/kontakt)

Dubbletter uppstår om samma post finns i både importfilen och i databasen. I importinställningarna måste du alltid ange regler för dubbletthantering.

Under **Företag**, **Kontakt** och **Produkt** i dialogrutan **Importinställningar** anger du hur dubbletter ska hanteras.

1. Klicka på listrutan **Dubblett** och välj vilka fält som ska användas för att identifiera dubbletter av företag och kontakter.

    > [!NOTE]
    > Om du vill förhindra att data skrivs över bör du välja det alternativ som är unikt för varje företag, kontakt och produkt.
    >
    > De data som har valts för dubblettkontroll MÅSTE finnas med i importfilen. Om du väljer namn + kod måste importfilen innehålla åtminstone dessa kolumner.

1. Klicka på listrutan **Åtgärd** och välj hur dubbletter ska hanteras.

    * **Lägg alltid till**:
      * Nya företag, kontakter och produkter läggs alltid till, även om det finns dubbletter.
      * Nya produkter läggs alltid till, även om det finns dubbletter.

    * **Slå ihop – uppdatera tomma fält**:
      * Om företag och kontakter som redan finns i SuperOffice har tomma fält fylls de tomma fälten i med data från importkällan. Data som redan finns i SuperOffice-fält skrivs inte över.

      * Om produkter som redan finns i den valda prislistan har tomma fält fylls de tomma fälten i med data från importkällan. Data som redan finns i den valda prislistan skrivs inte över.

    * **Ersätt - skriv över befintlig**:
      * Importdata skriver över befintliga data i SuperOffice-fältet.
      * Importdata skriver över befintliga data i den valda prislistan.

    * **Hoppa över - importera inte**:
      * Om företag och kontakter redan finns i SuperOffice importeras de inte.
      * Om produkter redan finns med i den valda prislistan importeras de inte.

### Alternativ för dubbletter

**Företag:**

* **Namn**: Företagsnamnen måste vara identiska.
* **Namn + Avdelning**: Både företagsnamn och avdelning måste vara identiska.
* **Nummer**: Företagsnumret måste vara identiskt.
* **Kod**: Företagets kod måste vara identisk.
* **Organisationsnummer**: Företagets organisationsnummer måste vara identiskt.
* **ID**: Företagets ID måste vara identiskt.

**Kontaktperson:**

* **Namn**: Kontakternas fullständiga namn (förnamn + efternamn) måste vara identiska.
* **E-postadress**: Kontaktens e-postadress måste vara identisk.
* **Mobiltelefon**: Kontakternas mobiltelefonnummer måste vara identiska.
* **Nummer**: Kontaktens nummer måste vara identiskt.
* **Ingen – importera inte kontakt**: Välj det här alternativet om du inte vill importera några kontakter.
* **ID**: Kontaktens ID måste vara identiskt.

**Produkt:**

* **Namn**: Produktnamnet måste vara identiskt.
* **Kod**: Produktkoden måste vara identisk.
* **Namn + kod**: Både produktnamnet och produktkoden måste vara identiska.

## Hantera kontakter som inte hör till något företag

Om det finns kontakter i importkällan som inte är registrerade på ett företag har du tre alternativ i listrutan **Om företagsnamn är tomt**:

* **Skapa företag med kontaktens namn**: Det skapas en företag med kontaktens namn, och kontakten blir den enda kontakten.

* **Hoppa över – skapa inte företag eller kontakt**: Företaget importeras inte.

* **Importera kontakter utan företag**: Kontakten importeras utan länk till ett företag. Det här alternativet kan endast användas om den globala inställningen **Obligatoriskt företag för kontakt** är satt till **Nej**.

## Integritetsinställningar för importerade personer

När du importerar personer måste du också ange rättslig grund och samtyckeskälla för syftet **Försäljning och tjänster**:

* **Rättslig grund**: Välj [rättslig grund][1] i listan eller välj **Använd standard** för att använda det standardvärde som har angetts i Integritet-fönstret.

* **Samtyckeskälla**: Det här värdet är som standard inställt på **Import**, men du kan välja ett annat värde i listan.

## Hantera listvärden som inte finns i SuperOffice

Importkällan kan exempelvis innehålla branscher som inte är registrerade i SuperOffice. Då måste du välja hur nya kategorier, branscher, befattningar och anpassade listvärden och intressen ska hanteras. I listrutorna under **Listor** har du följande val:

* **Lägg till nytt objekt i listan**: Nya värden läggs till i SuperOffice.
* **Ignorera – använd standardvärde**: Nya värden importeras inte och standardvärdet för kategori eller bransch används. Du anger standardvärdet under **Inställningar** > **Standardvärden**.

    > [!NOTE]
    > **Position** har inget standardvärde.

* **Ignorera - ange som tomt**: Inga nya värden importeras till SuperOffice.

## Hantera nya telefonnummer, länkar och e-postadresser

Importkällan kan innehålla till exempel telefonnummer, länkar och e-postadresser som inte är registrerade i SuperOffice. Eftersom flera telefonnummer, länkar och e-postadresser kan läggas in för samma företag/kontakt måste du ange hur de nya värdena ska hanteras. I listrutorna **Telefonnummer** och **Länkar + e-postadresser** under **Listor** har du följande alternativ:

* **Lägg till ny – behåll befintlig**: Nya värden läggs till i SuperOffice och befintliga värden behålls.
* **Ersätt - skriv över befintlig**: Befintliga värden i SuperOffice skrivs över med importerade värden.
    Till exempel: Detta kan vara användbart om du vet att importen innehåller korrekta e-postadresser till dina kontakter. Om e-postadresserna i SuperOffice är inaktuella kan du städa upp i systemet genom att skriva över dem.
* **Ignorera – behåll befintlig**: Inga nya värden importeras till SuperOffice.

## Hantera produktkategorier, produktserier och produkttyper som inte finns i SuperOffice

Importkällan kan innehålla exempelvis produktkategorier som inte är registrerade i SuperOffice. Du måste då välja hur nya produktkategorier, produktserier och produkttyper ska hanteras. I listrutorna **Nya värden för ...** har du följande alternativ:

* **Lägg till nytt objekt i listan**: Nya värden läggs till i SuperOffice.
* **Ignorera - ange som tomt**: Inga nya värden läggs till i SuperOffice.

<!-- Referenced links -->
[1]: ../../security/privacy/learn/index.md

<!-- Referenced images -->
