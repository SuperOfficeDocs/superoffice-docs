---
uid: help-da-automation-trigger
title: Triggere
description: Triggere
keywords: CRMScript, trigger
author: SuperOffice RnD
date: 06.29.2022
topic: howto
audience: settings
audience_tooltip: Settings and maintenance
language: da
---

# Triggere

[!include[Requirement](../../../learn/includes/req-expander-services.md)]

Udløsere er scripts, der udføres for bestemte hændelser i systemet, f.eks. når der oprettes et nyt salg, eller når en sag lukkes. Udløsere kan reagere lydløst på, hvad der sker, eller blokere handlingen og vise en forklaring tilbage til brugeren.

CRMScript kan gøre din arbejdsdag mere effektiv ved at automatisere forskellige opgaver. Du kan definere, at en bestemt hændelse i systemet sætter gang i (udløser) én eller flere foruddefinerede handlinger. Der kræves ingen viden om script-programmering for at få dette til at fungere.

**Eksempel fra SuperOffice**: Når en sag afsluttes, skal kunden underrettes om det via e-mail. Vi kan oprette en makro, der indeholder en række handlinger til at oprette og sende denne e-mail-underretning. Denne makro køres automatisk, når en sag afsluttes. Handlingerne i makroen indlæser den pågældende sag, henter den rigtige svarskabelon og sender en e-mail til kunden om, at sagen er lukket.

Dette er et eksempel på en meget enkel udløser. Du kan for eksempel tilføje betingelser for handlingerne i en udløser ved at ændre standardindstillingen **Altid** .

## Oprette en udløser

Vi vil nu oprette en række handlinger baseret på det ovenstående eksempel.

1. [!include[Go to](../../../learn/includes/goto-sm.md)]
1. Klik på <i class="ph ph-code-block" aria-hidden="true"></i> **CRMScript**, **og vælg fanen Udløsere** .
1. Klik på knappen **Ny udløser (makro)**. Skærmbilledet **Vælg udløser** viser de tilgængelige udløsere. Det er handlinger i systemet, som kan bruges til at aktivere handlinger/makroer. I vores eksempel vælger vi **Sag afsluttet**, så makroen køres, når en sag afsluttes i SuperOffice Service.
1. Skriv "sag" i søgefeltet, og vælg udløseren med navnet **Sag lukket**.
1. Angiv en kort beskrivelse af udløseren i feltet **Beskrivelse**.
1. Vælg **Aktiveret**.
1. Vælg **Ændre en sag** under **Vælg handlingstype** nedenfor. Du kommer til fanen **Ændre en sag**.
    Det bliver den første handling i makroen. Den henter sagen, så de forskellige værdier (ID, titel, person osv.) kan anvendes i de næste handlinger, vi vil oprette.
1. Valgfrit: Marker **Intern meddelelse**, og indtast for eksempel: "Sag lukket og bekræftelse sendt til kunden."
1. Klik på **Anvend**.
1. Klik på **Ny handling** ved siden af fanen **Ændre en sag**.
1. Vælg **Indlæs en svarskabelon til fletning**. Vi vil nu hente den svarskabelon, der skal bruges.
1. Klik på feltet **Svarskabelon**, og vælg en eksisterende svarskabelon på den viste liste, f.eks. "Sag lukket".
1. Klik på **Anvend**.
1. Klik på **Ny handling**, og vælg **Send en e-mail eller SMS**. Nu vil vi tilpasse den e-mail, som skal sendes til kunden.
1. Marker **Emnelinje**.
1. Klik på <i class="ph ph-gear" aria-label="Gear"></i> til højre, og klik derefter på feltet **Vælg parameter**.
1. Vælg **Ændre en sag** > **Titel**. Det anbringer sagstitlen i e-mailens emne.
1. Marker **Fra**, og vælg **Ændre en sag** > **Ejer**.
1. Marker **Til**, og vælg **Ændr en sag** > **Person: E-mailadresse**.
1. Marker **HTML-meddelelse**, og vælg **Indlæs en svarskabelon til fletning** > **HTML-tekst**.
1. Klik på **Anvend**.

Du har nu oprettet en makro, som sender en e-mail med "Sag lukket" til kunden, når en sag er lukket. Denne udløser bliver aktiveret øjeblikkeligt, hvis du har markeret **Aktiveret** øverst.
