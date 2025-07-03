---
uid: help-da-erp-update-connection
title: Rediger ERP-link
description: Lær, hvordan du ændrer navn, omfang eller konfiguration for et eksisterende ERP-link i SuperOffice CRM.
keywords: rediger ERP-link, opdater ERP-indstillinger, ændre ERP-link, sync connector, ERP-konfiguration, SuperOffice sync
author: Bergfrid Dias
date: 03.31.2025
version: 10.5
content_type: howto
license: development-tools
audience: settings
audience_tooltip: Indstillinger og vedligeholdelse
language: da
redirect_from: /da/quote/learn/admin/sync/sync-edit-erp-connection
index: true
---

# Rediger ERP-link

Du kan ændre navn, omfang og konfigurationsværdier for en eksisterende ERP-link.

> [!NOTE]
> Hvis linket er aktivt (markeret i kolonnen **Aktiv**), skal du midlertidigt deaktivere det, før du kan ændre konfigurationsværdier. Husk at genaktivere linket, når konfigurationen er færdig.

## Trin

1. I **Indstillinger og vedligeholdelse**, vælg <i class="ph ph-barcode" aria-label="Barcode icon"></i> **Tilbud/Sync** i navigatoren, og gå til fanen **Sync**.

1. Vælg ERP-linket, og klik på **Konfigurer ERP-link**.

1. Opdater navn og omfang efter behov.

1. For at opdatere connector-specifikke konfigurationsfelter:

    1. Fjern markeringen i afkrydsningsfeltet **Aktiv**.
    1. Opdater felterne efter behov.
    1. Markér **Aktiv**.
    1. Klik på **Test ERP-link** og ret eventuelle fejl.

1. Klik på **OK** for at gemme og lukke dialogboksen.

1. Hvis du også skal ændre felttilknytninger, standardværdier eller lister, kan du gøre det nu ved hjælp af knapperne nederst til venstre. Du kan finde detaljerede instruktioner under [Konfigurer ERP-links][1].

## Fejlfinding

### ERP-linket kan ikke gemmes

Hvis **OK**-knappen er nedtonet under tilføjelse eller redigering af et link:

* Kontrollér, at forbindelsestesten er gennemført med succes.
* Kontrollér, at alle obligatoriske konfigurationsfelter er udfyldt.
* Kontrollér, at nødvendige indstillinger som synlighed er angivet.

## Relateret indhold

* [Tilføj en Sync Connector og ERP-link][2]
* [Knyt firmaer, personer og projekter til ERP-aktører][3]

<!-- Referenced links -->
[1]: configure.md
[2]: add-connection.md
[3]: ../learn/connect.md
