---
uid: help-de-erp-connect-actor
title: Mit ERP verbinden
description: Mit ERP verbinden
keywords: mit ERP verbinden, Firma mit ERP verbinden, Person mit ERP verbinden, Projekt mit ERP verbinden, kein Treffer in ERP gefunden, in ERP erstellen, Akteur erstellen, ERP-Akteur, ERP
author: SuperOffice RnD
date: 03.31.2025
version: 10.5
content_type: howto
license: development-tools
audience: person
audience_tooltip: SuperOffice CRM
language: de
---

# Mit ERP verbinden

[!include[Requirement](../../learn/includes/req-expander-services.md)]

Sie können eine Firma aus SuperOffice mit einem Kunden oder Lieferanten im ERP-System verbinden. Personen, die bei einer Firma in SuperOffice erfasst sind, können anschließend mit passenden Objekten im ERP-System verknüpft werden. SuperOffice-Projekte können ebenfalls mit Projekten im ERP-System verbunden werden. Die Daten werden anschließend zwischen SuperOffice und dem ERP-System synchronisiert.

1. Gehen Sie zur Ansicht **Firma**, **Person** oder **Projekt** und wählen Sie die Registerkarte **ERP** aus.

    Wenn die Registerkarte **ERP** bereits Informationen zu Firma, Person oder Projekt enthält, wurde bereits eine Verbindung zum ERP-System hergestellt.

1. Klicken Sie auf **Bearbeiten**. Die verfügbaren Optionen hängen davon ab, ob Sie eine Firma, eine Person oder ein Projekt bearbeiten.
1. Firma: Klicken Sie auf **Kunde** oder **Lieferant**, je nachdem, mit welchem ERP-Akteur Sie die Firma verbinden möchten. Es kann nur ein Akteur pro Firma ausgewählt werden.
    *Oder* Projekt: Klicken Sie auf **Projekt**.
    *Oder* Person: Klicken Sie auf **Person**.
1. Geben Sie im Dialogfeld **Mit ERP verbinden** den gewünschten Text ins Suchfeld ein und klicken Sie auf **Suchen**. Sie können auch auf das Suchsymbol (<i class="ph ph-magnifying-glass" aria-label="Suchen"></i>) klicken, um eine [erweiterte Suche][1] zu starten.

    Wenn Sie ohne Suchbegriff suchen, werden alle verfügbaren Einträge im ERP-System angezeigt.

1. Wählen Sie einen Treffer aus der Liste. Wenn keine Treffer gefunden werden, können Sie basierend auf den SuperOffice-Daten einen [neuen Akteur im ERP-System erstellen](#create-actor).
1. Klicken Sie auf **Verbinden**. Es öffnet sich ein Dialog, das die Daten anzeigt, die zwischen SuperOffice CRM und dem ERP-System synchronisiert werden. Welche Daten hier angezeigt werden, wird in SuperOffice **Einstellungen und Verwaltung** festgelegt.
1. Wenn sich die Daten in den beiden Systemen unterscheiden, wählen Sie die korrekten Daten aus.
    Zum Beispiel: Wenn sich die Straßenadressen unterscheiden, wählen Sie die richtige aus. Die anderen Daten werden überschrieben.
1. Klicken Sie auf **Verbinden**. Sie kehren zur Registerkarte **ERP** zurück, auf der nun die synchronisierten Daten angezeigt werden.
1. Klicken Sie auf **Speichern**.

## <a id="create-actor"></a>Akteur im ERP-System erstellen

Wenn ein Kunde beispielsweise nicht im ERP-System vorhanden ist, können Sie ihn basierend auf den Daten aus SuperOffice im ERP-System erstellen.

> [!NOTE]
> Die Schaltfläche **Erstellen** ist deaktiviert, wenn SuperOffice keine Akteure im ERP-System erstellen darf.

1. Im Dialogfeld **Mit ERP verbinden** wählen Sie unten **Kein Treffer in ERP gefunden** und klicken auf **Erstellen**. Das Dialogfeld **In ERP erstellen** wird geöffnet.
1. Geben Sie die erforderlichen Werte ein.
1. Klicken Sie auf **Erstellen**. Sie kehren zur Registerkarte **ERP** zurück, auf der nun die synchronisierten Daten angezeigt werden.
1. Klicken Sie auf **Speichern**.

## Verwandte Inhalte

* [Synchronisierung deaktivieren][3]

<!-- Referenced links -->
[1]: ../../search-options/learn/find-screen.md
[3]: disconnect.md

<!-- Referenced images -->
