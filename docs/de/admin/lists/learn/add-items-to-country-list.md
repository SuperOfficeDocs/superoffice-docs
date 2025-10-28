---
uid: help-de-add-items-to-country-list
title: Objekte zur Liste Land hinzufügen
description: Objekte zur Liste Land hinzufügen
keywords: Liste Allgemein - Land, Land
author: SuperOffice Product and engineering
date: 06.26.2025
version: 10.5
content_type: howto
audience: settings
audience_tooltip: Settings and maintenance
language: de
---

# Objekte zur Liste Allgemein - Land hinzufügen

[!include[Note difference](includes/different-edit-list-item-dialog.md)]

[!include[Edit list item](includes/edit-list-item.md)] wenn das Listenobjekt Länder sind:

1. Geben Sie den gewünschten Namen für das Objekt in das Feld **Name** ein. Der Name des Landes.

    [!include[Mandatory](includes/note-mandatory-field.md)]

1. Im Feld **Domäne der obersten Ebene** können Sie festlegen, welche Länderadresse in Internet-Adressen für das jeweilige Land verwendet werden soll, z. B. *NO* für Norwegen oder *DE* für Deutschland.

1. Geben Sie in das Feld **Präfix** die Buchstaben ein, die vor der Postleitzahl angegeben werden müssen, wenn Briefe aus dem Ausland in das betreffende Land geschickt werden, z. B. *D* für Deutschland.

1. In den folgenden drei Feldern können Sie auf <i class="ph ph-caret-down" aria-label="Chevron"></i> klicken, um das gewünschte Adressformat in der Liste auszuwählen. Im Allgemeinen gilt dasselbe Format für alle drei Felder, für einige Länder kann es jedoch nützlich sein, je nach Verwendungszweck der Adresse verschiedene Formate zu verwenden:
    * **Visuelles Adressformat**:
        Das normale Format, das in der Ansicht Firma angezeigt wird. In der Regel genügt es, nur hier ein Format auszuwählen.
    * **Lokales Adressformat** und **Internationales Adressformat**:
        Einige Länder verwenden verschiedene Adressformate für Briefe, je nachdem, ob sie im In- oder Ausland verschickt werden. In diesen Feldern können Sie festlegen, welches Format jeweils verwendet werden soll.

1. Die Ansicht Firma enthält ein Feld mit der Bezeichnung **Ust-IdNr.**, in das die Umsatzsteuernummer bzw. eine vergleichbare Nummer des Unternehmens eingegeben werden kann. Sie können diese Feldbezeichnung in Einstellungen und Verwaltung ändern. Geben Sie den gewünschten Text in das Feld **Leittext Organisationsnr.** ein, zum Beispiel *Handelsregister-Nr.* für Norwegen. Wenn Sie eine norwegische Firma in SuperOffice CRM registrieren, lautet die Bezeichnung für die Organisationsnummer des Unternehmens *Handelsregister-Nr.* statt *Ust-IdNr.*.

1. Klicken Sie auf <i class="ph ph-caret-down" aria-label="Chevron"></i> neben dem Feld **Währung** und wählen Sie eine Währung von der Liste aus.

    > [!NOTE]
    > Diese Optionen werden in der Liste [**Allgemein - Währung**][2] festgelegt.

1. Geben Sie in das Feld **Vorwahl dieses Landes** die Nummer ein, die Sie bei einem Anruf aus dem Ausland für dieses Land vorwählen müssen, z. B. *49* für Deutschland.

1. Geben Sie in das Feld **Ländervorwahl** die internationale Vorwahl ein, die Sie verwenden müssen, um von dem jeweiligen Land ins Ausland zu telefonieren. Diese Vorwahl lautet standardmäßig *00*.

1. Geben Sie optional in das Feld **Beschreibung** eine Beschreibung für das Land ein.

1. Klicken Sie auf **Speichern**. Das Land wird als separates Objekt zur Liste **Objekte** hinzugefügt. Wiederholen Sie diesen Vorgang, wenn Sie weitere Länder hinzufügen möchten.

<!-- Referenced links -->
[2]: ../../../sale/admin/add-currency.md
