---
uid: help-sv-lead-admin
title: Konfigurera leadhantering
description: Lär dig hur du aktiverar, konfigurerar och utökar leadhantering i SuperOffice CRM.
keywords: leadhantering, leadinställning, leadstatus, potentiell kund, säljprocess
author: digitaldiina
date: 11.12.2025
version: 10.6
content_type: concept
category: sale
topic: lead
license: salesessentials
audience: settings
audience_tooltip: Inställningar och underhåll
index: true
language: sv
---

# Konfigurera leadhantering

Leadhantering i SuperOffice CRM hjälper dig att följa potentiella kunder från första kontakt genom kvalificering och in i säljprocessen. För att komma igång måste administratörer konfigurera vilka företagskategorier som använder **Leadstatus**, granska de tillgängliga statusvärdena och eventuellt utöka spårningen med marknadsföringsdata.

> [!NOTE]
> Standardkategorierna *Lead*, *Marknadsföringskvalificerat lead*, *Affärsmöjlighet* och *Förlorad möjlighet* ingår endast i nya databaser.
> Befintliga kunder måste lägga till eller uppdatera kategorier manuellt för att aktivera leadstatus.

## Steg 1: Aktivera leadstatus på en företagskategori

Leadstatus kan endast användas för kategorier som tillhör gruppen **Potentiell kund**. Se till att minst en kategori är inställd på detta sätt innan du aktiverar leadhantering.

1. Gå till **Inställningar och underhåll** > **Listor** > **Företag – Kategori**.
1. Skapa en ny kategori eller redigera en befintlig.
1. Ange **Kategorigrupp** till *Potentiell kund*.
1. Välj **Aktivera leadstatus för denna kategori**.
1. Klicka **OK** för att spara ändringarna.

Mer information finns i [Företagskategori och kategorigrupp][1].

## Steg 2: Anpassa listan för leadstatus

Listan **Kontakt – Leadstatus** definierar de kvalificeringssteg som används i organisationen. Som standard inkluderar SuperOffice statusar som *Öppen*, *Kontakt tas*, *Kvalificerad*, *Diskvalificerad* och *Återbearbetning*.

1. Gå till **Inställningar och underhåll** > **Listor** > **Kontakt – Leadstatus**.
1. Granska de fördefinierade posterna.
1. Lägg till, redigera eller ta bort statusar så att de matchar din egen kvalificeringsprocess.

För detaljerade steg, se [Hantera leadstatusar][2].

## Steg 3: (Valfritt) Utöka med Marketing Premium

Om du använder Marketing Premium kan du dra nytta av ytterligare spårnings- och automationsfunktioner i leadprocessen:

* **UTM-spårning:** Fånga källan till nya leads från onlineformulär.
  Se [Spåra formulär-UTM-data][3].
* **Lead-nurturingflöde:** Fördela nya leads automatiskt till användare.
  Se [Fördela nya leads][4].

## Relaterat innehåll

* [Översikt över leadhantering][5]
* [Företagskategori och kategorigrupp][1]
* [Hantera leadstatusar][2]

[1]: add-company-category.md
[2]: add-lead-status.md
[3]: ../learn/index.md
[5]: ../../marketing/utm/admin/set-up.md
[4]: ../../marketing/flows/learn/define-flow-actions.md#distribute
