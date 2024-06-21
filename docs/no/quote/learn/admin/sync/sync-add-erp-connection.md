---
uid: help-no-sync-add-erp-connection
title: Legge til ERP-kobling (Sync Connector)
description: Legge til ERP-kobling (Sync Connector)
author: SuperOffice RnD
date: 06.29.2022
keywords: tilbud, sync, connector, ERP
topic: howto
audience: settings
audience_tooltip: Settings and maintenance
language: no
---

# Legge til ERP-kobling (Sync Connector)

Hver Sync Connector må ha en ERP-kobling med konfigurasjonsinformasjon for å knytte Sync Connector til SuperOffice.

## Slik legger du til en ERP-tilkobling

1. Gå til fanen **Sync** i Tilbud/Sync-bildet.

1. Klikk på **Legg til** nederst i listen **ERP-koblinger**. Dialogboksen **Angi ny ERP-kobling** vises.

1. Skriv inn navnet på ERP-koblingen i feltet **Navn**.

1. Velg ønsket **ERP Sync Connector** i listen. Denne listen er identisk med **Sync Connectors**.

1. Velg ønsket **Omfang**:

    * **Alle**: Velg dette alternativet hvis alle brukere skal ha tilgang til og kunne bruke denne ERP-koblingen. Det vil si at de kan bruke prislistene som er tilgjengelig via denne koblingen.
    * **Angitte brukere + grupper**: Klikk på **Ingen brukere eller grupper er valgt** for å velge hvilke brukere og/eller brukergrupper som skal tilgang til denne ERP-koblingen.

1. Under **Konfigurasjonsfelt** angir du ønskede innstillinger. Innholdet i denne listen varierer etter hvilken type Sync Connector du har valgt.

1. Skriv inn en beskrivelse av ERP-koblingen i feltet nederst.

1. Klikk på **Test ERP-koblingen** for å kontrollere at koblingen fungerer. Hvis du får en feilmelding, må du rette opp problemet før du kan gå videre.

1. Klikk på **OK**. ERP-koblingen vises i listen **ERP-koblinger**.

    > [!NOTE]
    >**OK**-knappen er deaktivert helt til testen av ERP-koblingen er vellykket.

Du må merke av i kolonnen **Aktiv** for å aktivere koblingen, slik at **ERP**-fanen vises i SuperOffice CRM. Før du aktiverer ERP-koblingen, må du imidlertid sørge for at den er konfigurert riktig:

* Angi synkroniseringsinnstillinger, og velg hvilke felt som skal vises i søkevinduet og i **ERP**-fanen. Se [konfigurere felttilordning][1] og [Konfigurere listetilordning][2].

* [Angi ønskede standardverdier][3] for felt som vanligvis bare har én aktuell verdi, slik at brukerne slipper å angi verdi for disse feltene.

* [Velg rekkefølgen på ERP-feltene][4] som vises i ERP-fanen i SuperOffice CRM.

* Hvis du bruker flere ERP-tilkoblinger, kan [du angi prioritet for tilkoblinger][5].

* [Importere data fra ERP-systemet][6]

<!-- Referenced links -->
[1]: sync-configure-field-allocation.md
[2]: sync-configure-list-mapping.md
[3]: sync-configure-default-values.md
[4]: sync-rank-fields-shown-in-erp-tab.md
[5]: sync-set-sync-priority.md
[6]: ../../../../admin/import/learn/import-from-erp.md

<!-- Referenced images -->
