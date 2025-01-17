---
uid: help-sv-document-library-change-to-sharepoint
title: Konfigurera SharePoint dokumentbibliotek
description: Konfigurera SharePoint dokumentbibliotek
author: SuperOffice RnD
so.date: 03.21.2023
keywords: dokument, SharePoint
so.topic: howto
so.audience: settings
so.audience.tooltip: Settings and maintenance
language: sv
---

# Konfigurera SharePoint dokumentbibliotek

> [!NOTE]
> Innan du påbörjar den här konfigurationen måste du konfigurera din SharePoint-webbplats samt dina bibliotek och behörigheter. Alla användare måste autentiseras med MS 365.

När du konfigurerar ditt nya dokumentbibliotek kommer Admin att visa en mellanliggande status.

När du är klar och har bekräftat att du kommer att använda SharePoint ändras status under Admin till Microsoft SharePoint Online.

Vissa av inställningarna kan ändras i guiden i efterhand

**Steg:**

1. [!include[Open preferences](../includes/open-preferences.md)]
2. Välj fliken **Dokumentbibliotek**.
3. Klicka på **Ändra**. Sidan uppdateras med information om den anslutna SharePoint-webbplatsen. Ändringen är inte klar ännu.
4. Klicka på **Slutför ändringen** för att bekräfta SharePoint som standardokumentbibliotek. Ändringen är nu klar.
5. Klicka på **Inställningar**.
6. Gå igenom de fyra stegen i konfigurationsguiden enligt beskrivningen nedan.

## Steg 1 - Platser och mappar

I det här steget måste du konfigurera plats, mappar och filnamn för dina SuperOffice-dokument och -mallar.

### SuperOffice-dokument - plats, mappar och filnamn

* **Webbplats i SharePoint**: Välj din webbplats från listan.
* **Dokumentbibliotek**: Välj biblioteket i listan.
* **Mappstruktur**: Välj önskad mappstruktur (mappnamn).
* **Ordna mapparna i undermappar efter år**: Välj det här alternativet för att lägga till undermappar efter år.
* **Filnamn**: Välj önskad namngivning för filer.

### SuperOffice dokumentmallar – Plats

* **Webbplats i SharePoint**: Välj din webbplats från listan.
* **Dokumentbibliotek**: Välj biblioteket i listan.

Klicka på **Nästa steg** för att fortsätta.

## Steg 2 - Dokumentegenskaper

I det här steget måste du välja vilka dokumentfält som ska överföras som dokumentegenskaper från SuperOffice till SharePoint.

> [!NOTE]
> Vi rekommenderar att du väljer alla tillgängliga fält. Dessa fält visas som kolumner i ditt SharePoint-dokumentbibliotek.

Dessa fält kan användas för att skapa vyer i ditt SharePoint-dokumentbibliotek. Du kan också söka och gruppera efter dessa fält i SharePoint. Specifika fält kan döljas vid behov.

> [!NOTE]
> För att ändringar i dokument i SuperOffice ska sparas måste vi lagra fältens ID. ID-kolumner kan döljas i dina SharePoint-dokumentvyer.

Klicka på **Nästa steg** för att fortsätta.

## Steg 3 - Grupper och åtkomst

I det här steget kan du aktivera gruppåtkomst till SharePoint-dokument baserat på "Synlig för"-inställningarna i SuperOffice.

Välj inte detta alternativ om du inte har tänkt använda "Synlig för".

1. Välj **Aktivera gruppåtkomst för SharePoint-dokument baserat på "Synlig för"-inställningarna i SuperOffice**.

2. För att kunna ange behörigheter för dokument i SharePoint måste vi ha läs-/skrivrättighet för den valda webbplatsen. Detta är en engångsauktorisering och omfattar bara den webbplats du har valt för dina SuperOffice-dokument.

    > [!NOTE]
    > Endast en global Microsoft 365-administratör kan godkänna dessa behörigheter. Den globala Microsoft 365-administratören måste även vara medlem i webbplatsens ägargrupp eftersom webbplatsägarbehörighet krävs för att ange läs-/skrivrättigheter.

    Gör något av följande:

    * Om du är en Microsoft 365 Global Administratör: Klicka på **Auktorisera nu** för att fortsätta.

    * Om du INTE är en Microsoft 365 Global Administratör: Klicka på **Kopiera auktoriseringswebbadressen** och skicka den till en Microsoft 365 Global Administratör i din organisation.

3. Om du behöver vänta på auktorisering har du följande alternativ:

    * Klicka på **Spara och stäng** för att fortsätta med konfigurationen senare. Sidtexten uppdateras för att indikera att auktorisation inväntas.

    * Klicka på **Kontrollera status igen** för att kontrollera om den globala Microsoft 365-administratören har auktoriserat appen.

4. För varje SuperOffice-användargrupp väljer du matchande användargrupp i SharePoint. Alla användargrupper i SuperOffice måste mappas innan du kan gå vidare till nästa steg.

5. Klicka på **Nästa steg** för att fortsätta.

## Steg 4 - Granska och bekräfta

Granska konfigurationen noga och kontrollera att inställningarna är korrekta.

När du har bekräftat inställningarna kan de inte längre redigeras:

SuperOffice-dokument

* Webbplats i SharePoint
* Dokumentbibliotek

SuperOffice dokumentmallar

* Webbplats i SharePoint
* Dokumentbibliotek

Klicka på **Bekräfta** när du är klar.

## Relaterade ämnen

* [SharePoint-dokument][1] – teknisk översikt

<!-- Referenced links -->
[1]:https://docs.superoffice.com/en/document/cloud/sharepoint-documents/index.html

<!-- Referenced images -->
