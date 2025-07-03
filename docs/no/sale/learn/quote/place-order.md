---
uid: help-no-quote-place-order
title: Registrere ordre
description: Lær hvordan du registrerer en ordre i SuperOffice CRM.
keywords: registrere ordre, opprett ordre, ordre basert på tilbudsversjon, tilbud
author: Bergfrid Dias
date: 04.28.2025
version: 10.5.4
content_type: howto
license: salespremium
audience: person
audience_tooltip: SuperOffice CRM
language: no
redirect_from: /no/quote/learn/create-order
---

# Registrere ordre

Når kunden har akseptert tilbudet, kan du registrere ordren slik at den sendes videre til ordrebehandling eller lager.

> [!NOTE]
> Du kan ikke registrere ordren hvis tilbudet [inneholder feil eller varsler][2].

## Fremgangsmåte

1. Klikk på **Registrer ordre** i dialogboksen **Rediger tilbud**. Dialogboksen **Lag ordre basert på tilbudsversjon** vises. Tittelen viser hvilken versjon av tilbudet ordren baseres på.

    For å registrere en ordre for en arkivert versjon av tilbudet, velg denne versjonen i feltet **Versjon** og klikk på **Aktiver**. Den arkiverte versjonen kopieres og gjøres til aktiv versjon. Tidligere versjoner arkiveres.

1. Hvis tilbudet inneholder flere alternativer, velg ønsket alternativ i feltet **Velg alternativ**.
1. For å sende ordrebekreftelsen på e-post, merk av for **Send ordrebekreftelse på e-post**, og velg e-postmal og språk.
1. Legg inn kundens **bestillingsnummer** (hvis aktuelt) og eventuelt en **ordrekommentar**.
1. Merk av for **Sett salget til solgt (100 %)** for å endre statusen på salget.
1. Klikk på **OK**.

    Hvis du valgte å sende ordren som e-post, åpnes dialogboksen **Ny e-postmelding**. Her kan du redigere meldingen og sende bekreftelsen til kunden.

Hvis SuperOffice CRM er koblet til et ERP-system (enten via innebygd løsning eller tredjepartskonnektor), registreres ordren automatisk og behandles der. Hvis ikke, må ordren registreres manuelt i det eksterne systemet.

<!-- Referenced links -->
[2]: create.md#warning
