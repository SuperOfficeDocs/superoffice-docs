---
uid: help-da-quote-place-order
title: Registrering af ordre
description: Lær, hvordan du registrerer en ordre i SuperOffice CRM.
keywords: registrer ordre, opret ordre, ordre baseret på tilbudsversion, tilbud
author: Bergfrid Dias
date: 04.28.2025
version: 10.5.4
content_type: howto
license: salespremium
audience: person
audience_tooltip: SuperOffice CRM
language: da
redirect_from: /da/quote/learn/create-order
---

# Registrering af ordre

Når kunden har accepteret tilbuddet, kan du registrere ordren, så den sendes videre til ordremodtagelse eller lager.

> [!NOTE]
> Du kan ikke registrere ordren, hvis [tilbuddet indeholder fejl eller advarsler][2].

## Trin

1. Klik på **Registrer ordre** i dialogboksen **Rediger tilbud**. Dialogboksen **Opret ordre baseret på tilbudsversion** vises. Titlen angiver, hvilken version af tilbuddet ordren er baseret på.

    For at registrere en ordre baseret på en arkiveret version, vælg versionen i feltet **Version** og klik på **Aktiver**. Den arkiverede version kopieres og gøres til den aktuelle version. Tidligere versioner bliver arkiveret.

1. Hvis tilbuddet indeholder flere alternativer, vælg det ønskede i feltet **Vælg alternativ**.
1. For at sende ordren via e-mail, marker **Send ordrebekræftelse på e-mail**, og vælg skabelon og sprog.
1. Indtast kundens **indkøbsordrenummer**, hvis det findes, og eventuelt en **ordrekommentar**.
1. Marker **Sæt salget til solgt (100 %)**, hvis du vil ændre salgets status.
1. Klik på **OK**.

    Hvis du har valgt at sende ordren som e-mail, åbnes dialogboksen **Ny e-mailmeddelelse**, hvor du kan redigere beskeden og sende bekræftelsen til kunden.

Hvis SuperOffice CRM er tilsluttet et ERP-system (via indbygget løsning eller tredjepart), registreres og behandles ordren automatisk. Ellers skal du registrere ordren manuelt i det eksterne system.

<!-- Referenced links -->
[2]: create.md#warning
