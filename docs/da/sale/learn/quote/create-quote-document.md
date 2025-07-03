---
uid: help-da-quote-create-document
title: Opret tilbudsdokument
description: Opret et tilbudsdokument i SuperOffice Quote, som du kan sende til kunden.
keywords: opret tilbudsdokument, ændr tilbudsdokument, tilbudsdokument, tilbud
author: Bergfrid Dias
date: 04.28.2025
version: 10.5.4
content_type: howto
license: salespremium
audience: person
audience_tooltip: SuperOffice CRM
language: da
redirect_from: /da/quote/learn/create-quote-document
---

# Opret tilbudsdokument

Når du har oprettet tilbuddet og tilføjet produkterne, kan du generere tilbudsdokumentet. Det fungerer som et "brev" til kunden. Produktlisten tilføjes automatisk, når tilbuddet sendes.

Du kan oprette dokumentet enten fra fanen **Tilbud** i salget eller fra dialogboksen **Rediger tilbud**.

> [!TIP]
> Brug [en skabelon med tilbudsspecifikke fletfelter][3] for at inkludere tilbudsoplysninger i dokumentet.

## Opret tilbudsdokumentet

1. Hvis du allerede redigerer tilbuddet, skal du klikke på **Klik for at oprette tilbudsdokument** øverst i dialogboksen **Rediger tilbud**.

    *Alternativt* skal du gå til fanen **Tilbud** i salget og klikke på **Klik for at oprette tilbudsdokument**.

    > [!NOTE]
    > Tilbuddet skal have status **Udkast**. Hvis det allerede er sendt, skal du først [oprette en ny version][1].

2. I dialogboksen **Dokument**, [udfyld de nødvendige felter][2].

3. Klik på **Opret** for at oprette et nyt dokument baseret på den valgte skabelon.

4. Rediger dokumentet i Word (eller en anden standardeditor), og gem og luk filen.

    Dokumentet vises i fanen **Tilbud** og er knyttet til tilbuddet. Det vises også under fanen **Aktiviteter** i salget (samt på Firma- og Kalender-skærmbilledet).

## <a id="replace"></a>Erstat tilbudsdokument

Hvis du vil ændre indholdet eller skabelonen for tilbudsdokumentet, kan du vælge en af følgende metoder:

### Metode 1: Erstat kun filen

Brug denne metode, hvis du vil bevare dokumentets metadata, men uploade en opdateret fil.

1. Klik på dokumentet i fanen **Tilbud**.

2. Fjern markeringen af **Fuldført**.

3. Klik på **Erstat**, vælg den nye fil, og upload den.

4. Klik på **Gem**.

### Metode 2: Slet og opret dokumentet igen

Brug denne metode, hvis du vil starte forfra med et nyt dokument.

1. Klik på det eksisterende dokument i fanen **Tilbud**.

2. Klik på <i class="ph ph-dots-three-circle-vertical" aria-label="Task button"></i>, og vælg **Slet** i menuen **Opgave**.

3. Klik på **Klik for at oprette tilbudsdokument** for at oprette en ny fil.

### Metode 3: Opret og tilknyt et nyt dokument

Brug denne metode til manuelt at oprette et nyt dokument med din ønskede skabelon og tilknytte det til tilbuddet. Det gamle dokument bevares.

1. Klik på **Ny** i topbjælken, og vælg **Dokument**.

2. I dialogboksen **Dokument** skal du vælge en tilbudsskabelon og det salg, dokumentet skal knyttes til. Klik derefter på **Opret**.

3. Gå til fanen **Tilbud** i salget, og klik på **Åbn**.

4. Klik på <i class="ph ph-dots-three-circle-vertical" aria-label="Task button"></i>, og vælg **Skift tilbudsdokument** i menuen **Opgave**.

5. Vælg det nye dokument på listen.

    Listen viser alle dokumenter, der er registreret som tilbudsdokumenter for det aktuelle salg.

> [!TIP]
> Ved mindre ændringer kan du blot åbne det eksisterende dokument, foretage dine rettelser og gemme. Det er ikke nødvendigt at erstatte filen eller slette dokumentet.

## Sådan fungerer tilbudsskabeloner

Skabeloner til tilbudsdokumenter, tilbudsdetaljer og ordrebekræftelser adskiller sig fra almindelige dokumentskabeloner. De bruger **fletfelter** ud over standardvariabler.

* Hvis fletfeltet `<<QuoteDetails>>` findes i hoveddokumentet, indsættes tilbudsoplysningerne på dette sted.
* Hvis feltet ikke findes, indsættes tilbudsoplysningerne sidst i dokumentet.

## Relateret indhold

* [Afsendelse af tilbud][4]
* [Registrering af ordre][5]
* [Rediger et dokument][2]
* [Skabeloner til tilbudsdokumenter][6]
* [Skabelonvariabler og fletfelter][3]

<!-- Referenced links -->
[1]: send.md#versions
[2]: ../../../document/learn/edit.md
[3]: ../../../document/templates/merge-fields/quote.md
[4]: send.md
[5]: place-order.md
[6]: ../../../document/templates/learn/quote-templates.md
