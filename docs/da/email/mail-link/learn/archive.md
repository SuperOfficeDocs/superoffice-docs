---
uid: help-da-mail-link-archive
title: Arkivere e-mails i SuperOffice
description: Arkivere e-mails i SuperOffice
author: SuperOffice RnD
date: 06.29.2022
keywords: Mail Link
topic: howto
language: da
---

# Arkivere en e-mail

Når du klikker på knappen **Arkiver e-mail** på e-mailklientens værktøjslinje, vises der en menu med arkiveringsindstillinger.

> [!NOTE]
> Denne knap vises også i e-mailvinduet, når du åbner en e-mail, som du har modtaget.

**Muligheder:**

* [Sådan arkiveres e-mails på firmaer/personer][2]
* [Arkivering af e-mails som aktiviteter][1]
* [Sådan arkiveres vedhæftede filer][3]
* [Sådan arkiveres e-mails som sager][4]

Ved alle de forskellige arkiveringsindstillinger kan du klikke på valgmuligheden **Advar mig når en e-mail er større end (i KB)** i ruden [**Generelle indstillinger**][5] i dialogboksen **SuperOffice CRM indstillinger**. Når du så prøver at arkivere en e-mail, der indeholder en vedhæftet fil, som er større end den angivne grænse, oplyser en dialogboks dig om dette og spørger dig, om du ønsker at arkivere den alligevel.

## Forskelle mellem i Outlook, Notes og SuperOffice CRM

Du kan oprette mails på flere forskellige måder, både [fra Outlook][6] og [fra SuperOffice CRM.][8] Hvis dialogboksen **Dokument** vises, behandles e-mailen som et SuperOffice-dokument og arkiveres. Hvis dialogboksen **Dokument** ikke vises, afhænger arkivering af e-mailen af indstillingerne i dialogboksen **SuperOffice CRM indstillinger**.

Dialogboksen **Dokument** åbnes automatisk, hvis du:

* Klikker på knappen **Skriv** i SuperOffice CRM.

* Klikker på pil ned til højre for knappen **Ny e-mail** på værktøjslinjen i Microsoft Outlook, og vælg en af skabelonerne i undermenuen **SuperOffice besked**.

Dialogboksen **Dokument** åbnes ikke automatisk, hvis du:

* Klikker på knappen **Ny e-mail** i e-mailklienten. Dine e-mails arkiveres dog, hvis valgmuligheden **Arkiver e-mail som standard, når: oprettet fra e-mailklient** er valgt i dialogboksen **SuperOffice CRM indstillinger**.

* Klikker på knappen **E-mail** i SuperOffice CRM. Dine e-mails arkiveres dog, hvis valgmuligheden **Arkiver e-mail som standard, når: oprettet fra SuperOffice CRM** er valgt i dialogboksen **SuperOffice CRM indstillinger**.

* Når du opretter en e-mail via knappen **E-mail** i SuperOffice CRM, kan du anvende en foruddefineret e-mailmeddelelsestekstskabelon som standard, hvis valgmuligheden **Anvend SuperOffice e-mailmeddelelsestekst** er valgt i dialogboksen **SuperOffice CRM indstillinger**.

> [!NOTE]
> Dette gælder også, hvis du klikker på en e-mailadresse i fanebladet SuperOffice CRM, sender en e-mail fra fanebladet **Personer** eller svarer på/videresender en e-mail fra fanebladet **Aktiviteter**.

## E-mail er allerede arkiveret i SuperOffice CRM

Når en e-mail arkiveres af en bruger, mærkes den med et unikt id i SuperOffice CRM. Det betyder, at der vises en advarsel med oplysninger om dette, næste gang nogen forsøger at arkivere den samme e-mail; på denne måde er det muligt at undgå dubletter i databasen.

Hvis du åbner en e-mail, som allerede er arkiveret, vises knappen **Arkiver e-mail** ![ikon][img1] med grøn med et hvidt flueben. Hvis du fører musemarkøren hen over knappen, vises et infofelt med oplysninger om, hvem der arkiverede e-mailen og hvornår. Dette forudsætter, at du har valgt valgmuligheden **Check for dubletter når en e-mail åbnes** i dialogboksen **SuperOffice CRM indstillinger**.

## Relateret indhold

* [Arkivindstillinger][9]
* [Generelle indstillinger][5]

<!-- Referenced links -->
[1]: archive-as-activity.md
[2]: archive-on-contact.md
[3]: archive-attachment.md
[4]: archive-as-request.md
[5]: settings/general.md
[9]: settings/default.md
[6]: create-in-outlook.md
[8]: create-in-superoffice.md

<!-- Referenced images -->
[img1]: ../../../../media/icons/mail-link/already-archived.png
