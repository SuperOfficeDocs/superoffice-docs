---
uid: help-de-erp-connect
title: Mit ERP verbinden
description: Mit ERP verbinden
author: SuperOffice RnD
date: 07.04.2022
keywords: ERP
topic: howto
language: de
---

# Mit ERP verbinden

[!include[Requirement](includes/req-integration-server.md)]

Sie können eine Firma aus SuperOffice mit einem Kunden/Lieferanten im ERP-System verbinden. Personen, die bei einer Firma aus SuperOffice erfasst sind, können anschließend mit einzelnen Objekten im ERP-System verbunden werden. SuperOffice-Projekte können ganz ähnlich mit Projekten im ERP-System verknüpft werden. Die Daten werden anschließend zwischen SuperOffice und dem ERP-System synchronisiert.

1. Gehen Sie zur Ansicht Firma, Person oder Projekt und wählen Sie die Registerkarte **ERP** aus.

    > [!NOTE]
    > Wenn die Registerkarte **ERP** Firmen-, Personen- oder Projektinformationen enthält, wurde bereits eine Verbindung zwischen SuperOffice und dem ERP-System festgelegt.

1. Klicken Sie auf **Bearbeiten**. Die Optionen hängen davon ab, ob Sie eine Firma, eine Person oder ein Projekt bearbeiten.
1. Firma: Klicken Sie auf **Kunde** oder **Lieferant**, je nachdem, mit welchem ERP-Akteur Sie die Firma verbinden möchten. Sie können nur einen Akteur pro Firma auswählen.
    *Oder* Projekt: Klicken Sie auf **Projekt**.
    *Oder* Person: Klicken Sie auf **Person**.
1. Geben Sie in das Dialogfeld **Mit ERP verbinden** den Text ein, nach dem Sie im Suchfeld suchen möchten, und klicken Sie auf **Suchen**. Sie können auch auf <i class="ph ph-magnifying-glass" aria-label="Suchen"></i> klicken, um eine erweiterte Suche zu starten (siehe [Dialogfeld Suchen verwenden][1]).

    > [!TIP]
    > Wenn Sie mit einem leeren Suchfeld suchen, werden alle Datensätze im ERP-System angezeigt.

1. Wählen Sie ein Element in der Trefferliste aus. Wenn nicht alle Treffer angezeigt werden, können Sie basierend auf den Daten aus SuperOffice CRM einen [neuen Akteur im ERP-System erstellen][2].
1. Klicken Sie auf **Verbinden**. Ein Dialogfeld wird geöffnet, das die Daten anzeigt, die zwischen SuperOffice CRM und dem ERP-System synchronisiert werden. Welche Daten hier angezeigt werden, ist in SuperOffice Einstellungen und Verwaltung festgelegt.
1. Sind die Daten in den zwei Systemen unterschiedlich, wählen Sie die richtigen Daten aus.
    Zum Beispiel: Wenn die Besuchsadressen unterschiedlich sind, wählen Sie die richtige aus. Die anderen Daten werden überschrieben.
1. Klicken Sie auf **Verbinden**. Dies bringt Sie zurück zur Registerkarte **ERP** zurück, in der jetzt die synchronisierten Daten angezeigt werden.
1. Klicken Sie auf **Speichern**.
1. Wenn Sie möchten, können Sie auf **Jetzt synchronisieren** klicken.

## Was möchten Sie jetzt tun?

* [Akteur im ERP-System erstellen][2]
* [Synchronisierung deaktivieren][3]

<!-- Referenced links -->
[1]: ../../../search-options/learn/find-screen.md
[2]: erp-create-new-actor.md
[3]: erp-sync-disconnect.md

<!-- Referenced images -->
