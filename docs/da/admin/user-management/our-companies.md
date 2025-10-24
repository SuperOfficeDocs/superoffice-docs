---
uid: help-da-our-companies-manage
title: Administration af Vores firmaer
description: Sådan tilføjes og fjernes firmaer fra fanen Vores firmaer
keywords: vores firmaer
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
  - /da/admin/user-management/learn/move-user
  - /da/admin/user-management/learn/our-companies
language: da
---

# Administration af "Vores firmaer"

Du kan administrere "Vores firmaer" og flytte brugere mellem dem i skærmbilledet Brugere under Indstillinger og vedligeholdelse.

## Tilføjelse af firma i fanen Vores firmaer

Forudsætninger: For at tilføje et firma under fanen **Vores firmaer** skal det først registreres som et firma i SuperOffice.

1. Vælg fanen **Vores firmaer**.

1. Klik på knappen **Tilføj** under virksomhedslisten.

1. Skærmbilledet Find åbnes. Hvis der allerede er indtastet søgekriterier, men det ikke er dem, du vil bruge, skal du klikke på knappen **Deaktiver alle** for at fjerne dem eller fjerne markeringerne fra afkrydsningsfelterne for de relevante kriterier.

1. Søg efter et firma. Se detaljer nedenunder.

1. Når du har valgt det firma, du har brug for, og har klikket på **OK,**, vises det på listen.

## Sletning af firma i fanen Vores firmaer

1. Kontroller, at følgende kriterier er opfyldt:

    * Der må ikke være registreret medarbejdere på firmaet. Antal medarbejdere vises i kolonnen **Medarbejdere** på firmalisten. Hvis du vil slette et firma, skal du først [slette de registrerede medarbejdere][2].
    * Firmaet må ikke være en aktiv satellit. Kontroller, om firmaet er opført i kolonnen **Aktiv satellit** på virksomhedslisten.

1. Vælg fanen **Vores firmaer**.

1. Marker det ønskede firma på listen.

1. Klik på knappen **Slet** under firmalisten. Firmaet fjernes fra listen.

> [!NOTE]
> Du kan ikke slette firmaet, hvis det er registreret som databaseejer. Hvis du vælger en databaseejer, deaktiveres knappen **Slet**.

## <a id="move"></a>Flyt bruger fra et firma til et andet

Du kan flytte en bruger fra et firma til et andet, hvis din organisation består af flere firmaer, der er registreret på fanen [Vores firmaer][2]. Hvis en bruger blev konfigureret under det forkerte firma, eller hvis brugeren har skiftet stilling/job i organisationen, kan brugeren flyttes, herunder brugerens aktiviteter og salg.

1. Gå til fanen **Medarbejdere** og marker den ønskede bruger på listen.

1. Klik på **Opgave**, og vælg **Flyt bruger**.

1. Vælg i dialogboksen **Flyt til**, og vælg det firma, du vil flytte personen til.

1. Vælg et af følgende **Handling på alle eksisterende aktiviteter og salg**:

    [!include[Select action](../../learn/includes/select-action-on-activity.md)]

    > [!NOTE]
    > Hvis du vil se resultaterne, før du bekræfter handlingen, skal du klikke på <i class="ph ph-info" aria-label="Vis resultater"></i>.

1. Klik på **Flyt**. Brugeren flyttes til det angivne firma.

## Hvordan søger jeg efter et firma?

1. På listen til højre for det felt, du vil søge efter, skal du vælge, om du vil søge efter et firma, der **Begynder med**, **Indeholder** eller **Er lig med** de søgekriterier, du angiver.

2. Du kan angive flere forskellige søgekriterier, f.eks. navn, kode, telefonnummer eller e-mailadresse. Hvis du angiver flere søgekriterier, søges der efter firmaer, som opfylder alle kriterierne.

3. Når du har angivet de nødvendige kriterier, skal du klikke på knappen **Søg**.

4. Når søgningen er færdig, er der disse mulige resultater:

    * **Ét hit**: Det firma, der matcher søgekriterierne, vises på listen.

    * **To eller flere hit**: Skærmbilledet Søg viser en liste med matches. Her kan du vælge det ønskede firma på listen og klikke på **OK** for at gå til det pågældende firma.

    * **Ingen hit**: Der vises en meddelelse om, at der ikke er nogen poster, der opfylder søgekriterierne. Klik på **OK**, og søg igen ved hjælp af andre kriterier.

### <a id="criteria"></a>Søgekriterierne

Felterne nedenfor svarer til felterne på firmakortet.

* Navn: Indtast hele eller begyndelsen af firmanavnet.
* Nummer: Indtast hele eller begyndelsen af firmanavnet.
* Kode: Indtast hele eller begyndelsen af koden.
* SE-nr.: Indtast hele eller begyndelsen af SE-nummeret.
* Fornavn: Indtast hele eller en del af fornavnet på en person i firmaet.
* Efternavn: Indtast hele eller en del af efternavnet på en person i firmaet.
* Telefon: Indtast hele eller en del af et telefonnummer til firmaet.
* E-mail: Indtast hele eller en del af en e-mailadresse for firmaet.
* Opfyld også: Her kan du angive yderligere [søgekriterier][1].

<!-- Referenced links -->
[1]: ../../search-options/learn/search-criteria.md
[2]: update-user.md#delete

<!-- Referenced images -->
