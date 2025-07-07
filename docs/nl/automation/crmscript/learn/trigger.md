---
uid: help-nl-automation-trigger
title: Triggers
description: Triggers
keywords: CRMScript, trigger
author: SuperOffice RnD
date: 06.29.2022
content_type: howto
audience: settings
audience_tooltip: Settings and maintenance
language: nl
---

# Triggers

[!include[Requirement](../../../includes/req-dev-tools.md)]

Triggers zijn scripts die worden uitgevoerd voor specifieke gebeurtenissen in het systeem, zoals wanneer een nieuwe verkoop wordt gemaakt of een verzoek wordt gesloten. Triggers kunnen in stilte reageren op wat er gebeurt, of de bewerking blokkeren en de gebruiker voorzien van uitleg hierover.

CRMScript kan uw werkdag efficiënter maken door verschillende taken te automatiseren. U kunt aangeven dat een bepaalde gebeurtenis in het systeem één of meer vooraf gedefinieerde acties op gang brengt (activeert). Er is geen kennis van scripting vereist om dit te laten werken.

**Voorbeeld uit SuperOffice**: Wanneer een verzoek wordt gesloten, moet de klant hiervan per e-mail op de hoogte worden gebracht. We kunnen een macro met een serie acties maken om deze e-mailmelding te maken en te verzenden. Deze macro wordt automatisch uitgevoerd wanneer een verzoek wordt gesloten. De acties in de macro laden het desbetreffende verzoek, zorgen voor het juiste antwoordsjabloon en verzenden een e-mail naar de klant met de mededeling dat het verzoek gesloten is.

Dit is een voorbeeld van een zeer eenvoudige trigger. U kunt bijvoorbeeld voorwaarden toevoegen aan de acties in een trigger door de standaardinstelling **Altijd** te wijzigen.

## Een trigger maken

We maken nu een actiereeks gebaseerd op het bovenstaande voorbeeld.

1. [!include[Go to](../../../learn/includes/goto-sm.md)]
1. Klik op <i class="ph ph-code-block" aria-hidden="true"></i> **CRMScript** en selecteer het tabblad **Triggers**.
1. Klik op de knop **Nieuwe trigger (macro)**. Het scherm **Trigger kiezen** geeft de beschikbare triggers weer. Dit zijn de gebeurtenissen in het systeem die kunnen worden gebruikt om acties/macro's te starten. In ons voorbeeld selecteren we **Verzoek gesloten**, zodat de macro wordt uitgevoerd wanneer een verzoek in SuperOffice is gesloten.
1. Typ "verzoek" in het zoekveld en selecteer de trigger met de naam **Verzoek gesloten**.
1. Voer een beschrijving van de trigger in het veld **Beschrijving** in.
1. Selecteer **Ingeschakeld**.
1. Selecteer **Verzoek wijzigen** onder **Actietype kiezen**. Het tabblad **Verzoek weergeven** wordt geopend.
    Dit is de eerste actie in de macro. Het verzoek wordt binnengehaald, zodat de verschillende waarden (ID, titel, persoon enzovoort) gebruikt kunnen worden in de volgende acties die we gaan maken.
1. Optioneel: selecteer **Interne boodschap** en typ, bijvoorbeeld: "Verzoek gesloten en bevestiging verzonden naar de klant."
1. Klik op **Toepassen**.
1. Klik op **Nieuwe actie** naast de tab **Een verzoek wijzigen**.
1. Selecteer **Een antwoordsjabloon voor samenvoeging laden**. De antwoordsjabloon wordt nu binnengehaald zodat u deze kunt gebruiken.
1. Klik op het veld **Antwoordsjabloon** en selecteer een bestaande antwoordsjabloon uit de getoonde lijst, zoals 'Verzoek gesloten'.
1. Klik op **Toepassen**.
1. Klik op **Nieuwe actie** en selecteer **E-mail of SMS verzenden**. We passen nu de e-mail aan die naar de klant wordt gestuurd.
1. Selecteer **Onderwerp**.
1. Klik op <i class="ph ph-gear" aria-label="Gear"></i> rechts en klik vervolgens op het veld **Parameter kiezen**.
1. Selecteer **Een verzoek wijzigen** > **Titel**. Hiermee zet u de verzoektitel in het onderwerp van de e-mail.
1. Selecteer **Van** en selecteer **Een verzoek wijzigen** > **Eigenaar**.
1. Selecteer **Aan** en selecteer **Een verzoek wijzigen** > **Persoon: E-mailadres**.
1. Selecteer **HTML-bericht** en selecteer **Een antwoordsjabloon voor samenvoeging laden** > **HTML-tekst**.
1. Klik op **Toepassen**.

U hebt nu een macro gemaakt die een e-mail naar de klant stuurt met 'Verzoek gesloten' wanneer een verzoek wordt gesloten. Deze trigger is direct actief als u bovenaan **Ingeschakeld** hebt ingeschakeld.
